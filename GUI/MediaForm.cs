using System;
using System.Collections.Generic;

using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using MMDPlayer.Object;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Microsoft.WindowsAPICodePack.Shell;
using MMDPlayer.Properties;

namespace MMDPlayer.GUI
{
    public partial class MediaForm : Form, IMessageFilter
    {
        public Form activeForm;
        public static readonly string EMPTY_MEDIA = "00:00";
        public static readonly string DEFAULT_TITLE = "Song Title";

        public static readonly string MEDIA_FORM = "WinMedia";
        public static readonly string PLAYLIST_FORM = "SongList";
        public static readonly string DEFAULT_AUTHOR = "Author";
        public PlayList currPlayList = null;
        private const UInt32 WM_KEYDOWN = 0x0100;
        public static MediaForm Instance { 
            get {
                if (instance == null) instance = new MediaForm();
                return instance;
            } 
        }
        private static MediaForm instance;
        private Dictionary<string, Form> formList = new Dictionary<string, Form>();
        public List<PlayList> Library { get; set; }
        public  List<SongView> list { get; set; } = new List<SongView>();
        public List<SongView> HistoryList { get; set; } = new List<SongView>();
        public AxWMPLib.AxWindowsMediaPlayer player = new AxWMPLib.AxWindowsMediaPlayer();
        public static bool isRunning = false;
        private bool nextPause = false;
        private bool loop = false;
        private bool random = false;
        private int currVol = 0;
        private int num = 0;
        private static bool threadLock = false;
        //Thread thread;

        private MediaForm()
        {
            InitializeComponent();
            subList2.Visible = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            //thread = new Thread(s => GetData());
            //thread.SetApartmentState(ApartmentState.STA);
            //thread.Start();
            //CheckForIllegalCrossThreadCalls = false;
            Application.AddMessageFilter(this);
        }

        private void mediaForm_Load(object sender, EventArgs e)
        {
            Library = Utils.ReadLibraryPlayList(Utils.DEF_PLAYLIST_LOC);
            HistoryList = Utils.ChangeMediaInfoToView(Utils.DEF_HISTORY_LOC);
            if (Library != null && Library.Count > 0)
            {
                currPlayList = Library[0];
                list = Utils.ChangeMediaInfoToView(currPlayList.Path);
            }
            else
            {
                list = Utils.ChangeMediaInfoToView(Utils.DEF_LIST_LOCATION);
                currPlayList = new PlayList("PlayList", Utils.DEF_LIST_LOCATION, Utils.GetTotalTime(list), list.Count);
            }
            SongList songs = new SongList(list);
            if (Library == null || Library.Count <= 0)
            {
                Library = new List<PlayList>();
                Library.Add(currPlayList);
            }
            songs.list = list;
            openChildForm(songs);
            closeChildPanel();
            WinMedia media = new WinMedia();
            CurrentWinMedia(media);
        }
        public void LoadPlayList(PlayList playlist)
        {
            if(currPlayList.Amount <= 0 && Library.Count > 0)
            {
                for(int i = 0; i < Library.Count; i++)
                {
                    PlayList playList = Library[i];
                    if (playList.Title.Equals(currPlayList.Title)) Library.Remove(playList);
                }
            }
            list = Utils.ChangeMediaInfoToView(playlist.Path);
            currPlayList = playlist;
            SongList.IsNewPlayList = false;
            SongList.IsChange = true;
            LibraryForm.IsChange = true;
            OnPlayListButton();
        }

        private void mediaForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                if (activeForm != null)

                {
                    if (activeForm.Visible)
                    {
                        activeForm.Hide();
                    }
                }
            }
            else
            {
                if (activeForm != null)
                {
                    if (!activeForm.Visible)
                    {
                        activeForm.Show();
                    }
                }
            }
        }
        public void openChildForm(Form childForm)
        {
            try
            {
                if (childForm != null)
                {
                    if (activeForm != null) activeForm = null;
                    activeForm = childForm;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    panelChildForm.Controls.Add(activeForm);
                    panelChildForm.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }
        private void playListButt_Click(object sender, EventArgs e)
        {
            OnPlayListButton();
        }

        public void OnPlayListButton()
        {
            try
            {
                if (activeForm != null)
                {
                    closeChildPanel();
                }
                Form songList = null; 
                if (formList != null && formList.Count > 0 && formList.TryGetValue(PLAYLIST_FORM, out songList))
                {
                    if (SongList.IsChange) ((SongList)songList).list = list;
                    openChildForm(songList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }

        public void closeChildPanel()
        {
            try
            {
                if (activeForm != null && activeForm.Visible)
                {
                    if (!formList.ContainsKey(activeForm.Name))
                        formList.Add(activeForm.Name, activeForm);
                    activeForm.Hide();
                    activeForm = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }

        private void mediaButt_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }
        public OpenFileDialog openFileChoose(bool multiselect)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog()
                {
                    Multiselect = multiselect,
                    ValidateNames = true,
                    Filter = "All|*.mp3;*.mp4;*.wav;*.webm;*.weba;*.wma;*.mpa|MP3|*.mp3|WAV|*.wav|MP4|*.mp4|WEBM|*.webm|WEBA|*.weba|WMA|*.wma|MPA|*.mpa",
                    AutoUpgradeEnabled = true,
                };
                DialogResult choose = openFile.ShowDialog();
                if (choose == DialogResult.OK)
                    return openFile;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
            return null;
        }

        private Form getFormByName(string formName)
        {
            try
            {
                Form form = null;
                if (formList != null && formList.Count > 0)
                {
                    formList.TryGetValue(formName, out form);
                    if (form != null)
                    {
                        return form;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
            return null;
        }
        public void CurrentWinMedia(WinMedia currMedia)
        {
            try
            {
                Form winMedia = null;
                if(formList != null && formList.Count > 0 && formList.TryGetValue(MEDIA_FORM, out winMedia))
                {
                   formList.Remove(MEDIA_FORM);
                }
                formList.Add(currMedia.Name, currMedia);
                openChildForm(currMedia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }

        public void PlayMedia(Media mediaInfo)
        {
            try
            {
                if (isRunning)
                {
                    endingMedia();
                }
                WinMedia media = new WinMedia();
                player = media.winMedia;
                if(!CheckMediaExist(mediaInfo.Path)) return;
                CurrentWinMedia(media);
                player.URL = mediaInfo.Path;
                FillSongInfo(mediaInfo.Path, mediaInfo);
                player.Ctlcontrols.play();
                player.settings.volume = soundTrack.Value;
                timer.Start();
                isRunning = true;
                nextPause = true;
                HistoryListUpdate(player.URL);
                playButt.BackgroundImage = Resources.pause_button_FFD5;
                //if (!keyboardThread.IsAlive) keyboardThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }

        public void FillSongInfo(string path, Media mediaInfo)
        {
            if (mediaInfo != null)
            {
                songTitle.Text = mediaInfo.Title;
                authorSong.Text = mediaInfo.Author;
            }
            else
            {
                string title = Path.GetFileNameWithoutExtension(path);
                if (title.Length > 0 && title.Contains("-"))
                {
                    string[] songInfo = title.Split('-');
                    if (title.Contains("("))
                    {
                        string[] cleanTitle = title.Split('(');
                        songInfo = cleanTitle[0].Split('-');
                    }
                    if (songInfo.Length > 4)
                    {
                        songTitle.Text = title;
                        authorSong.Text = title;
                    }
                    else
                    {
                        string author = songInfo[songInfo.Length - 1];
                        if (songInfo.Length > 2)
                        {
                            songTitle.Text = songInfo[0] + songInfo[1];
                        }
                        else songTitle.Text = songInfo[0];
                        if (author.ToLower().Contains('x')) authorSong.Text = author;
                        else if (author.ToLower().Contains("mv") || author.ToLower().Contains("official") || author.ToLower().Contains("cover")) authorSong.Text = songInfo[songInfo.Length - 2] + author;
                        else if (authorSong.Text.Length <= 4)
                        {
                            authorSong.Text = title;
                        }
                        else
                        {
                            authorSong.Text = author;
                        }
                    }
                }
                else
                {
                    songTitle.Text = title;
                    authorSong.Text = title;
                }
            }
        }
        private string GetAuthorInfo(string mediaPath)
        {
            try
            {
                string title = Path.GetFileNameWithoutExtension(mediaPath);
                if (title.Length > 0 && title.Contains("-"))
                {
                    string[] songInfo = title.Split('-');
                    if (title.Contains("("))
                    {
                        string[] cleanTitle = title.Split('(');
                        songInfo = cleanTitle[0].Split('-');
                    }
                    string author = songInfo[songInfo.Length - 1];
                    if (songInfo.Length > 4)
                    {
                        author = title;
                    }
                    else
                    {
                        if (author.ToLower().Contains('x')) return author = songInfo[songInfo.Length - 1];
                        if (author.ToLower().Contains("mv") || author.ToLower().Contains("official") || author.ToLower().Contains("cover")) return author = songInfo[songInfo.Length - 2] + author;
                        if (author.Length <= 4)
                        {
                            return title;
                        }
                    }
                    return author;
                }
                else return title;
            } catch(Exception e)
            {
                MessageBox.Show("GetAuthorInfo error!!");
            }
            return "";
        }

        private bool CheckMediaExist(string playURL)
        {
            FileInfo file = new FileInfo(playURL);
            if (!file.Exists)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    if (list[i].mediaInfo.Path.Equals(playURL)) list.Remove(list[i]);
                    SongList.IsChange = true;
                    LibraryForm.IsChange = true;
                }
                MessageBox.Show("Cannot Found Media!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private SongView GetSongViewByPath(string path)
        {
            if(list.Count > 0)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    SongView song = list[i];
                    if (song.mediaInfo.Path.Equals(path)) return song;
                }
            }
            return null;
        }

        private void HistoryListUpdate(string path)
        {
            SongView song = GetSongViewByPath(path);
            if (HistoryList.Count >= 20) HistoryList.RemoveAt(0);
            if (checkDuplicationHistorySong(path))
            {
                HistoryList.Add(new SongView(song.mediaInfo));
                if (activeForm != null && activeForm.Name.Equals("HistoryForm"))
                {
                    HistoryFormUpdate();
                }
                HistoryForm.IsChange = true;
            }
        }

        public void PlayMedia()
        {
            try
            {
                if (nextPause)
                {
                    player.Ctlcontrols.pause();
                    nextPause = false;
                    playButt.BackgroundImage = Resources.play_FFD5;
                    return;
                }
                OpenFileDialog openFile = null;
                if (!isRunning)
                {
                    if (list.Count > 0)
                    {
                        WinMedia media = new WinMedia();
                        player = media.winMedia;
                        CurrentWinMedia(media);
                        player.URL = list[0].mediaInfo.Path;
                        if (!CheckMediaExist(player.URL)) return;
                        FillSongInfo(player.URL, null);
                        player.Ctlcontrols.play();
                        timer.Start();
                        HistoryListUpdate(player.URL);
                        player.settings.volume = soundTrack.Value;
                    }
                    else
                    {
                        openFile = openFileChoose(false);
                        if (openFile == null) return;
                        if (openFile.CheckPathExists && openFile.CheckFileExists)
                        {
                            WinMedia media = new WinMedia();
                            player = media.winMedia;
                            CurrentWinMedia(media);
                            player.URL = openFile.FileName;
                            FillSongInfo(player.URL, null);
                            player.Ctlcontrols.play();
                            timer.Start();
                            player.settings.volume = soundTrack.Value;
                            listMediaAddNonDuplicate(player.URL);
                            HistoryListUpdate(player.URL);
                        }
                        else return;
                    }
                    //if (!keyboardThread.IsAlive) keyboardThread.Start();
                    isRunning = true;
                }
                else
                {
                    player.Ctlcontrols.play();
                }
                nextPause = true;
                playButt.BackgroundImage = Resources.pause_button_FFD5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }

        private void playButt_Click(object sender, EventArgs e)
        {
            PlayMedia();
        }
        public void hideShowSidePanel()
        {
            try
            {
                if (sidePanel.Visible)
                {
                    sidePanel.Visible = false;
                    panelChildForm.Location = new Point(0, 0);
                    panelChildForm.Size = new Size(panelChildForm.Width + 229, panelChildForm.Height);
                    sidePanelEye.BackgroundImage = Resources.hide_FFD5;
                }
                else
                {
                    sidePanel.Visible = true;
                    panelChildForm.Location = new Point(229, 0);
                    panelChildForm.Size = new Size(panelChildForm.Width - 229, panelChildForm.Height);
                    sidePanelEye.BackgroundImage = Resources.eye_FFD5;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }

        public void PreviousSong()
        {
            if (list != null && list.Count > 1)
            {
                mediaTrack.Value = 0;
                player.Ctlcontrols.currentPosition = mediaTrack.Value;
                startMedia.Text = EMPTY_MEDIA;
                endMedia.Text = EMPTY_MEDIA;
                songTitle.Text = DEFAULT_TITLE;
                if (random)
                {
                    Random random = new Random();
                    int rand = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        rand = random.Next(list.Count);
                        if (rand != num)
                        {
                            num = rand;
                            break;
                        }
                    }
                    SongView song = list[rand];
                    player.URL = song.mediaInfo.Path;
                    FillSongInfo(player.URL, null);
                    player.Ctlcontrols.play();
                    HistoryListUpdate(player.URL);
                    playButt.BackgroundImage = Resources.pause_button_FFD5;
                    nextPause = true;
                    return;
                }
                else
                {
                    num = (num - 1) % list.Count;
                    if (num == -1) num = list.Count - 1;
                    string url = list[num].mediaInfo.Path;
                    if (!player.URL.Equals(url))
                    {
                        player.URL = url;
                        player.Ctlcontrols.play();
                        FillSongInfo(player.URL, null);
                        HistoryListUpdate(player.URL);
                        playButt.BackgroundImage = Resources.pause_button_FFD5;
                        nextPause = true;
                        return;
                    }
                }
            }
            endingMedia();
        }

        private void morePreviousButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (isRunning)
                {
                    if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        player.Ctlcontrols.stop();
                        PreviousSong();
                    } else
                    {
                        PreviousSong();
                    }
                } else
                {
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }

        public void previous5Sec()
        {
            try
            {
                if (isRunning)
                {
                    if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        double back = player.Ctlcontrols.currentPosition - 5;
                        if (back >= 0)
                        {
                            player.Ctlcontrols.currentPosition = back;
                        }
                        else player.Ctlcontrols.currentPosition = 0;
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }

        private void previousButt_Click(object sender, EventArgs e)
        {
            previous5Sec();
        }

        public void next5Sec()
        {
            try
            {
                if (isRunning)
                {
                    if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        double forward = player.Ctlcontrols.currentPosition + 5;
                        if (forward <= mediaTrack.Maximum)
                        {
                            player.Ctlcontrols.currentPosition = forward;
                        }
                        else
                        {
                            if (!threadLock)
                            {
                                player.Ctlcontrols.currentPosition = player.Ctlcontrols.currentItem.duration;
                                startMedia.Text = endMedia.Text;
                                CheckEndMedia();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }

        private void nextButt_Click(object sender, EventArgs e)
        {
            next5Sec();
        }
        private void moreNextButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (isRunning)
                {
                    if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        player.Ctlcontrols.stop();
                        NextSong();
                    }
                    else
                    {
                        NextSong();
                    }
                } else {
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }

        private void NextSong()
        {
            try
            {
                if (list != null && list.Count > 1)
                {
                mediaTrack.Value = 0;
                player.Ctlcontrols.currentPosition = mediaTrack.Value;
                startMedia.Text = EMPTY_MEDIA;
                endMedia.Text = EMPTY_MEDIA;
                songTitle.Text = DEFAULT_TITLE;
                    if (random)
                    {
                        Random random = new Random();
                        int rand = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            rand = random.Next(list.Count);
                            if (rand != num)
                            {
                                num = rand;
                                break;
                            }
                        }
                        SongView song = list[rand];
                        player.URL = song.mediaInfo.Path;
                        FillSongInfo(player.URL, null);
                        player.Ctlcontrols.play();
                        timer.Start();
                        HistoryListUpdate(player.URL);
                        nextPause = true;
                        playButt.BackgroundImage = Resources.pause_button_FFD5;
                        return;
                    }
                    else
                    {
                        num = (num + 1) % list.Count;
                        string url = list[num].mediaInfo.Path;
                        if (!player.URL.Equals(url))
                        {
                            player.URL = url;
                            player.Ctlcontrols.play();
                            timer.Start();
                            FillSongInfo(player.URL, null);
                            HistoryListUpdate(player.URL);
                            nextPause = true;
                            playButt.BackgroundImage = Resources.pause_button_FFD5;
                            return;
                        }
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
            endingMedia();
        }

        private void sound_Click(object sender, EventArgs e)
        {
            try
            {
                if (soundTrack.Value > 0)
                {
                    currVol = soundTrack.Value;
                    soundTrack.Value = 0;
                    sound.BackgroundImage = Resources.mute_FFD5;
                }
                else
                {
                    soundTrack.Value = currVol;
                    sound.BackgroundImage = Resources.volume_FFD5;
                }
                if(isRunning) player.settings.volume = soundTrack.Value;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }

        public TimeSpan GetMediaDuration(string filePath)
        {
            try
            {
                using (var shell = ShellObject.FromParsingName(filePath))
                {
                    IShellProperty prop = shell.Properties.System.Media.Duration;
                    var t = (ulong)prop.ValueAsObject;
                    return TimeSpan.FromTicks((long)t);
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("ERROR at GetMediaDuration:" + e.ToString());
            }
        }

        private void listMediaAddNonDuplicate(string path)
        {
            try
            {
                SongView song = new SongView(new Media(Path.GetFileNameWithoutExtension(path), GetAuthorInfo(path), path, GetMediaDuration(path)));
                if (list != null && list.Count > 0)
                {
                    if(list.Count >= 100)
                    {
                        MessageBox.Show("PlayList Only Contain 100 space!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (checkDuplicationSong(song.mediaInfo.Path))
                    {
                        list.Add(song);
                    }
                    else return;
                }
                else list.Add(song);
                SongList songList = (SongList)getFormByName(PLAYLIST_FORM);
                if (songList != null)
                {
                    songList.AddOne(song);
                    LibraryForm.IsChange = true;
                }
                OnPlayListButton();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + e.ToString());
            }
        }
        private bool checkDuplicationSong(string path)
        {
            try
            {
                if (list != null && list.Count > 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        var listPath = list[i].mediaInfo.Path;
                        if (path.Equals(listPath)) return false;
                    }
                }
                return true;
            } catch(Exception e)
            {
                MessageBox.Show(e.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + e.ToString());
            }
            return false;
        }

        private bool checkDuplicationHistorySong(string path)
        {
            try
            {
                if (HistoryList.Count > 0)
                {
                    for (int i = 0; i < HistoryList.Count; i++)
                    {
                        var listPath = HistoryList[i].mediaInfo.Path;
                        if (path.Equals(listPath)) return false;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + e.ToString());
            }
            return false;
        }
        private void listMedia_Click(object sender, EventArgs e)
        {
            AddToList();
        }

        public void AddToList()
        {
            try
            {
                OpenFileDialog openFile = openFileChoose(true);
                if (openFile == null) return;
                if (openFile.CheckFileExists && openFile.CheckPathExists)
                {
                    List<SongView> listSongView = new List<SongView>();
                    foreach (var songs in openFile.FileNames)
                    {
                        TimeSpan dur = GetMediaDuration(songs);
                        SongView song = new SongView(new Media(Path.GetFileNameWithoutExtension(songs), GetAuthorInfo(songs), songs, dur));
                        if (list != null)
                        {
                            if (list.Count >= 100)
                            {
                                MessageBox.Show("PlayList Only Contain 100 space!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                            if (checkDuplicationSong(song.mediaInfo.Path))
                            {
                                list.Add(song);
                                listSongView.Add(song);
                            }
                        }
                    }
                    if (listSongView.Count > 0)
                    {
                        SongList songList = (SongList)getFormByName(PLAYLIST_FORM);
                        if (songList != null)
                        {
                            songList.AddToList(listSongView);
                            LibraryForm.IsChange = true;
                        }
                        OnPlayListButton();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + ex.ToString());
            }
        }

        public void endingMedia()
        {
            try
            {
                if (isRunning)
                {
                    player.Ctlcontrols.stop();
                    timer.Stop();
                    isRunning = false;
                    playButt.BackgroundImage = Resources.play_FFD5;
                    mediaTrack.Value = 0;
                    player.Ctlcontrols.currentPosition = mediaTrack.Value;
                    startMedia.Text = EMPTY_MEDIA;
                    endMedia.Text = EMPTY_MEDIA;
                    songTitle.Text = DEFAULT_TITLE;
                    authorSong.Text = DEFAULT_AUTHOR;
                    nextPause = false;
                    closeChildPanel();
                }
            } catch(Exception e)
            {
                MessageBox.Show(e.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + e.ToString());
            }
        }

        public void endingMediaWithList()
        {
            try
            {
                if (isRunning)
                {
                    player.Ctlcontrols.stop();
                    timer.Stop();
                    NextSong();
                }
            } catch(Exception e)
            {
                MessageBox.Show(e.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at: " + e.ToString());
            } 
        }

        public void CheckEndMedia()
        {
            if (startMedia.Text.Equals(endMedia.Text) && !endMedia.Text.Equals(EMPTY_MEDIA))
            {
                if (loop)
                {
                    mediaTrack.Value = 0;
                    player.Ctlcontrols.currentPosition = mediaTrack.Value;
                    startMedia.Text = EMPTY_MEDIA;
                }
                else
                {
                    endingMediaWithList();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (isRunning)
                {
                    mediaTrack.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                    mediaTrack.Value = (int)player.Ctlcontrols.currentPosition;
                    if (mediaTrack.Value != mediaTrack.Maximum) startMedia.Text = player.Ctlcontrols.currentPositionString;
                    else startMedia.Text = endMedia.Text;
                    endMedia.Text = player.Ctlcontrols.currentItem.durationString;
                    CheckEndMedia();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine("ERROR at :" + ex.ToString());
            } 
        }

        private void sidePanelEyE_Click_1(object sender, EventArgs e)
        {
            hideShowSidePanel();
        }

        private void mediaTrack_Scroll(object sender, EventArgs e)
        {
            if (isRunning == false) return;
            player.Ctlcontrols.currentPosition = mediaTrack.Value;
            startMedia.Text = player.Ctlcontrols.currentPositionString;
        }

        private void soundTrack_Scroll(object sender, EventArgs e)
        {
            if (!isRunning) return;
            else
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    player.settings.volume = soundTrack.Value;
                }
            }
        }

        private void soundTrack_ValueChanged(object sender, decimal value)
        {
            if (soundTrack.Value == 0)
            {
                sound.BackgroundImage = Resources.mute_FFD5;
            }
            else
            {
                sound.BackgroundImage = Resources.volume_FFD5;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (formList != null && formList.ContainsKey(MEDIA_FORM))
            {
                Form form = null;
                formList.TryGetValue(MEDIA_FORM, out form);
                if (activeForm != null)
                {
                    if (form == null || activeForm.Equals(form)) return;
                    closeChildPanel();
                }
                openChildForm(form);
            }
        }

        private void loop_Click(object sender, EventArgs e)
        {
            if (loop)
            {
                loopButt.BackgroundImage = Resources.loop__1__FFD5;
                loop = false;
            }
            else
            {
                loop = true;
                loopButt.BackgroundImage = Resources.loop_87DE;
                if (random)
                {
                    random = false;
                    randomMediaButt.BackgroundImage = Resources.random_FFD5;
                }
            }
        }

        private void randomButt_Click(object sender, EventArgs e)
        {
            if (random)
            {
                random = false;
                randomMediaButt.BackgroundImage = Resources.random_FFD5;
            }
            else
            {
                random = true;
                randomMediaButt.BackgroundImage = Resources.random_87DE;
                if (loop)
                {
                    loop = false;
                    loopButt.BackgroundImage = Resources.loop__1__FFD5;
                }
            }
        }

        private void subListPlayList_Click(object sender, EventArgs e)
        {
            if(subList2.Visible)
            {
                subList2.Visible = false;
                subListPlayList.BackgroundImage = Resources.hide_FFD5;
            }
            else
            {
                subList2.Visible = true;
                subListPlayList.BackgroundImage = Resources.eye_FFD5;
            }
        }
        private void MediaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Library != null)
            {
                for (int i = 0; i < Library.Count; i++)
                {
                    PlayList playlist = Library[i];
                    if (playlist.Amount <= 0) Library.Remove(playlist);
                    else if (playlist.Path.Equals(currPlayList.Path))
                    {
                        PlayList temp = Library[0];
                        Library[0] = currPlayList;
                        Library[i] = temp;
                    }
                }
                Utils.WriteLibraryPlayList(Utils.DEF_PLAYLIST_LOC, Library);
            }
            if (HistoryList != null)
            {
                Utils.WriteToJsonFile(Utils.DEF_HISTORY_LOC, HistoryList, false);
            }
            Application.RemoveMessageFilter(this);
            Environment.Exit(1);
        }


        public bool RemoveMedia(SongView rmSong)
        {
            if(list.Count > 0)
            {
                if (isRunning && rmSong.mediaInfo.Path.Equals(player.URL))
                {
                    endingMedia();
                    if(activeForm == null)
                    {
                        openChildForm(getFormByName(PLAYLIST_FORM));
                    }
                }
                for(int i = 0;i < list.Count; i++)
                {
                    var song = list[i];
                    if(song.mediaInfo.Path.Equals(rmSong.mediaInfo.Path))
                    {
                        
                        if (list.Remove(song))
                        {
                            SongList songList = (SongList)getFormByName(PLAYLIST_FORM);
                            songList.list = list;
                            songList.RefreshDeleteSongTime(song);
                            return true;
                        }
                    }
                }     
            }
            return false;
        }

        private void playButt_MouseDown(object sender, MouseEventArgs e)
        {
            if(!nextPause) playButt.BackgroundImage = Resources.play_FFD5;
            else playButt.BackgroundImage = Resources.pause_button_FFD5;
        }

        private void libraryButt_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                closeChildPanel();
            }
            Form libraryForm = null;
            if (formList != null && formList.TryGetValue("LibraryForm", out libraryForm)) {
                if (LibraryForm.IsChange) ((LibraryForm)libraryForm).LibraryPlayList = Library;
                openChildForm(libraryForm);
            } else
            {
                openChildForm(new LibraryForm(Library));
            }
        }

        private void subListPlayList_MouseEnter(object sender, EventArgs e)
        {
            subListPlayList.BackColor = Color.FromArgb(255, 56, 91);
            playListButt.BackColor = Color.FromArgb(255, 56, 91);
            playlistPic.BackColor = Color.FromArgb(255, 56, 91);
        }

        private void subListPlayList_MouseLeave(object sender, EventArgs e)
        {
            playListButt.BackColor = Color.FromArgb(26, 21, 36);
            subListPlayList.BackColor = Color.FromArgb(26, 21, 36);
            playlistPic.BackColor = Color.FromArgb(26, 21, 36);
        }

        private void subListPlayList_MouseDown(object sender, MouseEventArgs e)
        {
            playListButt.BackColor = Color.FromArgb(26, 21, 36);
            subListPlayList.BackColor = Color.FromArgb(26, 21, 36);
            playlistPic.BackColor = Color.FromArgb(26, 21, 36);
        }
        private void subListPlayList_MouseUp(object sender, MouseEventArgs e)
        {
            playListButt.BackColor = Color.FromArgb(255, 56, 91);
            subListPlayList.BackColor = Color.FromArgb(255, 56, 91);
            playlistPic.BackColor = Color.FromArgb(255, 56, 91);
        }

        public bool PreFilterMessage(ref Message m)
        {
            try
            {
                if (m.Msg == WM_KEYDOWN)
                {
                    Thread.Sleep(100);
                    Keys keyCode = (Keys)(int)m.WParam & Keys.KeyCode;
                    if (keyCode == Keys.Escape)
                    {
                        if (activeForm != null)
                        {
                            WinMedia media = (WinMedia)getFormByName(MEDIA_FORM);
                            if (media != null && media.winMedia.fullScreen)
                                media.winMedia.fullScreen = false;
                            return true;
                        }
                    }
                    if (keyCode == Keys.Right)
                    {
                        if (activeForm != null)
                        {
                            next5Sec();
                            return true;
                        }
                    }
                    if (keyCode == Keys.Left)
                    {
                        if (activeForm != null)
                        {
                            previous5Sec();
                            return true;
                        }
                    }
                    if (keyCode == Keys.Space)
                    {
                        if (activeForm != null)
                        {
                            PlayMedia();
                            return true;
                        }
                    }
                    if (keyCode == Keys.Enter)
                    {
                        if (activeForm != null)
                        {
                            WinMedia media = (WinMedia)getFormByName(MEDIA_FORM);
                            if (media != null && !media.winMedia.fullScreen)
                                media.winMedia.fullScreen = true;
                            return true;
                        }
                    }

                }
            } catch(Exception e)
            {
                Trace.WriteLine(e.ToString());
            }
            return false;
        }

        private void createPlaylistButt_Click(object sender, EventArgs e)
        {
            if (Library[0].Amount > 0)
            {
                if (activeForm != null) closeChildPanel();
                SongList songList = (SongList)getFormByName(PLAYLIST_FORM);
                SongList.IsNewPlayList = true;
                if (songList != null)
                {
                    if (songList.list.Count > 0)
                    {
                        CreatePlayListChange();
                    }
                    else
                    {
                        openChildForm(songList);
                        return;
                    }
                }
                SongList.IsChange = true;
                songList.list = list;
                openChildForm(songList);
            }
            else OnPlayListButton();
        }

        public void CreatePlayListChange()
        {
            currPlayList = new PlayList("My PlayList #0", Utils.DEF_DIRECTORY + "def-playlist-0.list", new TimeSpan(0), 0);
            if (Library != null && Library.Count > 0)
                foreach (var playlist in Library)
                {
                    if (playlist.Title.Contains("My PlayList #"))
                    {
                        string[] subStr = playlist.Title.Split('#');
                        string[] subPath = playlist.Path.Split('.');
                        string[] defName = subPath[0].Split('-');
                        int curNum = Int32.Parse("" + subStr[1]) + 1;
                        currPlayList.Title = subStr[0] + $"#{curNum}";
                        currPlayList.Path =  defName[0] + "-" + defName[1] + $"-{curNum}.list";
                    }
                }
            Library.Add(currPlayList);
            list.Clear();
            LibraryForm.IsChange = true;
        }

        private void playButt_MouseEnter(object sender, EventArgs e)
        {
            if (!nextPause) playButt.BackgroundImage = Resources.play_white;
            else playButt.BackgroundImage = Resources.pause_button_white;
        }

        private void playButt_MouseLeave(object sender, EventArgs e)
        {
            if (!nextPause) playButt.BackgroundImage = Resources.play_FFD5;
            else playButt.BackgroundImage = Resources.pause_button_FFD5;
        }

        private void loopButt_MouseEnter(object sender, EventArgs e)
        {
                loopButt.BackgroundImage = Resources.loop_87DE;
        }

        private void loopButt_MouseLeave(object sender, EventArgs e)
        {
                if(!loop)loopButt.BackgroundImage = Resources.loop__1__FFD5;
        }

        private void randomMediaButt_MouseEnter(object sender, EventArgs e)
        {
            randomMediaButt.BackgroundImage = Resources.random_87DE;
        }

        private void randomMediaButt_MouseLeave(object sender, EventArgs e)
        {
            if (!random) randomMediaButt.BackgroundImage = Resources.random_FFD5;
        }

        private void moreNextButt_MouseEnter(object sender, EventArgs e)
        {
            moreNextButt.BackgroundImage = Resources.play_and_pause_button_white;
        }

        private void moreNextButt_MouseLeave(object sender, EventArgs e)
        {
            moreNextButt.BackgroundImage = Resources.play_and_pause_button_FFD5;
        }

        private void nextButt_MouseEnter(object sender, EventArgs e)
        {
            nextButt.BackgroundImage = Resources.forward_button_white;
        }

        private void nextButt_MouseLeave(object sender, EventArgs e)
        {
            nextButt.BackgroundImage = Resources.forward_button_FFD5;
        }

        private void previousButt_MouseEnter(object sender, EventArgs e)
        {
            previousButt.BackgroundImage = Resources.previous_button_white;
        }

        private void previousButt_MouseLeave(object sender, EventArgs e)
        {
            previousButt.BackgroundImage = Resources.previous_button_FFD5;
        }

        private void morePreviousButt_MouseEnter(object sender, EventArgs e)
        {
            morePreviousButt.BackgroundImage = Resources.previous_white;
        }

        private void morePreviousButt_MouseLeave(object sender, EventArgs e)
        {
            morePreviousButt.BackgroundImage = Resources.previous_FFD5;
        }

        public void HistoryFormUpdate()
        {
            if (activeForm != null) closeChildPanel();
            Form historyForm = null;
            if (formList != null && formList.Count > 0 && formList.TryGetValue("HistoryForm", out historyForm))
            {
                if(HistoryForm.IsChange) ((HistoryForm)historyForm).HistoryList = HistoryList;
                openChildForm(historyForm);
            }
            else openChildForm(new HistoryForm(HistoryList));
        }

        public void historyButt_Click(object sender, EventArgs e)
        {
            HistoryFormUpdate();
        }

        private void mediaPic_Click(object sender, EventArgs e)
        {
            mediaButt_Click(sender, e);
        }

        private void playlistPic_Click(object sender, EventArgs e)
        {
            playListButt_Click(sender, e);
        }

        private void libraryPic_Click(object sender, EventArgs e)
        {
            libraryButt_Click(sender, e);
        }
    }
}
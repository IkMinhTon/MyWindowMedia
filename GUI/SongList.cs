using MMDPlayer.GUI;
using MMDPlayer.Object;
using MMDPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMDPlayer.GUI
{
    public partial class SongList : Form
    {
        public int Hours { get; set; } = 0;
        public int Minutes { get; set; } = 0;
        public int Seconds { get; set; }= 0;
        public List<SongView> list { get; set; }
        public static bool IsChange { get; set; } = false;
        public static bool IsNewPlayList { get; set; } = false;
        public SongList(List<SongView> listSongView)
        {
            InitializeComponent();
            list = listSongView;
        }

        private void SongList_Load(object sender, EventArgs e)
        {
            ListSongsView();
            if (IsNewPlayList)
            {
                playListName.Text = MediaForm.Instance.currPlayList.Title;
                if (MediaForm.Instance.currPlayList.image.Length > 0)
                {
                    FileInfo fileImage = new FileInfo(MediaForm.Instance.currPlayList.image);
                    if (fileImage != null && fileImage.Exists)
                    {
                        var image = Image.FromFile(MediaForm.Instance.currPlayList.image);
                        playListPicture.Image = image;
                    }
                    else
                    {
                        playListPicture.Image = Resources.video_marketing;
                        MediaForm.Instance.currPlayList.image = "";
                    }
                }
                else playListPicture.Image = Resources.video_marketing;
            }
        }

        public void ListSongsView()
        {
            listSongs.Controls.Clear();
            if (list != null && list.Count > 0)
            {
                Hours = 0; Minutes = 0; Seconds = 0;
                for(int i = list.Count - 1; i >= 0 ; i--)
                {
                    SongView view = list[i];
                    view.Parent = this;
                    listSongs.Controls.Add(view);
                    Hours += view.mediaInfo.Time.Hours;
                    Minutes += view.mediaInfo.Time.Minutes;
                    Seconds += view.mediaInfo.Time.Seconds;
                }
                if (Seconds >= 60)
                {
                    int min = Seconds / 60;
                    Seconds %= 60;
                    Minutes += min;
                }
                if (Minutes >= 60)
                {
                    int hr = Minutes / 60;
                    Minutes %= 60;
                    Hours += hr;
                }
            } else
            {
                Hours = 0;
                Minutes = 0;
                Seconds = 0;
            }
            songNumberLabel.Text = list.Count + " Songs";
            if (Hours > 0) totalTimeRunLabel.Text = $"{Hours:0} hr {Minutes:0} min {Seconds} sec";
            else if (Minutes > 0) totalTimeRunLabel.Text = $"{Minutes:0} min {Seconds} sec";
            else totalTimeRunLabel.Text = $"{Seconds} sec";
            MediaForm.Instance.currPlayList.Amount = list.Count;
            MediaForm.Instance.currPlayList.TotalTime = GetTotalTime();
            Utils.WriteToJsonFile(MediaForm.Instance.currPlayList.Path, list);
            IsChange = false;
        }

        public void RefreshDeleteSongTime(SongView songView)
        {
            if(songView != null)
            {
                Hours -= songView.mediaInfo.Time.Hours;
                Minutes -= songView.mediaInfo.Time.Minutes;
                Seconds -= songView.mediaInfo.Time.Seconds;
                if (Seconds < 0)
                {
                    Minutes -= 1;
                    Seconds = 60 - Math.Abs(Seconds);
                }
                if (Minutes < 0)
                {
                    Hours -= 1;
                    Minutes = 60 - Math.Abs(Minutes);
                }
                if (Hours < 0)
                {
                    Hours = 0;
                    Minutes = 0;
                    Seconds = 0;
                }
                songNumberLabel.Text = list.Count + " Songs";
                if (Hours > 0) totalTimeRunLabel.Text = $"{Hours:0} hr {Minutes:0} min {Seconds} sec";
                else if (Minutes > 0) totalTimeRunLabel.Text = $"{Minutes:0} min {Seconds} sec";
                else totalTimeRunLabel.Text = $"{Seconds} sec";
                MediaForm.Instance.currPlayList.Amount = list.Count;
                MediaForm.Instance.currPlayList.TotalTime = GetTotalTime();
            }
        }

        public TimeSpan GetTotalTime()
        {
            return new TimeSpan(Hours, Minutes, Seconds);
        }

        public void AddToList(List<SongView> list)
        {
            if (list != null)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    SongView view = list[i];
                    view.Parent = this;
                    listSongs.Controls.Add(view);
                    Hours += view.mediaInfo.Time.Hours;
                    Minutes += view.mediaInfo.Time.Minutes;
                    Seconds += view.mediaInfo.Time.Seconds;
                }
                if (Seconds >= 60)
                {
                    int min = Seconds / 60;
                    Seconds %= 60;
                    Minutes += min;
                }
                if (Minutes >= 60)
                {
                    int hr = Minutes / 60;
                    Minutes %= 60;
                    Hours += hr;
                }
                songNumberLabel.Text = this.list.Count + " Songs";
                if (Hours > 0) totalTimeRunLabel.Text = $"{Hours:0} hr {Minutes:0} min {Seconds} sec";
                else if (Minutes > 0) totalTimeRunLabel.Text = $"{Minutes:0} min {Seconds} sec";
                else totalTimeRunLabel.Text = $"{Seconds} sec";
                MediaForm.Instance.currPlayList.Amount = this.list.Count;
                MediaForm.Instance.currPlayList.TotalTime = GetTotalTime();
                Utils.WriteToJsonFile(MediaForm.Instance.currPlayList.Path, this.list);
            }
        }

        public void AddOne(SongView songView)
        {
            if (songView != null)
            {
                SongView view = songView;
                view.Parent = this;
                listSongs.Controls.Add(view);
                Hours += view.mediaInfo.Time.Hours;
                Minutes += view.mediaInfo.Time.Minutes;
                Seconds += view.mediaInfo.Time.Seconds;
                if (Seconds >= 60)
                {
                    int min = Seconds / 60;
                    Seconds %= 60;
                    Minutes += min;
                }
                if (Minutes >= 60)
                {
                    int hr = Minutes / 60;
                    Minutes %= 60;
                    Hours += hr;
                }
                songNumberLabel.Text = list.Count + " Songs";
                if (Hours > 0) totalTimeRunLabel.Text = $"{Hours:0} hr {Minutes:0} min {Seconds} sec";
                else if (Minutes > 0) totalTimeRunLabel.Text = $"{Minutes:0} min {Seconds} sec";
                else totalTimeRunLabel.Text = $"{Seconds} sec";
                MediaForm.Instance.currPlayList.Amount = list.Count;
                MediaForm.Instance.currPlayList.TotalTime = GetTotalTime();
                Utils.WriteToJsonFile(MediaForm.Instance.currPlayList.Path, list);
            }
        }

        private void listSongs_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void SongList_VisibleChanged(object sender, EventArgs e)
        {
            listSongs.Refresh();
            if (IsChange) ListSongsView();
            if(IsNewPlayList)
            {
                saveButt.Visible = false;
                label4.Visible = false;
            } else {
                saveButt.Visible = true;
                label4.Visible = true;
            }
            playListName.Text = MediaForm.Instance.currPlayList.Title;
            if (MediaForm.Instance.currPlayList.image.Length > 0)
            {
                FileInfo fileImage = new FileInfo(MediaForm.Instance.currPlayList.image);
                if (fileImage != null && fileImage.Exists)
                {
                    var image = Image.FromFile(MediaForm.Instance.currPlayList.image);
                    playListPicture.Image = image;
                }
                else
                {
                    playListPicture.Image = Resources.video_marketing;
                    MediaForm.Instance.currPlayList.image = "";
                }
            }
            else playListPicture.Image = Resources.video_marketing;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteAllButt_Click(object sender, EventArgs e)
        {
            if (list == null || list.Count <= 0)
            {
                MessageBox.Show("Nothing in list to delete!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult d = MessageBox.Show("Do you want to delete all media?", MediaForm.Instance.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                list.Clear();
                MediaForm.Instance.list = list;
                Utils.listMedia.Clear();
                ListSongsView();
                MediaForm.Instance.endingMedia();
                LibraryForm.IsChange = true;
                Utils.WriteToJsonFile(MediaForm.Instance.currPlayList.Path, list);
            }
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            if (IsNewPlayList)
            {
                Utils.listMedia.Clear();
                MediaForm.Instance.AddToList();
                if (list != null && list.Count > 0)
                {
                    Utils.WriteLibraryPlayList(Utils.DEF_PLAYLIST_LOC, MediaForm.Instance.Library);
                }
            }
            else
            {
                MediaForm.Instance.AddToList();
            }
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                SaveFileDialog saveFile = new SaveFileDialog()
                {
                    Filter = "All|*.dat;*.list;*.txt|DAT|*.dat|LIST|*.list|TXT|*.txt",
                    Title = "Save List Media",
                    DefaultExt = ".list",
                };
                DialogResult d = saveFile.ShowDialog();
                if (saveFile.CheckPathExists && d == DialogResult.OK)
                {
                    MediaForm.Instance.Library.Add(new PlayList(Path.GetFileNameWithoutExtension(saveFile.FileName), saveFile.FileName, GetTotalTime(), list.Count));
                    LibraryForm.IsChange = true;
                    Utils.WriteToJsonFile(saveFile.FileName, list);
                }
            } else
            {
                MessageBox.Show("Nothing in list to save!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listSongs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void playListName_Click(object sender, EventArgs e)
        {
            MediaForm media = MediaForm.Instance;
            PlayListDetails playListDetails = new PlayListDetails(this);
            playListDetails.StartPosition = FormStartPosition.CenterScreen;
            media.Opacity = 0.8;
            playListDetails.ShowDialog();
        }

        private void playListPicture_Click(object sender, EventArgs e)
        {
            playListName_Click(sender, e);
        }
    }
}

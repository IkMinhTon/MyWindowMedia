using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMDPlayer.GUI
{
    public partial class SongViewDetails : Form
    {
        public SongView CurSong { get; set; }
        private string parentName;
        public SongViewDetails(SongView song, string parentName)
        {
            this.parentName = parentName;
            CurSong = song;
            InitializeComponent();
            songPath.Text = song.mediaInfo.Path;
            songTitle.Text = song.mediaInfo.Title;
            songAuthor.Text = song.mediaInfo.Author;
        }

        private void choosePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = MediaForm.Instance.openFileChoose(false);
            if (openFile == null) return;
            if(openFile.CheckFileExists && openFile.CheckPathExists)
            {
                songPath.Text = openFile.FileName;
            }
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            List<SongView> list = MediaForm.Instance.list;
            List<SongView> history = MediaForm.Instance.HistoryList;
            bool timeChange = false;
            if(list != null && list.Count > 0)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    SongView song = list[i];
                    if(song.mediaInfo.Path.Equals(CurSong.mediaInfo.Path))
                    {
                        list[i].mediaInfo.Title = songTitle.Text.Trim();
                        list[i].mediaInfo.Author = songAuthor.Text.Trim();
                        string nPath = songPath.Text.Trim();
                        if (!song.mediaInfo.Path.Equals(nPath))
                        {
                            list[i].mediaInfo.Time = MediaForm.Instance.GetMediaDuration(nPath);
                            list[i].mediaInfo.Path = nPath;
                            timeChange = true;
                        }
                        if (MediaForm.isRunning)
                        {
                            string currPath = MediaForm.Instance.player.URL;
                            if (currPath != null && currPath.Length > 0)
                                if (currPath.Equals(CurSong.mediaInfo.Path)) MediaForm.Instance.FillSongInfo(null, list[i].mediaInfo);
                        }
                    }
                }
            }
            if (history != null && history.Count > 0)
            {
                for (int i = 0; i < history.Count; i++)
                {
                    SongView song = history[i];
                    if (song.mediaInfo.Path.Equals(CurSong.mediaInfo.Path))
                    {
                        history[i].mediaInfo.Title = songTitle.Text.Trim();
                        history[i].mediaInfo.Author = songAuthor.Text.Trim();
                        string nPath = songPath.Text.Trim();
                        if (!song.mediaInfo.Path.Equals(nPath))
                        {
                            history[i].mediaInfo.Time = MediaForm.Instance.GetMediaDuration(nPath);
                            history[i].mediaInfo.Path = nPath;
                        }
                    }
                }
            }
            MediaForm.Instance.list = list;
            MediaForm.Instance.HistoryList = history;
            SongList.IsChange = true;
            HistoryForm.IsChange = true;
            if (timeChange) LibraryForm.IsChange = true;
            if (parentName != null)
            {
                if (parentName.Equals("listSongs")) MediaForm.Instance.OnPlayListButton();
                else MediaForm.Instance.HistoryFormUpdate();
            }
            Close();
        }

        private void SongViewDetails_Load(object sender, EventArgs e)
        {
            if(MediaForm.Instance.list == null || !MediaForm.Instance.list.Contains(CurSong))
            {
                songTitle.Enabled = false;
                songAuthor.Enabled = false;
                choosePath.Visible = false;
                saveButt.Visible = false;
            }
            MediaForm.Instance.Opacity = 0.8;
            Application.RemoveMessageFilter(MediaForm.Instance);
        }

        private void SongViewDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.AddMessageFilter(MediaForm.Instance);
            MediaForm.Instance.Opacity = 1;
        }
    }
}

using MMDPlayer.GUI;
using MMDPlayer.Object;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMDPlayer.GUI
{
    public partial class SongView : UserControl
    {
        
        public Media mediaInfo { get; set; }

        public Button DeleteButt { get { return deleteButt; } } 
        public bool HistoryDlt { get; set; } = false;
        public SongView (Media mediaInfo)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            this.mediaInfo = mediaInfo;
            songAuthor.Text = mediaInfo.Author;
            songTitle.Text = mediaInfo.Title;
        }
        private void songClick(object sender, EventArgs e)
        {
            MediaForm.Instance.PlayMedia(mediaInfo);
        }

        private void deleteClick(object sender, EventArgs e)
        {
            if(HistoryDlt)
            {
                MediaForm.Instance.HistoryList.Remove(this);
                HistoryForm.IsChange = true;
                MediaForm.Instance.historyButt_Click(sender, e);
                return;
            }
            DialogResult d = MessageBox.Show("Do you want to delete this media?", MediaForm.Instance.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                if (MediaForm.Instance.RemoveMedia(this))
                {
                    if (Utils.listMedia != null && Utils.listMedia.Count > 0)
                    {
                        for (int i = 0; i < Utils.listMedia.Count; i++)
                        {
                            var media = Utils.listMedia[i];
                            if (media != null)
                            {
                                if (media.Path.Equals(mediaInfo.Path))
                                {
                                    Utils.listMedia.Remove(media);
                                }
                            }
                        }
                    }
                    LibraryForm.IsChange = true;
                    Dispose();
                    Utils.WriteToJsonFile(MediaForm.Instance.currPlayList.Path, MediaForm.Instance.list);
                }
            }
            
        }

        private void songTitle_MouseEnter(object sender, EventArgs e)
        {
            songTitle.BackColor = Color.DimGray;
            songAuthor.BackColor = Color.DimGray;
        }

        private void songTitle_MouseLeave(object sender, EventArgs e)
        {
            songTitle.BackColor = Color.FromArgb(47, 44, 61);
            songAuthor.BackColor = Color.FromArgb(47, 44, 61);
        }

        private void songTitle_DoubleClick(object sender, EventArgs e)
        {
           new SongViewDetails(this, Parent.Name).ShowDialog();
        }

        private void songAuthor_VisibleChanged(object sender, EventArgs e)
        {
            songAuthor.Text = mediaInfo.Author;
            songTitle.Text = mediaInfo.Title;
        }
    }
}

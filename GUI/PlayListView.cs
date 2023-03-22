using MMDPlayer.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMDPlayer.GUI
{
    public partial class PlayListView : UserControl
    {
        private static readonly string DEF_LIST_NAME = "PlayList Name";
        public PlayList playList { get; set; }
        public bool IsCurrPlayList { get; set; }
        public PlayListView(PlayList playList, bool isCurrPlayList)
        {
            InitializeComponent();
            this.playList = playList;
            IsCurrPlayList = isCurrPlayList;
            if (CheckName(playList.Title))
            {
                playListLabel.Text = UpperFirstChar(playList.Title);
            }
            else playListLabel.Text = DEF_LIST_NAME;
            totalSongsLabel.Text = playList.Amount + " Songs";
            int hours = playList.TotalTime.Hours;
            int minutes = playList.TotalTime.Minutes;
            int seconds = playList.TotalTime.Seconds;
            if (playList.image.Length > 0)
            {
                FileInfo fileImage = new FileInfo(playList.image);
                if (fileImage.Exists)
                {
                    var image = Image.FromFile(playList.image);
                    playListPicture.BackgroundImage = image;
                    playListPicture.Image = null;
                }
            }
            if (hours > 0) totalTimeLabel.Text = $"{hours:0} hr {minutes:0} min {seconds} sec";
            else if (minutes > 0) totalTimeLabel.Text = $"{minutes:0} min {seconds} sec";
            else totalTimeLabel.Text = $"{seconds} sec";
        }

        private void PlayListView_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(21, 38, 45);
        }

        private void PlayListView_Load(object sender, EventArgs e)
        {
            if (playList.Amount <= 0)
            {
                Dispose();
            }
            SelectedPlayList();
        }

        public void SelectedPlayList()
        {
            if (IsCurrPlayList)
            {
                playListLabel.ForeColor = Color.FromArgb(192, 255, 255);
                playListLabel.Font = new Font("Dungeon", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
                totalSongsLabel.ForeColor = Color.FromArgb(192, 255, 255);
                totalTimeLabel.ForeColor = Color.FromArgb(192, 255, 255);
                label2.ForeColor = Color.FromArgb(192, 255, 255);
            }
            else
            {
                playListLabel.ForeColor = SystemColors.ButtonHighlight;
                playListLabel.Font = new Font("Roboto", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
                totalSongsLabel.ForeColor = SystemColors.ButtonHighlight;
                totalTimeLabel.ForeColor = SystemColors.ButtonHighlight;
                label2.ForeColor = SystemColors.ButtonHighlight;
            }
        }
        public bool CheckName(string name)
        {
            name = name.Trim();
            if (name.Length > 0)
            {
                return true;
            }
            return false;
        }

        public string UpperFirstChar(string name)
        {
            name = name.ToLower();
            string uppFirst = name[0] + "";
            name = uppFirst.ToUpper() + name.Substring(1, name.Length - 1);
            return name;
        }

        private void playListPicture_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(38, 38, 38);
            playListPicture.BackColor = Color.FromArgb(38,38,38);
            playListLabel.BackColor = Color.FromArgb(38, 38, 38);
            label2.BackColor = Color.FromArgb(38, 38, 38);
            totalSongsLabel.BackColor = Color.FromArgb(38, 38, 38);
            totalTimeLabel.BackColor = Color.FromArgb(38, 38, 38);
        }

        private void playListPicture_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(36, 33, 49);
            playListPicture.BackColor = Color.FromArgb(36, 33, 49);
            playListLabel.BackColor = Color.FromArgb(36, 33, 49);
            label2.BackColor = Color.FromArgb(36, 33, 49);
            totalSongsLabel.BackColor = Color.FromArgb(36, 33, 49);
            totalTimeLabel.BackColor = Color.FromArgb(36, 33, 49);
        }

        private void playListPicture_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(36, 33, 49);
            playListPicture.BackColor = Color.FromArgb(36, 33, 49);
            playListLabel.BackColor = Color.FromArgb(36, 33, 49);
            label2.BackColor = Color.FromArgb(36, 33, 49);
            totalSongsLabel.BackColor = Color.FromArgb(36, 33, 49);
            totalTimeLabel.BackColor = Color.FromArgb(36, 33, 49);
        }

        private void playListPicture_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(38, 38, 38);
            playListPicture.BackColor = Color.FromArgb(38, 38, 38);
            playListLabel.BackColor = Color.FromArgb(38, 38, 38);
            label2.BackColor = Color.FromArgb(38, 38, 38);
            totalSongsLabel.BackColor = Color.FromArgb(38, 38, 38);
            totalTimeLabel.BackColor = Color.FromArgb(38, 38, 38);
        }

        private void playListPicture_MouseClick(object sender, MouseEventArgs e)
        {
            MediaForm mediaF = MediaForm.Instance;
            if (!IsCurrPlayList)
            {
                mediaF.LoadPlayList(playList);
                LibraryForm.IsChange = true;
            } else
            {
                mediaF.OnPlayListButton();
            }
        }

        private void PlayListView_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}

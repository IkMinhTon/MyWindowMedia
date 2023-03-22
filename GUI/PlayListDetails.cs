using MMDPlayer.Object;
using MMDPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMDPlayer.GUI
{
    public partial class PlayListDetails : Form
    {
        public SongList Songlist { get; set; }
        private string imagePath = "";
        public PlayListDetails(SongList songList)
        {
            InitializeComponent();
            Songlist = songList;
            songNumberLabel.Text = songList.list.Count + " Songs";
            if (songList.Hours > 0) totalTimeRunLabel.Text = $"{songList.Hours:0} hr {songList.Minutes:0} min {songList.Seconds} sec";
            else if (songList.Minutes > 0) totalTimeRunLabel.Text = $"{songList.Minutes:0} min {songList.Seconds} sec";
            else totalTimeRunLabel.Text = $"{songList.Seconds} sec";
        }

        private void playListNameBox__TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayListDetails_MouseEnter(object sender, EventArgs e)
        {

        }

        private void choosePicture_MouseEnter(object sender, EventArgs e)
        {
            choosePicture.BackgroundImage = Resources.image_choose_a_photo;
        }

        private void choosePicture_MouseLeave(object sender, EventArgs e)
        {
            if (imagePath.Length <= 0) choosePicture.BackgroundImage = Resources.video_marketing;
            else
            {
                FileInfo fileImage = new FileInfo(imagePath);
                if (fileImage != null && fileImage.Exists)
                {
                    choosePicture.BackgroundImage = Image.FromFile(imagePath);
                } else choosePicture.BackgroundImage = Resources.video_marketing;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayListDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            MediaForm.Instance.Opacity = 1;
            Application.AddMessageFilter(MediaForm.Instance);

        }

        private void PlayListDetails_Load(object sender, EventArgs e)
        {
            Application.RemoveMessageFilter(MediaForm.Instance);
            playListNameBox.Text = MediaForm.Instance.currPlayList.Title;
            if(MediaForm.Instance.currPlayList.image.Length > 0)
            {
                imagePath = MediaForm.Instance.currPlayList.image;
                FileInfo fileImage = new FileInfo(imagePath);
                if (fileImage != null && fileImage.Exists)
                {
                    choosePicture.BackgroundImage = Image.FromFile(imagePath);
                }
                else choosePicture.BackgroundImage = Resources.video_marketing;
            }
        }
        private void choosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog()
            {
                Filter = "ALL|*.png;*.jpg;*.jpeg;*.jfif;*.pjpeg;*.pjp",
                ValidateNames = true,
                Multiselect = false,
            };
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                if (openImage.CheckFileExists)
                {
                    imagePath = openImage.FileName;
                    choosePicture.BackgroundImage = Image.FromFile(openImage.FileName);
                }
            }
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            PlayList currPlayList = MediaForm.Instance.currPlayList;
            List<PlayList> list = MediaForm.Instance.Library;
            if (imagePath.Length > 0)
            {
                currPlayList.image = imagePath;
            }
            currPlayList.Title = playListNameBox.Text.Trim();
            if (list != null)
            {
                foreach(var playlist in list)
                {
                    if(playlist.Path.Equals(currPlayList.Path))
                    {
                        if(!currPlayList.Title.ToLower().Contains("My PlayList #".ToLower())) 
                            playlist.Path = Utils.DEF_DIRECTORY + $"uc-playlist-{currPlayList.Title}.list"; 
                        playlist.Title = currPlayList.Title;
                        playlist.image = currPlayList.image;
                    }
                }
            }
            MediaForm.Instance.currPlayList = currPlayList;
            MediaForm.Instance.Library = list;
            SongList.IsChange = true;
            LibraryForm.IsChange = true;
            MediaForm.Instance.OnPlayListButton();
            Close();
        }
    }
}

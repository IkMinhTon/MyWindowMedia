using MMDPlayer.Object;
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
    public partial class LibraryForm : Form
    {
        public List<PlayList> LibraryPlayList { get; set; }
        public static bool IsChange { get; set; } = false;
        public LibraryForm(List<PlayList> LibraryPlayList)
        {
            this.LibraryPlayList = LibraryPlayList;
            InitializeComponent();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            LibraryChange();
            ViewUpdate();
        }

        public void ViewUpdate()
        {
            if (LibraryPlayList != null && LibraryPlayList.Count > 0)
            {
                playListShowPanel.Controls.Clear();
                PlayList currlist = MediaForm.Instance.currPlayList;
                for (int i = 0; i < LibraryPlayList.Count; i++)
                {
                    
                    if (currlist.TotalTime.Equals(LibraryPlayList[i].TotalTime) &&
                        currlist.Title.Equals(LibraryPlayList[i].Title)) playListShowPanel.Controls.Add(new PlayListView(LibraryPlayList[i], true));
                    else playListShowPanel.Controls.Add(new PlayListView(LibraryPlayList[i], false));
                }
                IsChange = false;
            }
        }

        private void LibraryForm_VisibleChanged(object sender, EventArgs e)
        {
            if (IsChange)
            {
                LibraryChange();
                ViewUpdate();
            }
        }

        public void LibraryChange()
        {
            if (LibraryPlayList != null && LibraryPlayList.Count > 0)
            {
                for (int i = 0; i < LibraryPlayList.Count; i++)
                {
                    if (LibraryPlayList[i].Title.Equals(MediaForm.Instance.currPlayList.Title))
                    {
                        LibraryPlayList[i].TotalTime = MediaForm.Instance.currPlayList.TotalTime;
                        LibraryPlayList[i].Amount = MediaForm.Instance.currPlayList.Amount;
                        MediaForm.Instance.Library = LibraryPlayList;
                    }
                }
            }
        }

        public void ViewSearch(List<PlayList> playLists)
        {
            playListShowPanel.Controls.Clear();

            for (int i = 0; i < playLists.Count; i++)
            {
                if (MediaForm.Instance.currPlayList.Equals(playLists[i])) playListShowPanel.Controls.Add(new PlayListView(playLists[i], true));
                else playListShowPanel.Controls.Add(new PlayListView(playLists[i], false));
            }
        }

        public bool CheckInput()
        {
            if (LibraryPlayList == null || LibraryPlayList.Count <= 0) return false;
            if (searchBox.Texts.Length <= 0)
            {
                ViewUpdate();
                return false;
            }
            Application.RemoveMessageFilter(MediaForm.Instance);
            return true;
        }

        private void searchBox__TextChanged(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            if(LibraryPlayList != null && LibraryPlayList.Count > 0)
            {
                List<PlayList> listSearch = new List<PlayList>();
                for(int i = 0; i < LibraryPlayList.Count; i++)
                {
                    if (LibraryPlayList[i].Title.ToLower().Contains(searchBox.Texts.ToLower())) listSearch.Add(LibraryPlayList[i]);
                    else
                    {
                        if (listSearch.Contains(LibraryPlayList[i])) listSearch.Remove(LibraryPlayList[i]);
                    }
                }
                ViewSearch(listSearch);
            }
        }

        public OpenFileDialog openFileChoose(bool multiselect)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog()
                {
                    Multiselect = multiselect,
                    ValidateNames = true,
                    Filter = "All|*.list;*.txt;*.dat|LIST|*.list|TXT|*.txt|DAT|*.dat",
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

        public void AddPlayListToLibrary()
        {
            try {
                OpenFileDialog openFile = openFileChoose(true);
                if (openFile != null)
                {
                    if (openFile.CheckFileExists && openFile.CheckPathExists)
                    {
                        for (int i = 0; i < openFile.FileNames.Count(); i++)
                        {
                            var playlist = openFile.FileNames[i];
                            List<SongView> list = Utils.ChangeMediaInfoToView(playlist);

                            if (list != null && list.Count > 0)
                            {
                                LibraryPlayList.Add(new PlayList()
                                {
                                    Title = Path.GetFileNameWithoutExtension(playlist),
                                    Path = playlist,
                                    Amount = list.Count,
                                    TotalTime = Utils.GetTotalTime(list),
                                });
                            }
                        }
                        ViewUpdate();
                        MediaForm.Instance.Library = LibraryPlayList;
                    }
                }
            } catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addListButt_Click(object sender, EventArgs e)
        {
            AddPlayListToLibrary();
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            Application.AddMessageFilter(MediaForm.Instance);
        }
    }
}

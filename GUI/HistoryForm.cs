using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMDPlayer.GUI
{
    public partial class HistoryForm : Form
    {
        public List<SongView> HistoryList { get; set; }

        public static bool IsChange { get; set; } = false;
        public HistoryForm(List<SongView> historyList)
        {
            HistoryList = historyList;
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            ListSongView();
        }

        public void ListSongView()
        {
            panelHistory.Controls.Clear();
            if (HistoryList != null && HistoryList.Count > 0)
            {
                for (int i = 0; i < HistoryList.Count; i++)
                {
                    SongView song = HistoryList[i];
                    song.HistoryDlt = true;
                    song.Parent = this;
                    panelHistory.Controls.Add(song);
                }
            }
            IsChange = false;
        }

        private void HistoryForm_VisibleChanged(object sender, EventArgs e)
        {
            if(IsChange) ListSongView();
        }
    }
}

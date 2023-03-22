using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MMDPlayer.GUI
{
    public partial class WinMedia : Form
    {

        //private readonly int ESC_BUTT = 27;
        public WinMedia()
        {
            InitializeComponent();
            winMedia.enableContextMenu = false;
        }

        private void axWindowsMediaPlayer1_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
        }
    }
}

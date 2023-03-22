
namespace MMDPlayer.GUI
{
    partial class MediaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaForm));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.libraryButt = new System.Windows.Forms.Button();
            this.libraryPic = new System.Windows.Forms.PictureBox();
            this.subList2 = new System.Windows.Forms.Panel();
            this.historyButt = new System.Windows.Forms.Button();
            this.createPlaylistButt = new System.Windows.Forms.Button();
            this.playListButt = new System.Windows.Forms.Button();
            this.playlistPic = new System.Windows.Forms.PictureBox();
            this.subListPlayList = new System.Windows.Forms.PictureBox();
            this.mediaButt = new System.Windows.Forms.Button();
            this.mediaPic = new System.Windows.Forms.PictureBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.sidePanelEye = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startMedia = new System.Windows.Forms.Label();
            this.playButt = new System.Windows.Forms.Button();
            this.loopButt = new System.Windows.Forms.Button();
            this.morePreviousButt = new System.Windows.Forms.Button();
            this.randomMediaButt = new System.Windows.Forms.Button();
            this.previousButt = new System.Windows.Forms.Button();
            this.endMedia = new System.Windows.Forms.Label();
            this.moreNextButt = new System.Windows.Forms.Button();
            this.nextButt = new System.Windows.Forms.Button();
            this.mediaTrack = new XComponent.SliderBar.MACTrackBar();
            this.listMedia = new System.Windows.Forms.Button();
            this.soundTrack = new XComponent.SliderBar.MACTrackBar();
            this.sound = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.songTitle = new System.Windows.Forms.TextBox();
            this.authorSong = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.sidePanel.SuspendLayout();
            this.libraryButt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryPic)).BeginInit();
            this.subList2.SuspendLayout();
            this.playListButt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subListPlayList)).BeginInit();
            this.mediaButt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidePanel.Controls.Add(this.libraryButt);
            this.sidePanel.Controls.Add(this.subList2);
            this.sidePanel.Controls.Add(this.playListButt);
            this.sidePanel.Controls.Add(this.mediaButt);
            this.sidePanel.Controls.Add(this.logoBox);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(229, 503);
            this.sidePanel.TabIndex = 0;
            // 
            // libraryButt
            // 
            this.libraryButt.AllowDrop = true;
            this.libraryButt.BackColor = System.Drawing.Color.Transparent;
            this.libraryButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.libraryButt.Controls.Add(this.libraryPic);
            this.libraryButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libraryButt.Dock = System.Windows.Forms.DockStyle.Top;
            this.libraryButt.FlatAppearance.BorderSize = 0;
            this.libraryButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.libraryButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.libraryButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libraryButt.Font = new System.Drawing.Font("VNI-Fato", 15.75F, System.Drawing.FontStyle.Bold);
            this.libraryButt.ForeColor = System.Drawing.Color.White;
            this.libraryButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.libraryButt.Location = new System.Drawing.Point(0, 249);
            this.libraryButt.Margin = new System.Windows.Forms.Padding(0);
            this.libraryButt.Name = "libraryButt";
            this.libraryButt.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.libraryButt.Size = new System.Drawing.Size(227, 35);
            this.libraryButt.TabIndex = 0;
            this.libraryButt.TabStop = false;
            this.libraryButt.Text = "Library";
            this.libraryButt.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.libraryButt.UseVisualStyleBackColor = false;
            this.libraryButt.Click += new System.EventHandler(this.libraryButt_Click);
            // 
            // libraryPic
            // 
            this.libraryPic.BackgroundImage = global::MMDPlayer.Properties.Resources.books;
            this.libraryPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.libraryPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.libraryPic.Location = new System.Drawing.Point(0, 0);
            this.libraryPic.Name = "libraryPic";
            this.libraryPic.Size = new System.Drawing.Size(43, 35);
            this.libraryPic.TabIndex = 7;
            this.libraryPic.TabStop = false;
            this.libraryPic.Click += new System.EventHandler(this.libraryPic_Click);
            // 
            // subList2
            // 
            this.subList2.Controls.Add(this.historyButt);
            this.subList2.Controls.Add(this.createPlaylistButt);
            this.subList2.Dock = System.Windows.Forms.DockStyle.Top;
            this.subList2.Location = new System.Drawing.Point(0, 179);
            this.subList2.Name = "subList2";
            this.subList2.Size = new System.Drawing.Size(227, 70);
            this.subList2.TabIndex = 1;
            // 
            // historyButt
            // 
            this.historyButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.historyButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButt.Dock = System.Windows.Forms.DockStyle.Top;
            this.historyButt.FlatAppearance.BorderSize = 0;
            this.historyButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.historyButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButt.Font = new System.Drawing.Font("VNI-Cooper", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.historyButt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.historyButt.Location = new System.Drawing.Point(0, 35);
            this.historyButt.Margin = new System.Windows.Forms.Padding(0);
            this.historyButt.Name = "historyButt";
            this.historyButt.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.historyButt.Size = new System.Drawing.Size(227, 35);
            this.historyButt.TabIndex = 1;
            this.historyButt.Text = "History Played";
            this.historyButt.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.historyButt.UseVisualStyleBackColor = false;
            this.historyButt.Click += new System.EventHandler(this.historyButt_Click);
            // 
            // createPlaylistButt
            // 
            this.createPlaylistButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.createPlaylistButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createPlaylistButt.Dock = System.Windows.Forms.DockStyle.Top;
            this.createPlaylistButt.FlatAppearance.BorderSize = 0;
            this.createPlaylistButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createPlaylistButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPlaylistButt.Font = new System.Drawing.Font("VNI-Cooper", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.createPlaylistButt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createPlaylistButt.Location = new System.Drawing.Point(0, 0);
            this.createPlaylistButt.Margin = new System.Windows.Forms.Padding(0);
            this.createPlaylistButt.Name = "createPlaylistButt";
            this.createPlaylistButt.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.createPlaylistButt.Size = new System.Drawing.Size(227, 35);
            this.createPlaylistButt.TabIndex = 3;
            this.createPlaylistButt.Text = "Create PlayList";
            this.createPlaylistButt.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.createPlaylistButt.UseVisualStyleBackColor = false;
            this.createPlaylistButt.Click += new System.EventHandler(this.createPlaylistButt_Click);
            // 
            // playListButt
            // 
            this.playListButt.AllowDrop = true;
            this.playListButt.BackColor = System.Drawing.Color.Transparent;
            this.playListButt.Controls.Add(this.playlistPic);
            this.playListButt.Controls.Add(this.subListPlayList);
            this.playListButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playListButt.Dock = System.Windows.Forms.DockStyle.Top;
            this.playListButt.FlatAppearance.BorderSize = 0;
            this.playListButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playListButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.playListButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playListButt.Font = new System.Drawing.Font("VNI-Fato", 15.75F, System.Drawing.FontStyle.Bold);
            this.playListButt.ForeColor = System.Drawing.Color.White;
            this.playListButt.Location = new System.Drawing.Point(0, 144);
            this.playListButt.Margin = new System.Windows.Forms.Padding(0);
            this.playListButt.Name = "playListButt";
            this.playListButt.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.playListButt.Size = new System.Drawing.Size(227, 35);
            this.playListButt.TabIndex = 2;
            this.playListButt.TabStop = false;
            this.playListButt.Text = "PlayList";
            this.playListButt.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.playListButt.UseVisualStyleBackColor = false;
            this.playListButt.Click += new System.EventHandler(this.playListButt_Click);
            // 
            // playlistPic
            // 
            this.playlistPic.BackgroundImage = global::MMDPlayer.Properties.Resources.playlist;
            this.playlistPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playlistPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.playlistPic.Location = new System.Drawing.Point(0, 0);
            this.playlistPic.Name = "playlistPic";
            this.playlistPic.Size = new System.Drawing.Size(43, 35);
            this.playlistPic.TabIndex = 6;
            this.playlistPic.TabStop = false;
            this.playlistPic.Click += new System.EventHandler(this.playlistPic_Click);
            // 
            // subListPlayList
            // 
            this.subListPlayList.BackgroundImage = global::MMDPlayer.Properties.Resources.hide_FFD5;
            this.subListPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.subListPlayList.Dock = System.Windows.Forms.DockStyle.Right;
            this.subListPlayList.Location = new System.Drawing.Point(187, 0);
            this.subListPlayList.Name = "subListPlayList";
            this.subListPlayList.Size = new System.Drawing.Size(40, 35);
            this.subListPlayList.TabIndex = 5;
            this.subListPlayList.TabStop = false;
            this.subListPlayList.Click += new System.EventHandler(this.subListPlayList_Click);
            // 
            // mediaButt
            // 
            this.mediaButt.AllowDrop = true;
            this.mediaButt.BackColor = System.Drawing.Color.Transparent;
            this.mediaButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mediaButt.Controls.Add(this.mediaPic);
            this.mediaButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mediaButt.Dock = System.Windows.Forms.DockStyle.Top;
            this.mediaButt.FlatAppearance.BorderSize = 0;
            this.mediaButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mediaButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.mediaButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediaButt.Font = new System.Drawing.Font("VNI-Fato", 15.75F, System.Drawing.FontStyle.Bold);
            this.mediaButt.ForeColor = System.Drawing.Color.White;
            this.mediaButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mediaButt.Location = new System.Drawing.Point(0, 109);
            this.mediaButt.Margin = new System.Windows.Forms.Padding(0);
            this.mediaButt.Name = "mediaButt";
            this.mediaButt.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.mediaButt.Size = new System.Drawing.Size(227, 35);
            this.mediaButt.TabIndex = 3;
            this.mediaButt.TabStop = false;
            this.mediaButt.Text = "Media";
            this.mediaButt.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mediaButt.UseVisualStyleBackColor = false;
            this.mediaButt.Click += new System.EventHandler(this.mediaButt_Click);
            // 
            // mediaPic
            // 
            this.mediaPic.BackColor = System.Drawing.Color.Transparent;
            this.mediaPic.BackgroundImage = global::MMDPlayer.Properties.Resources.social_media;
            this.mediaPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mediaPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.mediaPic.Location = new System.Drawing.Point(0, 0);
            this.mediaPic.Name = "mediaPic";
            this.mediaPic.Size = new System.Drawing.Size(43, 35);
            this.mediaPic.TabIndex = 5;
            this.mediaPic.TabStop = false;
            this.mediaPic.Click += new System.EventHandler(this.mediaPic_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(227, 109);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 4;
            this.logoBox.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.bottomPanel.Controls.Add(this.sidePanelEye);
            this.bottomPanel.Controls.Add(this.panel2);
            this.bottomPanel.Controls.Add(this.listMedia);
            this.bottomPanel.Controls.Add(this.soundTrack);
            this.bottomPanel.Controls.Add(this.sound);
            this.bottomPanel.Controls.Add(this.panel1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 503);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1088, 105);
            this.bottomPanel.TabIndex = 2;
            // 
            // sidePanelEye
            // 
            this.sidePanelEye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sidePanelEye.BackColor = System.Drawing.Color.Transparent;
            this.sidePanelEye.BackgroundImage = global::MMDPlayer.Properties.Resources.eye_FFD5;
            this.sidePanelEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sidePanelEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidePanelEye.FlatAppearance.BorderSize = 0;
            this.sidePanelEye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sidePanelEye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sidePanelEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidePanelEye.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sidePanelEye.Location = new System.Drawing.Point(854, 39);
            this.sidePanelEye.MinimumSize = new System.Drawing.Size(40, 21);
            this.sidePanelEye.Name = "sidePanelEye";
            this.sidePanelEye.Size = new System.Drawing.Size(40, 26);
            this.sidePanelEye.TabIndex = 0;
            this.sidePanelEye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sidePanelEye.UseVisualStyleBackColor = false;
            this.sidePanelEye.Click += new System.EventHandler(this.sidePanelEyE_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.startMedia);
            this.panel2.Controls.Add(this.playButt);
            this.panel2.Controls.Add(this.loopButt);
            this.panel2.Controls.Add(this.morePreviousButt);
            this.panel2.Controls.Add(this.randomMediaButt);
            this.panel2.Controls.Add(this.previousButt);
            this.panel2.Controls.Add(this.endMedia);
            this.panel2.Controls.Add(this.moreNextButt);
            this.panel2.Controls.Add(this.nextButt);
            this.panel2.Controls.Add(this.mediaTrack);
            this.panel2.Location = new System.Drawing.Point(338, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 100);
            this.panel2.TabIndex = 1;
            // 
            // startMedia
            // 
            this.startMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.startMedia.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.startMedia.ForeColor = System.Drawing.Color.White;
            this.startMedia.Location = new System.Drawing.Point(-2, 51);
            this.startMedia.Name = "startMedia";
            this.startMedia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startMedia.Size = new System.Drawing.Size(58, 31);
            this.startMedia.TabIndex = 0;
            this.startMedia.Text = "00:00";
            this.startMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playButt
            // 
            this.playButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.playButt.BackColor = System.Drawing.Color.Transparent;
            this.playButt.BackgroundImage = global::MMDPlayer.Properties.Resources.play_FFD5;
            this.playButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButt.FlatAppearance.BorderSize = 0;
            this.playButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playButt.Location = new System.Drawing.Point(223, 13);
            this.playButt.MinimumSize = new System.Drawing.Size(40, 21);
            this.playButt.Name = "playButt";
            this.playButt.Size = new System.Drawing.Size(40, 39);
            this.playButt.TabIndex = 1;
            this.playButt.TabStop = false;
            this.playButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.playButt.UseVisualStyleBackColor = false;
            this.playButt.Click += new System.EventHandler(this.playButt_Click);
            this.playButt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playButt_MouseDown);
            this.playButt.MouseEnter += new System.EventHandler(this.playButt_MouseEnter);
            this.playButt.MouseLeave += new System.EventHandler(this.playButt_MouseLeave);
            // 
            // loopButt
            // 
            this.loopButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loopButt.BackColor = System.Drawing.Color.Transparent;
            this.loopButt.BackgroundImage = global::MMDPlayer.Properties.Resources.loop__1__FFD5;
            this.loopButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loopButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loopButt.FlatAppearance.BorderSize = 0;
            this.loopButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loopButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loopButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loopButt.Location = new System.Drawing.Point(360, 19);
            this.loopButt.MinimumSize = new System.Drawing.Size(40, 21);
            this.loopButt.Name = "loopButt";
            this.loopButt.Size = new System.Drawing.Size(40, 27);
            this.loopButt.TabIndex = 2;
            this.loopButt.TabStop = false;
            this.loopButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loopButt.UseVisualStyleBackColor = false;
            this.loopButt.Click += new System.EventHandler(this.loop_Click);
            this.loopButt.MouseEnter += new System.EventHandler(this.loopButt_MouseEnter);
            this.loopButt.MouseLeave += new System.EventHandler(this.loopButt_MouseLeave);
            // 
            // morePreviousButt
            // 
            this.morePreviousButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.morePreviousButt.BackColor = System.Drawing.Color.Transparent;
            this.morePreviousButt.BackgroundImage = global::MMDPlayer.Properties.Resources.previous_button_FFD5;
            this.morePreviousButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.morePreviousButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.morePreviousButt.FlatAppearance.BorderSize = 0;
            this.morePreviousButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.morePreviousButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.morePreviousButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.morePreviousButt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.morePreviousButt.Location = new System.Drawing.Point(133, 19);
            this.morePreviousButt.Name = "morePreviousButt";
            this.morePreviousButt.Size = new System.Drawing.Size(40, 30);
            this.morePreviousButt.TabIndex = 3;
            this.morePreviousButt.TabStop = false;
            this.morePreviousButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.morePreviousButt.UseVisualStyleBackColor = false;
            this.morePreviousButt.Click += new System.EventHandler(this.morePreviousButt_Click);
            this.morePreviousButt.MouseEnter += new System.EventHandler(this.morePreviousButt_MouseEnter);
            this.morePreviousButt.MouseLeave += new System.EventHandler(this.morePreviousButt_MouseLeave);
            // 
            // randomMediaButt
            // 
            this.randomMediaButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.randomMediaButt.BackColor = System.Drawing.Color.Transparent;
            this.randomMediaButt.BackgroundImage = global::MMDPlayer.Properties.Resources.random_FFD5;
            this.randomMediaButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.randomMediaButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomMediaButt.FlatAppearance.BorderSize = 0;
            this.randomMediaButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.randomMediaButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.randomMediaButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomMediaButt.ForeColor = System.Drawing.Color.Transparent;
            this.randomMediaButt.Location = new System.Drawing.Point(87, 19);
            this.randomMediaButt.Name = "randomMediaButt";
            this.randomMediaButt.Size = new System.Drawing.Size(40, 27);
            this.randomMediaButt.TabIndex = 4;
            this.randomMediaButt.TabStop = false;
            this.randomMediaButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.randomMediaButt.UseVisualStyleBackColor = false;
            this.randomMediaButt.Click += new System.EventHandler(this.randomButt_Click);
            this.randomMediaButt.MouseEnter += new System.EventHandler(this.randomMediaButt_MouseEnter);
            this.randomMediaButt.MouseLeave += new System.EventHandler(this.randomMediaButt_MouseLeave);
            // 
            // previousButt
            // 
            this.previousButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.previousButt.BackColor = System.Drawing.Color.Transparent;
            this.previousButt.BackgroundImage = global::MMDPlayer.Properties.Resources.previous_button_FFD5;
            this.previousButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousButt.FlatAppearance.BorderSize = 0;
            this.previousButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.previousButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.previousButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.previousButt.Location = new System.Drawing.Point(176, 18);
            this.previousButt.MinimumSize = new System.Drawing.Size(40, 21);
            this.previousButt.Name = "previousButt";
            this.previousButt.Size = new System.Drawing.Size(40, 30);
            this.previousButt.TabIndex = 5;
            this.previousButt.TabStop = false;
            this.previousButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.previousButt.UseVisualStyleBackColor = false;
            this.previousButt.Click += new System.EventHandler(this.previousButt_Click);
            this.previousButt.MouseEnter += new System.EventHandler(this.previousButt_MouseEnter);
            this.previousButt.MouseLeave += new System.EventHandler(this.previousButt_MouseLeave);
            // 
            // endMedia
            // 
            this.endMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.endMedia.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.endMedia.ForeColor = System.Drawing.Color.White;
            this.endMedia.Location = new System.Drawing.Point(425, 51);
            this.endMedia.Name = "endMedia";
            this.endMedia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endMedia.Size = new System.Drawing.Size(58, 31);
            this.endMedia.TabIndex = 6;
            this.endMedia.Text = "00:00";
            this.endMedia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // moreNextButt
            // 
            this.moreNextButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.moreNextButt.BackColor = System.Drawing.Color.Transparent;
            this.moreNextButt.BackgroundImage = global::MMDPlayer.Properties.Resources.play_and_pause_button_FFD5;
            this.moreNextButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moreNextButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moreNextButt.FlatAppearance.BorderSize = 0;
            this.moreNextButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.moreNextButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.moreNextButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreNextButt.Location = new System.Drawing.Point(314, 17);
            this.moreNextButt.MinimumSize = new System.Drawing.Size(40, 21);
            this.moreNextButt.Name = "moreNextButt";
            this.moreNextButt.Size = new System.Drawing.Size(40, 30);
            this.moreNextButt.TabIndex = 7;
            this.moreNextButt.TabStop = false;
            this.moreNextButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.moreNextButt.UseVisualStyleBackColor = false;
            this.moreNextButt.Click += new System.EventHandler(this.moreNextButt_Click);
            this.moreNextButt.MouseEnter += new System.EventHandler(this.moreNextButt_MouseEnter);
            this.moreNextButt.MouseLeave += new System.EventHandler(this.moreNextButt_MouseLeave);
            // 
            // nextButt
            // 
            this.nextButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nextButt.BackColor = System.Drawing.Color.Transparent;
            this.nextButt.BackgroundImage = global::MMDPlayer.Properties.Resources.forward_button_FFD5;
            this.nextButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButt.FlatAppearance.BorderSize = 0;
            this.nextButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nextButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nextButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextButt.Location = new System.Drawing.Point(271, 18);
            this.nextButt.MinimumSize = new System.Drawing.Size(40, 21);
            this.nextButt.Name = "nextButt";
            this.nextButt.Size = new System.Drawing.Size(40, 30);
            this.nextButt.TabIndex = 8;
            this.nextButt.TabStop = false;
            this.nextButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nextButt.UseVisualStyleBackColor = false;
            this.nextButt.Click += new System.EventHandler(this.nextButt_Click);
            this.nextButt.MouseEnter += new System.EventHandler(this.nextButt_MouseEnter);
            this.nextButt.MouseLeave += new System.EventHandler(this.nextButt_MouseLeave);
            // 
            // mediaTrack
            // 
            this.mediaTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mediaTrack.BackColor = System.Drawing.Color.Transparent;
            this.mediaTrack.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mediaTrack.Cursor = System.Windows.Forms.Cursors.Default;
            this.mediaTrack.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.mediaTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mediaTrack.IndentHeight = 6;
            this.mediaTrack.Location = new System.Drawing.Point(53, 51);
            this.mediaTrack.Maximum = 100;
            this.mediaTrack.Minimum = 0;
            this.mediaTrack.Name = "mediaTrack";
            this.mediaTrack.Size = new System.Drawing.Size(375, 33);
            this.mediaTrack.TabIndex = 9;
            this.mediaTrack.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mediaTrack.TickColor = System.Drawing.Color.Transparent;
            this.mediaTrack.TickHeight = 4;
            this.mediaTrack.TrackerColor = System.Drawing.Color.Lavender;
            this.mediaTrack.TrackerSize = new System.Drawing.Size(16, 16);
            this.mediaTrack.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.mediaTrack.TrackLineHeight = 3;
            this.mediaTrack.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.mediaTrack.Value = 0;
            this.mediaTrack.Scroll += new System.EventHandler(this.mediaTrack_Scroll);
            // 
            // listMedia
            // 
            this.listMedia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMedia.BackColor = System.Drawing.Color.Transparent;
            this.listMedia.BackgroundImage = global::MMDPlayer.Properties.Resources.list_text_FFD5;
            this.listMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.listMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listMedia.FlatAppearance.BorderSize = 0;
            this.listMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.listMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.listMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listMedia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listMedia.Location = new System.Drawing.Point(900, 39);
            this.listMedia.MinimumSize = new System.Drawing.Size(40, 21);
            this.listMedia.Name = "listMedia";
            this.listMedia.Size = new System.Drawing.Size(40, 26);
            this.listMedia.TabIndex = 2;
            this.listMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.listMedia.UseVisualStyleBackColor = false;
            this.listMedia.Click += new System.EventHandler(this.listMedia_Click);
            // 
            // soundTrack
            // 
            this.soundTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soundTrack.BackColor = System.Drawing.Color.Transparent;
            this.soundTrack.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.soundTrack.Cursor = System.Windows.Forms.Cursors.Default;
            this.soundTrack.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.soundTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.soundTrack.IndentHeight = 6;
            this.soundTrack.Location = new System.Drawing.Point(991, 39);
            this.soundTrack.Maximum = 100;
            this.soundTrack.Minimum = 0;
            this.soundTrack.Name = "soundTrack";
            this.soundTrack.Size = new System.Drawing.Size(87, 33);
            this.soundTrack.TabIndex = 3;
            this.soundTrack.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.soundTrack.TickColor = System.Drawing.Color.Transparent;
            this.soundTrack.TickHeight = 4;
            this.soundTrack.TrackerColor = System.Drawing.Color.Lavender;
            this.soundTrack.TrackerSize = new System.Drawing.Size(16, 16);
            this.soundTrack.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.soundTrack.TrackLineHeight = 3;
            this.soundTrack.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.soundTrack.Value = 50;
            this.soundTrack.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.soundTrack_ValueChanged);
            this.soundTrack.Scroll += new System.EventHandler(this.soundTrack_Scroll);
            // 
            // sound
            // 
            this.sound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sound.BackColor = System.Drawing.Color.Transparent;
            this.sound.BackgroundImage = global::MMDPlayer.Properties.Resources.volume_FFD5;
            this.sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound.FlatAppearance.BorderSize = 0;
            this.sound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sound.Location = new System.Drawing.Point(945, 39);
            this.sound.MinimumSize = new System.Drawing.Size(40, 21);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(40, 26);
            this.sound.TabIndex = 4;
            this.sound.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sound.UseVisualStyleBackColor = false;
            this.sound.Click += new System.EventHandler(this.sound_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.songTitle);
            this.panel1.Controls.Add(this.authorSong);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 100);
            this.panel1.TabIndex = 5;
            // 
            // songTitle
            // 
            this.songTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.songTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songTitle.Font = new System.Drawing.Font("Roboto", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTitle.ForeColor = System.Drawing.Color.White;
            this.songTitle.Location = new System.Drawing.Point(90, 20);
            this.songTitle.Multiline = true;
            this.songTitle.Name = "songTitle";
            this.songTitle.ReadOnly = true;
            this.songTitle.Size = new System.Drawing.Size(275, 32);
            this.songTitle.TabIndex = 0;
            this.songTitle.TabStop = false;
            this.songTitle.Text = "Song Title";
            // 
            // authorSong
            // 
            this.authorSong.AutoSize = true;
            this.authorSong.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorSong.ForeColor = System.Drawing.Color.White;
            this.authorSong.Location = new System.Drawing.Point(95, 50);
            this.authorSong.Name = "authorSong";
            this.authorSong.Size = new System.Drawing.Size(59, 23);
            this.authorSong.TabIndex = 1;
            this.authorSong.Text = "Author";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MMDPlayer.Properties.Resources.music;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelChildForm.Location = new System.Drawing.Point(229, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(859, 503);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MMDPlayer.Properties.Resources.video_player_withtext;
            this.pictureBox1.Location = new System.Drawing.Point(329, 131);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(216, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 608);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.bottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1104, 647);
            this.Name = "MediaForm";
            this.Text = "Media & Video Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MediaForm_FormClosing);
            this.Load += new System.EventHandler(this.mediaForm_Load);
            this.SizeChanged += new System.EventHandler(this.mediaForm_SizeChanged);
            this.sidePanel.ResumeLayout(false);
            this.libraryButt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libraryPic)).EndInit();
            this.subList2.ResumeLayout(false);
            this.playListButt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playlistPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subListPlayList)).EndInit();
            this.mediaButt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button playButt;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button playListButt;
        private System.Windows.Forms.Button libraryButt;
        private System.Windows.Forms.Panel subList2;
        private System.Windows.Forms.Button historyButt;
        private System.Windows.Forms.Button createPlaylistButt;
        private System.Windows.Forms.Button mediaButt;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label endMedia;
        private System.Windows.Forms.Button moreNextButt;
        private System.Windows.Forms.Button nextButt;
        private System.Windows.Forms.Button morePreviousButt;
        private System.Windows.Forms.Button previousButt;
        private XComponent.SliderBar.MACTrackBar mediaTrack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label authorSong;
        private System.Windows.Forms.Button sound;
        private XComponent.SliderBar.MACTrackBar soundTrack;
        private System.Windows.Forms.Button loopButt;
        private System.Windows.Forms.Button randomMediaButt;
        private System.Windows.Forms.Label startMedia;
        private System.Windows.Forms.TextBox songTitle;
        private System.Windows.Forms.Button listMedia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button sidePanelEye;
        private System.Windows.Forms.PictureBox mediaPic;
        private System.Windows.Forms.PictureBox playlistPic;
        private System.Windows.Forms.PictureBox libraryPic;
        private System.Windows.Forms.PictureBox subListPlayList;
    }
}


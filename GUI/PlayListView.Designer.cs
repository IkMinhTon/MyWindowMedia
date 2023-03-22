
namespace MMDPlayer.GUI
{
    partial class PlayListView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playListLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playListPicture = new System.Windows.Forms.PictureBox();
            this.totalSongsLabel = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.playListPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playListLabel
            // 
            this.playListLabel.AutoSize = true;
            this.playListLabel.BackColor = System.Drawing.Color.Transparent;
            this.playListLabel.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playListLabel.ForeColor = System.Drawing.Color.White;
            this.playListLabel.Location = new System.Drawing.Point(10, 10);
            this.playListLabel.Name = "playListLabel";
            this.playListLabel.Size = new System.Drawing.Size(114, 21);
            this.playListLabel.TabIndex = 1;
            this.playListLabel.Text = "PlayList Name";
            this.playListLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseClick);
            this.playListLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseDown);
            this.playListLabel.MouseEnter += new System.EventHandler(this.playListPicture_MouseEnter);
            this.playListLabel.MouseLeave += new System.EventHandler(this.playListPicture_MouseLeave);
            this.playListLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "By You";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseClick);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseDown);
            this.label2.MouseEnter += new System.EventHandler(this.playListPicture_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.playListPicture_MouseLeave);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseUp);
            // 
            // playListPicture
            // 
            this.playListPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playListPicture.Image = global::MMDPlayer.Properties.Resources.music;
            this.playListPicture.Location = new System.Drawing.Point(9, 15);
            this.playListPicture.Name = "playListPicture";
            this.playListPicture.Size = new System.Drawing.Size(190, 117);
            this.playListPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playListPicture.TabIndex = 0;
            this.playListPicture.TabStop = false;
            this.playListPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseClick);
            this.playListPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseDown);
            this.playListPicture.MouseEnter += new System.EventHandler(this.playListPicture_MouseEnter);
            this.playListPicture.MouseLeave += new System.EventHandler(this.playListPicture_MouseLeave);
            this.playListPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseUp);
            // 
            // totalSongsLabel
            // 
            this.totalSongsLabel.AutoSize = true;
            this.totalSongsLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalSongsLabel.Font = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSongsLabel.ForeColor = System.Drawing.Color.White;
            this.totalSongsLabel.Location = new System.Drawing.Point(11, 61);
            this.totalSongsLabel.Name = "totalSongsLabel";
            this.totalSongsLabel.Size = new System.Drawing.Size(75, 18);
            this.totalSongsLabel.TabIndex = 3;
            this.totalSongsLabel.Text = "Total Songs";
            this.totalSongsLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseClick);
            this.totalSongsLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseDown);
            this.totalSongsLabel.MouseEnter += new System.EventHandler(this.playListPicture_MouseEnter);
            this.totalSongsLabel.MouseLeave += new System.EventHandler(this.playListPicture_MouseLeave);
            this.totalSongsLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseUp);
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalTimeLabel.Font = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeLabel.ForeColor = System.Drawing.Color.White;
            this.totalTimeLabel.Location = new System.Drawing.Point(11, 85);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(67, 18);
            this.totalTimeLabel.TabIndex = 4;
            this.totalTimeLabel.Text = "Total Time";
            this.totalTimeLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseClick);
            this.totalTimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseDown);
            this.totalTimeLabel.MouseEnter += new System.EventHandler(this.playListPicture_MouseEnter);
            this.totalTimeLabel.MouseLeave += new System.EventHandler(this.playListPicture_MouseLeave);
            this.totalTimeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MMDPlayer.Properties.Resources._976562;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalSongsLabel);
            this.panel1.Controls.Add(this.totalTimeLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.playListLabel);
            this.panel1.Location = new System.Drawing.Point(9, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 114);
            this.panel1.TabIndex = 7;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseDown);
            this.panel1.MouseEnter += new System.EventHandler(this.playListPicture_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.playListPicture_MouseLeave);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseUp);
            // 
            // PlayListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playListPicture);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(30, 30, 3, 3);
            this.Name = "PlayListView";
            this.Size = new System.Drawing.Size(206, 247);
            this.Load += new System.EventHandler(this.PlayListView_Load);
            this.VisibleChanged += new System.EventHandler(this.PlayListView_VisibleChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseDown);
            this.MouseEnter += new System.EventHandler(this.playListPicture_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.playListPicture_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playListPicture_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.playListPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playListPicture;
        private System.Windows.Forms.Label playListLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalSongsLabel;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

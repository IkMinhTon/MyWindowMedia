
using System.Windows.Forms;

namespace MMDPlayer.GUI
{
    partial class SongList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playListName = new System.Windows.Forms.Label();
            this.listSongs = new System.Windows.Forms.Panel();
            this.songNumberLabel = new System.Windows.Forms.Label();
            this.totalTimeRunLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playListPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addButt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteAllButt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playListPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // playListName
            // 
            this.playListName.AutoSize = true;
            this.playListName.Font = new System.Drawing.Font("VNI-Fato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playListName.ForeColor = System.Drawing.Color.White;
            this.playListName.Location = new System.Drawing.Point(251, 29);
            this.playListName.Name = "playListName";
            this.playListName.Size = new System.Drawing.Size(123, 39);
            this.playListName.TabIndex = 0;
            this.playListName.Text = "Playlist";
            this.playListName.Click += new System.EventHandler(this.playListName_Click);
            // 
            // listSongs
            // 
            this.listSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSongs.AutoScroll = true;
            this.listSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.listSongs.Location = new System.Drawing.Point(0, 197);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(830, 363);
            this.listSongs.TabIndex = 1;
            this.listSongs.ClientSizeChanged += new System.EventHandler(this.listSongs_ClientSizeChanged);
            this.listSongs.Paint += new System.Windows.Forms.PaintEventHandler(this.listSongs_Paint);
            // 
            // songNumberLabel
            // 
            this.songNumberLabel.AutoSize = true;
            this.songNumberLabel.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songNumberLabel.ForeColor = System.Drawing.Color.White;
            this.songNumberLabel.Location = new System.Drawing.Point(266, 77);
            this.songNumberLabel.Name = "songNumberLabel";
            this.songNumberLabel.Size = new System.Drawing.Size(49, 23);
            this.songNumberLabel.TabIndex = 3;
            this.songNumberLabel.Text = "songs";
            // 
            // totalTimeRunLabel
            // 
            this.totalTimeRunLabel.AutoSize = true;
            this.totalTimeRunLabel.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeRunLabel.ForeColor = System.Drawing.Color.White;
            this.totalTimeRunLabel.Location = new System.Drawing.Point(266, 115);
            this.totalTimeRunLabel.Name = "totalTimeRunLabel";
            this.totalTimeRunLabel.Size = new System.Drawing.Size(80, 23);
            this.totalTimeRunLabel.TabIndex = 4;
            this.totalTimeRunLabel.Text = "total time";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.playListPicture);
            this.panel1.Controls.Add(this.totalTimeRunLabel);
            this.panel1.Controls.Add(this.playListName);
            this.panel1.Controls.Add(this.songNumberLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 198);
            this.panel1.TabIndex = 5;
            // 
            // playListPicture
            // 
            this.playListPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playListPicture.Image = global::MMDPlayer.Properties.Resources.video_marketing;
            this.playListPicture.Location = new System.Drawing.Point(53, 39);
            this.playListPicture.Name = "playListPicture";
            this.playListPicture.Size = new System.Drawing.Size(169, 132);
            this.playListPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playListPicture.TabIndex = 2;
            this.playListPicture.TabStop = false;
            this.playListPicture.Click += new System.EventHandler(this.playListPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MMDPlayer.Properties.Resources._976562;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(44, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.saveButt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addButt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.deleteAllButt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 45);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("VNI-Fato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(361, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(166, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Save Media";
            // 
            // saveButt
            // 
            this.saveButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.saveButt.BackgroundImage = global::MMDPlayer.Properties.Resources.save_white;
            this.saveButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButt.FlatAppearance.BorderSize = 0;
            this.saveButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButt.Location = new System.Drawing.Point(293, 1);
            this.saveButt.Name = "saveButt";
            this.saveButt.Size = new System.Drawing.Size(62, 42);
            this.saveButt.TabIndex = 4;
            this.saveButt.UseVisualStyleBackColor = true;
            this.saveButt.Click += new System.EventHandler(this.saveButt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("VNI-Fato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(62, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(156, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add Media";
            // 
            // addButt
            // 
            this.addButt.BackgroundImage = global::MMDPlayer.Properties.Resources.more_white;
            this.addButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButt.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButt.FlatAppearance.BorderSize = 0;
            this.addButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButt.Location = new System.Drawing.Point(0, 0);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(62, 45);
            this.addButt.TabIndex = 2;
            this.addButt.UseVisualStyleBackColor = true;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("VNI-Fato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(611, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(157, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delete All";
            // 
            // deleteAllButt
            // 
            this.deleteAllButt.BackgroundImage = global::MMDPlayer.Properties.Resources.delete;
            this.deleteAllButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteAllButt.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteAllButt.FlatAppearance.BorderSize = 0;
            this.deleteAllButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAllButt.Location = new System.Drawing.Point(768, 0);
            this.deleteAllButt.Name = "deleteAllButt";
            this.deleteAllButt.Size = new System.Drawing.Size(62, 45);
            this.deleteAllButt.TabIndex = 0;
            this.deleteAllButt.UseVisualStyleBackColor = true;
            this.deleteAllButt.Click += new System.EventHandler(this.deleteAllButt_Click);
            // 
            // SongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(830, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listSongs);
            this.Name = "SongList";
            this.Text = "Songs List";
            this.Load += new System.EventHandler(this.SongList_Load);
            this.VisibleChanged += new System.EventHandler(this.SongList_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playListPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label playListName;
        private System.Windows.Forms.Panel listSongs;
        private System.Windows.Forms.Label songNumberLabel;
        private System.Windows.Forms.Label totalTimeRunLabel;
        private System.Windows.Forms.Panel panel1;
        private Panel panel2;
        private Button deleteAllButt;
        private Label label2;
        private Label label3;
        private Button addButt;
        private Label label4;
        private Button saveButt;
        private PictureBox pictureBox1;
        private PictureBox playListPicture;
    }
}
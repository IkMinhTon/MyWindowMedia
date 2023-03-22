
namespace MMDPlayer.GUI
{
    partial class PlayListDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.saveButt = new System.Windows.Forms.Button();
            this.playListNameBox = new System.Windows.Forms.TextBox();
            this.choosePicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.songNumberLabel = new System.Windows.Forms.Label();
            this.totalTimeRunLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.choosePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "PlayList Details";
            // 
            // saveButt
            // 
            this.saveButt.BackColor = System.Drawing.Color.Transparent;
            this.saveButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButt.FlatAppearance.BorderSize = 2;
            this.saveButt.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButt.ForeColor = System.Drawing.Color.Black;
            this.saveButt.Location = new System.Drawing.Point(483, 269);
            this.saveButt.Name = "saveButt";
            this.saveButt.Size = new System.Drawing.Size(75, 33);
            this.saveButt.TabIndex = 3;
            this.saveButt.Text = "Save";
            this.saveButt.UseVisualStyleBackColor = false;
            this.saveButt.Click += new System.EventHandler(this.saveButt_Click);
            // 
            // playListNameBox
            // 
            this.playListNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.playListNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playListNameBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playListNameBox.ForeColor = System.Drawing.Color.White;
            this.playListNameBox.Location = new System.Drawing.Point(257, 60);
            this.playListNameBox.MaxLength = 12;
            this.playListNameBox.Name = "playListNameBox";
            this.playListNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playListNameBox.Size = new System.Drawing.Size(277, 33);
            this.playListNameBox.TabIndex = 4;
            // 
            // choosePicture
            // 
            this.choosePicture.BackgroundImage = global::MMDPlayer.Properties.Resources.video_marketing;
            this.choosePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.choosePicture.Location = new System.Drawing.Point(44, 71);
            this.choosePicture.Name = "choosePicture";
            this.choosePicture.Size = new System.Drawing.Size(188, 182);
            this.choosePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.choosePicture.TabIndex = 1;
            this.choosePicture.TabStop = false;
            this.choosePicture.Click += new System.EventHandler(this.choosePicture_Click);
            this.choosePicture.MouseEnter += new System.EventHandler(this.choosePicture_MouseEnter);
            this.choosePicture.MouseLeave += new System.EventHandler(this.choosePicture_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MMDPlayer.Properties.Resources._976562;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(35, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // songNumberLabel
            // 
            this.songNumberLabel.AutoSize = true;
            this.songNumberLabel.Font = new System.Drawing.Font("Sitka Subheading", 12F);
            this.songNumberLabel.ForeColor = System.Drawing.Color.White;
            this.songNumberLabel.Location = new System.Drawing.Point(253, 118);
            this.songNumberLabel.Name = "songNumberLabel";
            this.songNumberLabel.Size = new System.Drawing.Size(49, 23);
            this.songNumberLabel.TabIndex = 7;
            this.songNumberLabel.Text = "songs";
            // 
            // totalTimeRunLabel
            // 
            this.totalTimeRunLabel.AutoSize = true;
            this.totalTimeRunLabel.Font = new System.Drawing.Font("Sitka Subheading", 12F);
            this.totalTimeRunLabel.ForeColor = System.Drawing.Color.White;
            this.totalTimeRunLabel.Location = new System.Drawing.Point(253, 165);
            this.totalTimeRunLabel.Name = "totalTimeRunLabel";
            this.totalTimeRunLabel.Size = new System.Drawing.Size(80, 23);
            this.totalTimeRunLabel.TabIndex = 8;
            this.totalTimeRunLabel.Text = "total time";
            // 
            // PlayListDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(570, 314);
            this.Controls.Add(this.totalTimeRunLabel);
            this.Controls.Add(this.songNumberLabel);
            this.Controls.Add(this.playListNameBox);
            this.Controls.Add(this.saveButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choosePicture);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(586, 353);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(586, 353);
            this.Name = "PlayListDetails";
            this.Text = "PlayList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayListDetails_FormClosing);
            this.Load += new System.EventHandler(this.PlayListDetails_Load);
            this.MouseEnter += new System.EventHandler(this.PlayListDetails_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.choosePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox choosePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButt;
        private System.Windows.Forms.TextBox playListNameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label songNumberLabel;
        private System.Windows.Forms.Label totalTimeRunLabel;
    }
}
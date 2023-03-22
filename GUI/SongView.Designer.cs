
using System;
using System.Windows.Forms;

namespace MMDPlayer.GUI
{
    partial class SongView
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
            this.deleteButt = new System.Windows.Forms.Button();
            this.songPicture = new System.Windows.Forms.Button();
            this.songAuthor = new System.Windows.Forms.TextBox();
            this.songTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteButt
            // 
            this.deleteButt.BackgroundImage = global::MMDPlayer.Properties.Resources.delete;
            this.deleteButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButt.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteButt.FlatAppearance.BorderSize = 0;
            this.deleteButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButt.Location = new System.Drawing.Point(989, 0);
            this.deleteButt.Name = "deleteButt";
            this.deleteButt.Size = new System.Drawing.Size(68, 47);
            this.deleteButt.TabIndex = 2;
            this.deleteButt.UseVisualStyleBackColor = true;
            this.deleteButt.Click += new System.EventHandler(this.deleteClick);
            // 
            // songPicture
            // 
            this.songPicture.BackgroundImage = global::MMDPlayer.Properties.Resources.mp4;
            this.songPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.songPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.songPicture.FlatAppearance.BorderSize = 0;
            this.songPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songPicture.Location = new System.Drawing.Point(0, 0);
            this.songPicture.Name = "songPicture";
            this.songPicture.Size = new System.Drawing.Size(68, 47);
            this.songPicture.TabIndex = 3;
            this.songPicture.UseVisualStyleBackColor = true;
            this.songPicture.Click += new System.EventHandler(this.songClick);
            // 
            // songAuthor
            // 
            this.songAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.songAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.songAuthor.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F);
            this.songAuthor.ForeColor = System.Drawing.Color.White;
            this.songAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songAuthor.Location = new System.Drawing.Point(68, 29);
            this.songAuthor.MaxLength = 100;
            this.songAuthor.Name = "songAuthor";
            this.songAuthor.ReadOnly = true;
            this.songAuthor.Size = new System.Drawing.Size(921, 17);
            this.songAuthor.TabIndex = 8;
            this.songAuthor.Text = "Author";
            this.songAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.songAuthor.VisibleChanged += new System.EventHandler(this.songAuthor_VisibleChanged);
            this.songAuthor.DoubleClick += new System.EventHandler(this.songTitle_DoubleClick);
            this.songAuthor.MouseEnter += new System.EventHandler(this.songTitle_MouseEnter);
            this.songAuthor.MouseLeave += new System.EventHandler(this.songTitle_MouseLeave);
            // 
            // songTitle
            // 
            this.songTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.songTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.songTitle.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.songTitle.ForeColor = System.Drawing.Color.White;
            this.songTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songTitle.Location = new System.Drawing.Point(68, 0);
            this.songTitle.MaxLength = 100;
            this.songTitle.Multiline = true;
            this.songTitle.Name = "songTitle";
            this.songTitle.ReadOnly = true;
            this.songTitle.ShortcutsEnabled = false;
            this.songTitle.Size = new System.Drawing.Size(921, 29);
            this.songTitle.TabIndex = 7;
            this.songTitle.Text = "Song Title";
            this.songTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.songTitle.DoubleClick += new System.EventHandler(this.songTitle_DoubleClick);
            this.songTitle.MouseEnter += new System.EventHandler(this.songTitle_MouseEnter);
            this.songTitle.MouseLeave += new System.EventHandler(this.songTitle_MouseLeave);
            // 
            // SongView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.songAuthor);
            this.Controls.Add(this.songTitle);
            this.Controls.Add(this.deleteButt);
            this.Controls.Add(this.songPicture);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "SongView";
            this.Size = new System.Drawing.Size(1057, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button songPicture;
        private Button deleteButt;
        #endregion

        private TextBox songAuthor;
        private TextBox songTitle;
    }
}

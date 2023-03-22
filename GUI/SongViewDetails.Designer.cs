
namespace MMDPlayer.GUI
{
    partial class SongViewDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongViewDetails));
            this.songTitle = new System.Windows.Forms.TextBox();
            this.songAuthor = new System.Windows.Forms.TextBox();
            this.songPath = new System.Windows.Forms.TextBox();
            this.choosePath = new System.Windows.Forms.Button();
            this.saveButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // songTitle
            // 
            this.songTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.songTitle.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.songTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.songTitle.Location = new System.Drawing.Point(27, 122);
            this.songTitle.MaxLength = 50;
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(327, 33);
            this.songTitle.TabIndex = 0;
            // 
            // songAuthor
            // 
            this.songAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.songAuthor.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.songAuthor.ForeColor = System.Drawing.Color.DarkGray;
            this.songAuthor.Location = new System.Drawing.Point(27, 208);
            this.songAuthor.MaxLength = 20;
            this.songAuthor.Name = "songAuthor";
            this.songAuthor.Size = new System.Drawing.Size(327, 33);
            this.songAuthor.TabIndex = 1;
            // 
            // songPath
            // 
            this.songPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.songPath.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.songPath.ForeColor = System.Drawing.Color.DarkGray;
            this.songPath.Location = new System.Drawing.Point(27, 48);
            this.songPath.Name = "songPath";
            this.songPath.ReadOnly = true;
            this.songPath.Size = new System.Drawing.Size(327, 33);
            this.songPath.TabIndex = 2;
            // 
            // choosePath
            // 
            this.choosePath.BackColor = System.Drawing.Color.Transparent;
            this.choosePath.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePath.ForeColor = System.Drawing.Color.Black;
            this.choosePath.Location = new System.Drawing.Point(372, 48);
            this.choosePath.Name = "choosePath";
            this.choosePath.Size = new System.Drawing.Size(102, 33);
            this.choosePath.TabIndex = 3;
            this.choosePath.Text = "Choose Path";
            this.choosePath.UseVisualStyleBackColor = false;
            this.choosePath.Click += new System.EventHandler(this.choosePath_Click);
            // 
            // saveButt
            // 
            this.saveButt.BackColor = System.Drawing.Color.Transparent;
            this.saveButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButt.FlatAppearance.BorderSize = 2;
            this.saveButt.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButt.ForeColor = System.Drawing.Color.Black;
            this.saveButt.Location = new System.Drawing.Point(399, 238);
            this.saveButt.Name = "saveButt";
            this.saveButt.Size = new System.Drawing.Size(75, 33);
            this.saveButt.TabIndex = 4;
            this.saveButt.Text = "Save";
            this.saveButt.UseVisualStyleBackColor = false;
            this.saveButt.Click += new System.EventHandler(this.saveButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "File Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Song Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author";
            // 
            // SongViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(486, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButt);
            this.Controls.Add(this.choosePath);
            this.Controls.Add(this.songPath);
            this.Controls.Add(this.songAuthor);
            this.Controls.Add(this.songTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(502, 322);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(502, 322);
            this.Name = "SongViewDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Song Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SongViewDetails_FormClosing);
            this.Load += new System.EventHandler(this.SongViewDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox songTitle;
        private System.Windows.Forms.TextBox songAuthor;
        private System.Windows.Forms.TextBox songPath;
        private System.Windows.Forms.Button choosePath;
        private System.Windows.Forms.Button saveButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
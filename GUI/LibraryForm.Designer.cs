
namespace MMDPlayer.GUI
{
    partial class LibraryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addListButt = new System.Windows.Forms.Button();
            this.searchBox = new RJCodeAdvance.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelShowList = new System.Windows.Forms.Panel();
            this.playListShowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.addListButt);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 0;
            // 
            // addListButt
            // 
            this.addListButt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addListButt.BackgroundImage = global::MMDPlayer.Properties.Resources.list_text_FFD5;
            this.addListButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addListButt.FlatAppearance.BorderSize = 0;
            this.addListButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addListButt.Location = new System.Drawing.Point(12, 13);
            this.addListButt.Name = "addListButt";
            this.addListButt.Size = new System.Drawing.Size(44, 33);
            this.addListButt.TabIndex = 2;
            this.addListButt.UseVisualStyleBackColor = true;
            this.addListButt.Click += new System.EventHandler(this.addListButt_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.searchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(169)))), ((int)(((byte)(205)))));
            this.searchBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchBox.BorderRadius = 0;
            this.searchBox.BorderSize = 2;
            this.searchBox.Controls.Add(this.pictureBox1);
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchBox.Location = new System.Drawing.Point(557, 13);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            this.searchBox.Padding = new System.Windows.Forms.Padding(6, 7, 10, 7);
            this.searchBox.PasswordChar = false;
            this.searchBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchBox.PlaceholderText = "Search";
            this.searchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBox.Size = new System.Drawing.Size(230, 33);
            this.searchBox.TabIndex = 1;
            this.searchBox.Texts = "";
            this.searchBox.UnderlinedStyle = false;
            this.searchBox._TextChanged += new System.EventHandler(this.searchBox__TextChanged);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pictureBox1.BackgroundImage = global::MMDPlayer.Properties.Resources.search_white;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 19);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Fato", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PlayLists";
            // 
            // panelShowList
            // 
            this.panelShowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowList.Location = new System.Drawing.Point(0, 60);
            this.panelShowList.Name = "panelShowList";
            this.panelShowList.Size = new System.Drawing.Size(800, 390);
            this.panelShowList.TabIndex = 1;
            // 
            // playListShowPanel
            // 
            this.playListShowPanel.AutoScroll = true;
            this.playListShowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.playListShowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playListShowPanel.Location = new System.Drawing.Point(0, 60);
            this.playListShowPanel.Name = "playListShowPanel";
            this.playListShowPanel.Size = new System.Drawing.Size(800, 390);
            this.playListShowPanel.TabIndex = 1;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playListShowPanel);
            this.Controls.Add(this.panel1);
            this.Name = "LibraryForm";
            this.Text = "LibraryForm";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.VisibleChanged += new System.EventHandler(this.LibraryForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelShowList;
        private System.Windows.Forms.FlowLayoutPanel playListShowPanel;
        private RJCodeAdvance.RJControls.RJTextBox searchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addListButt;
    }
}
namespace YouTube_Downloader_PI
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.comboBoxQuality = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDowload = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnClipBoardPaste = new System.Windows.Forms.Button();
            this.linkLabelProgressBar = new System.Windows.Forms.LinkLabel();
            this.linkLabelBrowseLocation = new System.Windows.Forms.LinkLabel();
            this.linkLabelVideoQuality = new System.Windows.Forms.LinkLabel();
            this.linkLabelHelpUrl = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 98);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 124);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Brown;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(229, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Copyright © 2018 Placide IRANDORA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Brown;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(239, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "e-Mail: placideirandora@gmail.com";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Brown;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(250, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Developer: Placide IRANDORA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(261, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "YouTube Downloader PI 1.0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Brown;
            this.pictureBox2.Location = new System.Drawing.Point(218, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 88);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxUrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUrl.ForeColor = System.Drawing.Color.Black;
            this.textBoxUrl.Location = new System.Drawing.Point(134, 27);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(457, 23);
            this.textBoxUrl.TabIndex = 0;
            // 
            // comboBoxQuality
            // 
            this.comboBoxQuality.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxQuality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxQuality.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQuality.ForeColor = System.Drawing.Color.Black;
            this.comboBoxQuality.FormattingEnabled = true;
            this.comboBoxQuality.Items.AddRange(new object[] {
            "240",
            "360 ",
            "480 ",
            "720",
            "1080 "});
            this.comboBoxQuality.Location = new System.Drawing.Point(134, 79);
            this.comboBoxQuality.Name = "comboBoxQuality";
            this.comboBoxQuality.Size = new System.Drawing.Size(82, 24);
            this.comboBoxQuality.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Video Url:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Video Quality:";
            // 
            // btnDowload
            // 
            this.btnDowload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDowload.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDowload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnDowload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnDowload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDowload.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDowload.ForeColor = System.Drawing.Color.Black;
            this.btnDowload.Location = new System.Drawing.Point(326, 218);
            this.btnDowload.Name = "btnDowload";
            this.btnDowload.Size = new System.Drawing.Size(90, 32);
            this.btnDowload.TabIndex = 4;
            this.btnDowload.Text = "&Download";
            this.btnDowload.UseVisualStyleBackColor = true;
            this.btnDowload.Click += new System.EventHandler(this.btnDowload_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressBar.Location = new System.Drawing.Point(134, 171);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(457, 32);
            this.progressBar.TabIndex = 5;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.Color.Black;
            this.lblPercentage.Location = new System.Drawing.Point(605, 181);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(34, 16);
            this.lblPercentage.TabIndex = 6;
            this.lblPercentage.Text = "0%";
            this.lblPercentage.Click += new System.EventHandler(this.lblPercentage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Save To:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxPath.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPath.ForeColor = System.Drawing.Color.Black;
            this.textBoxPath.Location = new System.Drawing.Point(134, 124);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(457, 23);
            this.textBoxPath.TabIndex = 8;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(599, 122);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 25);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Progress:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btnClipBoardPaste);
            this.panel2.Controls.Add(this.linkLabelProgressBar);
            this.panel2.Controls.Add(this.linkLabelBrowseLocation);
            this.panel2.Controls.Add(this.linkLabelVideoQuality);
            this.panel2.Controls.Add(this.linkLabelHelpUrl);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Controls.Add(this.textBoxPath);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblPercentage);
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Controls.Add(this.btnDowload);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxQuality);
            this.panel2.Controls.Add(this.textBoxUrl);
            this.panel2.Location = new System.Drawing.Point(12, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 274);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Brown;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(134, -81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(469, 66);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnClipBoardPaste
            // 
            this.btnClipBoardPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClipBoardPaste.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClipBoardPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnClipBoardPaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnClipBoardPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClipBoardPaste.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClipBoardPaste.ForeColor = System.Drawing.Color.Black;
            this.btnClipBoardPaste.Location = new System.Drawing.Point(599, 26);
            this.btnClipBoardPaste.Name = "btnClipBoardPaste";
            this.btnClipBoardPaste.Size = new System.Drawing.Size(79, 25);
            this.btnClipBoardPaste.TabIndex = 15;
            this.btnClipBoardPaste.Text = "&Paste Video URL";
            this.btnClipBoardPaste.UseVisualStyleBackColor = true;
            this.btnClipBoardPaste.Click += new System.EventHandler(this.btnClipBoardPaste_Click_1);
            // 
            // linkLabelProgressBar
            // 
            this.linkLabelProgressBar.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelProgressBar.AutoSize = true;
            this.linkLabelProgressBar.BackColor = System.Drawing.Color.Gray;
            this.linkLabelProgressBar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelProgressBar.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelProgressBar.LinkColor = System.Drawing.Color.Silver;
            this.linkLabelProgressBar.Location = new System.Drawing.Point(684, 181);
            this.linkLabelProgressBar.Name = "linkLabelProgressBar";
            this.linkLabelProgressBar.Size = new System.Drawing.Size(43, 16);
            this.linkLabelProgressBar.TabIndex = 14;
            this.linkLabelProgressBar.TabStop = true;
            this.linkLabelProgressBar.Text = "Help?";
            this.linkLabelProgressBar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelProgressBar_LinkClicked_1);
            // 
            // linkLabelBrowseLocation
            // 
            this.linkLabelBrowseLocation.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelBrowseLocation.AutoSize = true;
            this.linkLabelBrowseLocation.BackColor = System.Drawing.Color.Gray;
            this.linkLabelBrowseLocation.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBrowseLocation.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelBrowseLocation.LinkColor = System.Drawing.Color.Silver;
            this.linkLabelBrowseLocation.Location = new System.Drawing.Point(684, 126);
            this.linkLabelBrowseLocation.Name = "linkLabelBrowseLocation";
            this.linkLabelBrowseLocation.Size = new System.Drawing.Size(43, 16);
            this.linkLabelBrowseLocation.TabIndex = 13;
            this.linkLabelBrowseLocation.TabStop = true;
            this.linkLabelBrowseLocation.Text = "Help?";
            this.linkLabelBrowseLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBrowseLocation_LinkClicked);
            // 
            // linkLabelVideoQuality
            // 
            this.linkLabelVideoQuality.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelVideoQuality.AutoSize = true;
            this.linkLabelVideoQuality.BackColor = System.Drawing.Color.Gray;
            this.linkLabelVideoQuality.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelVideoQuality.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelVideoQuality.LinkColor = System.Drawing.Color.Silver;
            this.linkLabelVideoQuality.Location = new System.Drawing.Point(222, 82);
            this.linkLabelVideoQuality.Name = "linkLabelVideoQuality";
            this.linkLabelVideoQuality.Size = new System.Drawing.Size(43, 16);
            this.linkLabelVideoQuality.TabIndex = 12;
            this.linkLabelVideoQuality.TabStop = true;
            this.linkLabelVideoQuality.Text = "Help?";
            this.linkLabelVideoQuality.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVideoQuality_LinkClicked);
            // 
            // linkLabelHelpUrl
            // 
            this.linkLabelHelpUrl.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelHelpUrl.AutoSize = true;
            this.linkLabelHelpUrl.BackColor = System.Drawing.Color.Gray;
            this.linkLabelHelpUrl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHelpUrl.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelHelpUrl.LinkColor = System.Drawing.Color.Silver;
            this.linkLabelHelpUrl.Location = new System.Drawing.Point(684, 30);
            this.linkLabelHelpUrl.Name = "linkLabelHelpUrl";
            this.linkLabelHelpUrl.Size = new System.Drawing.Size(43, 16);
            this.linkLabelHelpUrl.TabIndex = 11;
            this.linkLabelHelpUrl.TabStop = true;
            this.linkLabelHelpUrl.Text = "Help?";
            this.linkLabelHelpUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelpUrl_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Brown;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(770, 543);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Downloader PI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.ComboBox comboBoxQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDowload;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabelHelpUrl;
        private System.Windows.Forms.LinkLabel linkLabelVideoQuality;
        private System.Windows.Forms.LinkLabel linkLabelBrowseLocation;
        private System.Windows.Forms.LinkLabel linkLabelProgressBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClipBoardPaste;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


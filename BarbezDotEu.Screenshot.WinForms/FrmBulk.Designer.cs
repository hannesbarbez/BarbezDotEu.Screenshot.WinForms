namespace ScreenshotOnePro
{
    partial class FrmBulk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBulk));
            this.tcBulk = new System.Windows.Forms.TabControl();
            this.tpUrls = new System.Windows.Forms.TabPage();
            this.lblUrls = new System.Windows.Forms.Label();
            this.tbUrls = new System.Windows.Forms.TextBox();
            this.tpAdvanced = new System.Windows.Forms.TabPage();
            this.lblAdvanced = new System.Windows.Forms.Label();
            this.tbAdvanced = new System.Windows.Forms.TextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.cbPolite = new System.Windows.Forms.CheckBox();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.llBarbezEu = new System.Windows.Forms.LinkLabel();
            this.tcBulk.SuspendLayout();
            this.tpUrls.SuspendLayout();
            this.tpAdvanced.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tcBulk
            // 
            this.tcBulk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcBulk.Controls.Add(this.tpUrls);
            this.tcBulk.Controls.Add(this.tpAdvanced);
            this.tcBulk.Controls.Add(this.tpAbout);
            this.tcBulk.Location = new System.Drawing.Point(11, 13);
            this.tcBulk.Name = "tcBulk";
            this.tcBulk.SelectedIndex = 0;
            this.tcBulk.Size = new System.Drawing.Size(1102, 372);
            this.tcBulk.TabIndex = 4;
            // 
            // tpUrls
            // 
            this.tpUrls.BackColor = System.Drawing.Color.White;
            this.tpUrls.Controls.Add(this.lblUrls);
            this.tpUrls.Controls.Add(this.tbUrls);
            this.tpUrls.Location = new System.Drawing.Point(4, 28);
            this.tpUrls.Name = "tpUrls";
            this.tpUrls.Padding = new System.Windows.Forms.Padding(3);
            this.tpUrls.Size = new System.Drawing.Size(1094, 340);
            this.tpUrls.TabIndex = 0;
            this.tpUrls.Text = "Simple Batch";
            // 
            // lblUrls
            // 
            this.lblUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUrls.AutoSize = true;
            this.lblUrls.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrls.Location = new System.Drawing.Point(6, 309);
            this.lblUrls.Name = "lblUrls";
            this.lblUrls.Size = new System.Drawing.Size(541, 19);
            this.lblUrls.TabIndex = 2;
            this.lblUrls.Text = "Use a new line for each URL. Other settings will be taken from the main window.";
            // 
            // tbUrls
            // 
            this.tbUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrls.Location = new System.Drawing.Point(6, 6);
            this.tbUrls.MaxLength = 2147483646;
            this.tbUrls.Multiline = true;
            this.tbUrls.Name = "tbUrls";
            this.tbUrls.Size = new System.Drawing.Size(1082, 300);
            this.tbUrls.TabIndex = 0;
            this.tbUrls.Text = resources.GetString("tbUrls.Text");
            // 
            // tpAdvanced
            // 
            this.tpAdvanced.Controls.Add(this.lblAdvanced);
            this.tpAdvanced.Controls.Add(this.tbAdvanced);
            this.tpAdvanced.Location = new System.Drawing.Point(4, 28);
            this.tpAdvanced.Name = "tpAdvanced";
            this.tpAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvanced.Size = new System.Drawing.Size(1094, 340);
            this.tpAdvanced.TabIndex = 2;
            this.tpAdvanced.Text = "Advanced Batch";
            this.tpAdvanced.UseVisualStyleBackColor = true;
            // 
            // lblAdvanced
            // 
            this.lblAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdvanced.AutoSize = true;
            this.lblAdvanced.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvanced.Location = new System.Drawing.Point(6, 309);
            this.lblAdvanced.Name = "lblAdvanced";
            this.lblAdvanced.Size = new System.Drawing.Size(766, 19);
            this.lblAdvanced.TabIndex = 5;
            this.lblAdvanced.Text = "Use a new line per screenshot. See www.barbez.eu, or the above examples on how to" +
    " use CLI parameter switches.";
            // 
            // tbAdvanced
            // 
            this.tbAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdvanced.Location = new System.Drawing.Point(6, 6);
            this.tbAdvanced.MaxLength = 2147483646;
            this.tbAdvanced.Multiline = true;
            this.tbAdvanced.Name = "tbAdvanced";
            this.tbAdvanced.Size = new System.Drawing.Size(1082, 300);
            this.tbAdvanced.TabIndex = 3;
            this.tbAdvanced.Text = resources.GetString("tbAdvanced.Text");
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.BackColor = System.Drawing.Color.White;
            this.pbProgress.Location = new System.Drawing.Point(-1, 429);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(1128, 10);
            this.pbProgress.TabIndex = 10;
            this.pbProgress.Visible = false;
            // 
            // cbPolite
            // 
            this.cbPolite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPolite.AutoSize = true;
            this.cbPolite.Checked = true;
            this.cbPolite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPolite.Location = new System.Drawing.Point(15, 396);
            this.cbPolite.Name = "cbPolite";
            this.cbPolite.Size = new System.Drawing.Size(689, 23);
            this.cbPolite.TabIndex = 11;
            this.cbPolite.Text = "&Pause between screenshots. This is polite, and reduces the risk of a website bla" +
    "cklisting you (recommended).";
            this.cbPolite.UseVisualStyleBackColor = true;
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdvanced.Location = new System.Drawing.Point(964, 391);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(150, 31);
            this.btnAdvanced.TabIndex = 12;
            this.btnAdvanced.Text = "Render";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.BtnAdvanced_Click);
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.tableLayoutPanel);
            this.tpAbout.Controls.Add(this.llBarbezEu);
            this.tpAbout.Location = new System.Drawing.Point(4, 28);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(1094, 340);
            this.tpAbout.TabIndex = 3;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
            this.tpAbout.Enter += new System.EventHandler(this.TpAbout_Enter);
            this.tpAbout.Leave += new System.EventHandler(this.TpAbout_Leave);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(1088, 334);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.ErrorImage = null;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.InitialImage = null;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 4);
            this.logoPictureBox.Size = new System.Drawing.Size(60, 328);
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(72, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(1013, 40);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(72, 40);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(1013, 40);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Location = new System.Drawing.Point(72, 80);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(1013, 40);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(72, 123);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(1013, 208);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // llBarbezEu
            // 
            this.llBarbezEu.AutoSize = true;
            this.llBarbezEu.Location = new System.Drawing.Point(82, 306);
            this.llBarbezEu.Name = "llBarbezEu";
            this.llBarbezEu.Size = new System.Drawing.Size(146, 19);
            this.llBarbezEu.TabIndex = 3;
            this.llBarbezEu.TabStop = true;
            this.llBarbezEu.Text = "https://www.barbez.eu";
            this.llBarbezEu.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // FrmBulk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 437);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.cbPolite);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.tcBulk);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(839, 376);
            this.Name = "FrmBulk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Screenshot One Pro - Bulk Screenshots";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBulk_FormClosing);
            this.tcBulk.ResumeLayout(false);
            this.tpUrls.ResumeLayout(false);
            this.tpUrls.PerformLayout();
            this.tpAdvanced.ResumeLayout(false);
            this.tpAdvanced.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcBulk;
        private System.Windows.Forms.TabPage tpUrls;
        private System.Windows.Forms.Label lblUrls;
        private System.Windows.Forms.TextBox tbUrls;
        private System.Windows.Forms.TabPage tpAdvanced;
        private System.Windows.Forms.Label lblAdvanced;
        private System.Windows.Forms.TextBox tbAdvanced;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.CheckBox cbPolite;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.LinkLabel llBarbezEu;
    }
}

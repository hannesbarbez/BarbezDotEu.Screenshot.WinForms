namespace ScreenshotOnePro
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnBig = new System.Windows.Forms.Button();
            this.btnBaseOnUrl = new System.Windows.Forms.Button();
            this.cbEmulateIEver = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFileReference = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWatermarkSelecter = new System.Windows.Forms.Button();
            this.lblWatermark = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnTakeAPicture = new System.Windows.Forms.Button();
            this.btnNoWatermark = new System.Windows.Forms.Button();
            this.pbWorking = new System.Windows.Forms.ProgressBar();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCopyOpenShow = new System.Windows.Forms.Button();
            this.btnShowInImageViewer = new System.Windows.Forms.Button();
            this.btnShowFileInFolder = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnPasteUrl = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnBulk = new System.Windows.Forms.Button();
            this.cbPreset = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOutputDir = new System.Windows.Forms.Button();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbOutputFileType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbResult.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBig
            // 
            this.btnBig.BackColor = System.Drawing.Color.White;
            this.btnBig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBig.Location = new System.Drawing.Point(348, 56);
            this.btnBig.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(47, 24);
            this.btnBig.TabIndex = 6;
            this.btnBig.Text = "&Huge";
            this.btnBig.UseVisualStyleBackColor = false;
            this.btnBig.Click += new System.EventHandler(this.BtnBig_Click);
            // 
            // btnBaseOnUrl
            // 
            this.btnBaseOnUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaseOnUrl.BackColor = System.Drawing.Color.White;
            this.btnBaseOnUrl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBaseOnUrl.Location = new System.Drawing.Point(724, 108);
            this.btnBaseOnUrl.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnBaseOnUrl.Name = "btnBaseOnUrl";
            this.btnBaseOnUrl.Size = new System.Drawing.Size(92, 24);
            this.btnBaseOnUrl.TabIndex = 12;
            this.btnBaseOnUrl.Text = "&Base on URL";
            this.btnBaseOnUrl.UseVisualStyleBackColor = false;
            this.btnBaseOnUrl.Click += new System.EventHandler(this.BtnBaseOnUrl_Click);
            // 
            // cbEmulateIEver
            // 
            this.cbEmulateIEver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmulateIEver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmulateIEver.BackColor = System.Drawing.Color.White;
            this.cbEmulateIEver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmulateIEver.Items.AddRange(new object[] {
            "(Latest)",
            "Edge (Pretending)",
            "11 - Quirks Mode",
            "11 - Edge Mode",
            "10 - Quirks Mode",
            "10 - Standards Mode",
            "9 - Quirks Mode",
            "9 - Standards Mode",
            "8 - Quirks Mode",
            "8 - Standards Mode",
            "7"});
            this.cbEmulateIEver.Location = new System.Drawing.Point(571, 139);
            this.cbEmulateIEver.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbEmulateIEver.MaxDropDownItems = 20;
            this.cbEmulateIEver.Name = "cbEmulateIEver";
            this.cbEmulateIEver.Size = new System.Drawing.Size(147, 21);
            this.cbEmulateIEver.TabIndex = 14;
            this.cbEmulateIEver.SelectionChangeCommitted += new System.EventHandler(this.CbEmulateIEver_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Renderer:";
            // 
            // tbFileReference
            // 
            this.tbFileReference.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileReference.Location = new System.Drawing.Point(197, 109);
            this.tbFileReference.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbFileReference.MaxLength = 100;
            this.tbFileReference.Name = "tbFileReference";
            this.tbFileReference.Size = new System.Drawing.Size(521, 22);
            this.tbFileReference.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Screenshot filename:";
            // 
            // btnWatermarkSelecter
            // 
            this.btnWatermarkSelecter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWatermarkSelecter.BackColor = System.Drawing.Color.White;
            this.btnWatermarkSelecter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWatermarkSelecter.Location = new System.Drawing.Point(52, 82);
            this.btnWatermarkSelecter.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnWatermarkSelecter.Name = "btnWatermarkSelecter";
            this.btnWatermarkSelecter.Size = new System.Drawing.Size(132, 24);
            this.btnWatermarkSelecter.TabIndex = 9;
            this.btnWatermarkSelecter.Text = "&Watermark file...";
            this.btnWatermarkSelecter.UseVisualStyleBackColor = false;
            this.btnWatermarkSelecter.Click += new System.EventHandler(this.BtnWatermarkSelecter_Click);
            // 
            // lblWatermark
            // 
            this.lblWatermark.AutoSize = true;
            this.lblWatermark.Location = new System.Drawing.Point(193, 87);
            this.lblWatermark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWatermark.Name = "lblWatermark";
            this.lblWatermark.Size = new System.Drawing.Size(0, 13);
            this.lblWatermark.TabIndex = 28;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(281, 57);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbHeight.MaxLength = 5;
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(60, 22);
            this.tbHeight.TabIndex = 5;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(197, 57);
            this.tbWidth.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbWidth.MaxLength = 4;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(60, 22);
            this.tbWidth.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Screenshot dimensions (pixels):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "&Webpage or file to screenshot:";
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(197, 31);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbUrl.MaxLength = 400;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(460, 22);
            this.tbUrl.TabIndex = 0;
            // 
            // btnTakeAPicture
            // 
            this.btnTakeAPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTakeAPicture.Location = new System.Drawing.Point(724, 30);
            this.btnTakeAPicture.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnTakeAPicture.Name = "btnTakeAPicture";
            this.btnTakeAPicture.Size = new System.Drawing.Size(92, 48);
            this.btnTakeAPicture.TabIndex = 3;
            this.btnTakeAPicture.Text = "&Generate Screenshot";
            this.btnTakeAPicture.UseVisualStyleBackColor = false;
            this.btnTakeAPicture.Click += new System.EventHandler(this.BtnTakeAPicture_Click);
            // 
            // btnNoWatermark
            // 
            this.btnNoWatermark.BackColor = System.Drawing.Color.White;
            this.btnNoWatermark.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNoWatermark.Location = new System.Drawing.Point(19, 82);
            this.btnNoWatermark.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnNoWatermark.Name = "btnNoWatermark";
            this.btnNoWatermark.Size = new System.Drawing.Size(29, 24);
            this.btnNoWatermark.TabIndex = 8;
            this.btnNoWatermark.Text = "&X";
            this.btnNoWatermark.UseVisualStyleBackColor = false;
            this.btnNoWatermark.Click += new System.EventHandler(this.BtnNoWatermark_Click);
            // 
            // pbWorking
            // 
            this.pbWorking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbWorking.Location = new System.Drawing.Point(724, 31);
            this.pbWorking.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pbWorking.Name = "pbWorking";
            this.pbWorking.Size = new System.Drawing.Size(92, 47);
            this.pbWorking.TabIndex = 37;
            // 
            // lblRate
            // 
            this.lblRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRate.AutoSize = true;
            this.lblRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.Black;
            this.lblRate.Location = new System.Drawing.Point(753, 83);
            this.lblRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(63, 12);
            this.lblRate.TabIndex = 22;
            this.lblRate.Text = "Rate the app!";
            this.lblRate.Visible = false;
            this.lblRate.Click += new System.EventHandler(this.LblRate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(577, 56);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 42);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "&Delete Image";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnCopyOpenShow
            // 
            this.btnCopyOpenShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyOpenShow.BackColor = System.Drawing.Color.White;
            this.btnCopyOpenShow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCopyOpenShow.Location = new System.Drawing.Point(437, 56);
            this.btnCopyOpenShow.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCopyOpenShow.Name = "btnCopyOpenShow";
            this.btnCopyOpenShow.Size = new System.Drawing.Size(137, 42);
            this.btnCopyOpenShow.TabIndex = 20;
            this.btnCopyOpenShow.Text = "Co&py, Open and Show Image";
            this.btnCopyOpenShow.UseVisualStyleBackColor = false;
            this.btnCopyOpenShow.Visible = false;
            this.btnCopyOpenShow.Click += new System.EventHandler(this.BtnCopyOpenShow_Click);
            // 
            // btnShowInImageViewer
            // 
            this.btnShowInImageViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowInImageViewer.BackColor = System.Drawing.Color.White;
            this.btnShowInImageViewer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowInImageViewer.Location = new System.Drawing.Point(296, 56);
            this.btnShowInImageViewer.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnShowInImageViewer.Name = "btnShowInImageViewer";
            this.btnShowInImageViewer.Size = new System.Drawing.Size(137, 42);
            this.btnShowInImageViewer.TabIndex = 19;
            this.btnShowInImageViewer.Text = "&Show in Default Viewer";
            this.btnShowInImageViewer.UseVisualStyleBackColor = false;
            this.btnShowInImageViewer.Visible = false;
            this.btnShowInImageViewer.Click += new System.EventHandler(this.BtnShowInImageViewer_Click);
            // 
            // btnShowFileInFolder
            // 
            this.btnShowFileInFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowFileInFolder.BackColor = System.Drawing.Color.White;
            this.btnShowFileInFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowFileInFolder.Location = new System.Drawing.Point(155, 56);
            this.btnShowFileInFolder.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnShowFileInFolder.Name = "btnShowFileInFolder";
            this.btnShowFileInFolder.Size = new System.Drawing.Size(137, 42);
            this.btnShowFileInFolder.TabIndex = 18;
            this.btnShowFileInFolder.Text = "&Open Containing Folder";
            this.btnShowFileInFolder.UseVisualStyleBackColor = false;
            this.btnShowFileInFolder.Visible = false;
            this.btnShowFileInFolder.Click += new System.EventHandler(this.BtnShowFileInFolder_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyToClipboard.BackColor = System.Drawing.Color.White;
            this.btnCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(14, 56);
            this.btnCopyToClipboard.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(137, 42);
            this.btnCopyToClipboard.TabIndex = 17;
            this.btnCopyToClipboard.Text = "Cop&y Path to Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = false;
            this.btnCopyToClipboard.Visible = false;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.BtnCopyToClipboard_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblResult.Location = new System.Drawing.Point(17, 30);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.MaximumSize = new System.Drawing.Size(799, 25);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Click += new System.EventHandler(this.LblResult_Click);
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.lblRate);
            this.gbResult.Controls.Add(this.btnDelete);
            this.gbResult.Controls.Add(this.lblAbout);
            this.gbResult.Controls.Add(this.btnCopyOpenShow);
            this.gbResult.Controls.Add(this.btnShowInImageViewer);
            this.gbResult.Controls.Add(this.btnShowFileInFolder);
            this.gbResult.Controls.Add(this.btnCopyToClipboard);
            this.gbResult.Controls.Add(this.lblResult);
            this.gbResult.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(13, 219);
            this.gbResult.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbResult.Size = new System.Drawing.Size(832, 106);
            this.gbResult.TabIndex = 100;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // lblAbout
            // 
            this.lblAbout.Location = new System.Drawing.Point(706, 19);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(100, 23);
            this.lblAbout.TabIndex = 3;
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.btnPasteUrl);
            this.gbSettings.Controls.Add(this.btnSelectFile);
            this.gbSettings.Controls.Add(this.btnBulk);
            this.gbSettings.Controls.Add(this.cbPreset);
            this.gbSettings.Controls.Add(this.label8);
            this.gbSettings.Controls.Add(this.btnOutputDir);
            this.gbSettings.Controls.Add(this.lblOutputDirectory);
            this.gbSettings.Controls.Add(this.label7);
            this.gbSettings.Controls.Add(this.cbOutputFileType);
            this.gbSettings.Controls.Add(this.label6);
            this.gbSettings.Controls.Add(this.btnBig);
            this.gbSettings.Controls.Add(this.btnBaseOnUrl);
            this.gbSettings.Controls.Add(this.cbEmulateIEver);
            this.gbSettings.Controls.Add(this.label5);
            this.gbSettings.Controls.Add(this.tbFileReference);
            this.gbSettings.Controls.Add(this.label4);
            this.gbSettings.Controls.Add(this.btnWatermarkSelecter);
            this.gbSettings.Controls.Add(this.lblWatermark);
            this.gbSettings.Controls.Add(this.tbHeight);
            this.gbSettings.Controls.Add(this.tbWidth);
            this.gbSettings.Controls.Add(this.label3);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Controls.Add(this.tbUrl);
            this.gbSettings.Controls.Add(this.btnTakeAPicture);
            this.gbSettings.Controls.Add(this.btnNoWatermark);
            this.gbSettings.Controls.Add(this.pbWorking);
            this.gbSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbSettings.Location = new System.Drawing.Point(13, 12);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbSettings.Size = new System.Drawing.Size(832, 202);
            this.gbSettings.TabIndex = 99;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // btnPasteUrl
            // 
            this.btnPasteUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasteUrl.BackColor = System.Drawing.Color.White;
            this.btnPasteUrl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPasteUrl.Font = new System.Drawing.Font("Wingdings", 8.25F);
            this.btnPasteUrl.Location = new System.Drawing.Point(659, 30);
            this.btnPasteUrl.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnPasteUrl.Name = "btnPasteUrl";
            this.btnPasteUrl.Size = new System.Drawing.Size(29, 24);
            this.btnPasteUrl.TabIndex = 1;
            this.btnPasteUrl.Text = "\'";
            this.btnPasteUrl.UseVisualStyleBackColor = false;
            this.btnPasteUrl.Click += new System.EventHandler(this.BtnPasteUrl_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFile.BackColor = System.Drawing.Color.White;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectFile.Font = new System.Drawing.Font("Wingdings", 8.25F);
            this.btnSelectFile.Location = new System.Drawing.Point(689, 30);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(29, 24);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "1";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // btnBulk
            // 
            this.btnBulk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBulk.BackColor = System.Drawing.Color.White;
            this.btnBulk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBulk.Location = new System.Drawing.Point(724, 81);
            this.btnBulk.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnBulk.Name = "btnBulk";
            this.btnBulk.Size = new System.Drawing.Size(92, 24);
            this.btnBulk.TabIndex = 10;
            this.btnBulk.Text = "B&ulk options...";
            this.btnBulk.UseVisualStyleBackColor = false;
            this.btnBulk.Click += new System.EventHandler(this.BtnBulk_Click);
            // 
            // cbPreset
            // 
            this.cbPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPreset.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPreset.BackColor = System.Drawing.Color.White;
            this.cbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPreset.Items.AddRange(new object[] {
            "Select...",
            "1200x30000",
            "3840x2160",
            "1366x768",
            "1920x1080",
            "1280x800",
            "320x568",
            "1440x900",
            "1280x1024",
            "320x480",
            "1600x900",
            "768x1024",
            "1024x768",
            "1680x1050",
            "360x640",
            "1920x1200",
            "720x1280",
            "480x800",
            "1360x768",
            "1280x720"});
            this.cbPreset.Location = new System.Drawing.Point(571, 57);
            this.cbPreset.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbPreset.MaxDropDownItems = 20;
            this.cbPreset.Name = "cbPreset";
            this.cbPreset.Size = new System.Drawing.Size(147, 21);
            this.cbPreset.TabIndex = 7;
            this.cbPreset.SelectionChangeCommitted += new System.EventHandler(this.CbPreset_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Preset:";
            // 
            // btnOutputDir
            // 
            this.btnOutputDir.BackColor = System.Drawing.Color.White;
            this.btnOutputDir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOutputDir.Location = new System.Drawing.Point(196, 164);
            this.btnOutputDir.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(146, 24);
            this.btnOutputDir.TabIndex = 15;
            this.btnOutputDir.Text = "&Change...";
            this.btnOutputDir.UseVisualStyleBackColor = false;
            this.btnOutputDir.Click += new System.EventHandler(this.BtnOutputDir_Click);
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.AutoSize = true;
            this.lblOutputDirectory.Location = new System.Drawing.Point(349, 170);
            this.lblOutputDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(0, 13);
            this.lblOutputDirectory.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "Render Output Directory:";
            // 
            // cbOutputFileType
            // 
            this.cbOutputFileType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOutputFileType.BackColor = System.Drawing.Color.White;
            this.cbOutputFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputFileType.Items.AddRange(new object[] {
            "PNG",
            "GIF",
            "JPEG",
            "TIFF",
            "BMP"});
            this.cbOutputFileType.Location = new System.Drawing.Point(197, 137);
            this.cbOutputFileType.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbOutputFileType.MaxDropDownItems = 20;
            this.cbOutputFileType.Name = "cbOutputFileType";
            this.cbOutputFileType.Size = new System.Drawing.Size(144, 21);
            this.cbOutputFileType.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "Screenshot File Type:";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnTakeAPicture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(858, 337);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbSettings);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MinimumSize = new System.Drawing.Size(839, 376);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBig;
        private System.Windows.Forms.Button btnBaseOnUrl;
        private System.Windows.Forms.ComboBox cbEmulateIEver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFileReference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWatermarkSelecter;
        private System.Windows.Forms.Label lblWatermark;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnTakeAPicture;
        private System.Windows.Forms.Button btnNoWatermark;
        private System.Windows.Forms.ProgressBar pbWorking;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCopyOpenShow;
        private System.Windows.Forms.Button btnShowInImageViewer;
        private System.Windows.Forms.Button btnShowFileInFolder;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.ComboBox cbOutputFileType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOutputDir;
        private System.Windows.Forms.Label lblOutputDirectory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPreset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBulk;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnPasteUrl;
    }
}


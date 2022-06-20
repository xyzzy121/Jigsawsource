namespace AddressWizard
{
    partial class FormMain
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
            this.backgroundWorkerStart = new System.ComponentModel.BackgroundWorker();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageWallet = new System.Windows.Forms.TabPage();
            this.labelChkdAddrPc = new System.Windows.Forms.Label();
            this.buttonNotEmptyAddresses = new System.Windows.Forms.Button();
            this.pictureBoxBackgroundWallet = new System.Windows.Forms.PictureBox();
            this.pictureBoxRefreshing = new System.Windows.Forms.PictureBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelBtcStored = new System.Windows.Forms.Label();
            this.tabPageAddressGenerator = new System.Windows.Forms.TabPage();
            this.pictureBoxBackgroundAddrGen = new System.Windows.Forms.PictureBox();
            this.pictureBoxAddressGenerating = new System.Windows.Forms.PictureBox();
            this.labelGenAddrCnt = new System.Windows.Forms.Label();
            this.comboBoxFileSize = new System.Windows.Forms.ComboBox();
            this.labelStatusGenAddr = new System.Windows.Forms.Label();
            this.buttonOpenAddressFolder = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.backgroundWorkerRefresh = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxBitcoinStealerDeveloperLogLink = new System.Windows.Forms.TextBox();
            this.backgroundWorkerCheckForUpdates = new System.ComponentModel.BackgroundWorker();
            this.textBoxBitcoinBlackmailerDevelopmentLogLink = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageWallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundWallet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefreshing)).BeginInit();
            this.tabPageAddressGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundAddrGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddressGenerating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorkerStart
            // 
            this.backgroundWorkerStart.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerStart_DoWork);
            this.backgroundWorkerStart.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerStart_RunWorkerCompleted);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageWallet);
            this.tabControlMain.Controls.Add(this.tabPageAddressGenerator);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(317, 327);
            this.tabControlMain.TabIndex = 6;
            // 
            // tabPageWallet
            // 
            this.tabPageWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageWallet.Controls.Add(this.labelChkdAddrPc);
            this.tabPageWallet.Controls.Add(this.buttonNotEmptyAddresses);
            this.tabPageWallet.Controls.Add(this.pictureBoxBackgroundWallet);
            this.tabPageWallet.Controls.Add(this.pictureBoxRefreshing);
            this.tabPageWallet.Controls.Add(this.buttonRefresh);
            this.tabPageWallet.Controls.Add(this.labelBtcStored);
            this.tabPageWallet.Location = new System.Drawing.Point(4, 22);
            this.tabPageWallet.Name = "tabPageWallet";
            this.tabPageWallet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWallet.Size = new System.Drawing.Size(309, 301);
            this.tabPageWallet.TabIndex = 1;
            this.tabPageWallet.Text = "Wallet";
            this.tabPageWallet.UseVisualStyleBackColor = true;
            // 
            // labelChkdAddrPc
            // 
            this.labelChkdAddrPc.AutoSize = true;
            this.labelChkdAddrPc.Location = new System.Drawing.Point(12, 231);
            this.labelChkdAddrPc.Name = "labelChkdAddrPc";
            this.labelChkdAddrPc.Size = new System.Drawing.Size(21, 13);
            this.labelChkdAddrPc.TabIndex = 7;
            this.labelChkdAddrPc.Text = "0%";
            // 
            // buttonNotEmptyAddresses
            // 
            this.buttonNotEmptyAddresses.Location = new System.Drawing.Point(12, 250);
            this.buttonNotEmptyAddresses.Name = "buttonNotEmptyAddresses";
            this.buttonNotEmptyAddresses.Size = new System.Drawing.Size(287, 38);
            this.buttonNotEmptyAddresses.TabIndex = 6;
            this.buttonNotEmptyAddresses.Text = "Check out not empty addresses!";
            this.buttonNotEmptyAddresses.UseVisualStyleBackColor = true;
            this.buttonNotEmptyAddresses.Click += new System.EventHandler(this.buttonNotEmptyAddresses_Click);
            // 
            // pictureBoxBackgroundWallet
            // 
            this.pictureBoxBackgroundWallet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBackgroundWallet.Image = global::AddressWizard.Properties.Resources.logo;
            this.pictureBoxBackgroundWallet.Location = new System.Drawing.Point(12, 37);
            this.pictureBoxBackgroundWallet.Name = "pictureBoxBackgroundWallet";
            this.pictureBoxBackgroundWallet.Size = new System.Drawing.Size(287, 187);
            this.pictureBoxBackgroundWallet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackgroundWallet.TabIndex = 5;
            this.pictureBoxBackgroundWallet.TabStop = false;
            // 
            // pictureBoxRefreshing
            // 
            this.pictureBoxRefreshing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxRefreshing.Image = global::AddressWizard.Properties.Resources.working3;
            this.pictureBoxRefreshing.Location = new System.Drawing.Point(12, 37);
            this.pictureBoxRefreshing.Name = "pictureBoxRefreshing";
            this.pictureBoxRefreshing.Size = new System.Drawing.Size(287, 181);
            this.pictureBoxRefreshing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRefreshing.TabIndex = 4;
            this.pictureBoxRefreshing.TabStop = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 8);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelBtcStored
            // 
            this.labelBtcStored.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBtcStored.AutoSize = true;
            this.labelBtcStored.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBtcStored.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBtcStored.ForeColor = System.Drawing.Color.Green;
            this.labelBtcStored.Location = new System.Drawing.Point(93, 13);
            this.labelBtcStored.Name = "labelBtcStored";
            this.labelBtcStored.Size = new System.Drawing.Size(60, 18);
            this.labelBtcStored.TabIndex = 0;
            this.labelBtcStored.Text = "50 BTC";
            this.labelBtcStored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageAddressGenerator
            // 
            this.tabPageAddressGenerator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageAddressGenerator.Controls.Add(this.pictureBoxBackgroundAddrGen);
            this.tabPageAddressGenerator.Controls.Add(this.pictureBoxAddressGenerating);
            this.tabPageAddressGenerator.Controls.Add(this.labelGenAddrCnt);
            this.tabPageAddressGenerator.Controls.Add(this.comboBoxFileSize);
            this.tabPageAddressGenerator.Controls.Add(this.labelStatusGenAddr);
            this.tabPageAddressGenerator.Controls.Add(this.buttonOpenAddressFolder);
            this.tabPageAddressGenerator.Controls.Add(this.buttonStart);
            this.tabPageAddressGenerator.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddressGenerator.Name = "tabPageAddressGenerator";
            this.tabPageAddressGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddressGenerator.Size = new System.Drawing.Size(309, 301);
            this.tabPageAddressGenerator.TabIndex = 0;
            this.tabPageAddressGenerator.Text = "AddressGenerator";
            this.tabPageAddressGenerator.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBackgroundAddrGen
            // 
            this.pictureBoxBackgroundAddrGen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBackgroundAddrGen.Image = global::AddressWizard.Properties.Resources.logo;
            this.pictureBoxBackgroundAddrGen.Location = new System.Drawing.Point(12, 37);
            this.pictureBoxBackgroundAddrGen.Name = "pictureBoxBackgroundAddrGen";
            this.pictureBoxBackgroundAddrGen.Size = new System.Drawing.Size(287, 187);
            this.pictureBoxBackgroundAddrGen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackgroundAddrGen.TabIndex = 8;
            this.pictureBoxBackgroundAddrGen.TabStop = false;
            // 
            // pictureBoxAddressGenerating
            // 
            this.pictureBoxAddressGenerating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAddressGenerating.Location = new System.Drawing.Point(12, 37);
            this.pictureBoxAddressGenerating.Name = "pictureBoxAddressGenerating";
            this.pictureBoxAddressGenerating.Size = new System.Drawing.Size(287, 187);
            this.pictureBoxAddressGenerating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddressGenerating.TabIndex = 7;
            this.pictureBoxAddressGenerating.TabStop = false;
            // 
            // labelGenAddrCnt
            // 
            this.labelGenAddrCnt.AutoSize = true;
            this.labelGenAddrCnt.Location = new System.Drawing.Point(93, 13);
            this.labelGenAddrCnt.Name = "labelGenAddrCnt";
            this.labelGenAddrCnt.Size = new System.Drawing.Size(141, 13);
            this.labelGenAddrCnt.TabIndex = 6;
            this.labelGenAddrCnt.Text = "Generated address number: ";
            // 
            // comboBoxFileSize
            // 
            this.comboBoxFileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileSize.FormattingEnabled = true;
            this.comboBoxFileSize.Location = new System.Drawing.Point(240, 10);
            this.comboBoxFileSize.Name = "comboBoxFileSize";
            this.comboBoxFileSize.Size = new System.Drawing.Size(59, 21);
            this.comboBoxFileSize.TabIndex = 5;
            this.comboBoxFileSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileSize_SelectedIndexChanged);
            // 
            // labelStatusGenAddr
            // 
            this.labelStatusGenAddr.AutoSize = true;
            this.labelStatusGenAddr.Location = new System.Drawing.Point(12, 224);
            this.labelStatusGenAddr.Name = "labelStatusGenAddr";
            this.labelStatusGenAddr.Size = new System.Drawing.Size(101, 13);
            this.labelStatusGenAddr.TabIndex = 4;
            this.labelStatusGenAddr.Text = "labelStatusGenAddr";
            // 
            // buttonOpenAddressFolder
            // 
            this.buttonOpenAddressFolder.Location = new System.Drawing.Point(12, 250);
            this.buttonOpenAddressFolder.Name = "buttonOpenAddressFolder";
            this.buttonOpenAddressFolder.Size = new System.Drawing.Size(287, 38);
            this.buttonOpenAddressFolder.TabIndex = 3;
            this.buttonOpenAddressFolder.Text = "Check out generated addresses!";
            this.buttonOpenAddressFolder.UseVisualStyleBackColor = true;
            this.buttonOpenAddressFolder.Click += new System.EventHandler(this.buttonOpenAddressFolder_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 8);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // backgroundWorkerRefresh
            // 
            this.backgroundWorkerRefresh.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRefresh_DoWork);
            this.backgroundWorkerRefresh.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerRefresh_RunWorkerCompleted);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxBitcoinStealerDeveloperLogLink);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxBitcoinBlackmailerDevelopmentLogLink);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlMain);
            this.splitContainer1.Size = new System.Drawing.Size(317, 394);
            this.splitContainer1.SplitterDistance = 63;
            this.splitContainer1.TabIndex = 7;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(0, 0);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(317, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Are you up to date?";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxBitcoinStealerDeveloperLogLink
            // 
            this.textBoxBitcoinStealerDeveloperLogLink.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxBitcoinStealerDeveloperLogLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxBitcoinStealerDeveloperLogLink.Location = new System.Drawing.Point(0, 23);
            this.textBoxBitcoinStealerDeveloperLogLink.Name = "textBoxBitcoinStealerDeveloperLogLink";
            this.textBoxBitcoinStealerDeveloperLogLink.ReadOnly = true;
            this.textBoxBitcoinStealerDeveloperLogLink.Size = new System.Drawing.Size(317, 20);
            this.textBoxBitcoinStealerDeveloperLogLink.TabIndex = 1;
            this.textBoxBitcoinStealerDeveloperLogLink.Text = "funwito6ykzrupsj.onion/bitcoin-stealer.html";
            this.textBoxBitcoinStealerDeveloperLogLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backgroundWorkerCheckForUpdates
            // 
            this.backgroundWorkerCheckForUpdates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCheckForUpdates_DoWork);
            this.backgroundWorkerCheckForUpdates.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCheckForUpdates_RunWorkerCompleted);
            // 
            // textBoxBitcoinBlackmailerDevelopmentLogLink
            // 
            this.textBoxBitcoinBlackmailerDevelopmentLogLink.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxBitcoinBlackmailerDevelopmentLogLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxBitcoinBlackmailerDevelopmentLogLink.Location = new System.Drawing.Point(0, 43);
            this.textBoxBitcoinBlackmailerDevelopmentLogLink.Name = "textBoxBitcoinBlackmailerDevelopmentLogLink";
            this.textBoxBitcoinBlackmailerDevelopmentLogLink.ReadOnly = true;
            this.textBoxBitcoinBlackmailerDevelopmentLogLink.Size = new System.Drawing.Size(317, 20);
            this.textBoxBitcoinBlackmailerDevelopmentLogLink.TabIndex = 3;
            this.textBoxBitcoinBlackmailerDevelopmentLogLink.Text = "funwito6ykzrupsj.onion/bitcoin-blackmailer.html";
            this.textBoxBitcoinBlackmailerDevelopmentLogLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 394);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddressWizard";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageWallet.ResumeLayout(false);
            this.tabPageWallet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundWallet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefreshing)).EndInit();
            this.tabPageAddressGenerator.ResumeLayout(false);
            this.tabPageAddressGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundAddrGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddressGenerating)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonOpenAddressFolder;
        private System.Windows.Forms.Label labelStatusGenAddr;
        private System.ComponentModel.BackgroundWorker backgroundWorkerStart;
        private System.Windows.Forms.ComboBox comboBoxFileSize;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageAddressGenerator;
        private System.Windows.Forms.TabPage tabPageWallet;
        private System.Windows.Forms.Label labelBtcStored;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelGenAddrCnt;
        private System.Windows.Forms.PictureBox pictureBoxAddressGenerating;
        private System.Windows.Forms.PictureBox pictureBoxRefreshing;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRefresh;
        private System.Windows.Forms.PictureBox pictureBoxBackgroundAddrGen;
        private System.Windows.Forms.PictureBox pictureBoxBackgroundWallet;
        private System.Windows.Forms.Button buttonNotEmptyAddresses;
        private System.Windows.Forms.Label labelChkdAddrPc;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxBitcoinStealerDeveloperLogLink;
        private System.Windows.Forms.Button buttonUpdate;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCheckForUpdates;
        private System.Windows.Forms.TextBox textBoxBitcoinBlackmailerDevelopmentLogLink;
    }
}


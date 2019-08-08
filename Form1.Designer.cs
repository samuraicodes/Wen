namespace Wen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.addDeleteTab = new System.Windows.Forms.TabPage();
            this.collectionCount = new System.Windows.Forms.TextBox();
            this.videosCount = new System.Windows.Forms.TextBox();
            this.linksCount = new System.Windows.Forms.TextBox();
            this.deleteGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteOthersReset = new System.Windows.Forms.Button();
            this.deleteNameBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.resetAddLink = new System.Windows.Forms.Button();
            this.linkDonePicture = new System.Windows.Forms.PictureBox();
            this.linkStatusBox = new System.Windows.Forms.TextBox();
            this.linkDescriptionBox = new System.Windows.Forms.TextBox();
            this.linkErrorPicture = new System.Windows.Forms.PictureBox();
            this.linkCategoriesBox = new System.Windows.Forms.ComboBox();
            this.linkCollectionBox = new System.Windows.Forms.ComboBox();
            this.linkUrlBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.linkNameBox = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.Label();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.addOthersReset = new System.Windows.Forms.Button();
            this.addOthersButton = new System.Windows.Forms.Button();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.deleteLink = new System.Windows.Forms.Button();
            this.resetSearchButton = new System.Windows.Forms.Button();
            this.searchCategoriesBox = new System.Windows.Forms.ComboBox();
            this.searchCollection = new System.Windows.Forms.ComboBox();
            this.openSearchButton = new System.Windows.Forms.Button();
            this.linksList = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.videosTab = new System.Windows.Forms.TabPage();
            this.videoCollection = new System.Windows.Forms.ComboBox();
            this.videoBrowser = new System.Windows.Forms.WebBrowser();
            this.videoSelectComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.addDeleteTab.SuspendLayout();
            this.deleteGroupBox.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkDonePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkErrorPicture)).BeginInit();
            this.addGroupBox.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.videosTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabs);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(544, 403);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.addDeleteTab);
            this.tabs.Controls.Add(this.searchTab);
            this.tabs.Controls.Add(this.videosTab);
            this.tabs.Location = new System.Drawing.Point(3, 3);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(536, 395);
            this.tabs.TabIndex = 2;
            // 
            // addDeleteTab
            // 
            this.addDeleteTab.Controls.Add(this.collectionCount);
            this.addDeleteTab.Controls.Add(this.videosCount);
            this.addDeleteTab.Controls.Add(this.linksCount);
            this.addDeleteTab.Controls.Add(this.deleteGroupBox);
            this.addDeleteTab.Controls.Add(this.groupBox6);
            this.addDeleteTab.Controls.Add(this.addGroupBox);
            this.addDeleteTab.Location = new System.Drawing.Point(4, 22);
            this.addDeleteTab.Name = "addDeleteTab";
            this.addDeleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.addDeleteTab.Size = new System.Drawing.Size(528, 369);
            this.addDeleteTab.TabIndex = 0;
            this.addDeleteTab.Text = "Add/Delete";
            this.addDeleteTab.UseVisualStyleBackColor = true;
            // 
            // collectionCount
            // 
            this.collectionCount.BackColor = System.Drawing.SystemColors.Window;
            this.collectionCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.collectionCount.ForeColor = System.Drawing.SystemColors.InfoText;
            this.collectionCount.Location = new System.Drawing.Point(314, 339);
            this.collectionCount.Multiline = true;
            this.collectionCount.Name = "collectionCount";
            this.collectionCount.ReadOnly = true;
            this.collectionCount.Size = new System.Drawing.Size(200, 20);
            this.collectionCount.TabIndex = 17;
            this.collectionCount.Text = "Collections: 0";
            this.collectionCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // videosCount
            // 
            this.videosCount.BackColor = System.Drawing.SystemColors.Window;
            this.videosCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.videosCount.ForeColor = System.Drawing.SystemColors.InfoText;
            this.videosCount.Location = new System.Drawing.Point(314, 313);
            this.videosCount.Multiline = true;
            this.videosCount.Name = "videosCount";
            this.videosCount.ReadOnly = true;
            this.videosCount.Size = new System.Drawing.Size(200, 20);
            this.videosCount.TabIndex = 16;
            this.videosCount.Text = "Videos: 0";
            this.videosCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linksCount
            // 
            this.linksCount.BackColor = System.Drawing.SystemColors.Window;
            this.linksCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linksCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linksCount.Location = new System.Drawing.Point(314, 287);
            this.linksCount.Multiline = true;
            this.linksCount.Name = "linksCount";
            this.linksCount.ReadOnly = true;
            this.linksCount.Size = new System.Drawing.Size(200, 20);
            this.linksCount.TabIndex = 15;
            this.linksCount.Text = "Links: 0";
            this.linksCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteGroupBox
            // 
            this.deleteGroupBox.Controls.Add(this.label2);
            this.deleteGroupBox.Controls.Add(this.deleteOthersReset);
            this.deleteGroupBox.Controls.Add(this.deleteNameBox);
            this.deleteGroupBox.Controls.Add(this.deleteButton);
            this.deleteGroupBox.Controls.Add(this.label1);
            this.deleteGroupBox.Location = new System.Drawing.Point(314, 143);
            this.deleteGroupBox.Name = "deleteGroupBox";
            this.deleteGroupBox.Size = new System.Drawing.Size(200, 127);
            this.deleteGroupBox.TabIndex = 5;
            this.deleteGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "All links in the collection will be deleted";
            // 
            // deleteOthersReset
            // 
            this.deleteOthersReset.Location = new System.Drawing.Point(7, 92);
            this.deleteOthersReset.Name = "deleteOthersReset";
            this.deleteOthersReset.Size = new System.Drawing.Size(89, 23);
            this.deleteOthersReset.TabIndex = 7;
            this.deleteOthersReset.Text = "Reset";
            this.deleteOthersReset.UseVisualStyleBackColor = true;
            this.deleteOthersReset.Click += new System.EventHandler(this.DeleteOthersReset_Click);
            // 
            // deleteNameBox
            // 
            this.deleteNameBox.FormattingEnabled = true;
            this.deleteNameBox.Location = new System.Drawing.Point(7, 59);
            this.deleteNameBox.Name = "deleteNameBox";
            this.deleteNameBox.Size = new System.Drawing.Size(187, 21);
            this.deleteNameBox.TabIndex = 5;
            this.deleteNameBox.Text = "Select Name";
            this.deleteNameBox.Leave += new System.EventHandler(this.DeleteNameBox_Leave);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(102, 92);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Collection";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.resetAddLink);
            this.groupBox6.Controls.Add(this.linkDonePicture);
            this.groupBox6.Controls.Add(this.linkStatusBox);
            this.groupBox6.Controls.Add(this.linkDescriptionBox);
            this.groupBox6.Controls.Add(this.linkErrorPicture);
            this.groupBox6.Controls.Add(this.linkCategoriesBox);
            this.groupBox6.Controls.Add(this.linkCollectionBox);
            this.groupBox6.Controls.Add(this.linkUrlBox);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.linkNameBox);
            this.groupBox6.Controls.Add(this.linkLabel);
            this.groupBox6.Location = new System.Drawing.Point(4, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(304, 353);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // resetAddLink
            // 
            this.resetAddLink.Location = new System.Drawing.Point(6, 293);
            this.resetAddLink.Name = "resetAddLink";
            this.resetAddLink.Size = new System.Drawing.Size(140, 23);
            this.resetAddLink.TabIndex = 15;
            this.resetAddLink.Text = "Reset";
            this.resetAddLink.UseVisualStyleBackColor = true;
            this.resetAddLink.Click += new System.EventHandler(this.ResetAddLink_Click);
            // 
            // linkDonePicture
            // 
            this.linkDonePicture.Image = ((System.Drawing.Image)(resources.GetObject("linkDonePicture.Image")));
            this.linkDonePicture.Location = new System.Drawing.Point(245, 324);
            this.linkDonePicture.Name = "linkDonePicture";
            this.linkDonePicture.Size = new System.Drawing.Size(51, 15);
            this.linkDonePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.linkDonePicture.TabIndex = 14;
            this.linkDonePicture.TabStop = false;
            this.linkDonePicture.Visible = false;
            // 
            // linkStatusBox
            // 
            this.linkStatusBox.BackColor = System.Drawing.SystemColors.Window;
            this.linkStatusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linkStatusBox.Location = new System.Drawing.Point(7, 325);
            this.linkStatusBox.Name = "linkStatusBox";
            this.linkStatusBox.ReadOnly = true;
            this.linkStatusBox.Size = new System.Drawing.Size(182, 13);
            this.linkStatusBox.TabIndex = 10;
            this.linkStatusBox.Text = "Status";
            this.linkStatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.linkStatusBox.Visible = false;
            // 
            // linkDescriptionBox
            // 
            this.linkDescriptionBox.Enabled = false;
            this.linkDescriptionBox.Location = new System.Drawing.Point(6, 127);
            this.linkDescriptionBox.Multiline = true;
            this.linkDescriptionBox.Name = "linkDescriptionBox";
            this.linkDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.linkDescriptionBox.Size = new System.Drawing.Size(292, 160);
            this.linkDescriptionBox.TabIndex = 7;
            this.linkDescriptionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkErrorPicture
            // 
            this.linkErrorPicture.Image = ((System.Drawing.Image)(resources.GetObject("linkErrorPicture.Image")));
            this.linkErrorPicture.Location = new System.Drawing.Point(200, 324);
            this.linkErrorPicture.Name = "linkErrorPicture";
            this.linkErrorPicture.Size = new System.Drawing.Size(57, 15);
            this.linkErrorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.linkErrorPicture.TabIndex = 13;
            this.linkErrorPicture.TabStop = false;
            this.linkErrorPicture.Visible = false;
            // 
            // linkCategoriesBox
            // 
            this.linkCategoriesBox.FormattingEnabled = true;
            this.linkCategoriesBox.Location = new System.Drawing.Point(162, 67);
            this.linkCategoriesBox.Name = "linkCategoriesBox";
            this.linkCategoriesBox.Size = new System.Drawing.Size(136, 21);
            this.linkCategoriesBox.TabIndex = 6;
            this.linkCategoriesBox.Text = "Select Categorie";
            this.linkCategoriesBox.Leave += new System.EventHandler(this.LinkCategorieBox_Leave);
            // 
            // linkCollectionBox
            // 
            this.linkCollectionBox.FormattingEnabled = true;
            this.linkCollectionBox.Location = new System.Drawing.Point(6, 67);
            this.linkCollectionBox.Name = "linkCollectionBox";
            this.linkCollectionBox.Size = new System.Drawing.Size(140, 21);
            this.linkCollectionBox.TabIndex = 5;
            this.linkCollectionBox.Text = "Select Collection";
            this.linkCollectionBox.Leave += new System.EventHandler(this.LinkCollectionBox_Leave);
            // 
            // linkUrlBox
            // 
            this.linkUrlBox.Location = new System.Drawing.Point(6, 37);
            this.linkUrlBox.Name = "linkUrlBox";
            this.linkUrlBox.Size = new System.Drawing.Size(292, 20);
            this.linkUrlBox.TabIndex = 4;
            this.linkUrlBox.Text = "URL";
            this.linkUrlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.linkUrlBox.Enter += new System.EventHandler(this.LinkUrlBox_Enter);
            this.linkUrlBox.Leave += new System.EventHandler(this.LinkUrlBox_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddLink);
            // 
            // linkNameBox
            // 
            this.linkNameBox.Enabled = false;
            this.linkNameBox.Location = new System.Drawing.Point(6, 98);
            this.linkNameBox.Name = "linkNameBox";
            this.linkNameBox.Size = new System.Drawing.Size(292, 20);
            this.linkNameBox.TabIndex = 2;
            this.linkNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(128, 16);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(49, 13);
            this.linkLabel.TabIndex = 1;
            this.linkLabel.Text = "Add Link";
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.addOthersReset);
            this.addGroupBox.Controls.Add(this.addOthersButton);
            this.addGroupBox.Controls.Add(this.addNameTextBox);
            this.addGroupBox.Controls.Add(this.addLabel);
            this.addGroupBox.Location = new System.Drawing.Point(314, 7);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(200, 135);
            this.addGroupBox.TabIndex = 0;
            this.addGroupBox.TabStop = false;
            // 
            // addOthersReset
            // 
            this.addOthersReset.Location = new System.Drawing.Point(7, 92);
            this.addOthersReset.Name = "addOthersReset";
            this.addOthersReset.Size = new System.Drawing.Size(89, 23);
            this.addOthersReset.TabIndex = 6;
            this.addOthersReset.Text = "Reset";
            this.addOthersReset.UseVisualStyleBackColor = true;
            this.addOthersReset.Click += new System.EventHandler(this.AddOthersReset_Click);
            // 
            // addOthersButton
            // 
            this.addOthersButton.Location = new System.Drawing.Point(102, 92);
            this.addOthersButton.Name = "addOthersButton";
            this.addOthersButton.Size = new System.Drawing.Size(92, 23);
            this.addOthersButton.TabIndex = 3;
            this.addOthersButton.Text = "Add";
            this.addOthersButton.UseVisualStyleBackColor = true;
            this.addOthersButton.Click += new System.EventHandler(this.AddCollection);
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(6, 52);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.addNameTextBox.TabIndex = 2;
            this.addNameTextBox.Text = "Name";
            this.addNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addNameTextBox.Enter += new System.EventHandler(this.AddNameTextBox_Enter);
            this.addNameTextBox.Leave += new System.EventHandler(this.AddNameTextBox_Leave);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(62, 18);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(75, 13);
            this.addLabel.TabIndex = 1;
            this.addLabel.Text = "Add Collection";
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.deleteLink);
            this.searchTab.Controls.Add(this.resetSearchButton);
            this.searchTab.Controls.Add(this.searchCategoriesBox);
            this.searchTab.Controls.Add(this.searchCollection);
            this.searchTab.Controls.Add(this.openSearchButton);
            this.searchTab.Controls.Add(this.linksList);
            this.searchTab.Controls.Add(this.searchButton);
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(528, 369);
            this.searchTab.TabIndex = 1;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // deleteLink
            // 
            this.deleteLink.Location = new System.Drawing.Point(397, 6);
            this.deleteLink.Name = "deleteLink";
            this.deleteLink.Size = new System.Drawing.Size(103, 23);
            this.deleteLink.TabIndex = 13;
            this.deleteLink.Text = "Delete";
            this.deleteLink.UseVisualStyleBackColor = true;
            this.deleteLink.Click += new System.EventHandler(this.DeleteLink_Click);
            // 
            // resetSearchButton
            // 
            this.resetSearchButton.Location = new System.Drawing.Point(330, 6);
            this.resetSearchButton.Name = "resetSearchButton";
            this.resetSearchButton.Size = new System.Drawing.Size(62, 23);
            this.resetSearchButton.TabIndex = 12;
            this.resetSearchButton.Text = "Reset";
            this.resetSearchButton.UseVisualStyleBackColor = true;
            this.resetSearchButton.Click += new System.EventHandler(this.ResetSortedLinks);
            // 
            // searchCategoriesBox
            // 
            this.searchCategoriesBox.FormattingEnabled = true;
            this.searchCategoriesBox.Location = new System.Drawing.Point(144, 7);
            this.searchCategoriesBox.Name = "searchCategoriesBox";
            this.searchCategoriesBox.Size = new System.Drawing.Size(108, 21);
            this.searchCategoriesBox.TabIndex = 11;
            this.searchCategoriesBox.Text = "Select Categorie";
            this.searchCategoriesBox.Leave += new System.EventHandler(this.SearchCategorieBox_Leave);
            // 
            // searchCollection
            // 
            this.searchCollection.FormattingEnabled = true;
            this.searchCollection.Location = new System.Drawing.Point(29, 7);
            this.searchCollection.Name = "searchCollection";
            this.searchCollection.Size = new System.Drawing.Size(109, 21);
            this.searchCollection.TabIndex = 10;
            this.searchCollection.Text = "Select Collection";
            this.searchCollection.Leave += new System.EventHandler(this.SearchCollection_Leave);
            // 
            // openSearchButton
            // 
            this.openSearchButton.Location = new System.Drawing.Point(201, 332);
            this.openSearchButton.Name = "openSearchButton";
            this.openSearchButton.Size = new System.Drawing.Size(135, 23);
            this.openSearchButton.TabIndex = 9;
            this.openSearchButton.Text = "Open in Webbrowser";
            this.openSearchButton.UseVisualStyleBackColor = true;
            this.openSearchButton.Click += new System.EventHandler(this.OpenLinkInBrowser);
            // 
            // linksList
            // 
            this.linksList.FormattingEnabled = true;
            this.linksList.Location = new System.Drawing.Point(6, 36);
            this.linksList.Name = "linksList";
            this.linksList.Size = new System.Drawing.Size(516, 290);
            this.linksList.TabIndex = 8;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(261, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(63, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Sort";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SortLinksBy);
            // 
            // videosTab
            // 
            this.videosTab.Controls.Add(this.videoCollection);
            this.videosTab.Controls.Add(this.videoBrowser);
            this.videosTab.Controls.Add(this.videoSelectComboBox);
            this.videosTab.Controls.Add(this.button1);
            this.videosTab.Location = new System.Drawing.Point(4, 22);
            this.videosTab.Name = "videosTab";
            this.videosTab.Padding = new System.Windows.Forms.Padding(3);
            this.videosTab.Size = new System.Drawing.Size(528, 369);
            this.videosTab.TabIndex = 2;
            this.videosTab.Text = "Videos";
            this.videosTab.UseVisualStyleBackColor = true;
            // 
            // videoCollection
            // 
            this.videoCollection.FormattingEnabled = true;
            this.videoCollection.Location = new System.Drawing.Point(6, 7);
            this.videoCollection.Name = "videoCollection";
            this.videoCollection.Size = new System.Drawing.Size(114, 21);
            this.videoCollection.TabIndex = 8;
            this.videoCollection.Text = "Select Collection";
            this.videoCollection.SelectedIndexChanged += new System.EventHandler(this.VideoCollection_SelectedIndexChanged);
            this.videoCollection.Leave += new System.EventHandler(this.VideoCollection_Leave);
            // 
            // videoBrowser
            // 
            this.videoBrowser.Location = new System.Drawing.Point(3, 40);
            this.videoBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.videoBrowser.Name = "videoBrowser";
            this.videoBrowser.Size = new System.Drawing.Size(522, 329);
            this.videoBrowser.TabIndex = 7;
            // 
            // videoSelectComboBox
            // 
            this.videoSelectComboBox.FormattingEnabled = true;
            this.videoSelectComboBox.Location = new System.Drawing.Point(126, 7);
            this.videoSelectComboBox.Name = "videoSelectComboBox";
            this.videoSelectComboBox.Size = new System.Drawing.Size(323, 21);
            this.videoSelectComboBox.TabIndex = 6;
            this.videoSelectComboBox.Text = "Select Video";
            this.videoSelectComboBox.Leave += new System.EventHandler(this.VideoSelectComboBox_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PlayVideo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 403);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Wen - Save Knowlegde";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.addDeleteTab.ResumeLayout(false);
            this.addDeleteTab.PerformLayout();
            this.deleteGroupBox.ResumeLayout(false);
            this.deleteGroupBox.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkDonePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkErrorPicture)).EndInit();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.searchTab.ResumeLayout(false);
            this.videosTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage addDeleteTab;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.TabPage videosTab;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Button addOthersButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox linkDescriptionBox;
        private System.Windows.Forms.ComboBox linkCategoriesBox;
        private System.Windows.Forms.ComboBox linkCollectionBox;
        private System.Windows.Forms.TextBox linkUrlBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox linkNameBox;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.GroupBox deleteGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deleteNameBox;
        private System.Windows.Forms.TextBox linkStatusBox;
        private System.Windows.Forms.PictureBox linkDonePicture;
        private System.Windows.Forms.PictureBox linkErrorPicture;
        private System.Windows.Forms.TextBox collectionCount;
        private System.Windows.Forms.TextBox videosCount;
        private System.Windows.Forms.TextBox linksCount;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button openSearchButton;
        private System.Windows.Forms.ListBox linksList;
        private System.Windows.Forms.ComboBox videoSelectComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser videoBrowser;
        private System.Windows.Forms.Button resetSearchButton;
        private System.Windows.Forms.ComboBox searchCategoriesBox;
        private System.Windows.Forms.ComboBox searchCollection;
        private System.Windows.Forms.ComboBox videoCollection;
        private System.Windows.Forms.Button resetAddLink;
        private System.Windows.Forms.Button deleteOthersReset;
        private System.Windows.Forms.Button addOthersReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteLink;
    }
}


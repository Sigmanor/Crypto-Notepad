﻿namespace Crypto_Notepad
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.editorFontColorLabel = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.applicationTabPage = new System.Windows.Forms.TabPage();
            this.singleInstanceCheckBox = new System.Windows.Forms.CheckBox();
            this.closeToTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.minimizeToTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.mainMenuCheckBox = new System.Windows.Forms.CheckBox();
            this.menuIconsCheckBox = new System.Windows.Forms.CheckBox();
            this.autoCheckUpdatesCheckBox = new System.Windows.Forms.CheckBox();
            this.autoLockOnMinimizeCheckBox = new System.Windows.Forms.CheckBox();
            this.editorTabPage = new System.Windows.Forms.TabPage();
            this.editorBorderLabel = new System.Windows.Forms.Label();
            this.editorBorderComboBox = new System.Windows.Forms.ComboBox();
            this.editorOpenLinksWithComboBox = new System.Windows.Forms.ComboBox();
            this.editorOpenLinksWithLabel = new System.Windows.Forms.Label();
            this.editorFontButton = new System.Windows.Forms.Button();
            this.editorPaddingLeftTextBox = new System.Windows.Forms.TextBox();
            this.editorPaddingLeftLabel = new System.Windows.Forms.Label();
            this.editorInsertKeyComboBox = new System.Windows.Forms.ComboBox();
            this.editorBackColorLabel = new System.Windows.Forms.Label();
            this.editorInsertKeyLabel = new System.Windows.Forms.Label();
            this.editorBackColor = new System.Windows.Forms.Panel();
            this.editorFontColor = new System.Windows.Forms.Panel();
            this.integrationTabPage = new System.Windows.Forms.TabPage();
            this.integrateCheckBox = new System.Windows.Forms.CheckBox();
            this.associateCheckBox = new System.Windows.Forms.CheckBox();
            this.sendToCheckBox = new System.Windows.Forms.CheckBox();
            this.encryptionTabPage = new System.Windows.Forms.TabPage();
            this.passwordIterationsTextBox = new System.Windows.Forms.TextBox();
            this.hashAlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.passwordIterationsLabel = new System.Windows.Forms.Label();
            this.keySizeLabel = new System.Windows.Forms.Label();
            this.hashAlgorithmLabel = new System.Windows.Forms.Label();
            this.keySizeComboBox = new System.Windows.Forms.ComboBox();
            this.statusPanelTabPage = new System.Windows.Forms.TabPage();
            this.statusPanelLabelsGroupBox = new System.Windows.Forms.GroupBox();
            this.statusPanelLengthCheckBox = new System.Windows.Forms.CheckBox();
            this.statusPanelSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.statusPanelLinesCheckBox = new System.Windows.Forms.CheckBox();
            this.statusPanelModifiedCheckBox = new System.Windows.Forms.CheckBox();
            this.statusPanelVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.statusPanelBackColor = new System.Windows.Forms.Panel();
            this.statusPanelFontColor = new System.Windows.Forms.Panel();
            this.statusPanelFontColorLabel = new System.Windows.Forms.Label();
            this.statusPanelBackColorLabel = new System.Windows.Forms.Label();
            this.toolbarTabPage = new System.Windows.Forms.TabPage();
            this.toolbarCloseButtonCheckBox = new System.Windows.Forms.CheckBox();
            this.toolbarOldIconsCheckBox = new System.Windows.Forms.CheckBox();
            this.toolbarBorderCheckBox = new System.Windows.Forms.CheckBox();
            this.toolbarBackColor = new System.Windows.Forms.Panel();
            this.toolbarBackColorLabel = new System.Windows.Forms.Label();
            this.toolbarVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.searchPanelTabPage = new System.Windows.Forms.TabPage();
            this.searchBorderComboBox = new System.Windows.Forms.ComboBox();
            this.searchBorderLabel = new System.Windows.Forms.Label();
            this.searchFontColor = new System.Windows.Forms.Panel();
            this.searchBackColor = new System.Windows.Forms.Panel();
            this.searchFontColorLabel = new System.Windows.Forms.Label();
            this.searchBackColorLabel = new System.Windows.Forms.Label();
            this.settingsNavigation = new System.Windows.Forms.ListBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.settingsTabControl.SuspendLayout();
            this.applicationTabPage.SuspendLayout();
            this.editorTabPage.SuspendLayout();
            this.integrationTabPage.SuspendLayout();
            this.encryptionTabPage.SuspendLayout();
            this.statusPanelTabPage.SuspendLayout();
            this.statusPanelLabelsGroupBox.SuspendLayout();
            this.toolbarTabPage.SuspendLayout();
            this.searchPanelTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // editorFontColorLabel
            // 
            this.editorFontColorLabel.Location = new System.Drawing.Point(6, 4);
            this.editorFontColorLabel.Name = "editorFontColorLabel";
            this.editorFontColorLabel.Size = new System.Drawing.Size(83, 21);
            this.editorFontColorLabel.TabIndex = 0;
            this.editorFontColorLabel.Text = "Font color";
            this.editorFontColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.applicationTabPage);
            this.settingsTabControl.Controls.Add(this.editorTabPage);
            this.settingsTabControl.Controls.Add(this.integrationTabPage);
            this.settingsTabControl.Controls.Add(this.encryptionTabPage);
            this.settingsTabControl.Controls.Add(this.statusPanelTabPage);
            this.settingsTabControl.Controls.Add(this.toolbarTabPage);
            this.settingsTabControl.Controls.Add(this.searchPanelTabPage);
            this.settingsTabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsTabControl.Location = new System.Drawing.Point(105, -2);
            this.settingsTabControl.Multiline = true;
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(252, 285);
            this.settingsTabControl.TabIndex = 4;
            this.settingsTabControl.SelectedIndexChanged += new System.EventHandler(this.SettingsTabControl_SelectedIndexChanged);
            // 
            // applicationTabPage
            // 
            this.applicationTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.applicationTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applicationTabPage.Controls.Add(this.singleInstanceCheckBox);
            this.applicationTabPage.Controls.Add(this.closeToTrayCheckBox);
            this.applicationTabPage.Controls.Add(this.minimizeToTrayCheckBox);
            this.applicationTabPage.Controls.Add(this.mainMenuCheckBox);
            this.applicationTabPage.Controls.Add(this.menuIconsCheckBox);
            this.applicationTabPage.Controls.Add(this.autoCheckUpdatesCheckBox);
            this.applicationTabPage.Controls.Add(this.autoLockOnMinimizeCheckBox);
            this.applicationTabPage.Location = new System.Drawing.Point(4, 44);
            this.applicationTabPage.Name = "applicationTabPage";
            this.applicationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.applicationTabPage.Size = new System.Drawing.Size(244, 237);
            this.applicationTabPage.TabIndex = 2;
            this.applicationTabPage.Text = "app";
            // 
            // singleInstanceCheckBox
            // 
            this.singleInstanceCheckBox.AutoSize = true;
            this.singleInstanceCheckBox.Location = new System.Drawing.Point(7, 155);
            this.singleInstanceCheckBox.Name = "singleInstanceCheckBox";
            this.singleInstanceCheckBox.Size = new System.Drawing.Size(105, 19);
            this.singleInstanceCheckBox.TabIndex = 6;
            this.singleInstanceCheckBox.Text = "Single instance";
            this.singleInstanceCheckBox.UseVisualStyleBackColor = true;
            this.singleInstanceCheckBox.Click += new System.EventHandler(this.SingleInstanceCheckBox_Click);
            // 
            // closeToTrayCheckBox
            // 
            this.closeToTrayCheckBox.AutoSize = true;
            this.closeToTrayCheckBox.Location = new System.Drawing.Point(7, 130);
            this.closeToTrayCheckBox.Name = "closeToTrayCheckBox";
            this.closeToTrayCheckBox.Size = new System.Drawing.Size(92, 19);
            this.closeToTrayCheckBox.TabIndex = 5;
            this.closeToTrayCheckBox.Text = "Close to tray";
            this.closeToTrayCheckBox.UseVisualStyleBackColor = true;
            this.closeToTrayCheckBox.Click += new System.EventHandler(this.CloseToTrayCheckBox_Click);
            // 
            // minimizeToTrayCheckBox
            // 
            this.minimizeToTrayCheckBox.AutoSize = true;
            this.minimizeToTrayCheckBox.Location = new System.Drawing.Point(7, 105);
            this.minimizeToTrayCheckBox.Name = "minimizeToTrayCheckBox";
            this.minimizeToTrayCheckBox.Size = new System.Drawing.Size(112, 19);
            this.minimizeToTrayCheckBox.TabIndex = 4;
            this.minimizeToTrayCheckBox.Text = "Minimize to tray";
            this.minimizeToTrayCheckBox.UseVisualStyleBackColor = true;
            this.minimizeToTrayCheckBox.Click += new System.EventHandler(this.MinimizeToTrayCheckBox_Click);
            // 
            // mainMenuCheckBox
            // 
            this.mainMenuCheckBox.AutoSize = true;
            this.mainMenuCheckBox.Location = new System.Drawing.Point(7, 55);
            this.mainMenuCheckBox.Name = "mainMenuCheckBox";
            this.mainMenuCheckBox.Size = new System.Drawing.Size(87, 19);
            this.mainMenuCheckBox.TabIndex = 2;
            this.mainMenuCheckBox.Text = "Main menu";
            this.mainMenuCheckBox.UseVisualStyleBackColor = true;
            this.mainMenuCheckBox.Click += new System.EventHandler(this.MainMenuCheckBox_Click);
            // 
            // menuIconsCheckBox
            // 
            this.menuIconsCheckBox.AutoSize = true;
            this.menuIconsCheckBox.Location = new System.Drawing.Point(7, 80);
            this.menuIconsCheckBox.Name = "menuIconsCheckBox";
            this.menuIconsCheckBox.Size = new System.Drawing.Size(88, 19);
            this.menuIconsCheckBox.TabIndex = 3;
            this.menuIconsCheckBox.Text = "Menu icons";
            this.menuIconsCheckBox.UseVisualStyleBackColor = true;
            this.menuIconsCheckBox.Click += new System.EventHandler(this.MenuIconsCheckBox_Click);
            // 
            // autoCheckUpdatesCheckBox
            // 
            this.autoCheckUpdatesCheckBox.AutoSize = true;
            this.autoCheckUpdatesCheckBox.Location = new System.Drawing.Point(7, 30);
            this.autoCheckUpdatesCheckBox.Name = "autoCheckUpdatesCheckBox";
            this.autoCheckUpdatesCheckBox.Size = new System.Drawing.Size(131, 19);
            this.autoCheckUpdatesCheckBox.TabIndex = 1;
            this.autoCheckUpdatesCheckBox.Text = "Auto check updates";
            this.autoCheckUpdatesCheckBox.UseVisualStyleBackColor = true;
            this.autoCheckUpdatesCheckBox.Click += new System.EventHandler(this.AutoCheckUpdatesCheckBox_Click);
            // 
            // autoLockOnMinimizeCheckBox
            // 
            this.autoLockOnMinimizeCheckBox.AutoSize = true;
            this.autoLockOnMinimizeCheckBox.Location = new System.Drawing.Point(7, 7);
            this.autoLockOnMinimizeCheckBox.Name = "autoLockOnMinimizeCheckBox";
            this.autoLockOnMinimizeCheckBox.Size = new System.Drawing.Size(146, 19);
            this.autoLockOnMinimizeCheckBox.TabIndex = 0;
            this.autoLockOnMinimizeCheckBox.Text = "Auto lock on minimize";
            this.autoLockOnMinimizeCheckBox.UseVisualStyleBackColor = true;
            this.autoLockOnMinimizeCheckBox.Click += new System.EventHandler(this.AutoLockOnMinimizeCheckBox_Click);
            // 
            // editorTabPage
            // 
            this.editorTabPage.AutoScroll = true;
            this.editorTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.editorTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editorTabPage.Controls.Add(this.editorBorderLabel);
            this.editorTabPage.Controls.Add(this.editorBorderComboBox);
            this.editorTabPage.Controls.Add(this.editorOpenLinksWithComboBox);
            this.editorTabPage.Controls.Add(this.editorOpenLinksWithLabel);
            this.editorTabPage.Controls.Add(this.editorFontButton);
            this.editorTabPage.Controls.Add(this.editorPaddingLeftTextBox);
            this.editorTabPage.Controls.Add(this.editorPaddingLeftLabel);
            this.editorTabPage.Controls.Add(this.editorInsertKeyComboBox);
            this.editorTabPage.Controls.Add(this.editorBackColorLabel);
            this.editorTabPage.Controls.Add(this.editorInsertKeyLabel);
            this.editorTabPage.Controls.Add(this.editorBackColor);
            this.editorTabPage.Controls.Add(this.editorFontColorLabel);
            this.editorTabPage.Controls.Add(this.editorFontColor);
            this.editorTabPage.Location = new System.Drawing.Point(4, 44);
            this.editorTabPage.Name = "editorTabPage";
            this.editorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.editorTabPage.Size = new System.Drawing.Size(244, 237);
            this.editorTabPage.TabIndex = 0;
            this.editorTabPage.Text = "edt";
            // 
            // editorBorderLabel
            // 
            this.editorBorderLabel.AutoSize = true;
            this.editorBorderLabel.Location = new System.Drawing.Point(6, 145);
            this.editorBorderLabel.Name = "editorBorderLabel";
            this.editorBorderLabel.Size = new System.Drawing.Size(42, 15);
            this.editorBorderLabel.TabIndex = 21;
            this.editorBorderLabel.Text = "Border";
            // 
            // editorBorderComboBox
            // 
            this.editorBorderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editorBorderComboBox.FormattingEnabled = true;
            this.editorBorderComboBox.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D"});
            this.editorBorderComboBox.Location = new System.Drawing.Point(132, 142);
            this.editorBorderComboBox.Name = "editorBorderComboBox";
            this.editorBorderComboBox.Size = new System.Drawing.Size(100, 23);
            this.editorBorderComboBox.TabIndex = 3;
            this.editorBorderComboBox.DropDownClosed += new System.EventHandler(this.EditorBorderComboBox_DropDownClosed);
            // 
            // editorOpenLinksWithComboBox
            // 
            this.editorOpenLinksWithComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editorOpenLinksWithComboBox.FormattingEnabled = true;
            this.editorOpenLinksWithComboBox.Items.AddRange(new object[] {
            "LMB Click",
            "Shift+LMB",
            "Control+LMB"});
            this.editorOpenLinksWithComboBox.Location = new System.Drawing.Point(132, 113);
            this.editorOpenLinksWithComboBox.Name = "editorOpenLinksWithComboBox";
            this.editorOpenLinksWithComboBox.Size = new System.Drawing.Size(100, 23);
            this.editorOpenLinksWithComboBox.TabIndex = 2;
            this.editorOpenLinksWithComboBox.DropDownClosed += new System.EventHandler(this.EditorOpenLinksWithComboBox_DropDownClosed);
            // 
            // editorOpenLinksWithLabel
            // 
            this.editorOpenLinksWithLabel.AutoSize = true;
            this.editorOpenLinksWithLabel.Location = new System.Drawing.Point(6, 116);
            this.editorOpenLinksWithLabel.Name = "editorOpenLinksWithLabel";
            this.editorOpenLinksWithLabel.Size = new System.Drawing.Size(89, 15);
            this.editorOpenLinksWithLabel.TabIndex = 18;
            this.editorOpenLinksWithLabel.Text = "Open links with";
            // 
            // editorFontButton
            // 
            this.editorFontButton.Location = new System.Drawing.Point(9, 171);
            this.editorFontButton.Name = "editorFontButton";
            this.editorFontButton.Size = new System.Drawing.Size(223, 23);
            this.editorFontButton.TabIndex = 4;
            this.editorFontButton.Text = "Font";
            this.editorFontButton.UseVisualStyleBackColor = true;
            this.editorFontButton.Click += new System.EventHandler(this.EditorFontButton_Click);
            // 
            // editorPaddingLeftTextBox
            // 
            this.editorPaddingLeftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editorPaddingLeftTextBox.Location = new System.Drawing.Point(132, 87);
            this.editorPaddingLeftTextBox.Name = "editorPaddingLeftTextBox";
            this.editorPaddingLeftTextBox.Size = new System.Drawing.Size(100, 20);
            this.editorPaddingLeftTextBox.TabIndex = 1;
            this.editorPaddingLeftTextBox.Click += new System.EventHandler(this.EditorPaddingLeftTextBox_Click);
            this.editorPaddingLeftTextBox.TextChanged += new System.EventHandler(this.EditorPaddingLeftTextBox_TextChanged);
            this.editorPaddingLeftTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditorPaddingLeftTextBox_KeyPress);
            // 
            // editorPaddingLeftLabel
            // 
            this.editorPaddingLeftLabel.AutoSize = true;
            this.editorPaddingLeftLabel.Location = new System.Drawing.Point(6, 88);
            this.editorPaddingLeftLabel.Name = "editorPaddingLeftLabel";
            this.editorPaddingLeftLabel.Size = new System.Drawing.Size(73, 15);
            this.editorPaddingLeftLabel.TabIndex = 15;
            this.editorPaddingLeftLabel.Text = "Padding-left";
            // 
            // editorInsertKeyComboBox
            // 
            this.editorInsertKeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editorInsertKeyComboBox.FormattingEnabled = true;
            this.editorInsertKeyComboBox.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.editorInsertKeyComboBox.Location = new System.Drawing.Point(132, 58);
            this.editorInsertKeyComboBox.Name = "editorInsertKeyComboBox";
            this.editorInsertKeyComboBox.Size = new System.Drawing.Size(100, 23);
            this.editorInsertKeyComboBox.TabIndex = 0;
            this.editorInsertKeyComboBox.DropDownClosed += new System.EventHandler(this.EditorInsertKeyComboBox_DropDownClosed);
            // 
            // editorBackColorLabel
            // 
            this.editorBackColorLabel.Location = new System.Drawing.Point(6, 31);
            this.editorBackColorLabel.Name = "editorBackColorLabel";
            this.editorBackColorLabel.Size = new System.Drawing.Size(103, 21);
            this.editorBackColorLabel.TabIndex = 10;
            this.editorBackColorLabel.Text = "Background color";
            this.editorBackColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editorInsertKeyLabel
            // 
            this.editorInsertKeyLabel.AutoSize = true;
            this.editorInsertKeyLabel.Location = new System.Drawing.Point(6, 61);
            this.editorInsertKeyLabel.Name = "editorInsertKeyLabel";
            this.editorInsertKeyLabel.Size = new System.Drawing.Size(57, 15);
            this.editorInsertKeyLabel.TabIndex = 13;
            this.editorInsertKeyLabel.Text = "Insert key";
            // 
            // editorBackColor
            // 
            this.editorBackColor.BackColor = System.Drawing.SystemColors.Control;
            this.editorBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editorBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editorBackColor.Location = new System.Drawing.Point(132, 31);
            this.editorBackColor.Name = "editorBackColor";
            this.editorBackColor.Size = new System.Drawing.Size(100, 21);
            this.editorBackColor.TabIndex = 1;
            this.editorBackColor.Click += new System.EventHandler(this.EditorBackColor_Click);
            // 
            // editorFontColor
            // 
            this.editorFontColor.BackColor = System.Drawing.Color.Black;
            this.editorFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editorFontColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editorFontColor.Location = new System.Drawing.Point(132, 4);
            this.editorFontColor.Name = "editorFontColor";
            this.editorFontColor.Size = new System.Drawing.Size(100, 21);
            this.editorFontColor.TabIndex = 0;
            this.editorFontColor.Click += new System.EventHandler(this.EditorFontColor_Click);
            // 
            // integrationTabPage
            // 
            this.integrationTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.integrationTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.integrationTabPage.Controls.Add(this.integrateCheckBox);
            this.integrationTabPage.Controls.Add(this.associateCheckBox);
            this.integrationTabPage.Controls.Add(this.sendToCheckBox);
            this.integrationTabPage.Location = new System.Drawing.Point(4, 44);
            this.integrationTabPage.Name = "integrationTabPage";
            this.integrationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.integrationTabPage.Size = new System.Drawing.Size(244, 237);
            this.integrationTabPage.TabIndex = 3;
            this.integrationTabPage.Text = "intgr";
            // 
            // integrateCheckBox
            // 
            this.integrateCheckBox.AutoSize = true;
            this.integrateCheckBox.Location = new System.Drawing.Point(7, 7);
            this.integrateCheckBox.Name = "integrateCheckBox";
            this.integrateCheckBox.Size = new System.Drawing.Size(226, 19);
            this.integrateCheckBox.TabIndex = 0;
            this.integrateCheckBox.Text = "Integrate with windows context menu";
            this.integrateCheckBox.UseVisualStyleBackColor = true;
            this.integrateCheckBox.Click += new System.EventHandler(this.IntegrateCheckBox_Click);
            // 
            // associateCheckBox
            // 
            this.associateCheckBox.AutoSize = true;
            this.associateCheckBox.Location = new System.Drawing.Point(7, 30);
            this.associateCheckBox.Name = "associateCheckBox";
            this.associateCheckBox.Size = new System.Drawing.Size(157, 19);
            this.associateCheckBox.TabIndex = 1;
            this.associateCheckBox.Text = "Associate with *.cnp files";
            this.associateCheckBox.UseVisualStyleBackColor = true;
            this.associateCheckBox.Click += new System.EventHandler(this.AssociateCheckBox_Click);
            // 
            // sendToCheckBox
            // 
            this.sendToCheckBox.AutoSize = true;
            this.sendToCheckBox.Location = new System.Drawing.Point(7, 53);
            this.sendToCheckBox.Name = "sendToCheckBox";
            this.sendToCheckBox.Size = new System.Drawing.Size(155, 19);
            this.sendToCheckBox.TabIndex = 2;
            this.sendToCheckBox.Text = "Show in \"Send to\" menu";
            this.sendToCheckBox.UseVisualStyleBackColor = true;
            this.sendToCheckBox.Click += new System.EventHandler(this.SendToCheckBox_Click);
            // 
            // encryptionTabPage
            // 
            this.encryptionTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.encryptionTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encryptionTabPage.Controls.Add(this.passwordIterationsTextBox);
            this.encryptionTabPage.Controls.Add(this.hashAlgorithmComboBox);
            this.encryptionTabPage.Controls.Add(this.passwordIterationsLabel);
            this.encryptionTabPage.Controls.Add(this.keySizeLabel);
            this.encryptionTabPage.Controls.Add(this.hashAlgorithmLabel);
            this.encryptionTabPage.Controls.Add(this.keySizeComboBox);
            this.encryptionTabPage.Location = new System.Drawing.Point(4, 44);
            this.encryptionTabPage.Name = "encryptionTabPage";
            this.encryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.encryptionTabPage.Size = new System.Drawing.Size(244, 237);
            this.encryptionTabPage.TabIndex = 1;
            this.encryptionTabPage.Text = "enc";
            // 
            // passwordIterationsTextBox
            // 
            this.passwordIterationsTextBox.Location = new System.Drawing.Point(132, 62);
            this.passwordIterationsTextBox.Name = "passwordIterationsTextBox";
            this.passwordIterationsTextBox.Size = new System.Drawing.Size(100, 23);
            this.passwordIterationsTextBox.TabIndex = 2;
            this.passwordIterationsTextBox.Text = "1000";
            this.passwordIterationsTextBox.TextChanged += new System.EventHandler(this.PasswordIterationsTextBox_TextChanged);
            this.passwordIterationsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordIterationsTextBox_KeyPress);
            // 
            // hashAlgorithmComboBox
            // 
            this.hashAlgorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hashAlgorithmComboBox.FormattingEnabled = true;
            this.hashAlgorithmComboBox.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.hashAlgorithmComboBox.Location = new System.Drawing.Point(132, 4);
            this.hashAlgorithmComboBox.Name = "hashAlgorithmComboBox";
            this.hashAlgorithmComboBox.Size = new System.Drawing.Size(100, 23);
            this.hashAlgorithmComboBox.TabIndex = 0;
            this.hashAlgorithmComboBox.DropDownClosed += new System.EventHandler(this.HashAlgorithmComboBox_DropDownClosed);
            // 
            // passwordIterationsLabel
            // 
            this.passwordIterationsLabel.AutoSize = true;
            this.passwordIterationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordIterationsLabel.Location = new System.Drawing.Point(6, 65);
            this.passwordIterationsLabel.Name = "passwordIterationsLabel";
            this.passwordIterationsLabel.Size = new System.Drawing.Size(109, 15);
            this.passwordIterationsLabel.TabIndex = 6;
            this.passwordIterationsLabel.Text = "Password iterations";
            // 
            // keySizeLabel
            // 
            this.keySizeLabel.AutoSize = true;
            this.keySizeLabel.Location = new System.Drawing.Point(6, 36);
            this.keySizeLabel.Name = "keySizeLabel";
            this.keySizeLabel.Size = new System.Drawing.Size(48, 15);
            this.keySizeLabel.TabIndex = 1;
            this.keySizeLabel.Text = "Key size";
            // 
            // hashAlgorithmLabel
            // 
            this.hashAlgorithmLabel.AutoSize = true;
            this.hashAlgorithmLabel.Location = new System.Drawing.Point(6, 7);
            this.hashAlgorithmLabel.Name = "hashAlgorithmLabel";
            this.hashAlgorithmLabel.Size = new System.Drawing.Size(92, 15);
            this.hashAlgorithmLabel.TabIndex = 0;
            this.hashAlgorithmLabel.Text = "Hash algorithm ";
            // 
            // keySizeComboBox
            // 
            this.keySizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keySizeComboBox.FormattingEnabled = true;
            this.keySizeComboBox.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.keySizeComboBox.Location = new System.Drawing.Point(132, 33);
            this.keySizeComboBox.Name = "keySizeComboBox";
            this.keySizeComboBox.Size = new System.Drawing.Size(100, 23);
            this.keySizeComboBox.TabIndex = 1;
            this.keySizeComboBox.DropDownClosed += new System.EventHandler(this.KeySizeComboBox_DropDownClosed);
            // 
            // statusPanelTabPage
            // 
            this.statusPanelTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.statusPanelTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusPanelTabPage.Controls.Add(this.statusPanelLabelsGroupBox);
            this.statusPanelTabPage.Controls.Add(this.statusPanelVisibleCheckBox);
            this.statusPanelTabPage.Controls.Add(this.statusPanelBackColor);
            this.statusPanelTabPage.Controls.Add(this.statusPanelFontColor);
            this.statusPanelTabPage.Controls.Add(this.statusPanelFontColorLabel);
            this.statusPanelTabPage.Controls.Add(this.statusPanelBackColorLabel);
            this.statusPanelTabPage.Location = new System.Drawing.Point(4, 44);
            this.statusPanelTabPage.Name = "statusPanelTabPage";
            this.statusPanelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statusPanelTabPage.Size = new System.Drawing.Size(244, 237);
            this.statusPanelTabPage.TabIndex = 5;
            this.statusPanelTabPage.Text = "stat";
            // 
            // statusPanelLabelsGroupBox
            // 
            this.statusPanelLabelsGroupBox.Controls.Add(this.statusPanelLengthCheckBox);
            this.statusPanelLabelsGroupBox.Controls.Add(this.statusPanelSizeCheckBox);
            this.statusPanelLabelsGroupBox.Controls.Add(this.statusPanelLinesCheckBox);
            this.statusPanelLabelsGroupBox.Controls.Add(this.statusPanelModifiedCheckBox);
            this.statusPanelLabelsGroupBox.Location = new System.Drawing.Point(9, 96);
            this.statusPanelLabelsGroupBox.Name = "statusPanelLabelsGroupBox";
            this.statusPanelLabelsGroupBox.Size = new System.Drawing.Size(223, 129);
            this.statusPanelLabelsGroupBox.TabIndex = 8;
            this.statusPanelLabelsGroupBox.TabStop = false;
            this.statusPanelLabelsGroupBox.Text = "Status panel labels";
            // 
            // statusPanelLengthCheckBox
            // 
            this.statusPanelLengthCheckBox.AutoSize = true;
            this.statusPanelLengthCheckBox.Location = new System.Drawing.Point(6, 22);
            this.statusPanelLengthCheckBox.Name = "statusPanelLengthCheckBox";
            this.statusPanelLengthCheckBox.Size = new System.Drawing.Size(63, 19);
            this.statusPanelLengthCheckBox.TabIndex = 4;
            this.statusPanelLengthCheckBox.Text = "Length";
            this.statusPanelLengthCheckBox.UseVisualStyleBackColor = true;
            this.statusPanelLengthCheckBox.Click += new System.EventHandler(this.StatusPanelLengthCheckBox_Click);
            // 
            // statusPanelSizeCheckBox
            // 
            this.statusPanelSizeCheckBox.AutoSize = true;
            this.statusPanelSizeCheckBox.Location = new System.Drawing.Point(6, 97);
            this.statusPanelSizeCheckBox.Name = "statusPanelSizeCheckBox";
            this.statusPanelSizeCheckBox.Size = new System.Drawing.Size(46, 19);
            this.statusPanelSizeCheckBox.TabIndex = 7;
            this.statusPanelSizeCheckBox.Text = "Size";
            this.statusPanelSizeCheckBox.UseVisualStyleBackColor = true;
            this.statusPanelSizeCheckBox.Click += new System.EventHandler(this.statusPanelSizeCheckBox_Click);
            // 
            // statusPanelLinesCheckBox
            // 
            this.statusPanelLinesCheckBox.AutoSize = true;
            this.statusPanelLinesCheckBox.Location = new System.Drawing.Point(6, 47);
            this.statusPanelLinesCheckBox.Name = "statusPanelLinesCheckBox";
            this.statusPanelLinesCheckBox.Size = new System.Drawing.Size(53, 19);
            this.statusPanelLinesCheckBox.TabIndex = 5;
            this.statusPanelLinesCheckBox.Text = "Lines";
            this.statusPanelLinesCheckBox.UseVisualStyleBackColor = true;
            this.statusPanelLinesCheckBox.Click += new System.EventHandler(this.StatusPanelLinesCheckBox_Click);
            // 
            // statusPanelModifiedCheckBox
            // 
            this.statusPanelModifiedCheckBox.AutoSize = true;
            this.statusPanelModifiedCheckBox.Location = new System.Drawing.Point(6, 72);
            this.statusPanelModifiedCheckBox.Name = "statusPanelModifiedCheckBox";
            this.statusPanelModifiedCheckBox.Size = new System.Drawing.Size(74, 19);
            this.statusPanelModifiedCheckBox.TabIndex = 6;
            this.statusPanelModifiedCheckBox.Text = "Modified";
            this.statusPanelModifiedCheckBox.UseVisualStyleBackColor = true;
            this.statusPanelModifiedCheckBox.Click += new System.EventHandler(this.StatusPanelModifiedCheckBox_Click);
            // 
            // statusPanelVisibleCheckBox
            // 
            this.statusPanelVisibleCheckBox.AutoSize = true;
            this.statusPanelVisibleCheckBox.Location = new System.Drawing.Point(9, 66);
            this.statusPanelVisibleCheckBox.Name = "statusPanelVisibleCheckBox";
            this.statusPanelVisibleCheckBox.Size = new System.Drawing.Size(60, 19);
            this.statusPanelVisibleCheckBox.TabIndex = 0;
            this.statusPanelVisibleCheckBox.Text = "Visible";
            this.statusPanelVisibleCheckBox.UseVisualStyleBackColor = true;
            this.statusPanelVisibleCheckBox.Click += new System.EventHandler(this.StatusPanelVisibleCheckBox_Click);
            // 
            // statusPanelBackColor
            // 
            this.statusPanelBackColor.BackColor = System.Drawing.SystemColors.Control;
            this.statusPanelBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusPanelBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusPanelBackColor.Location = new System.Drawing.Point(132, 4);
            this.statusPanelBackColor.Name = "statusPanelBackColor";
            this.statusPanelBackColor.Size = new System.Drawing.Size(100, 21);
            this.statusPanelBackColor.TabIndex = 3;
            this.statusPanelBackColor.Click += new System.EventHandler(this.StatusPanelBackColor_Click);
            // 
            // statusPanelFontColor
            // 
            this.statusPanelFontColor.BackColor = System.Drawing.SystemColors.Control;
            this.statusPanelFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusPanelFontColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusPanelFontColor.Location = new System.Drawing.Point(132, 31);
            this.statusPanelFontColor.Name = "statusPanelFontColor";
            this.statusPanelFontColor.Size = new System.Drawing.Size(100, 21);
            this.statusPanelFontColor.TabIndex = 3;
            this.statusPanelFontColor.Click += new System.EventHandler(this.StatusPanelFontColor_Click);
            // 
            // statusPanelFontColorLabel
            // 
            this.statusPanelFontColorLabel.Location = new System.Drawing.Point(6, 31);
            this.statusPanelFontColorLabel.Name = "statusPanelFontColorLabel";
            this.statusPanelFontColorLabel.Size = new System.Drawing.Size(96, 21);
            this.statusPanelFontColorLabel.TabIndex = 1;
            this.statusPanelFontColorLabel.Text = "Font color";
            this.statusPanelFontColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusPanelBackColorLabel
            // 
            this.statusPanelBackColorLabel.Location = new System.Drawing.Point(6, 4);
            this.statusPanelBackColorLabel.Name = "statusPanelBackColorLabel";
            this.statusPanelBackColorLabel.Size = new System.Drawing.Size(120, 21);
            this.statusPanelBackColorLabel.TabIndex = 0;
            this.statusPanelBackColorLabel.Text = "Background color";
            this.statusPanelBackColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolbarTabPage
            // 
            this.toolbarTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.toolbarTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolbarTabPage.Controls.Add(this.toolbarCloseButtonCheckBox);
            this.toolbarTabPage.Controls.Add(this.toolbarOldIconsCheckBox);
            this.toolbarTabPage.Controls.Add(this.toolbarBorderCheckBox);
            this.toolbarTabPage.Controls.Add(this.toolbarBackColor);
            this.toolbarTabPage.Controls.Add(this.toolbarBackColorLabel);
            this.toolbarTabPage.Controls.Add(this.toolbarVisibleCheckBox);
            this.toolbarTabPage.Location = new System.Drawing.Point(4, 44);
            this.toolbarTabPage.Name = "toolbarTabPage";
            this.toolbarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.toolbarTabPage.Size = new System.Drawing.Size(244, 237);
            this.toolbarTabPage.TabIndex = 6;
            this.toolbarTabPage.Text = "tb";
            // 
            // toolbarCloseButtonCheckBox
            // 
            this.toolbarCloseButtonCheckBox.AutoSize = true;
            this.toolbarCloseButtonCheckBox.Location = new System.Drawing.Point(9, 116);
            this.toolbarCloseButtonCheckBox.Name = "toolbarCloseButtonCheckBox";
            this.toolbarCloseButtonCheckBox.Size = new System.Drawing.Size(94, 19);
            this.toolbarCloseButtonCheckBox.TabIndex = 12;
            this.toolbarCloseButtonCheckBox.Text = "Close button";
            this.toolbarCloseButtonCheckBox.UseVisualStyleBackColor = true;
            this.toolbarCloseButtonCheckBox.Click += new System.EventHandler(this.ToolbarCloseButtonCheckBox_Click);
            // 
            // toolbarOldIconsCheckBox
            // 
            this.toolbarOldIconsCheckBox.AutoSize = true;
            this.toolbarOldIconsCheckBox.Location = new System.Drawing.Point(9, 91);
            this.toolbarOldIconsCheckBox.Name = "toolbarOldIconsCheckBox";
            this.toolbarOldIconsCheckBox.Size = new System.Drawing.Size(76, 19);
            this.toolbarOldIconsCheckBox.TabIndex = 2;
            this.toolbarOldIconsCheckBox.Text = "Old icons";
            this.toolbarOldIconsCheckBox.UseVisualStyleBackColor = true;
            this.toolbarOldIconsCheckBox.Click += new System.EventHandler(this.ToolbarOldIconsCheckBox_Click);
            // 
            // toolbarBorderCheckBox
            // 
            this.toolbarBorderCheckBox.AutoSize = true;
            this.toolbarBorderCheckBox.Location = new System.Drawing.Point(9, 66);
            this.toolbarBorderCheckBox.Name = "toolbarBorderCheckBox";
            this.toolbarBorderCheckBox.Size = new System.Drawing.Size(61, 19);
            this.toolbarBorderCheckBox.TabIndex = 1;
            this.toolbarBorderCheckBox.Text = "Border";
            this.toolbarBorderCheckBox.UseVisualStyleBackColor = true;
            this.toolbarBorderCheckBox.Click += new System.EventHandler(this.ToolbarBorderCheckBox_Click);
            // 
            // toolbarBackColor
            // 
            this.toolbarBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.toolbarBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolbarBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolbarBackColor.Location = new System.Drawing.Point(132, 4);
            this.toolbarBackColor.Name = "toolbarBackColor";
            this.toolbarBackColor.Size = new System.Drawing.Size(100, 21);
            this.toolbarBackColor.TabIndex = 11;
            this.toolbarBackColor.Click += new System.EventHandler(this.ToolbarBackColor_Click);
            // 
            // toolbarBackColorLabel
            // 
            this.toolbarBackColorLabel.Location = new System.Drawing.Point(6, 4);
            this.toolbarBackColorLabel.Name = "toolbarBackColorLabel";
            this.toolbarBackColorLabel.Size = new System.Drawing.Size(120, 21);
            this.toolbarBackColorLabel.TabIndex = 9;
            this.toolbarBackColorLabel.Text = "Background color";
            this.toolbarBackColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolbarVisibleCheckBox
            // 
            this.toolbarVisibleCheckBox.AutoSize = true;
            this.toolbarVisibleCheckBox.Location = new System.Drawing.Point(9, 41);
            this.toolbarVisibleCheckBox.Name = "toolbarVisibleCheckBox";
            this.toolbarVisibleCheckBox.Size = new System.Drawing.Size(60, 19);
            this.toolbarVisibleCheckBox.TabIndex = 0;
            this.toolbarVisibleCheckBox.Text = "Visible";
            this.toolbarVisibleCheckBox.UseVisualStyleBackColor = true;
            this.toolbarVisibleCheckBox.Click += new System.EventHandler(this.ToolbarVisibleCheckBox_Click);
            // 
            // searchPanelTabPage
            // 
            this.searchPanelTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.searchPanelTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanelTabPage.Controls.Add(this.searchBorderComboBox);
            this.searchPanelTabPage.Controls.Add(this.searchBorderLabel);
            this.searchPanelTabPage.Controls.Add(this.searchFontColor);
            this.searchPanelTabPage.Controls.Add(this.searchBackColor);
            this.searchPanelTabPage.Controls.Add(this.searchFontColorLabel);
            this.searchPanelTabPage.Controls.Add(this.searchBackColorLabel);
            this.searchPanelTabPage.Location = new System.Drawing.Point(4, 44);
            this.searchPanelTabPage.Name = "searchPanelTabPage";
            this.searchPanelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchPanelTabPage.Size = new System.Drawing.Size(244, 237);
            this.searchPanelTabPage.TabIndex = 7;
            this.searchPanelTabPage.Text = "srch";
            // 
            // searchBorderComboBox
            // 
            this.searchBorderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBorderComboBox.FormattingEnabled = true;
            this.searchBorderComboBox.Items.AddRange(new object[] {
            "None",
            "Single"});
            this.searchBorderComboBox.Location = new System.Drawing.Point(132, 58);
            this.searchBorderComboBox.Name = "searchBorderComboBox";
            this.searchBorderComboBox.Size = new System.Drawing.Size(100, 23);
            this.searchBorderComboBox.TabIndex = 5;
            this.searchBorderComboBox.DropDownClosed += new System.EventHandler(this.SearchBorderComboBox_DropDownClosed);
            // 
            // searchBorderLabel
            // 
            this.searchBorderLabel.AutoSize = true;
            this.searchBorderLabel.Location = new System.Drawing.Point(6, 61);
            this.searchBorderLabel.Name = "searchBorderLabel";
            this.searchBorderLabel.Size = new System.Drawing.Size(42, 15);
            this.searchBorderLabel.TabIndex = 4;
            this.searchBorderLabel.Text = "Border";
            // 
            // searchFontColor
            // 
            this.searchFontColor.BackColor = System.Drawing.Color.Black;
            this.searchFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchFontColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchFontColor.Location = new System.Drawing.Point(132, 31);
            this.searchFontColor.Name = "searchFontColor";
            this.searchFontColor.Size = new System.Drawing.Size(100, 21);
            this.searchFontColor.TabIndex = 3;
            this.searchFontColor.Click += new System.EventHandler(this.SearchFontColor_Click);
            // 
            // searchBackColor
            // 
            this.searchBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.searchBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBackColor.Location = new System.Drawing.Point(132, 4);
            this.searchBackColor.Name = "searchBackColor";
            this.searchBackColor.Size = new System.Drawing.Size(100, 21);
            this.searchBackColor.TabIndex = 2;
            this.searchBackColor.Click += new System.EventHandler(this.SearchBackColor_Click);
            // 
            // searchFontColorLabel
            // 
            this.searchFontColorLabel.Location = new System.Drawing.Point(6, 31);
            this.searchFontColorLabel.Name = "searchFontColorLabel";
            this.searchFontColorLabel.Size = new System.Drawing.Size(87, 21);
            this.searchFontColorLabel.TabIndex = 1;
            this.searchFontColorLabel.Text = "Font color";
            this.searchFontColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchBackColorLabel
            // 
            this.searchBackColorLabel.Location = new System.Drawing.Point(6, 4);
            this.searchBackColorLabel.Name = "searchBackColorLabel";
            this.searchBackColorLabel.Size = new System.Drawing.Size(120, 21);
            this.searchBackColorLabel.TabIndex = 0;
            this.searchBackColorLabel.Text = "Background color";
            this.searchBackColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsNavigation
            // 
            this.settingsNavigation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsNavigation.FormattingEnabled = true;
            this.settingsNavigation.ItemHeight = 17;
            this.settingsNavigation.Items.AddRange(new object[] {
            "Application",
            "Toolbar",
            "Status Panel",
            "Search Panel",
            "Editor",
            "Encryption",
            "Integration"});
            this.settingsNavigation.Location = new System.Drawing.Point(3, 3);
            this.settingsNavigation.Name = "settingsNavigation";
            this.settingsNavigation.Size = new System.Drawing.Size(102, 276);
            this.settingsNavigation.TabIndex = 6;
            this.settingsNavigation.TabStop = false;
            this.settingsNavigation.Click += new System.EventHandler(this.SettingsNavigation_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.AllowScriptChange = false;
            this.fontDialog.AllowSimulations = false;
            this.fontDialog.AllowVectorFonts = false;
            this.fontDialog.AllowVerticalFonts = false;
            this.fontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fontDialog.FontMustExist = true;
            this.fontDialog.MaxSize = 72;
            this.fontDialog.MinSize = 8;
            this.fontDialog.ShowApply = true;
            this.fontDialog.ShowEffects = false;
            this.fontDialog.Apply += new System.EventHandler(this.FontDialog_Apply);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 283);
            this.Controls.Add(this.settingsTabControl);
            this.Controls.Add(this.settingsNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.settingsTabControl.ResumeLayout(false);
            this.applicationTabPage.ResumeLayout(false);
            this.applicationTabPage.PerformLayout();
            this.editorTabPage.ResumeLayout(false);
            this.editorTabPage.PerformLayout();
            this.integrationTabPage.ResumeLayout(false);
            this.integrationTabPage.PerformLayout();
            this.encryptionTabPage.ResumeLayout(false);
            this.encryptionTabPage.PerformLayout();
            this.statusPanelTabPage.ResumeLayout(false);
            this.statusPanelTabPage.PerformLayout();
            this.statusPanelLabelsGroupBox.ResumeLayout(false);
            this.statusPanelLabelsGroupBox.PerformLayout();
            this.toolbarTabPage.ResumeLayout(false);
            this.toolbarTabPage.PerformLayout();
            this.searchPanelTabPage.ResumeLayout(false);
            this.searchPanelTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label editorFontColorLabel;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage editorTabPage;
        private System.Windows.Forms.TabPage encryptionTabPage;
        private System.Windows.Forms.TabPage applicationTabPage;
        private System.Windows.Forms.CheckBox associateCheckBox;
        private System.Windows.Forms.CheckBox autoCheckUpdatesCheckBox;
        private System.Windows.Forms.Panel editorFontColor;
        private System.Windows.Forms.Panel editorBackColor;
        private System.Windows.Forms.Label editorBackColorLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ComboBox keySizeComboBox;
        private System.Windows.Forms.Label keySizeLabel;
        private System.Windows.Forms.Label hashAlgorithmLabel;
        private System.Windows.Forms.ComboBox hashAlgorithmComboBox;
        private System.Windows.Forms.TextBox passwordIterationsTextBox;
        private System.Windows.Forms.Label passwordIterationsLabel;
        private System.Windows.Forms.CheckBox toolbarVisibleCheckBox;
        private System.Windows.Forms.CheckBox autoLockOnMinimizeCheckBox;
        private System.Windows.Forms.CheckBox sendToCheckBox;
        private System.Windows.Forms.CheckBox integrateCheckBox;
        private System.Windows.Forms.CheckBox menuIconsCheckBox;
        private System.Windows.Forms.TabPage integrationTabPage;
        private System.Windows.Forms.ComboBox editorInsertKeyComboBox;
        private System.Windows.Forms.Label editorInsertKeyLabel;
        private System.Windows.Forms.TextBox editorPaddingLeftTextBox;
        private System.Windows.Forms.Label editorPaddingLeftLabel;
        private System.Windows.Forms.ListBox settingsNavigation;
        private System.Windows.Forms.Button editorFontButton;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.TabPage statusPanelTabPage;
        private System.Windows.Forms.TabPage toolbarTabPage;
        private System.Windows.Forms.TabPage searchPanelTabPage;
        private System.Windows.Forms.Label searchFontColorLabel;
        private System.Windows.Forms.Label searchBackColorLabel;
        private System.Windows.Forms.CheckBox statusPanelVisibleCheckBox;
        private System.Windows.Forms.Label statusPanelFontColorLabel;
        private System.Windows.Forms.Label statusPanelBackColorLabel;
        private System.Windows.Forms.Panel searchBackColor;
        private System.Windows.Forms.Panel statusPanelBackColor;
        private System.Windows.Forms.Panel statusPanelFontColor;
        private System.Windows.Forms.Panel searchFontColor;
        private System.Windows.Forms.Panel toolbarBackColor;
        private System.Windows.Forms.Label toolbarBackColorLabel;
        private System.Windows.Forms.CheckBox toolbarBorderCheckBox;
        private System.Windows.Forms.ComboBox editorOpenLinksWithComboBox;
        private System.Windows.Forms.Label editorOpenLinksWithLabel;
        private System.Windows.Forms.CheckBox mainMenuCheckBox;
        private System.Windows.Forms.CheckBox toolbarOldIconsCheckBox;
        private System.Windows.Forms.CheckBox closeToTrayCheckBox;
        private System.Windows.Forms.CheckBox minimizeToTrayCheckBox;
        private System.Windows.Forms.ComboBox editorBorderComboBox;
        private System.Windows.Forms.Label editorBorderLabel;
        private System.Windows.Forms.ComboBox searchBorderComboBox;
        private System.Windows.Forms.Label searchBorderLabel;
        private System.Windows.Forms.CheckBox toolbarCloseButtonCheckBox;
        private System.Windows.Forms.CheckBox singleInstanceCheckBox;
        private System.Windows.Forms.CheckBox statusPanelLengthCheckBox;
        private System.Windows.Forms.CheckBox statusPanelLinesCheckBox;
        private System.Windows.Forms.CheckBox statusPanelModifiedCheckBox;
        private System.Windows.Forms.CheckBox statusPanelSizeCheckBox;
        private System.Windows.Forms.GroupBox statusPanelLabelsGroupBox;
    }
}
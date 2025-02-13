﻿namespace Scada.Admin.App.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileShowStartPage = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileCloseProject = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeploy = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeployInstanceProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeployDownloadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeployUploadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeployInstanceStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.miTools = new System.Windows.Forms.ToolStripMenuItem();
            this.miToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.miToolsCulture = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowCloseActive = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowCloseAllButActive = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnFileNewProject = new System.Windows.Forms.ToolStripButton();
            this.btnFileOpenProject = new System.Windows.Forms.ToolStripButton();
            this.btnFileSave = new System.Windows.Forms.ToolStripButton();
            this.btnFileSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeployInstanceProfile = new System.Windows.Forms.ToolStripButton();
            this.btnDeployDownloadConfig = new System.Windows.Forms.ToolStripButton();
            this.btnDeployUploadConfig = new System.Windows.Forms.ToolStripButton();
            this.btnDeployInstanceStatus = new System.Windows.Forms.ToolStripButton();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lblSelectedInstance = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSelectedProfile = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.tvExplorer = new System.Windows.Forms.TreeView();
            this.ilExplorer = new System.Windows.Forms.ImageList(this.components);
            this.splVert = new System.Windows.Forms.Splitter();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.wctrlMain = new WinControl.WinControl();
            this.ofdProject = new System.Windows.Forms.OpenFileDialog();
            this.cmsInstance = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miInstanceAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstanceMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstanceMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstanceDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstanceSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.miInstanceProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstanceDownloadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstanceUploadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstanceStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstanceSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.miInstanceOpenInExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstanceOpenInBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstanceRename = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstanceProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miProjectOpenInExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.miProjectRename = new System.Windows.Forms.ToolStripMenuItem();
            this.miProjectProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDirectory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDirectoryNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miDirectoryNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.miDirectorySep1 = new System.Windows.Forms.ToolStripSeparator();
            this.miDirectoryDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miDirectoryRename = new System.Windows.Forms.ToolStripMenuItem();
            this.miDirectorySep2 = new System.Windows.Forms.ToolStripSeparator();
            this.miDirectoryOpenInExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.miDirectoryRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFileItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miFileItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileItemOpenLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileItemSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileItemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAppOpenInExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.miAppReloadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCnlTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCnlTableComm = new System.Windows.Forms.ToolStripMenuItem();
            this.miCnlTableRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.cmsInstance.SuspendLayout();
            this.cmsProject.SuspendLayout();
            this.cmsDirectory.SuspendLayout();
            this.cmsFileItem.SuspendLayout();
            this.cmsApp.SuspendLayout();
            this.cmsCnlTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miDeploy,
            this.miTools,
            this.miWindow,
            this.miHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(784, 24);
            this.msMain.TabIndex = 0;
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileNewProject,
            this.miFileOpenProject,
            this.miFileShowStartPage,
            this.miFileSep1,
            this.miFileSave,
            this.miFileSaveAll,
            this.miFileSep2,
            this.miFileClose,
            this.miFileCloseProject,
            this.miFileSep3,
            this.miFileExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "&File";
            this.miFile.DropDownOpening += new System.EventHandler(this.miFile_DropDownOpening);
            // 
            // miFileNewProject
            // 
            this.miFileNewProject.Image = global::Scada.Admin.App.Properties.Resources.blank;
            this.miFileNewProject.Name = "miFileNewProject";
            this.miFileNewProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miFileNewProject.Size = new System.Drawing.Size(195, 22);
            this.miFileNewProject.Text = "New Project...";
            this.miFileNewProject.Click += new System.EventHandler(this.miFileNewProject_Click);
            // 
            // miFileOpenProject
            // 
            this.miFileOpenProject.Image = global::Scada.Admin.App.Properties.Resources.open;
            this.miFileOpenProject.Name = "miFileOpenProject";
            this.miFileOpenProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miFileOpenProject.Size = new System.Drawing.Size(195, 22);
            this.miFileOpenProject.Text = "Open Project...";
            this.miFileOpenProject.Click += new System.EventHandler(this.miFileOpenProject_Click);
            // 
            // miFileShowStartPage
            // 
            this.miFileShowStartPage.Image = global::Scada.Admin.App.Properties.Resources.start_page;
            this.miFileShowStartPage.Name = "miFileShowStartPage";
            this.miFileShowStartPage.Size = new System.Drawing.Size(195, 22);
            this.miFileShowStartPage.Text = "Start Page";
            this.miFileShowStartPage.Click += new System.EventHandler(this.miFileShowStartPage_Click);
            // 
            // miFileSep1
            // 
            this.miFileSep1.Name = "miFileSep1";
            this.miFileSep1.Size = new System.Drawing.Size(192, 6);
            // 
            // miFileSave
            // 
            this.miFileSave.Image = global::Scada.Admin.App.Properties.Resources.save;
            this.miFileSave.Name = "miFileSave";
            this.miFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miFileSave.Size = new System.Drawing.Size(195, 22);
            this.miFileSave.Text = "Save";
            this.miFileSave.Click += new System.EventHandler(this.miFileSave_Click);
            // 
            // miFileSaveAll
            // 
            this.miFileSaveAll.Image = global::Scada.Admin.App.Properties.Resources.save_all;
            this.miFileSaveAll.Name = "miFileSaveAll";
            this.miFileSaveAll.Size = new System.Drawing.Size(195, 22);
            this.miFileSaveAll.Text = "Save All";
            this.miFileSaveAll.Click += new System.EventHandler(this.miFileSaveAll_Click);
            // 
            // miFileSep2
            // 
            this.miFileSep2.Name = "miFileSep2";
            this.miFileSep2.Size = new System.Drawing.Size(192, 6);
            // 
            // miFileClose
            // 
            this.miFileClose.Name = "miFileClose";
            this.miFileClose.Size = new System.Drawing.Size(195, 22);
            this.miFileClose.Text = "Close";
            this.miFileClose.Click += new System.EventHandler(this.miFileClose_Click);
            // 
            // miFileCloseProject
            // 
            this.miFileCloseProject.Name = "miFileCloseProject";
            this.miFileCloseProject.Size = new System.Drawing.Size(195, 22);
            this.miFileCloseProject.Text = "Close Project";
            this.miFileCloseProject.Click += new System.EventHandler(this.miFileCloseProject_Click);
            // 
            // miFileSep3
            // 
            this.miFileSep3.Name = "miFileSep3";
            this.miFileSep3.Size = new System.Drawing.Size(192, 6);
            // 
            // miFileExit
            // 
            this.miFileExit.Image = global::Scada.Admin.App.Properties.Resources.close;
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.Size = new System.Drawing.Size(195, 22);
            this.miFileExit.Text = "Exit";
            this.miFileExit.Click += new System.EventHandler(this.miFileExit_Click);
            // 
            // miDeploy
            // 
            this.miDeploy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeployInstanceProfile,
            this.miDeployDownloadConfig,
            this.miDeployUploadConfig,
            this.miDeployInstanceStatus});
            this.miDeploy.Name = "miDeploy";
            this.miDeploy.Size = new System.Drawing.Size(56, 20);
            this.miDeploy.Text = "&Deploy";
            // 
            // miDeployInstanceProfile
            // 
            this.miDeployInstanceProfile.Image = global::Scada.Admin.App.Properties.Resources.deploy_profile;
            this.miDeployInstanceProfile.Name = "miDeployInstanceProfile";
            this.miDeployInstanceProfile.Size = new System.Drawing.Size(240, 22);
            this.miDeployInstanceProfile.Text = "Deployment Profile...";
            this.miDeployInstanceProfile.Click += new System.EventHandler(this.miDeployInstanceProfile_Click);
            // 
            // miDeployDownloadConfig
            // 
            this.miDeployDownloadConfig.Image = global::Scada.Admin.App.Properties.Resources.download;
            this.miDeployDownloadConfig.Name = "miDeployDownloadConfig";
            this.miDeployDownloadConfig.Size = new System.Drawing.Size(240, 22);
            this.miDeployDownloadConfig.Text = "Download Configuration...";
            this.miDeployDownloadConfig.Click += new System.EventHandler(this.miDeployDownloadConfig_Click);
            // 
            // miDeployUploadConfig
            // 
            this.miDeployUploadConfig.Image = global::Scada.Admin.App.Properties.Resources.upload;
            this.miDeployUploadConfig.Name = "miDeployUploadConfig";
            this.miDeployUploadConfig.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.miDeployUploadConfig.Size = new System.Drawing.Size(240, 22);
            this.miDeployUploadConfig.Text = "Upload Configuration...";
            this.miDeployUploadConfig.Click += new System.EventHandler(this.miDeployUploadConfig_Click);
            // 
            // miDeployInstanceStatus
            // 
            this.miDeployInstanceStatus.Image = global::Scada.Admin.App.Properties.Resources.status;
            this.miDeployInstanceStatus.Name = "miDeployInstanceStatus";
            this.miDeployInstanceStatus.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.miDeployInstanceStatus.Size = new System.Drawing.Size(240, 22);
            this.miDeployInstanceStatus.Text = "Instance Status...";
            this.miDeployInstanceStatus.Click += new System.EventHandler(this.miDeployInstanceStatus_Click);
            // 
            // miTools
            // 
            this.miTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miToolsOptions,
            this.miToolsCulture});
            this.miTools.Name = "miTools";
            this.miTools.Size = new System.Drawing.Size(46, 20);
            this.miTools.Text = "&Tools";
            // 
            // miToolsOptions
            // 
            this.miToolsOptions.Image = global::Scada.Admin.App.Properties.Resources.options;
            this.miToolsOptions.Name = "miToolsOptions";
            this.miToolsOptions.Size = new System.Drawing.Size(180, 22);
            this.miToolsOptions.Text = "Options...";
            this.miToolsOptions.Click += new System.EventHandler(this.miToolsOptions_Click);
            // 
            // miToolsCulture
            // 
            this.miToolsCulture.Name = "miToolsCulture";
            this.miToolsCulture.Size = new System.Drawing.Size(180, 22);
            this.miToolsCulture.Text = "Language...";
            this.miToolsCulture.Click += new System.EventHandler(this.miToolsCulture_Click);
            // 
            // miWindow
            // 
            this.miWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miWindowCloseActive,
            this.miWindowCloseAll,
            this.miWindowCloseAllButActive});
            this.miWindow.Name = "miWindow";
            this.miWindow.Size = new System.Drawing.Size(63, 20);
            this.miWindow.Text = "&Window";
            this.miWindow.DropDownOpening += new System.EventHandler(this.miWindow_DropDownOpening);
            // 
            // miWindowCloseActive
            // 
            this.miWindowCloseActive.Name = "miWindowCloseActive";
            this.miWindowCloseActive.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.miWindowCloseActive.Size = new System.Drawing.Size(185, 22);
            this.miWindowCloseActive.Text = "Close Active";
            this.miWindowCloseActive.Click += new System.EventHandler(this.miWindowCloseActive_Click);
            // 
            // miWindowCloseAll
            // 
            this.miWindowCloseAll.Name = "miWindowCloseAll";
            this.miWindowCloseAll.Size = new System.Drawing.Size(185, 22);
            this.miWindowCloseAll.Text = "Close All";
            this.miWindowCloseAll.Click += new System.EventHandler(this.miWindowCloseAll_Click);
            // 
            // miWindowCloseAllButActive
            // 
            this.miWindowCloseAllButActive.Name = "miWindowCloseAllButActive";
            this.miWindowCloseAllButActive.Size = new System.Drawing.Size(185, 22);
            this.miWindowCloseAllButActive.Text = "Close All But Active";
            this.miWindowCloseAllButActive.Click += new System.EventHandler(this.miWindowCloseAllButActive_Click);
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelpDoc,
            this.miHelpSupport,
            this.miHelpSep1,
            this.miHelpAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(44, 20);
            this.miHelp.Text = "&Help";
            // 
            // miHelpDoc
            // 
            this.miHelpDoc.Image = global::Scada.Admin.App.Properties.Resources.help;
            this.miHelpDoc.Name = "miHelpDoc";
            this.miHelpDoc.Size = new System.Drawing.Size(168, 22);
            this.miHelpDoc.Text = "Documentation";
            this.miHelpDoc.Click += new System.EventHandler(this.miHelpDoc_Click);
            // 
            // miHelpSupport
            // 
            this.miHelpSupport.Image = global::Scada.Admin.App.Properties.Resources.support;
            this.miHelpSupport.Name = "miHelpSupport";
            this.miHelpSupport.Size = new System.Drawing.Size(168, 22);
            this.miHelpSupport.Text = "Technical Support";
            this.miHelpSupport.Click += new System.EventHandler(this.miHelpSupport_Click);
            // 
            // miHelpSep1
            // 
            this.miHelpSep1.Name = "miHelpSep1";
            this.miHelpSep1.Size = new System.Drawing.Size(165, 6);
            // 
            // miHelpAbout
            // 
            this.miHelpAbout.Image = global::Scada.Admin.App.Properties.Resources.about;
            this.miHelpAbout.Name = "miHelpAbout";
            this.miHelpAbout.Size = new System.Drawing.Size(168, 22);
            this.miHelpAbout.Text = "About";
            this.miHelpAbout.Click += new System.EventHandler(this.miHelpAbout_Click);
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFileNewProject,
            this.btnFileOpenProject,
            this.btnFileSave,
            this.btnFileSaveAll,
            this.toolSep1,
            this.btnDeployInstanceProfile,
            this.btnDeployDownloadConfig,
            this.btnDeployUploadConfig,
            this.btnDeployInstanceStatus});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(784, 25);
            this.tsMain.TabIndex = 1;
            // 
            // btnFileNewProject
            // 
            this.btnFileNewProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileNewProject.Image = global::Scada.Admin.App.Properties.Resources.blank;
            this.btnFileNewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileNewProject.Name = "btnFileNewProject";
            this.btnFileNewProject.Size = new System.Drawing.Size(23, 22);
            this.btnFileNewProject.ToolTipText = "New Project (Ctrl+N)";
            this.btnFileNewProject.Click += new System.EventHandler(this.miFileNewProject_Click);
            // 
            // btnFileOpenProject
            // 
            this.btnFileOpenProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileOpenProject.Image = global::Scada.Admin.App.Properties.Resources.open;
            this.btnFileOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileOpenProject.Name = "btnFileOpenProject";
            this.btnFileOpenProject.Size = new System.Drawing.Size(23, 22);
            this.btnFileOpenProject.ToolTipText = "Open Project (Ctrl+O)";
            this.btnFileOpenProject.Click += new System.EventHandler(this.miFileOpenProject_Click);
            // 
            // btnFileSave
            // 
            this.btnFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileSave.Image = global::Scada.Admin.App.Properties.Resources.save;
            this.btnFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.Size = new System.Drawing.Size(23, 22);
            this.btnFileSave.ToolTipText = "Save (Ctrl+S)";
            this.btnFileSave.Click += new System.EventHandler(this.miFileSave_Click);
            // 
            // btnFileSaveAll
            // 
            this.btnFileSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileSaveAll.Image = global::Scada.Admin.App.Properties.Resources.save_all;
            this.btnFileSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileSaveAll.Name = "btnFileSaveAll";
            this.btnFileSaveAll.Size = new System.Drawing.Size(23, 22);
            this.btnFileSaveAll.ToolTipText = "Save All";
            this.btnFileSaveAll.Click += new System.EventHandler(this.miFileSaveAll_Click);
            // 
            // toolSep1
            // 
            this.toolSep1.Name = "toolSep1";
            this.toolSep1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDeployInstanceProfile
            // 
            this.btnDeployInstanceProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeployInstanceProfile.Image = global::Scada.Admin.App.Properties.Resources.deploy_profile;
            this.btnDeployInstanceProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeployInstanceProfile.Name = "btnDeployInstanceProfile";
            this.btnDeployInstanceProfile.Size = new System.Drawing.Size(23, 22);
            this.btnDeployInstanceProfile.ToolTipText = "Deployment Profile";
            this.btnDeployInstanceProfile.Click += new System.EventHandler(this.miDeployInstanceProfile_Click);
            // 
            // btnDeployDownloadConfig
            // 
            this.btnDeployDownloadConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeployDownloadConfig.Image = global::Scada.Admin.App.Properties.Resources.download;
            this.btnDeployDownloadConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeployDownloadConfig.Name = "btnDeployDownloadConfig";
            this.btnDeployDownloadConfig.Size = new System.Drawing.Size(23, 22);
            this.btnDeployDownloadConfig.ToolTipText = "Download Configuration";
            this.btnDeployDownloadConfig.Click += new System.EventHandler(this.miDeployDownloadConfig_Click);
            // 
            // btnDeployUploadConfig
            // 
            this.btnDeployUploadConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeployUploadConfig.Image = global::Scada.Admin.App.Properties.Resources.upload;
            this.btnDeployUploadConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeployUploadConfig.Name = "btnDeployUploadConfig";
            this.btnDeployUploadConfig.Size = new System.Drawing.Size(23, 22);
            this.btnDeployUploadConfig.ToolTipText = "Upload Configuration (Ctrl+U)";
            this.btnDeployUploadConfig.Click += new System.EventHandler(this.miDeployUploadConfig_Click);
            // 
            // btnDeployInstanceStatus
            // 
            this.btnDeployInstanceStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeployInstanceStatus.Image = global::Scada.Admin.App.Properties.Resources.status;
            this.btnDeployInstanceStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeployInstanceStatus.Name = "btnDeployInstanceStatus";
            this.btnDeployInstanceStatus.Size = new System.Drawing.Size(23, 22);
            this.btnDeployInstanceStatus.ToolTipText = "Instance Status (Ctrl+I)";
            this.btnDeployInstanceStatus.Click += new System.EventHandler(this.miDeployInstanceStatus_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSelectedInstance,
            this.lblSelectedProfile});
            this.ssMain.Location = new System.Drawing.Point(0, 487);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(784, 24);
            this.ssMain.TabIndex = 2;
            // 
            // lblSelectedInstance
            // 
            this.lblSelectedInstance.Name = "lblSelectedInstance";
            this.lblSelectedInstance.Size = new System.Drawing.Size(108, 19);
            this.lblSelectedInstance.Text = "lblSelectedInstance";
            // 
            // lblSelectedProfile
            // 
            this.lblSelectedProfile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblSelectedProfile.Name = "lblSelectedProfile";
            this.lblSelectedProfile.Size = new System.Drawing.Size(102, 19);
            this.lblSelectedProfile.Text = "lblSelectedProfile";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.tvExplorer);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 49);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(300, 438);
            this.pnlLeft.TabIndex = 3;
            // 
            // tvExplorer
            // 
            this.tvExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvExplorer.HideSelection = false;
            this.tvExplorer.ImageIndex = 0;
            this.tvExplorer.ImageList = this.ilExplorer;
            this.tvExplorer.Location = new System.Drawing.Point(0, 0);
            this.tvExplorer.Name = "tvExplorer";
            this.tvExplorer.SelectedImageIndex = 0;
            this.tvExplorer.ShowRootLines = false;
            this.tvExplorer.Size = new System.Drawing.Size(300, 438);
            this.tvExplorer.TabIndex = 0;
            this.tvExplorer.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvExplorer_BeforeCollapse);
            this.tvExplorer.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tvExplorer_AfterCollapse);
            this.tvExplorer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvExplorer_BeforeExpand);
            this.tvExplorer.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvExplorer_AfterExpand);
            this.tvExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvExplorer_AfterSelect);
            this.tvExplorer.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvExplorer_NodeMouseClick);
            this.tvExplorer.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvExplorer_NodeMouseDoubleClick);
            this.tvExplorer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tvExplorer_KeyDown);
            this.tvExplorer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvExplorer_MouseDown);
            // 
            // ilExplorer
            // 
            this.ilExplorer.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilExplorer.ImageSize = new System.Drawing.Size(16, 16);
            this.ilExplorer.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splVert
            // 
            this.splVert.Location = new System.Drawing.Point(300, 49);
            this.splVert.MinExtra = 100;
            this.splVert.MinSize = 100;
            this.splVert.Name = "splVert";
            this.splVert.Size = new System.Drawing.Size(3, 438);
            this.splVert.TabIndex = 4;
            this.splVert.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.wctrlMain);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(303, 49);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(481, 438);
            this.pnlRight.TabIndex = 5;
            // 
            // wctrlMain
            // 
            this.wctrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wctrlMain.Image = null;
            this.wctrlMain.Location = new System.Drawing.Point(0, 0);
            this.wctrlMain.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wctrlMain.Name = "wctrlMain";
            this.wctrlMain.SaveReqCancel = "Cancel";
            this.wctrlMain.SaveReqCaption = "Save changes";
            this.wctrlMain.SaveReqNo = "&No";
            this.wctrlMain.SaveReqQuestion = "Save changes to the following items?";
            this.wctrlMain.SaveReqYes = "&Yes";
            this.wctrlMain.Size = new System.Drawing.Size(481, 438);
            this.wctrlMain.TabIndex = 0;
            this.wctrlMain.ActiveFormChanged += new System.EventHandler(this.wctrlMain_ActiveFormChanged);
            this.wctrlMain.ChildFormClosed += new System.EventHandler<WinControl.ChildFormClosedEventArgs>(this.wctrlMain_ChildFormClosed);
            this.wctrlMain.ChildFormMessage += new System.EventHandler<WinControl.FormMessageEventArgs>(this.wctrlMain_ChildFormMessage);
            this.wctrlMain.ChildFormModifiedChanged += new System.EventHandler<WinControl.ChildFormEventArgs>(this.wctrlMain_ChildFormModifiedChanged);
            // 
            // ofdProject
            // 
            this.ofdProject.DefaultExt = "*.rsproj";
            this.ofdProject.Filter = "Projects (*.rsproj)|*.rsproj|All Files (*.*)|*.*";
            // 
            // cmsInstance
            // 
            this.cmsInstance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miInstanceAdd,
            this.miInstanceMoveUp,
            this.miInstanceMoveDown,
            this.miInstanceDelete,
            this.miInstanceSep1,
            this.miInstanceProfile,
            this.miInstanceDownloadConfig,
            this.miInstanceUploadConfig,
            this.miInstanceStatus,
            this.miInstanceSep2,
            this.miInstanceOpenInExplorer,
            this.miInstanceOpenInBrowser,
            this.miInstanceRename,
            this.miInstanceProperties});
            this.cmsInstance.Name = "cmsCommLine";
            this.cmsInstance.Size = new System.Drawing.Size(220, 280);
            this.cmsInstance.Opening += new System.ComponentModel.CancelEventHandler(this.cmsInstance_Opening);
            // 
            // miInstanceAdd
            // 
            this.miInstanceAdd.Image = global::Scada.Admin.App.Properties.Resources.add;
            this.miInstanceAdd.Name = "miInstanceAdd";
            this.miInstanceAdd.Size = new System.Drawing.Size(219, 22);
            this.miInstanceAdd.Text = "Add Instance...";
            this.miInstanceAdd.Click += new System.EventHandler(this.miInstanceAdd_Click);
            // 
            // miInstanceMoveUp
            // 
            this.miInstanceMoveUp.Image = global::Scada.Admin.App.Properties.Resources.move_up;
            this.miInstanceMoveUp.Name = "miInstanceMoveUp";
            this.miInstanceMoveUp.Size = new System.Drawing.Size(219, 22);
            this.miInstanceMoveUp.Text = "Move Instance Up";
            this.miInstanceMoveUp.Click += new System.EventHandler(this.miInstanceMoveUp_Click);
            // 
            // miInstanceMoveDown
            // 
            this.miInstanceMoveDown.Image = global::Scada.Admin.App.Properties.Resources.move_down;
            this.miInstanceMoveDown.Name = "miInstanceMoveDown";
            this.miInstanceMoveDown.Size = new System.Drawing.Size(219, 22);
            this.miInstanceMoveDown.Text = "Move Instance Down";
            this.miInstanceMoveDown.Click += new System.EventHandler(this.miInstanceMoveDown_Click);
            // 
            // miInstanceDelete
            // 
            this.miInstanceDelete.Image = global::Scada.Admin.App.Properties.Resources.delete;
            this.miInstanceDelete.Name = "miInstanceDelete";
            this.miInstanceDelete.Size = new System.Drawing.Size(219, 22);
            this.miInstanceDelete.Text = "Delete Instance";
            this.miInstanceDelete.Click += new System.EventHandler(this.miInstanceDelete_Click);
            // 
            // miInstanceSep1
            // 
            this.miInstanceSep1.Name = "miInstanceSep1";
            this.miInstanceSep1.Size = new System.Drawing.Size(216, 6);
            // 
            // miInstanceProfile
            // 
            this.miInstanceProfile.Image = global::Scada.Admin.App.Properties.Resources.deploy_profile;
            this.miInstanceProfile.Name = "miInstanceProfile";
            this.miInstanceProfile.Size = new System.Drawing.Size(219, 22);
            this.miInstanceProfile.Text = "Deployment Profile...";
            this.miInstanceProfile.Click += new System.EventHandler(this.miDeployInstanceProfile_Click);
            // 
            // miInstanceDownloadConfig
            // 
            this.miInstanceDownloadConfig.Image = global::Scada.Admin.App.Properties.Resources.download;
            this.miInstanceDownloadConfig.Name = "miInstanceDownloadConfig";
            this.miInstanceDownloadConfig.Size = new System.Drawing.Size(219, 22);
            this.miInstanceDownloadConfig.Text = "Download Configuration...";
            this.miInstanceDownloadConfig.Click += new System.EventHandler(this.miDeployDownloadConfig_Click);
            // 
            // miInstanceUploadConfig
            // 
            this.miInstanceUploadConfig.Image = global::Scada.Admin.App.Properties.Resources.upload;
            this.miInstanceUploadConfig.Name = "miInstanceUploadConfig";
            this.miInstanceUploadConfig.Size = new System.Drawing.Size(219, 22);
            this.miInstanceUploadConfig.Text = "Upload Configuration...";
            this.miInstanceUploadConfig.Click += new System.EventHandler(this.miDeployUploadConfig_Click);
            // 
            // miInstanceStatus
            // 
            this.miInstanceStatus.Image = global::Scada.Admin.App.Properties.Resources.status;
            this.miInstanceStatus.Name = "miInstanceStatus";
            this.miInstanceStatus.Size = new System.Drawing.Size(219, 22);
            this.miInstanceStatus.Text = "Instance Status...";
            this.miInstanceStatus.Click += new System.EventHandler(this.miDeployInstanceStatus_Click);
            // 
            // miInstanceSep2
            // 
            this.miInstanceSep2.Name = "miInstanceSep2";
            this.miInstanceSep2.Size = new System.Drawing.Size(216, 6);
            // 
            // miInstanceOpenInExplorer
            // 
            this.miInstanceOpenInExplorer.Image = global::Scada.Admin.App.Properties.Resources.open_explorer;
            this.miInstanceOpenInExplorer.Name = "miInstanceOpenInExplorer";
            this.miInstanceOpenInExplorer.Size = new System.Drawing.Size(219, 22);
            this.miInstanceOpenInExplorer.Text = "Open Folder in File Explorer";
            this.miInstanceOpenInExplorer.Click += new System.EventHandler(this.miDirectoryOpenInExplorer_Click);
            // 
            // miInstanceOpenInBrowser
            // 
            this.miInstanceOpenInBrowser.Image = global::Scada.Admin.App.Properties.Resources.web;
            this.miInstanceOpenInBrowser.Name = "miInstanceOpenInBrowser";
            this.miInstanceOpenInBrowser.Size = new System.Drawing.Size(219, 22);
            this.miInstanceOpenInBrowser.Text = "Open in Web Browser";
            this.miInstanceOpenInBrowser.Click += new System.EventHandler(this.miInstanceOpenInBrowser_Click);
            // 
            // miInstanceRename
            // 
            this.miInstanceRename.Image = global::Scada.Admin.App.Properties.Resources.rename;
            this.miInstanceRename.Name = "miInstanceRename";
            this.miInstanceRename.Size = new System.Drawing.Size(219, 22);
            this.miInstanceRename.Text = "Rename Instance";
            this.miInstanceRename.Click += new System.EventHandler(this.miInstanceRename_Click);
            // 
            // miInstanceProperties
            // 
            this.miInstanceProperties.Image = global::Scada.Admin.App.Properties.Resources.properties;
            this.miInstanceProperties.Name = "miInstanceProperties";
            this.miInstanceProperties.Size = new System.Drawing.Size(219, 22);
            this.miInstanceProperties.Text = "Properties";
            this.miInstanceProperties.Click += new System.EventHandler(this.miInstanceProperties_Click);
            // 
            // cmsProject
            // 
            this.cmsProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProjectOpenInExplorer,
            this.miProjectRename,
            this.miProjectProperties});
            this.cmsProject.Name = "cmsCommLine";
            this.cmsProject.Size = new System.Drawing.Size(220, 70);
            // 
            // miProjectOpenInExplorer
            // 
            this.miProjectOpenInExplorer.Image = global::Scada.Admin.App.Properties.Resources.open_explorer;
            this.miProjectOpenInExplorer.Name = "miProjectOpenInExplorer";
            this.miProjectOpenInExplorer.Size = new System.Drawing.Size(219, 22);
            this.miProjectOpenInExplorer.Text = "Open Folder in File Explorer";
            this.miProjectOpenInExplorer.Click += new System.EventHandler(this.miDirectoryOpenInExplorer_Click);
            // 
            // miProjectRename
            // 
            this.miProjectRename.Image = global::Scada.Admin.App.Properties.Resources.rename;
            this.miProjectRename.Name = "miProjectRename";
            this.miProjectRename.Size = new System.Drawing.Size(219, 22);
            this.miProjectRename.Text = "Rename Project";
            this.miProjectRename.Click += new System.EventHandler(this.miProjectRename_Click);
            // 
            // miProjectProperties
            // 
            this.miProjectProperties.Image = global::Scada.Admin.App.Properties.Resources.properties;
            this.miProjectProperties.Name = "miProjectProperties";
            this.miProjectProperties.Size = new System.Drawing.Size(219, 22);
            this.miProjectProperties.Text = "Properties";
            this.miProjectProperties.Click += new System.EventHandler(this.miProjectProperties_Click);
            // 
            // cmsDirectory
            // 
            this.cmsDirectory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDirectoryNewFile,
            this.miDirectoryNewFolder,
            this.miDirectorySep1,
            this.miDirectoryDelete,
            this.miDirectoryRename,
            this.miDirectorySep2,
            this.miDirectoryOpenInExplorer,
            this.miDirectoryRefresh});
            this.cmsDirectory.Name = "cmsDirectory";
            this.cmsDirectory.Size = new System.Drawing.Size(220, 148);
            this.cmsDirectory.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDirectory_Opening);
            // 
            // miDirectoryNewFile
            // 
            this.miDirectoryNewFile.Image = global::Scada.Admin.App.Properties.Resources.new_file;
            this.miDirectoryNewFile.Name = "miDirectoryNewFile";
            this.miDirectoryNewFile.Size = new System.Drawing.Size(219, 22);
            this.miDirectoryNewFile.Text = "New File...";
            this.miDirectoryNewFile.Click += new System.EventHandler(this.miDirectoryNewFile_Click);
            // 
            // miDirectoryNewFolder
            // 
            this.miDirectoryNewFolder.Image = global::Scada.Admin.App.Properties.Resources.new_folder;
            this.miDirectoryNewFolder.Name = "miDirectoryNewFolder";
            this.miDirectoryNewFolder.Size = new System.Drawing.Size(219, 22);
            this.miDirectoryNewFolder.Text = "New Folder...";
            this.miDirectoryNewFolder.Click += new System.EventHandler(this.miDirectoryNewFolder_Click);
            // 
            // miDirectorySep1
            // 
            this.miDirectorySep1.Name = "miDirectorySep1";
            this.miDirectorySep1.Size = new System.Drawing.Size(216, 6);
            // 
            // miDirectoryDelete
            // 
            this.miDirectoryDelete.Image = global::Scada.Admin.App.Properties.Resources.delete;
            this.miDirectoryDelete.Name = "miDirectoryDelete";
            this.miDirectoryDelete.Size = new System.Drawing.Size(219, 22);
            this.miDirectoryDelete.Text = "Delete";
            this.miDirectoryDelete.Click += new System.EventHandler(this.miDirectoryDelete_Click);
            // 
            // miDirectoryRename
            // 
            this.miDirectoryRename.Image = global::Scada.Admin.App.Properties.Resources.rename;
            this.miDirectoryRename.Name = "miDirectoryRename";
            this.miDirectoryRename.Size = new System.Drawing.Size(219, 22);
            this.miDirectoryRename.Text = "Rename";
            this.miDirectoryRename.Click += new System.EventHandler(this.miDirectoryRename_Click);
            // 
            // miDirectorySep2
            // 
            this.miDirectorySep2.Name = "miDirectorySep2";
            this.miDirectorySep2.Size = new System.Drawing.Size(216, 6);
            // 
            // miDirectoryOpenInExplorer
            // 
            this.miDirectoryOpenInExplorer.Image = global::Scada.Admin.App.Properties.Resources.open_explorer;
            this.miDirectoryOpenInExplorer.Name = "miDirectoryOpenInExplorer";
            this.miDirectoryOpenInExplorer.Size = new System.Drawing.Size(219, 22);
            this.miDirectoryOpenInExplorer.Text = "Open Folder in File Explorer";
            this.miDirectoryOpenInExplorer.Click += new System.EventHandler(this.miDirectoryOpenInExplorer_Click);
            // 
            // miDirectoryRefresh
            // 
            this.miDirectoryRefresh.Image = global::Scada.Admin.App.Properties.Resources.refresh;
            this.miDirectoryRefresh.Name = "miDirectoryRefresh";
            this.miDirectoryRefresh.Size = new System.Drawing.Size(219, 22);
            this.miDirectoryRefresh.Text = "Refresh";
            this.miDirectoryRefresh.Click += new System.EventHandler(this.miDirectoryRefresh_Click);
            // 
            // cmsFileItem
            // 
            this.cmsFileItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileItemOpen,
            this.miFileItemOpenLocation,
            this.miFileItemSep1,
            this.miFileItemDelete,
            this.miFileItemRename});
            this.cmsFileItem.Name = "cmsFileItem";
            this.cmsFileItem.Size = new System.Drawing.Size(233, 98);
            this.cmsFileItem.Opening += new System.ComponentModel.CancelEventHandler(this.cmsFileItem_Opening);
            // 
            // miFileItemOpen
            // 
            this.miFileItemOpen.Image = global::Scada.Admin.App.Properties.Resources.open_file;
            this.miFileItemOpen.Name = "miFileItemOpen";
            this.miFileItemOpen.Size = new System.Drawing.Size(232, 22);
            this.miFileItemOpen.Text = "Open";
            this.miFileItemOpen.Click += new System.EventHandler(this.miFileItemOpen_Click);
            // 
            // miFileItemOpenLocation
            // 
            this.miFileItemOpenLocation.Image = global::Scada.Admin.App.Properties.Resources.open_explorer;
            this.miFileItemOpenLocation.Name = "miFileItemOpenLocation";
            this.miFileItemOpenLocation.Size = new System.Drawing.Size(232, 22);
            this.miFileItemOpenLocation.Text = "Open Location in File Explorer";
            this.miFileItemOpenLocation.Click += new System.EventHandler(this.miFileItemOpenLocation_Click);
            // 
            // miFileItemSep1
            // 
            this.miFileItemSep1.Name = "miFileItemSep1";
            this.miFileItemSep1.Size = new System.Drawing.Size(229, 6);
            // 
            // miFileItemDelete
            // 
            this.miFileItemDelete.Image = global::Scada.Admin.App.Properties.Resources.delete;
            this.miFileItemDelete.Name = "miFileItemDelete";
            this.miFileItemDelete.Size = new System.Drawing.Size(232, 22);
            this.miFileItemDelete.Text = "Delete";
            this.miFileItemDelete.Click += new System.EventHandler(this.miFileItemDelete_Click);
            // 
            // miFileItemRename
            // 
            this.miFileItemRename.Image = global::Scada.Admin.App.Properties.Resources.rename;
            this.miFileItemRename.Name = "miFileItemRename";
            this.miFileItemRename.Size = new System.Drawing.Size(232, 22);
            this.miFileItemRename.Text = "Rename";
            this.miFileItemRename.Click += new System.EventHandler(this.miFileItemRename_Click);
            // 
            // cmsApp
            // 
            this.cmsApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAppOpenInExplorer,
            this.miAppReloadConfig});
            this.cmsApp.Name = "cmsServer";
            this.cmsApp.Size = new System.Drawing.Size(220, 48);
            // 
            // miAppOpenInExplorer
            // 
            this.miAppOpenInExplorer.Image = global::Scada.Admin.App.Properties.Resources.open_explorer;
            this.miAppOpenInExplorer.Name = "miAppOpenInExplorer";
            this.miAppOpenInExplorer.Size = new System.Drawing.Size(219, 22);
            this.miAppOpenInExplorer.Text = "Open Folder in File Explorer";
            this.miAppOpenInExplorer.Click += new System.EventHandler(this.miDirectoryOpenInExplorer_Click);
            // 
            // miAppReloadConfig
            // 
            this.miAppReloadConfig.Image = global::Scada.Admin.App.Properties.Resources.refresh;
            this.miAppReloadConfig.Name = "miAppReloadConfig";
            this.miAppReloadConfig.Size = new System.Drawing.Size(219, 22);
            this.miAppReloadConfig.Text = "Reload Configuration";
            this.miAppReloadConfig.Click += new System.EventHandler(this.miAppReloadConfig_Click);
            // 
            // cmsCnlTable
            // 
            this.cmsCnlTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCnlTableComm,
            this.miCnlTableRefresh});
            this.cmsCnlTable.Name = "cmsChannels";
            this.cmsCnlTable.Size = new System.Drawing.Size(188, 48);
            this.cmsCnlTable.Opening += new System.ComponentModel.CancelEventHandler(this.cmsCnlTable_Opening);
            // 
            // miCnlTableComm
            // 
            this.miCnlTableComm.Image = global::Scada.Admin.App.Properties.Resources.open_explorer;
            this.miCnlTableComm.Name = "miCnlTableComm";
            this.miCnlTableComm.Size = new System.Drawing.Size(187, 22);
            this.miCnlTableComm.Text = "Go to Communicator";
            this.miCnlTableComm.Click += new System.EventHandler(this.miCnlTableComm_Click);
            // 
            // miCnlTableRefresh
            // 
            this.miCnlTableRefresh.Image = global::Scada.Admin.App.Properties.Resources.refresh;
            this.miCnlTableRefresh.Name = "miCnlTableRefresh";
            this.miCnlTableRefresh.Size = new System.Drawing.Size(187, 22);
            this.miCnlTableRefresh.Text = "Refresh";
            this.miCnlTableRefresh.Click += new System.EventHandler(this.miCnlTableRefresh_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.splVert);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMain;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.cmsInstance.ResumeLayout(false);
            this.cmsProject.ResumeLayout(false);
            this.cmsDirectory.ResumeLayout(false);
            this.cmsFileItem.ResumeLayout(false);
            this.cmsApp.ResumeLayout(false);
            this.cmsCnlTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Splitter splVert;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileNewProject;
        private System.Windows.Forms.ToolStripMenuItem miFileOpenProject;
        private System.Windows.Forms.ToolStripMenuItem miFileSave;
        private System.Windows.Forms.ToolStripMenuItem miFileSaveAll;
        private System.Windows.Forms.ToolStripSeparator miFileSep1;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Windows.Forms.ToolStripMenuItem miTools;
        private System.Windows.Forms.ToolStripMenuItem miToolsOptions;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem miHelpDoc;
        private System.Windows.Forms.ToolStripMenuItem miHelpSupport;
        private System.Windows.Forms.ToolStripSeparator miHelpSep1;
        private System.Windows.Forms.ToolStripButton btnFileNewProject;
        private System.Windows.Forms.TreeView tvExplorer;
        private WinControl.WinControl wctrlMain;
        private System.Windows.Forms.ImageList ilExplorer;
        private System.Windows.Forms.OpenFileDialog ofdProject;
        private System.Windows.Forms.ContextMenuStrip cmsInstance;
        private System.Windows.Forms.ToolStripMenuItem miInstanceAdd;
        private System.Windows.Forms.ToolStripMenuItem miInstanceMoveUp;
        private System.Windows.Forms.ToolStripMenuItem miInstanceMoveDown;
        private System.Windows.Forms.ToolStripMenuItem miInstanceDelete;
        private System.Windows.Forms.ToolStripSeparator miInstanceSep1;
        private System.Windows.Forms.ToolStripMenuItem miInstanceRename;
        private System.Windows.Forms.ToolStripMenuItem miInstanceProperties;
        private System.Windows.Forms.ContextMenuStrip cmsProject;
        private System.Windows.Forms.ToolStripMenuItem miProjectRename;
        private System.Windows.Forms.ToolStripMenuItem miProjectProperties;
        private System.Windows.Forms.ContextMenuStrip cmsDirectory;
        private System.Windows.Forms.ToolStripMenuItem miDirectoryNewFile;
        private System.Windows.Forms.ToolStripMenuItem miDirectoryNewFolder;
        private System.Windows.Forms.ToolStripSeparator miDirectorySep1;
        private System.Windows.Forms.ToolStripMenuItem miDirectoryDelete;
        private System.Windows.Forms.ToolStripMenuItem miDirectoryRename;
        private System.Windows.Forms.ToolStripSeparator miDirectorySep2;
        private System.Windows.Forms.ToolStripMenuItem miDirectoryOpenInExplorer;
        private System.Windows.Forms.ContextMenuStrip cmsFileItem;
        private System.Windows.Forms.ToolStripMenuItem miFileItemOpen;
        private System.Windows.Forms.ToolStripMenuItem miFileItemOpenLocation;
        private System.Windows.Forms.ToolStripSeparator miFileItemSep1;
        private System.Windows.Forms.ToolStripMenuItem miFileItemDelete;
        private System.Windows.Forms.ToolStripMenuItem miFileItemRename;
        private System.Windows.Forms.ToolStripMenuItem miDirectoryRefresh;
        private System.Windows.Forms.ToolStripMenuItem miFileClose;
        private System.Windows.Forms.ToolStripMenuItem miFileCloseProject;
        private System.Windows.Forms.ToolStripSeparator miFileSep2;
        private System.Windows.Forms.ToolStripButton btnFileOpenProject;
        private System.Windows.Forms.ToolStripButton btnFileSave;
        private System.Windows.Forms.ToolStripButton btnFileSaveAll;
        private System.Windows.Forms.ToolStripSeparator toolSep1;
        private System.Windows.Forms.ToolStripMenuItem miDeploy;
        private System.Windows.Forms.ToolStripMenuItem miDeployDownloadConfig;
        private System.Windows.Forms.ToolStripMenuItem miDeployUploadConfig;
        private System.Windows.Forms.ToolStripMenuItem miDeployInstanceStatus;
        private System.Windows.Forms.ToolStripSeparator miInstanceSep2;
        private System.Windows.Forms.ToolStripMenuItem miInstanceDownloadConfig;
        private System.Windows.Forms.ToolStripMenuItem miInstanceUploadConfig;
        private System.Windows.Forms.ToolStripMenuItem miInstanceStatus;
        private System.Windows.Forms.ToolStripMenuItem miInstanceProfile;
        private System.Windows.Forms.ToolStripMenuItem miDeployInstanceProfile;
        private System.Windows.Forms.ToolStripMenuItem miProjectOpenInExplorer;
        private System.Windows.Forms.ToolStripMenuItem miInstanceOpenInExplorer;
        private System.Windows.Forms.ContextMenuStrip cmsApp;
        private System.Windows.Forms.ToolStripMenuItem miAppOpenInExplorer;
        private System.Windows.Forms.ToolStripMenuItem miToolsCulture;
        private System.Windows.Forms.ToolStripMenuItem miWindow;
        private System.Windows.Forms.ToolStripMenuItem miWindowCloseActive;
        private System.Windows.Forms.ToolStripMenuItem miWindowCloseAll;
        private System.Windows.Forms.ToolStripMenuItem miWindowCloseAllButActive;
        private System.Windows.Forms.ToolStripMenuItem miFileShowStartPage;
        private System.Windows.Forms.ToolStripSeparator miFileSep3;
        private System.Windows.Forms.ToolStripButton btnDeployInstanceProfile;
        private System.Windows.Forms.ToolStripButton btnDeployDownloadConfig;
        private System.Windows.Forms.ToolStripButton btnDeployUploadConfig;
        private System.Windows.Forms.ToolStripButton btnDeployInstanceStatus;
        private System.Windows.Forms.ContextMenuStrip cmsCnlTable;
        private System.Windows.Forms.ToolStripMenuItem miCnlTableRefresh;
        private System.Windows.Forms.ToolStripMenuItem miCnlTableComm;
        private System.Windows.Forms.ToolStripMenuItem miInstanceOpenInBrowser;
        private System.Windows.Forms.ToolStripStatusLabel lblSelectedInstance;
        private System.Windows.Forms.ToolStripStatusLabel lblSelectedProfile;
        private System.Windows.Forms.ToolStripMenuItem miAppReloadConfig;
    }
}


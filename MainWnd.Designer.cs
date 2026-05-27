namespace Asm68000
{
  partial class MainWnd
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
      this.mnuMainWnd = new System.Windows.Forms.MenuStrip();
      this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSaveAll = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileCloseAll = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditComment = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditUnComment = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuEditFixTabs = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuEditFind = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditFindNext = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuActions = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuActionCompile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuActionRun = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuActionClearPrevios = new System.Windows.Forms.ToolStripMenuItem();
      this.statusMainWnd = new System.Windows.Forms.StatusStrip();
      this.tabCtrlLeft = new System.Windows.Forms.TabControl();
      this.mnuTextCtrl = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuTextCtrlOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuTextCtrlSave = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuTextCtrlSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuTextCtrlClose = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuTextCtrlCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuTextCtrlCut = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuTextCtrlPaste = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuTextCtrlCompile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuTextCtrlRun = new System.Windows.Forms.ToolStripMenuItem();
      this.tabPHL = new System.Windows.Forms.TabPage();
      this.txtFeedback = new System.Windows.Forms.TextBox();
      this.splitMain = new System.Windows.Forms.SplitContainer();
      this.splitEdit = new System.Windows.Forms.SplitContainer();
      this.tabCtrlRight = new System.Windows.Forms.TabControl();
      this.tabPHR = new System.Windows.Forms.TabPage();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuTextCtrlNew = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuMainWnd.SuspendLayout();
      this.tabCtrlLeft.SuspendLayout();
      this.mnuTextCtrl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
      this.splitMain.Panel1.SuspendLayout();
      this.splitMain.Panel2.SuspendLayout();
      this.splitMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitEdit)).BeginInit();
      this.splitEdit.Panel1.SuspendLayout();
      this.splitEdit.Panel2.SuspendLayout();
      this.splitEdit.SuspendLayout();
      this.tabCtrlRight.SuspendLayout();
      this.SuspendLayout();
      // 
      // mnuMainWnd
      // 
      this.mnuMainWnd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuActions});
      this.mnuMainWnd.Location = new System.Drawing.Point(0, 0);
      this.mnuMainWnd.Name = "mnuMainWnd";
      this.mnuMainWnd.Size = new System.Drawing.Size(1163, 24);
      this.mnuMainWnd.TabIndex = 0;
      this.mnuMainWnd.Text = "menuStrip1";
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.toolStripSeparator1,
            this.mnuFileOpen,
            this.toolStripSeparator2,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileSaveAll,
            this.toolStripMenuItem1,
            this.mnuFileClose,
            this.mnuFileCloseAll,
            this.toolStripMenuItem2,
            this.mnuFileExit});
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(37, 20);
      this.mnuFile.Text = "File";
      this.mnuFile.DropDownOpening += new System.EventHandler(this.mnuFile_DropDownOpening);
      // 
      // mnuFileNew
      // 
      this.mnuFileNew.Name = "mnuFileNew";
      this.mnuFileNew.Size = new System.Drawing.Size(180, 22);
      this.mnuFileNew.Text = "New";
      this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
      // 
      // mnuFileOpen
      // 
      this.mnuFileOpen.Name = "mnuFileOpen";
      this.mnuFileOpen.Size = new System.Drawing.Size(180, 22);
      this.mnuFileOpen.Text = "Open";
      this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
      // 
      // mnuFileSave
      // 
      this.mnuFileSave.Name = "mnuFileSave";
      this.mnuFileSave.Size = new System.Drawing.Size(180, 22);
      this.mnuFileSave.Text = "Save";
      this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
      // 
      // mnuFileSaveAs
      // 
      this.mnuFileSaveAs.Name = "mnuFileSaveAs";
      this.mnuFileSaveAs.Size = new System.Drawing.Size(180, 22);
      this.mnuFileSaveAs.Text = "Save As";
      this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
      // 
      // mnuFileSaveAll
      // 
      this.mnuFileSaveAll.Name = "mnuFileSaveAll";
      this.mnuFileSaveAll.Size = new System.Drawing.Size(180, 22);
      this.mnuFileSaveAll.Text = "Save All";
      this.mnuFileSaveAll.Click += new System.EventHandler(this.mnuFileSaveAll_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
      // 
      // mnuFileClose
      // 
      this.mnuFileClose.Name = "mnuFileClose";
      this.mnuFileClose.Size = new System.Drawing.Size(180, 22);
      this.mnuFileClose.Text = "Close";
      this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
      // 
      // mnuFileCloseAll
      // 
      this.mnuFileCloseAll.Name = "mnuFileCloseAll";
      this.mnuFileCloseAll.Size = new System.Drawing.Size(180, 22);
      this.mnuFileCloseAll.Text = "Close All";
      this.mnuFileCloseAll.Click += new System.EventHandler(this.mnuFileCloseAll_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
      // 
      // mnuFileExit
      // 
      this.mnuFileExit.Name = "mnuFileExit";
      this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
      this.mnuFileExit.Text = "Exit";
      this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
      // 
      // mnuEdit
      // 
      this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditComment,
            this.mnuEditUnComment,
            this.toolStripMenuItem4,
            this.mnuEditFixTabs,
            this.toolStripMenuItem5,
            this.mnuEditFind,
            this.mnuEditFindNext,
            this.toolStripMenuItem6,
            this.mnuEditCopy,
            this.mnuEditCut,
            this.mnuEditPaste});
      this.mnuEdit.Name = "mnuEdit";
      this.mnuEdit.Size = new System.Drawing.Size(39, 20);
      this.mnuEdit.Text = "Edit";
      // 
      // mnuEditComment
      // 
      this.mnuEditComment.Name = "mnuEditComment";
      this.mnuEditComment.Size = new System.Drawing.Size(199, 22);
      this.mnuEditComment.Text = "Comment Selection";
      this.mnuEditComment.Click += new System.EventHandler(this.mnuEditComment_Click);
      // 
      // mnuEditUnComment
      // 
      this.mnuEditUnComment.Name = "mnuEditUnComment";
      this.mnuEditUnComment.Size = new System.Drawing.Size(199, 22);
      this.mnuEditUnComment.Text = "Un-Comment Selection";
      this.mnuEditUnComment.Click += new System.EventHandler(this.mnuEditUnComment_Click);
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(196, 6);
      // 
      // mnuEditFixTabs
      // 
      this.mnuEditFixTabs.Name = "mnuEditFixTabs";
      this.mnuEditFixTabs.Size = new System.Drawing.Size(199, 22);
      this.mnuEditFixTabs.Text = "Fix Tabs";
      this.mnuEditFixTabs.Click += new System.EventHandler(this.mnuEditFixTabs_Click);
      // 
      // toolStripMenuItem5
      // 
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new System.Drawing.Size(196, 6);
      // 
      // mnuEditFind
      // 
      this.mnuEditFind.Name = "mnuEditFind";
      this.mnuEditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
      this.mnuEditFind.Size = new System.Drawing.Size(199, 22);
      this.mnuEditFind.Text = "Find";
      this.mnuEditFind.Click += new System.EventHandler(this.mnuEditFind_Click);
      // 
      // mnuEditFindNext
      // 
      this.mnuEditFindNext.Name = "mnuEditFindNext";
      this.mnuEditFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
      this.mnuEditFindNext.Size = new System.Drawing.Size(199, 22);
      this.mnuEditFindNext.Text = "Find Next";
      this.mnuEditFindNext.Click += new System.EventHandler(this.mnuEditFindNext_Click);
      // 
      // toolStripMenuItem6
      // 
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.Size = new System.Drawing.Size(196, 6);
      // 
      // mnuEditCopy
      // 
      this.mnuEditCopy.Name = "mnuEditCopy";
      this.mnuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.mnuEditCopy.Size = new System.Drawing.Size(199, 22);
      this.mnuEditCopy.Text = "Copy";
      this.mnuEditCopy.Click += new System.EventHandler(this.mnuEditCopy_Click);
      // 
      // mnuEditCut
      // 
      this.mnuEditCut.Name = "mnuEditCut";
      this.mnuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.mnuEditCut.Size = new System.Drawing.Size(199, 22);
      this.mnuEditCut.Text = "Cut";
      this.mnuEditCut.Click += new System.EventHandler(this.mnuEditCut_Click);
      // 
      // mnuEditPaste
      // 
      this.mnuEditPaste.Name = "mnuEditPaste";
      this.mnuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.mnuEditPaste.Size = new System.Drawing.Size(199, 22);
      this.mnuEditPaste.Text = "Paste";
      this.mnuEditPaste.Click += new System.EventHandler(this.mnuEditPaste_Click);
      // 
      // mnuActions
      // 
      this.mnuActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuActionCompile,
            this.mnuActionRun,
            this.toolStripMenuItem9,
            this.mnuActionClearPrevios});
      this.mnuActions.Name = "mnuActions";
      this.mnuActions.Size = new System.Drawing.Size(54, 20);
      this.mnuActions.Text = "Action";
      // 
      // mnuActionCompile
      // 
      this.mnuActionCompile.Name = "mnuActionCompile";
      this.mnuActionCompile.Size = new System.Drawing.Size(183, 22);
      this.mnuActionCompile.Text = "Compile";
      this.mnuActionCompile.Click += new System.EventHandler(this.mnuActionCompile_Click);
      // 
      // mnuActionRun
      // 
      this.mnuActionRun.Name = "mnuActionRun";
      this.mnuActionRun.ShortcutKeys = System.Windows.Forms.Keys.F5;
      this.mnuActionRun.Size = new System.Drawing.Size(183, 22);
      this.mnuActionRun.Text = "Run";
      this.mnuActionRun.Click += new System.EventHandler(this.mnuActionRun_Click);
      // 
      // toolStripMenuItem9
      // 
      this.toolStripMenuItem9.Name = "toolStripMenuItem9";
      this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 6);
      // 
      // mnuActionClearPrevios
      // 
      this.mnuActionClearPrevios.Name = "mnuActionClearPrevios";
      this.mnuActionClearPrevios.Size = new System.Drawing.Size(183, 22);
      this.mnuActionClearPrevios.Text = "Clear Previous Menu";
      this.mnuActionClearPrevios.Click += new System.EventHandler(this.mnuActionClearPrevious_Click);
      // 
      // statusMainWnd
      // 
      this.statusMainWnd.Location = new System.Drawing.Point(0, 661);
      this.statusMainWnd.Name = "statusMainWnd";
      this.statusMainWnd.Size = new System.Drawing.Size(1163, 22);
      this.statusMainWnd.TabIndex = 2;
      this.statusMainWnd.Text = "statusStrip1";
      // 
      // tabCtrlLeft
      // 
      this.tabCtrlLeft.ContextMenuStrip = this.mnuTextCtrl;
      this.tabCtrlLeft.Controls.Add(this.tabPHL);
      this.tabCtrlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabCtrlLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabCtrlLeft.Location = new System.Drawing.Point(0, 0);
      this.tabCtrlLeft.Name = "tabCtrlLeft";
      this.tabCtrlLeft.SelectedIndex = 0;
      this.tabCtrlLeft.Size = new System.Drawing.Size(612, 509);
      this.tabCtrlLeft.TabIndex = 3;
      this.tabCtrlLeft.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCtrlLeft_Selected);
      this.tabCtrlLeft.Click += new System.EventHandler(this.tabCtrlLeft_Click);
      // 
      // mnuTextCtrl
      // 
      this.mnuTextCtrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTextCtrlNew,
            this.toolStripSeparator3,
            this.mnuTextCtrlOpen,
            this.mnuTextCtrlSave,
            this.mnuTextCtrlSaveAs,
            this.toolStripMenuItem3,
            this.mnuTextCtrlClose,
            this.toolStripMenuItem7,
            this.mnuTextCtrlCopy,
            this.mnuTextCtrlCut,
            this.mnuTextCtrlPaste,
            this.toolStripMenuItem8,
            this.mnuTextCtrlCompile,
            this.mnuTextCtrlRun});
      this.mnuTextCtrl.Name = "mnuTextCtrl";
      this.mnuTextCtrl.Size = new System.Drawing.Size(181, 270);
      this.mnuTextCtrl.Opening += new System.ComponentModel.CancelEventHandler(this.mnuTextCtrl_Opening);
      // 
      // mnuTextCtrlOpen
      // 
      this.mnuTextCtrlOpen.Name = "mnuTextCtrlOpen";
      this.mnuTextCtrlOpen.Size = new System.Drawing.Size(180, 22);
      this.mnuTextCtrlOpen.Text = "Open";
      this.mnuTextCtrlOpen.Click += new System.EventHandler(this.mnuTextCtrlOpen_Click);
      // 
      // mnuTextCtrlSave
      // 
      this.mnuTextCtrlSave.Name = "mnuTextCtrlSave";
      this.mnuTextCtrlSave.Size = new System.Drawing.Size(180, 22);
      this.mnuTextCtrlSave.Text = "Save";
      this.mnuTextCtrlSave.Click += new System.EventHandler(this.mnuTextCtrlSave_Click);
      // 
      // mnuTextCtrlSaveAs
      // 
      this.mnuTextCtrlSaveAs.Name = "mnuTextCtrlSaveAs";
      this.mnuTextCtrlSaveAs.Size = new System.Drawing.Size(180, 22);
      this.mnuTextCtrlSaveAs.Text = "Save As";
      this.mnuTextCtrlSaveAs.Click += new System.EventHandler(this.mnuTextCtrlSaveAs_Click);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
      // 
      // mnuTextCtrlClose
      // 
      this.mnuTextCtrlClose.Name = "mnuTextCtrlClose";
      this.mnuTextCtrlClose.Size = new System.Drawing.Size(180, 22);
      this.mnuTextCtrlClose.Text = "Close";
      this.mnuTextCtrlClose.Click += new System.EventHandler(this.mnuTextCtrlClose_Click);
      // 
      // toolStripMenuItem7
      // 
      this.toolStripMenuItem7.Name = "toolStripMenuItem7";
      this.toolStripMenuItem7.Size = new System.Drawing.Size(177, 6);
      // 
      // mnuTextCtrlCopy
      // 
      this.mnuTextCtrlCopy.Name = "mnuTextCtrlCopy";
      this.mnuTextCtrlCopy.Size = new System.Drawing.Size(180, 22);
      this.mnuTextCtrlCopy.Text = "Copy";
      this.mnuTextCtrlCopy.Click += new System.EventHandler(this.mnuTextCtrlCopy_Click);
      // 
      // mnuTextCtrlCut
      // 
      this.mnuTextCtrlCut.Name = "mnuTextCtrlCut";
      this.mnuTextCtrlCut.Size = new System.Drawing.Size(180, 22);
      this.mnuTextCtrlCut.Text = "Cut";
      this.mnuTextCtrlCut.Click += new System.EventHandler(this.mnuTextCtrlCut_Click);
      // 
      // mnuTextCtrlPaste
      // 
      this.mnuTextCtrlPaste.Name = "mnuTextCtrlPaste";
      this.mnuTextCtrlPaste.Size = new System.Drawing.Size(180, 22);
      this.mnuTextCtrlPaste.Text = "Paste";
      this.mnuTextCtrlPaste.Click += new System.EventHandler(this.mnuTextCtrlPaste_Click);
      // 
      // toolStripMenuItem8
      // 
      this.toolStripMenuItem8.Name = "toolStripMenuItem8";
      this.toolStripMenuItem8.Size = new System.Drawing.Size(177, 6);
      // 
      // mnuTextCtrlCompile
      // 
      this.mnuTextCtrlCompile.Name = "mnuTextCtrlCompile";
      this.mnuTextCtrlCompile.Size = new System.Drawing.Size(180, 22);
      this.mnuTextCtrlCompile.Text = "Compile";
      this.mnuTextCtrlCompile.Click += new System.EventHandler(this.mnuTextCtrlCompile_Click);
      // 
      // mnuTextCtrlRun
      // 
      this.mnuTextCtrlRun.Name = "mnuTextCtrlRun";
      this.mnuTextCtrlRun.Size = new System.Drawing.Size(180, 22);
      this.mnuTextCtrlRun.Text = "Run";
      this.mnuTextCtrlRun.Click += new System.EventHandler(this.mnuTextCtrlRun_Click);
      // 
      // tabPHL
      // 
      this.tabPHL.Location = new System.Drawing.Point(4, 27);
      this.tabPHL.Name = "tabPHL";
      this.tabPHL.Size = new System.Drawing.Size(604, 478);
      this.tabPHL.TabIndex = 0;
      this.tabPHL.Text = "Left PH";
      this.tabPHL.UseVisualStyleBackColor = true;
      // 
      // txtFeedback
      // 
      this.txtFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFeedback.Location = new System.Drawing.Point(0, 0);
      this.txtFeedback.Multiline = true;
      this.txtFeedback.Name = "txtFeedback";
      this.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtFeedback.Size = new System.Drawing.Size(1163, 124);
      this.txtFeedback.TabIndex = 4;
      this.txtFeedback.WordWrap = false;
      this.txtFeedback.DoubleClick += new System.EventHandler(this.txtFeedback_DoubleClick);
      // 
      // splitMain
      // 
      this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitMain.Location = new System.Drawing.Point(0, 24);
      this.splitMain.Name = "splitMain";
      this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitMain.Panel1
      // 
      this.splitMain.Panel1.Controls.Add(this.splitEdit);
      // 
      // splitMain.Panel2
      // 
      this.splitMain.Panel2.Controls.Add(this.txtFeedback);
      this.splitMain.Size = new System.Drawing.Size(1163, 637);
      this.splitMain.SplitterDistance = 509;
      this.splitMain.TabIndex = 5;
      this.splitMain.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitMain_SplitterMoved);
      // 
      // splitEdit
      // 
      this.splitEdit.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitEdit.Location = new System.Drawing.Point(0, 0);
      this.splitEdit.Name = "splitEdit";
      // 
      // splitEdit.Panel1
      // 
      this.splitEdit.Panel1.Controls.Add(this.tabCtrlLeft);
      // 
      // splitEdit.Panel2
      // 
      this.splitEdit.Panel2.Controls.Add(this.tabCtrlRight);
      this.splitEdit.Size = new System.Drawing.Size(1163, 509);
      this.splitEdit.SplitterDistance = 612;
      this.splitEdit.TabIndex = 0;
      this.splitEdit.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitEdit_SplitterMoved);
      // 
      // tabCtrlRight
      // 
      this.tabCtrlRight.ContextMenuStrip = this.mnuTextCtrl;
      this.tabCtrlRight.Controls.Add(this.tabPHR);
      this.tabCtrlRight.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabCtrlRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabCtrlRight.Location = new System.Drawing.Point(0, 0);
      this.tabCtrlRight.Name = "tabCtrlRight";
      this.tabCtrlRight.SelectedIndex = 0;
      this.tabCtrlRight.Size = new System.Drawing.Size(547, 509);
      this.tabCtrlRight.TabIndex = 4;
      this.tabCtrlRight.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCtrlRight_Selected);
      this.tabCtrlRight.Click += new System.EventHandler(this.tabCtrlRight_Click);
      // 
      // tabPHR
      // 
      this.tabPHR.Location = new System.Drawing.Point(4, 27);
      this.tabPHR.Name = "tabPHR";
      this.tabPHR.Size = new System.Drawing.Size(539, 478);
      this.tabPHR.TabIndex = 0;
      this.tabPHR.Text = "Right PH";
      this.tabPHR.UseVisualStyleBackColor = true;
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
      // 
      // mnuTextCtrlNew
      // 
      this.mnuTextCtrlNew.Name = "mnuTextCtrlNew";
      this.mnuTextCtrlNew.Size = new System.Drawing.Size(180, 22);
      this.mnuTextCtrlNew.Text = "New";
      this.mnuTextCtrlNew.Click += new System.EventHandler(this.mnuTextCtrlNew_Click);
      // 
      // MainWnd
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1163, 683);
      this.Controls.Add(this.splitMain);
      this.Controls.Add(this.statusMainWnd);
      this.Controls.Add(this.mnuMainWnd);
      this.DoubleBuffered = true;
      this.MainMenuStrip = this.mnuMainWnd;
      this.Name = "MainWnd";
      this.Text = "68000";
      this.mnuMainWnd.ResumeLayout(false);
      this.mnuMainWnd.PerformLayout();
      this.tabCtrlLeft.ResumeLayout(false);
      this.mnuTextCtrl.ResumeLayout(false);
      this.splitMain.Panel1.ResumeLayout(false);
      this.splitMain.Panel2.ResumeLayout(false);
      this.splitMain.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
      this.splitMain.ResumeLayout(false);
      this.splitEdit.Panel1.ResumeLayout(false);
      this.splitEdit.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitEdit)).EndInit();
      this.splitEdit.ResumeLayout(false);
      this.tabCtrlRight.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mnuMainWnd;
    private System.Windows.Forms.StatusStrip statusMainWnd;
    private System.Windows.Forms.TabControl tabCtrlLeft;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
    private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
    private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
    private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAll;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
    private System.Windows.Forms.ToolStripMenuItem mnuFileCloseAll;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
    private System.Windows.Forms.ToolStripMenuItem mnuEdit;
    private System.Windows.Forms.ToolStripMenuItem mnuActions;
    private System.Windows.Forms.ToolStripMenuItem mnuActionCompile;
    private System.Windows.Forms.ToolStripMenuItem mnuActionRun;
    private System.Windows.Forms.ToolStripMenuItem mnuEditComment;
    private System.Windows.Forms.ToolStripMenuItem mnuEditUnComment;
    private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem mnuEditFixTabs;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
    private System.Windows.Forms.ToolStripMenuItem mnuEditFind;
    private System.Windows.Forms.ToolStripMenuItem mnuEditFindNext;
    private System.Windows.Forms.TextBox txtFeedback;
    private System.Windows.Forms.SplitContainer splitMain;
    private System.Windows.Forms.SplitContainer splitEdit;
    private System.Windows.Forms.TabControl tabCtrlRight;
    private System.Windows.Forms.TabPage tabPHL;
    private System.Windows.Forms.TabPage tabPHR;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
    private System.Windows.Forms.ToolStripMenuItem mnuEditCopy;
    private System.Windows.Forms.ToolStripMenuItem mnuEditPaste;
    private System.Windows.Forms.ToolStripMenuItem mnuEditCut;
    private System.Windows.Forms.ContextMenuStrip mnuTextCtrl;
    private System.Windows.Forms.ToolStripMenuItem mnuTextCtrlOpen;
    private System.Windows.Forms.ToolStripMenuItem mnuTextCtrlSave;
    private System.Windows.Forms.ToolStripMenuItem mnuTextCtrlSaveAs;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem mnuTextCtrlClose;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
    private System.Windows.Forms.ToolStripMenuItem mnuTextCtrlCopy;
    private System.Windows.Forms.ToolStripMenuItem mnuTextCtrlCut;
    private System.Windows.Forms.ToolStripMenuItem mnuTextCtrlPaste;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
    private System.Windows.Forms.ToolStripMenuItem mnuTextCtrlCompile;
    private System.Windows.Forms.ToolStripMenuItem mnuTextCtrlRun;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
    private System.Windows.Forms.ToolStripMenuItem mnuActionClearPrevios;
    private System.Windows.Forms.ToolStripMenuItem mnuTextCtrlNew;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
  }
}


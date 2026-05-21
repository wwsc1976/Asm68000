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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
      this.mnuActions = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuActionCompile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuActionRun = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tabCtrlLeft = new System.Windows.Forms.TabControl();
      this.tabPHL = new System.Windows.Forms.TabPage();
      this.mnuTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuTextBoxClose = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.txtFeedback = new System.Windows.Forms.TextBox();
      this.splitMain = new System.Windows.Forms.SplitContainer();
      this.splitEdit = new System.Windows.Forms.SplitContainer();
      this.tabCtrlRight = new System.Windows.Forms.TabControl();
      this.tabPHR = new System.Windows.Forms.TabPage();
      this.menuStrip1.SuspendLayout();
      this.tabCtrlLeft.SuspendLayout();
      this.mnuTextBox.SuspendLayout();
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
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuActions});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1163, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
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
      // 
      // mnuFileNew
      // 
      this.mnuFileNew.Name = "mnuFileNew";
      this.mnuFileNew.Size = new System.Drawing.Size(120, 22);
      this.mnuFileNew.Text = "New";
      this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
      // 
      // mnuFileOpen
      // 
      this.mnuFileOpen.Name = "mnuFileOpen";
      this.mnuFileOpen.Size = new System.Drawing.Size(120, 22);
      this.mnuFileOpen.Text = "Open";
      this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(117, 6);
      // 
      // mnuFileSave
      // 
      this.mnuFileSave.Name = "mnuFileSave";
      this.mnuFileSave.Size = new System.Drawing.Size(120, 22);
      this.mnuFileSave.Text = "Save";
      this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
      // 
      // mnuFileSaveAs
      // 
      this.mnuFileSaveAs.Name = "mnuFileSaveAs";
      this.mnuFileSaveAs.Size = new System.Drawing.Size(120, 22);
      this.mnuFileSaveAs.Text = "Save As";
      this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
      // 
      // mnuFileSaveAll
      // 
      this.mnuFileSaveAll.Name = "mnuFileSaveAll";
      this.mnuFileSaveAll.Size = new System.Drawing.Size(120, 22);
      this.mnuFileSaveAll.Text = "Save All";
      this.mnuFileSaveAll.Click += new System.EventHandler(this.mnuFileSaveAll_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
      // 
      // mnuFileClose
      // 
      this.mnuFileClose.Name = "mnuFileClose";
      this.mnuFileClose.Size = new System.Drawing.Size(120, 22);
      this.mnuFileClose.Text = "Close";
      this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
      // 
      // mnuFileCloseAll
      // 
      this.mnuFileCloseAll.Name = "mnuFileCloseAll";
      this.mnuFileCloseAll.Size = new System.Drawing.Size(120, 22);
      this.mnuFileCloseAll.Text = "Close All";
      this.mnuFileCloseAll.Click += new System.EventHandler(this.mnuFileCloseAll_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 6);
      // 
      // mnuFileExit
      // 
      this.mnuFileExit.Name = "mnuFileExit";
      this.mnuFileExit.Size = new System.Drawing.Size(120, 22);
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
            this.mnuEditFindNext});
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
      // mnuActions
      // 
      this.mnuActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuActionCompile,
            this.mnuActionRun});
      this.mnuActions.Name = "mnuActions";
      this.mnuActions.Size = new System.Drawing.Size(54, 20);
      this.mnuActions.Text = "Action";
      // 
      // mnuActionCompile
      // 
      this.mnuActionCompile.Name = "mnuActionCompile";
      this.mnuActionCompile.Size = new System.Drawing.Size(180, 22);
      this.mnuActionCompile.Text = "Compile";
      this.mnuActionCompile.Click += new System.EventHandler(this.mnuActionCompile_Click);
      // 
      // mnuActionRun
      // 
      this.mnuActionRun.Name = "mnuActionRun";
      this.mnuActionRun.Size = new System.Drawing.Size(180, 22);
      this.mnuActionRun.Text = "Run";
      this.mnuActionRun.Click += new System.EventHandler(this.mnuActionRun_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 661);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1163, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tabCtrlLeft
      // 
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
      // tabPHL
      // 
      this.tabPHL.Location = new System.Drawing.Point(4, 27);
      this.tabPHL.Name = "tabPHL";
      this.tabPHL.Size = new System.Drawing.Size(604, 478);
      this.tabPHL.TabIndex = 0;
      this.tabPHL.Text = "Left PH";
      this.tabPHL.UseVisualStyleBackColor = true;
      // 
      // mnuTextBox
      // 
      this.mnuTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTextBoxClose,
            this.toolStripMenuItem3});
      this.mnuTextBox.Name = "contextMenuStrip1";
      this.mnuTextBox.Size = new System.Drawing.Size(104, 32);
      // 
      // mnuTextBoxClose
      // 
      this.mnuTextBoxClose.Name = "mnuTextBoxClose";
      this.mnuTextBoxClose.Size = new System.Drawing.Size(103, 22);
      this.mnuTextBoxClose.Text = "Close";
      this.mnuTextBoxClose.Click += new System.EventHandler(this.mnuTextBoxClose_Click);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 6);
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
      // MainWnd
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1163, 683);
      this.Controls.Add(this.splitMain);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.DoubleBuffered = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainWnd";
      this.Text = "68000";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabCtrlLeft.ResumeLayout(false);
      this.mnuTextBox.ResumeLayout(false);
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

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.StatusStrip statusStrip1;
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
    private System.Windows.Forms.ContextMenuStrip mnuTextBox;
    private System.Windows.Forms.ToolStripMenuItem mnuTextBoxClose;
    private System.Windows.Forms.ToolStripMenuItem mnuActions;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
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
  }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Asm68000
{
public partial class MainWnd : Form
{
 public enum TabFocus { Left, Right };

 public static ApplicationSettings Settings = new ApplicationSettings("Asm68000");
 public static Font TextFont = new Font(FontFamily.GenericMonospace, 12, FontStyle.Regular);
 public static Color TextBackColor = Color.FromArgb(10,10,20);
 public static Color TextForeColor = Color.White;

 public static string LastDirectory = Settings.GetString("LastDirectory");

 public Dictionary<string,DateTime> m_Previous = new Dictionary<string, DateTime>();
 
 public static TabFocus WhichTab = MainWnd.TabFocus.Left;

 private bool m_Ready;

public MainWnd()
{
 DateTime dt;
 ToolStripMenuItem menu;
 string s;
 Point pt;
 Size sz;
 bool maxi;
 int i, c;

 InitializeComponent();

 maxi = Settings.GetBool("Maximized", false);

 if (maxi == true)
    WindowState = FormWindowState.Maximized;
 else
  {
  StartPosition = FormStartPosition.Manual;
  pt = new Point(Settings.GetInt("MainWndX", 100), Settings.GetInt("MainWndY", 100));
  sz = new Size(Settings.GetInt("MainWndW", 600), Settings.GetInt("MainWndH", 400));
  Location = pt;
  Size = sz;
  }

 c = Settings.GetInt("PreviousCount");
 if (c > 0)
    mnuFile.DropDownItems.Add(new ToolStripSeparator());
 for(i = 1; i <= c; i++)
  {
   s = Settings.GetString("Previous_" + i.ToString(), "");
   dt = Settings.GetDate("Previous_Date_" + i.ToString(), DateTime.Now);
   menu = new ToolStripMenuItem();
   menu.Text = s;
   menu.Click += new EventHandler(mnuPrevious_Click);
   mnuFile.DropDownItems.Add(menu);
   m_Previous.Add(s, dt);
  }
 m_Ready = false;
}

protected override void OnActivated(EventArgs e)
{
 base.OnActivated(e);
 if (m_Ready == false)
  {
   splitMain.SplitterDistance = Settings.GetInt("SplitMain");
   splitEdit.SplitterDistance = Settings.GetInt("SplitEdit");
   DoSize();
   m_Ready = true;
  }
}

protected override void OnSizeChanged(EventArgs e)
{
 base.OnSizeChanged(e);
 DoSize();
}

private void DoSize()
{
}

protected override void OnClosing(CancelEventArgs e)
{
 PanelEditor pnl;
 bool success = true;

 base.OnClosing(e);
 
 foreach(TabPage tb in tabCtrlLeft.TabPages)
  {
   if (tb.Controls.Count > 0)
    {
     pnl = (PanelEditor)tb.Controls[0];
     if (ActionCloseFile(tabCtrlLeft, pnl) == false)
       success = false;
    }
  }
 foreach(TabPage tpa in tabCtrlRight.TabPages)
  {
   if (tpa.Controls.Count > 0)
    {
     pnl = (PanelEditor)tpa.Controls[0];
     if (ActionCloseFile(tabCtrlRight, pnl) == false)
       success = false;
    }
  }
 if (success == true)
  {
   if (WindowState == FormWindowState.Maximized)
    {
     Settings.SaveSetting("Maximized", true);
    }
   else
    {
     Settings.SaveSetting("Maximized", false);
     Settings.SaveSetting("MainWndX", Location.X);
     Settings.SaveSetting("MainWndY", Location.Y);
     Settings.SaveSetting("MainWndW", Size.Width);
     Settings.SaveSetting("MainWndH", Size.Height);
    }
   Settings.SaveSetting("SplitMain", splitMain.SplitterDistance);
   Settings.SaveSetting("SplitEdit", splitEdit.SplitterDistance);
  }
 else
  {
   e.Cancel = !success;
  }

}

private void ActionOpenFile(string path)
{
 ToolStripMenuItem menu;
 TabControl tabCtrl;
 DateTime created = DateTime.MinValue;
 DateTime modified = DateTime.MinValue;
 TabPage tp;
 PanelEditor tpa;
 StreamReader read = null;
 int i, c;

 if (path.Length > 0)
  {
   try
    {
     read = new StreamReader(path);
    }
   catch(System.IO.IOException ex)
    {
     MessageBox.Show("Error: " + ex.Message);
     return;
    }
  }

 switch(WhichTab)
  {
   case TabFocus.Left: tabCtrl = tabCtrlLeft; break;
   case TabFocus.Right: tabCtrl = tabCtrlRight; break;
   default: throw new Exception("huh?");
  }


 if (tabCtrl.TabPages[0].Controls.Count == 0)
   tabCtrl.TabPages.Clear();

 tp = new TabPage();

 tpa = new PanelEditor(WhichTab, tp, path, created, modified, mnuTextCtrl);

 if (read != null)
  {
   tpa.TextCtrl.Text = read.ReadToEnd();
   read.Close();  
   read.Dispose();
   tpa.AlterFlag = false;
  }

 tp.Controls.Add(tpa);
 tabCtrl.TabPages.Add(tp);

 tabCtrl.SelectedIndex = tabCtrl.TabPages.Count - 1;

 if (m_Previous.ContainsKey(tpa.Path) == false)
  {
   if (m_Previous.Count >= 8)
    {
     ActionDeleteOldestPrevious();
    }
   m_Previous.Add(tpa.Path, DateTime.Now);
   menu = new ToolStripMenuItem();
   menu.Text = tpa.Path;
   menu.Click += new EventHandler(mnuPrevious_Click);
   mnuFile.DropDownItems.Add(menu);
   c = m_Previous.Count;
   Settings.SaveSetting("PreviousCount", c);
   i = 1;
   foreach(string key in m_Previous.Keys)
    {
     Settings.SaveSetting("Previous_" + i.ToString(), key);
     Settings.SaveSetting("Previous_Date_" + i, m_Previous[key]); 
     i++;
    }
  }
}

private bool ActionCloseFile(TabControl tab, PanelEditor tpa)
{
 bool success = false;

 if (tpa.AlterFlag == false)
  {
   success = true;
  }
 else
  {
   switch(MessageBox.Show(this, "Save " + tpa.Text + " before closing?", "Close File", MessageBoxButtons.YesNoCancel))
    {
     case DialogResult.Yes:
      {
       success = tpa.Save();
      } break;
     case DialogResult.No:
      {
       success = true;
      } break;
     case DialogResult.Cancel:
      {
       return false;
      } 
     default: throw new Exception("msg box error");
    }
  }
 if (success == true)
  {
   tab.TabPages.RemoveAt(tab.SelectedIndex);
   if (tab.TabPages.Count == 0)
    {
     switch(WhichTab)
      {
       case TabFocus.Left: tab.TabPages.Add("Left PH"); break;
       case TabFocus.Right: tab.TabPages.Add("Right PH"); break;
       default: throw new Exception("huh?");
      }
    }
  }
 return success;
}

private void ActionDeleteOldestPrevious()
{
 List<PreviousItem> list = new List<PreviousItem>();

 foreach(string key in m_Previous.Keys)
  {
   list.Add(new PreviousItem(key, m_Previous[key]));
  }
 list.Sort(new PreviousSort());
 m_Previous.Remove(list[0].Path);
}

private class PreviousItem
{
 public string Path;
 public DateTime Opened;

public PreviousItem(string path, DateTime opened)
{
 Path = path;
 Opened = opened;
}
}

private class PreviousSort : IComparer<PreviousItem>
{
 public int Compare(PreviousItem x, PreviousItem y)  // sort Desc
 {
  if (x.Opened < y.Opened) return 1;
  if (x.Opened > y.Opened) return -1;
  return 0;
 }
}

private void AlignText()
{
 // what was this for?
}

public PanelEditor GetCurrentPanel()
{
 TabControl tab;
 PanelEditor tpa = null;

 switch(WhichTab)
  {
   case TabFocus.Left: tab = tabCtrlLeft; break;
   case TabFocus.Right: tab = tabCtrlRight; break;
   default: throw new Exception("huh?");
  }

 if (tab.TabPages.Count == 0)
   return null;

 if (tab.TabPages[tab.SelectedIndex].Controls.Count == 0)
   return null;

 tpa = (PanelEditor)tab.TabPages[tabCtrlLeft.SelectedIndex].Controls[0];

 return tpa;
}

// //////////////////// Events

private void mnuPrevious_Click(object sender, EventArgs e)
{
 string file = ((ToolStripMenuItem)sender).Text;
 ActionOpenFile(file);
}

private void mnuFileNew_Click(object sender, EventArgs e)
{
 TabControl tabCtrl;

 switch(WhichTab)
  {
   case TabFocus.Left: tabCtrl = tabCtrlLeft; break;
   case TabFocus.Right: tabCtrl = tabCtrlRight; break;
   default: throw new Exception("huh?");
  }
 ActionOpenFile("");
}

private void mnuFileOpen_Click(object sender, EventArgs e)
{
 OpenFileDialog dlg;

 dlg = new OpenFileDialog();
 dlg.InitialDirectory = LastDirectory;
 dlg.Multiselect = false;
 dlg.Filter = "Assembler File (*.s)|*.s";
 dlg.ShowDialog();
  {
   ActionOpenFile(dlg.FileName);
  }
 dlg.Dispose();
}

private void mnuFileSave_Click(object sender, EventArgs e)
{
 PanelEditor tpa = GetCurrentPanel();

 if (tpa != null)
  {
   if (tpa.Save() == true)
     tpa.AlterFlag = false;
  }
}

private void mnuFileSaveAs_Click(object sender, EventArgs e)
{
 PanelEditor tpa = GetCurrentPanel();

 if (tpa != null)
  {
   tpa = (PanelEditor)tabCtrlLeft.TabPages[tabCtrlLeft.SelectedIndex].Controls[0];
   if (tpa.SaveAs() == true)
     tpa.AlterFlag = false;
  }
}

private void mnuFileSaveAll_Click(object sender, EventArgs e)
{
 PanelEditor pe;

 foreach(TabPage tb in tabCtrlLeft.TabPages)
  {
   if (tb.Controls.Count > 0)
    {
     pe = (PanelEditor)tb.Controls[0];
     if (pe.AlterFlag == true)
       pe.Save();
    }
  }
 foreach(TabPage tb in tabCtrlRight.TabPages)
  {
   pe = (PanelEditor)tb.Controls[0];
   if (pe.Controls.Count > 0)
    {
     if (pe.AlterFlag == true)
       pe.Save();
    }
  }
}

private void mnuFileClose_Click(object sender, EventArgs e)
{
 TabControl tab = null;
 PanelEditor tpa = GetCurrentPanel();

 if (tpa == null)
   return;

 switch(WhichTab)
  {
   case TabFocus.Left: tab = tabCtrlLeft; break;
   case TabFocus.Right: tab = tabCtrlRight; break;
   default: throw new Exception("huh?");
  }
 ActionCloseFile(tab, tpa);
}

private void mnuFileCloseAll_Click(object sender, EventArgs e)
{
 PanelEditor pe;

 foreach(TabPage tpa in tabCtrlLeft.TabPages)
  {
   if (tpa.Controls.Count > 0)
    {
     pe = (PanelEditor)tpa.Controls[0];
     ActionCloseFile(tabCtrlLeft, pe);
    }
  }
 foreach(TabPage tpa in tabCtrlRight.TabPages)
  {  
   if (tpa.Controls.Count > 0)
    {
     pe = (PanelEditor)tpa.Controls[0];
     ActionCloseFile(tabCtrlRight, pe);
    }
  }
}

private void mnuFileExit_Click(object sender, EventArgs e)
{
 Close();
}

private void mnuEditTextAlign_Click(object sender, EventArgs e)
{
 AlignText();
}

private void mnuTextBoxClose_Click(object sender, EventArgs e)
{
 PanelEditor tpa = GetCurrentPanel();
 TabControl tab = null;

 if (tpa == null)
   return;

 switch(WhichTab)
  {
   case TabFocus.Left: tab = tabCtrlLeft; break;
   case TabFocus.Right: tab = tabCtrlRight; break;
   default: throw new Exception("huh?");
  }
 ActionCloseFile(tab, tpa);
}

private void mnuActionCompile_Click(object sender, EventArgs e)
{
 StreamReader read;
 StreamReader error;
 PanelEditor tpa = GetCurrentPanel();
 string exe, src, obj, listout, strError;

 if (tpa == null)
   return;

 if (tpa.AlterFlag == true)
  {
   if (tpa.Save() == false)
    {
     MessageBox.Show("File not saved, compile aborted");
     return;
    }
  }

// e:\Assembler\Source\%1.s -Ftos -o e:\Assembler\Run\%1.TOS -L e:\Assembler\Listout\%1.txt

 exe = "e:\\Assembler\\vbcc\\bin\\vasmm68k_mot.exe";
 src = '\"' + tpa.Path + '\"';
 obj = " -Ftos -o " + '\"' + "e:\\Assembler\\Run\\" + tpa.FileNameSansExt + ".TOS" + '\"';
 listout = "-L " + '\"' + "e:\\Assembler\\Listout\\" + tpa.FileNameSansExt + ".txt" + '\"';

 System.Diagnostics.Process proc;

 proc = new System.Diagnostics.Process();

 proc.StartInfo.FileName = exe;
 proc.StartInfo.Arguments = src + " " + obj + " " + listout;
 proc.StartInfo.UseShellExecute = false;
 proc.StartInfo.RedirectStandardError = true;
 proc.StartInfo.RedirectStandardOutput = true;
 proc.StartInfo.CreateNoWindow = true;
 proc.Start();

 error = proc.StandardError;
 read = proc.StandardOutput;
 listout = read.ReadToEnd();
 strError = error.ReadToEnd();
 proc.WaitForExit();

 proc.Dispose();
 read.Dispose();
 error.Dispose();

 src = "Source " + tpa.Path + "\r\n\r\n";
 src += listout;

 txtFeedback.Text = src + "\r\n\r\n" + strError;
 txtFeedback.SelectionLength = 0;
}

private void mnuActionRun_Click(object sender, EventArgs e)
{
 // e:\Assembler\hatari\hatari.exe e:\Assembler\Run\%1.TOS

 PanelEditor tpa = GetCurrentPanel();
 string exe, obj;

 if (tpa == null)
   return;

 if (tabCtrlLeft.TabPages.Count == 0)
   return;

 if (tpa.AlterFlag == true)
  {
   if (tpa.Save() == false)
    {
     MessageBox.Show("File not saved, compile aborted");
     return;
    }
  }

// e:\Assembler\Source\%1.s -Ftos -o e:\Assembler\Run\%1.TOS -L e:\Assembler\Listout\%1.txt

 exe = "e:\\Assembler\\hatari\\hatari.exe";
 obj = "e:\\Assembler\\Run\\" + tpa.FileNameSansExt + ".TOS" + '\"';

 System.Diagnostics.Process proc;

 proc = new System.Diagnostics.Process();

 proc.StartInfo.FileName = exe;
 proc.StartInfo.Arguments = obj;
 proc.StartInfo.UseShellExecute = false;
 proc.StartInfo.CreateNoWindow = true;
 proc.Start();
 proc.Dispose();
}

private void mnuEditComment_Click(object sender, EventArgs e)
{
 PanelEditor tpa = GetCurrentPanel();
 StringBuilder sb = new StringBuilder();
 string [] lines;
 string text;
 bool need;
 int i;

 if (tpa == null)
   return;

 text = tpa.TextCtrl.SelectedText;

 if (text.Length == 0)
   return;

 lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

 i = 0;
 foreach(string s in lines)
  {
   if (s.Trim().Length > 0)
    {
     text = s;
     need = true;
     if (s.Length > 2)
      {
       if (s.Substring(0, 1) == ";")
         need = false;
      }
     if (need == true)
       text = ";" + text;
     if (lines.Length > 1 && i<lines.Length - 1)
       text += "\r\n";
     sb.Append(text); 
    }
   i++;
  }

 text = sb.ToString();

 if (text.Length > 2)
  {
   if (text.Substring(text.Length - 2) == "\r\n")
     text = text.Substring(text.Length - 2);
  }
 ((PanelEditor)tabCtrlLeft.TabPages[tabCtrlLeft.SelectedIndex].Controls[0]).TextCtrl.SelectedText = sb.ToString();

}

private void mnuEditUnComment_Click(object sender, EventArgs e)
{
 PanelEditor tpa = GetCurrentPanel();
 StringBuilder sb = new StringBuilder();
 string [] lines;
 string text;
 bool need;
 int i;

 if (tpa == null)
   return;

 text = tpa.TextCtrl.SelectedText;

 if (text.Length == 0)
   return;

 lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

 i = 0;
 foreach(string s in lines)
  {
   if (s.Trim().Length > 0)
    {
     text = s.Trim();
     need = s.Trim().Substring(0, 1) == ";";
     if (need == true)
       text = text.Substring(1);
     if (lines.Length > 1 && i<lines.Length - 1)
       text += "\r\n";
     sb.Append(text); 
    }
   i++;
  }

 text = sb.ToString();

 if (text.Length > 2)
  {
   if (text.Substring(text.Length - 2) == "\r\n")
     text = text.Substring(text.Length - 2);
  }
 ((PanelEditor)tabCtrlLeft.TabPages[tabCtrlLeft.SelectedIndex].Controls[0]).TextCtrl.SelectedText = sb.ToString();

}

 private void mnuEditFixTabs_Click(object sender, EventArgs e)
 {
  PanelEditor tpa = GetCurrentPanel();
  StringBuilder sb = new StringBuilder();
  RichTextBox tb; 
  string [] parts;
  string nl, pt;
  bool tabFirst;

  if (tpa == null)
    return;

  tb = tpa.TextCtrl;

  foreach(string line in tb.Lines)
   {
    nl = "";
    if (line.Length > 0)
     {
      tabFirst = line[0] == '\t';
      parts = line.Split('\t');
      foreach(string p in parts)
       {
        if (p.Length > 0)
         {
          pt = p.Trim();
          if (nl.Length > 0 || tabFirst)
            nl += '\t';
          nl += pt;
         }
       }
      }
    sb.AppendLine(nl);
   }
  tb.Text = sb.ToString();
 }

private int m_FindStart = 0;
private string m_FindLast;

private void mnuEditFind_Click(object sender, EventArgs e)
{
 PanelEditor tpa = GetCurrentPanel();
 RichTextBox tb;
 FindDlg dlg = new FindDlg(this, m_FindLast);
 int found;

 if (tpa == null)
   return;


 tb = tpa.TextCtrl;

 m_FindLast = "";

 if (dlg.ShowDialog() == DialogResult.OK) 
  {
   m_FindLast = dlg.txtFind.Text.Trim();
  }
 dlg.Dispose();

 if (m_FindLast.Length == 0)
   return;

 m_FindStart = tb.SelectionStart;

 tb.AutoWordSelection = false;

 found = FindText(tb, m_FindLast, m_FindStart);

 if (found < 0)
   m_FindStart = 0;
 else
   {
    tb.SelectionStart = found;
    tb.SelectionLength = m_FindLast.Length;
    m_FindStart = found + m_FindLast.Length;
    return;
   }
 found = FindText(tb, m_FindLast, m_FindStart);
 if (found < 0)
  {
   MessageBox.Show("'" + m_FindLast + "' not found");
   return;
  }

 tb.SelectionStart = found;
 tb.SelectionLength = m_FindLast.Length;
 m_FindStart = found + m_FindLast.Length; 
}

private void mnuEditFindNext_Click(object sender, EventArgs e)
{
 PanelEditor tpa = GetCurrentPanel();
 RichTextBox tb;
 int found;

 if (m_FindLast.Length == 0)
   return;

 if (tpa == null)
   return;

 tb = tpa.TextCtrl;

 found = FindText(tb, m_FindLast, m_FindStart);

 if (found < 0)
   m_FindStart = 0;
 else
   {
    tb.SelectionStart = found;
    tb.SelectionLength = m_FindLast.Length;
    m_FindStart = found + m_FindLast.Length;
    return;
   }
 found = FindText(tb, m_FindLast, m_FindStart);
 if (found < 0)
  {
   MessageBox.Show("'" + m_FindLast + "' not found");
   return;
  }

 tb.SelectionStart = found;
 tb.SelectionLength = m_FindLast.Length;
 m_FindStart = found + m_FindLast.Length; 
}

public int FindText(RichTextBox box, string text, int startPos)
{
 string test;
 int l;
 int i;
 int c;

 c = box.Text.Length - text.Length;
 l = text.Length;

 for(i=startPos; i<c; i++)
  {
   test = box.Text.Substring(i, l);
   if (string.Compare(test,text) == 0)
     return i;
  }
 return -1;
}

private void tabCtrlLeft_Selected(object sender, TabControlEventArgs e)
{
 WhichTab = TabFocus.Left;
}

private void tabCtrlRight_Selected(object sender, TabControlEventArgs e)
{
 WhichTab = TabFocus.Right;
}

private void splitMain_SplitterMoved(object sender, SplitterEventArgs e)
{
 splitEdit.Location = new Point(0, 0);
 splitEdit.Size = splitMain.Panel1.ClientSize;

 txtFeedback.Location = new Point(0, 0);
 txtFeedback.Size = splitMain.Panel2.ClientSize;

 DoSize();
}

private void tabCtrlLeft_Click(object sender, EventArgs e)
{
 WhichTab = TabFocus.Left;
}

private void tabCtrlRight_Click(object sender, EventArgs e)
{
 WhichTab = TabFocus.Right;
}

private void splitEdit_SplitterMoved(object sender, SplitterEventArgs e)
{
 DoSize();
}

private void txtFeedback_DoubleClick(object sender, EventArgs e)
{
 // error 2 in line 77 of "E:\Assembler\Source\new_flip.s": unknown mnemonic <error>

 PanelEditor pta;
 string line, ws;
 string s1 = " in line ";
 int lineNum;
 int k;

 lineNum = txtFeedback.GetLineFromCharIndex(txtFeedback.SelectionStart);
 line = txtFeedback.Lines[lineNum];

if (line.Length < 5)
  return;

 if (line.Substring(0, 5) != "error")
   return;

 if (line.Length < s1.Length)
   return;

 k = line.IndexOf(s1);
 if (k < 0)
   return;

 ws = line.Substring(k + s1.Length);

 k = ws.IndexOf(" ");

 ws = ws.Substring(0, k);

 if (int.TryParse(ws, out lineNum) == false)
   return;

 pta = GetCurrentPanel();
 if (pta == null)
   return;

 pta.SelectLine(lineNum);

}

private void mnuEditCopy_Click(object sender, EventArgs e)
{
 PanelEditor pta = GetCurrentPanel();

 if (pta != null)
   pta.Copy();
}

private void mnuEditPaste_Click(object sender, EventArgs e)
{
 PanelEditor pta = GetCurrentPanel();
 if (pta != null)
   pta.Paste();
}

private void mnuEditCut_Click(object sender, EventArgs e)
{
 PanelEditor pta = GetCurrentPanel();

 if (pta != null)
   pta.Cut();
}

private void mnuTextCtrl_Opening(object sender, CancelEventArgs e)
{
 PanelEditor tpa = GetCurrentPanel();

 mnuTextCtrlSave.Enabled = (tpa != null);
 mnuTextCtrlSaveAs.Enabled = (tpa != null);
 mnuTextCtrlClose.Enabled = (tpa != null);
 mnuTextCtrlCopy.Enabled = (tpa != null);
 mnuTextCtrlCut.Enabled = (tpa != null);
 mnuTextCtrlPaste.Enabled = (tpa != null);
 mnuTextCtrlCompile.Enabled = (tpa != null);
 mnuTextCtrlRun.Enabled = (tpa != null);
}

private void mnuTextCtrlOpen_Click(object sender, EventArgs e)
{
 mnuFileOpen_Click(sender, e);
}

private void mnuTextCtrlSave_Click(object sender, EventArgs e)
{
 mnuFileSave_Click(sender, e);
}

private void mnuTextCtrlSaveAs_Click(object sender, EventArgs e)
{
 mnuFileSaveAs_Click(sender, e);
}

private void mnuTextCtrlClose_Click(object sender, EventArgs e)
{
 mnuFileClose_Click(sender, e);
}

private void mnuTextCtrlCopy_Click(object sender, EventArgs e)
{
 mnuEditCopy_Click(sender, e);
}

private void mnuTextCtrlCut_Click(object sender, EventArgs e)
{
 mnuEditCut_Click(sender, e);
}

private void mnuTextCtrlPaste_Click(object sender, EventArgs e)
{
 mnuEditPaste_Click(sender, e);
}

private void mnuTextCtrlCompile_Click(object sender, EventArgs e)
{
 mnuActionCompile_Click(sender, e);
}

private void mnuTextCtrlRun_Click(object sender, EventArgs e)
{
 mnuActionRun_Click(sender, e);
}

private void mnuActionClearPrevious_Click(object sender, EventArgs e)
{
 DialogResult r = MessageBox.Show("Reset Previous Menu?", "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
 if (r != DialogResult.OK)
   return;

 Settings.SaveSetting("PreviousCount", 0);
 MessageBox.Show("Restart program to reset the menu");
}

private void mnuFile_DropDownOpening(object sender, EventArgs e)
{
 PanelEditor pe;
 string whichSide = "";

 switch(WhichTab)
  {
   case TabFocus.Left: whichSide = "Left"; break;
   case TabFocus.Right: whichSide = "Right"; break;
  }

 mnuFileNew.Text = "New File On " + whichSide;
 mnuFileOpen.Text = "Open File On " + whichSide;

 pe = GetCurrentPanel(); 
 if (pe == null)
  {
   mnuFileSave.Enabled = false;
   mnuFileSaveAs.Enabled = false;
   mnuFileClose.Enabled = false;
  }
 else
  {
   mnuFileSave.Enabled = true;
   mnuFileSaveAs.Enabled = true;
   mnuFileClose.Enabled = true;
   if (pe.FileName == "")
    {
     mnuFileSave.Text = "Save New File On " + whichSide ;
     mnuFileSaveAs.Enabled = false;
     mnuFileClose.Text = "Close File On " + whichSide;
    }
   else
    {
     mnuFileSave.Text = "Save " + whichSide + " File " + pe.FileName;
     mnuFileSaveAs.Text = "Save " + whichSide + " File " + pe.FileName + " As";
     mnuFileClose.Text = "Close " + whichSide + " File " + pe.FileName;
    }
  }
}

private void mnuTextCtrlNew_Click(object sender, EventArgs e)
{
 mnuFileNew_Click(sender, e);
}

};
}




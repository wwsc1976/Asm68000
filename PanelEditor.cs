using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;



namespace Asm68000
{
public class PanelEditor : Panel
{
 private static int NextID = 1;

 public MainWnd.TabFocus WhichTab { get; private set; }

 public int          ID { get; private set; }
 public RichTextBox  TextCtrl { get; private set; }
 public PictureBox   LineCtrl { get; private set; }
 public TabPage      TabCtrl { get; private set; }
 public string       Path { get; private set; } = "";
 public string       FileName { get; private set; } = "";
 public string       FileNameSansExt { get; private set; }
 public DateTime     FileCreated { get; private set; }
 public DateTime     FileChanged { get; set; }
 public bool         AlterFlag   { get=> m_AlterFlag; set=>SetAlterFlag(value); }
 
 private bool m_AlterFlag;

public PanelEditor()
{
}

public PanelEditor(MainWnd.TabFocus focus, TabPage tp, string path, DateTime created, DateTime chg, ContextMenuStrip menu)
{
 WhichTab = focus;
 ID = NextID++;

 Name = "pnlPage" + ID.ToString();

 TabCtrl = tp;

 TextCtrl = new RichTextBox();
 TextCtrl.Multiline = true;
 TextCtrl.ScrollBars = RichTextBoxScrollBars.Both;
 TextCtrl.Font = MainWnd.TextFont;
 TextCtrl.BackColor = MainWnd.TextBackColor;
 TextCtrl.ForeColor = MainWnd.TextForeColor;
 TextCtrl.WordWrap = false;
 TextCtrl.AcceptsTab = true;
 TextCtrl.SelectionTabs = new int[]{200, 300, 500};
 TextCtrl.ContextMenuStrip = menu;

 LineCtrl = new PictureBox();
 LineCtrl.Width = (int)TextCtrl.Font.Size * 6;

 Controls.Add(TextCtrl);
 Controls.Add(LineCtrl);

 SetText(path, false);
 
 FileCreated = created;
 FileChanged = chg;
 
 TextCtrl.TextChanged += new EventHandler(TextCtrl_Changed);
 TextCtrl.SelectionChanged += new EventHandler(TextCtrl_SelectionChanged);
 TextCtrl.VScroll += new EventHandler(TextCtrl_VScroll);
 TextCtrl.Enter += new EventHandler(TextCtrl_Enter);
 TextCtrl.Click += new EventHandler(TextCtrl_Click);
 TextCtrl.KeyDown += new KeyEventHandler(TextCtrl_KeyDown);
 TextCtrl.GotFocus += new EventHandler(TextCtrl_GotFocus);
 LineCtrl.Paint += new PaintEventHandler(LineCtrl_Paint);
 

 Application.DoEvents();
 m_AlterFlag = false;       // change to textctrl would trigger Alterflag true so have to wait and set

 TextCtrl.Select();
 LineCtrl.Refresh();
 
 Dock = DockStyle.Fill;
}

private void SetAlterFlag(bool flag)
{
 m_AlterFlag = flag;
 SetText(Path, flag);
}

private void SetText(string p, bool changed)
{
 if (p.Length > 0)
  {
   Path = p;
   FileName = System.IO.Path.GetFileName(p);
   FileNameSansExt = System.IO.Path.GetFileNameWithoutExtension(p);
   TabCtrl.Text = FileName;
  }
 else
  {
   TabCtrl.Text = "New File " + ID.ToString();
  }
 if (changed == true)
  {
   TabCtrl.Text = "<" + TabCtrl.Text + ">";
  }
}

public void SelectLine(int iLine)
{
 string sLine;
 int pos, line;

 line = iLine - 1;

 pos = TextCtrl.GetFirstCharIndexFromLine(line);
 TextCtrl.SelectionStart = pos;
 sLine = TextCtrl.Lines[line];
 TextCtrl.SelectionLength = sLine.Length;
 TextCtrl.ScrollToCaret();
 TextCtrl.Focus();
}

public bool Save()
{
 SaveFileDialog dlg;
 DialogResult dr;
 StreamWriter stream = null;
 string tp = Path;
 bool success = false;
 bool newFile = false;

 if (Path.Length == 0)
  {
   dlg = new SaveFileDialog();
   dlg.InitialDirectory = MainWnd.LastDirectory;
   dlg.Filter = "Assembler File (*.s)|*.s";
   dr = dlg.ShowDialog();
   if (dr == DialogResult.OK)
    {
     tp = dlg.FileName;
     newFile = true;
    }
   dlg.Dispose();
  }
 try 
  {
   stream = new StreamWriter(tp);
  }
 catch(System.IO.IOException ex)
  {
   MessageBox.Show("File Error: " + ex.Message);
   stream = null;
  }

 if (stream != null)
  {
   try
    {
     stream.Write(TextCtrl.Text);
     success = true;
    }
   catch(System.IO.IOException ex)
    {
     MessageBox.Show("Write Error: " + ex.Message);
    } 
  }
 if (stream != null)
  {
   stream.Close();
   stream.Dispose();
  }

 if (newFile == true)
  {
   Path = tp;
   FileName = System.IO.Path.GetFileName(tp);
   FileNameSansExt = System.IO.Path.GetFileNameWithoutExtension(tp);
   Text = FileName;
  }

 if (success == true)
   SetAlterFlag(false);

 return success;
}

public bool SaveAs()
{
 SaveFileDialog dlg;
 DialogResult dr;
 StreamWriter stream = null;
 string tp = Path;
 bool success = false;

 dlg = new SaveFileDialog();
 dlg.InitialDirectory = MainWnd.LastDirectory;
 dlg.Filter = "Assembler File (*.s)|*.s";
 dr = dlg.ShowDialog();
 tp = "";
 if (dr == DialogResult.OK)
  {
   tp = dlg.FileName;
  }
 dlg.Dispose();

 if (tp.Length == 0)
   return false;

 try 
  {
   stream = new StreamWriter(tp);
  }
 catch(System.IO.IOException ex)
  {
   MessageBox.Show("Error Saving " + tp +"\n\n" + ex.Message);
   stream = null;
  }

 if (stream != null)
  {
   try
    {
     stream.Write(TextCtrl.Text);
     success = true;
    }
   catch(System.IO.IOException ex)
    {
     MessageBox.Show("Write Error: " + ex.Message);
    } 
  }
 if (stream != null)
  {
   stream.Close();
   stream.Dispose();
  }

 if (success == true)
  {
   SetAlterFlag(false);
   Path = tp;
   FileName = System.IO.Path.GetFileName(tp);
   FileNameSansExt = System.IO.Path.GetFileNameWithoutExtension(tp);
   Text = FileName;
  }
 return success;
}

public void Copy() 
{
 TextCtrl.Copy();
}

public void Cut() 
{
 TextCtrl.Cut();
 LineCtrl.Refresh();
}

public void Paste() 
{
 TextCtrl.Paste(DataFormats.GetFormat(DataFormats.UnicodeText));
 LineCtrl.Refresh();
}

private void TextCtrl_KeyDown(object sender, KeyEventArgs e)
{
 if (e.Control == false)
   return;

 if (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.P)
  {
   e.Handled = true;
   e.SuppressKeyPress = true;
  }
}


public void LineCtrl_Paint(object sender, PaintEventArgs e)
{
 Point pt;
 PointF ptf;
 Brush br = new SolidBrush(TextCtrl.ForeColor); 
 SizeF sz;
 int firstNdx, firstLine;
 int lastNdx,lastLine;
 float y;
 string s;
 
 pt = new Point(0, 0);  // get First Index & First Line from TextCtrl

 firstNdx = TextCtrl.GetCharIndexFromPosition(pt);
 firstLine = TextCtrl.GetLineFromCharIndex(firstNdx);

 pt.X = ClientRectangle.Width; // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively
 pt.Y = ClientRectangle.Height;
 
lastNdx = TextCtrl.GetCharIndexFromPosition(pt);  // get Last Index & Last Line from richTextBox1
lastLine = TextCtrl.GetLineFromCharIndex(lastNdx);

 LineCtrl.Text = "";

 DoSizeChanged();

 e.Graphics.Clear(TextCtrl.BackColor);

 sz = TextRenderer.MeasureText("W", TextCtrl.Font);

 y = 3.0F;
 for (int i = firstLine; i <= lastLine + 2; i++)
  {
   s = (i + 1).ToString("00000");
   ptf = new PointF(7, y);
   e.Graphics.DrawString(s, TextCtrl.Font, br, ptf);
   y += sz.Height;
  }
 br.Dispose();
}

private void DoSizeChanged()
{
 LineCtrl.Location = new Point(0, 0);
 LineCtrl.Size = new Size(LineCtrl.Width, ClientSize.Height);

 TextCtrl.Location = new Point(LineCtrl.Width, LineCtrl.Top);
 TextCtrl.Size = new Size(ClientSize.Width - LineCtrl.Width, LineCtrl.Height);
}

protected override void OnSizeChanged(EventArgs e)
{
 base.OnSizeChanged(e);
 DoSizeChanged();
}

private void TextCtrl_Changed(object s, EventArgs e)
{
 if (AlterFlag == false)
  {
   SetAlterFlag(true);
   SetText(Path, m_AlterFlag);
  }
 if (TextCtrl.Text == "")
   LineCtrl.Refresh();
}

private void TextCtrl_SelectionChanged(object sender, EventArgs e)
{
 Point pt;

 pt = TextCtrl.GetPositionFromCharIndex(TextCtrl.SelectionStart);
 if (pt.X == 1)
  {
   LineCtrl.Refresh();
  }
}

private void TextCtrl_VScroll(object sender, EventArgs e)
{
 LineCtrl.Refresh();
}

private void TextCtrl_Enter(object sender, EventArgs e)
{
 MainWnd.WhichTab = WhichTab;
}

private void TextCtrl_Click(object sender, EventArgs e)
{
 MainWnd.WhichTab = WhichTab;
}

private void TextCtrl_GotFocus(object sender, EventArgs e)
{
 ((TabControl)TabCtrl.Parent).SelectedTab = TabCtrl;
}

};

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm68000
{
public partial class FindDlg : Form
{

public FindDlg(Form own, string last)
{
 InitializeComponent();
     
 Owner = own;
 StartPosition = FormStartPosition.CenterParent;
 txtFind.Text = last;
   
}

private void btnOK_Click(object sender, EventArgs e)
{
 if (txtFind.Text.Trim().Length == 0)
   DialogResult = DialogResult.Cancel;
 else
   DialogResult = DialogResult.OK;
 Close();
}

private void btnCancel_Click(object sender, EventArgs e)
{
 DialogResult = DialogResult.Cancel;
 Close();
}

private void txtFind_KeyDown(object sender, KeyEventArgs e)
{
 if (e.KeyCode != Keys.Enter)
   return; 

 e.Handled = true;
 e.SuppressKeyPress = true;

 if (txtFind.Text.Trim().Length == 0)
   DialogResult = DialogResult.Cancel;
 else
   DialogResult = DialogResult.OK;
 Close();
}

};

}

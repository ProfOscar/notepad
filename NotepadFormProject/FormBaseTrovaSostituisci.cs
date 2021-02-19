using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadFormProject
{
    public partial class FormBaseTrovaSostituisci : Form
    {
        public FormBaseTrovaSostituisci()
        {
            InitializeComponent();
            txtFind.Text = FindSubClass.Parameters.textToFind;
            chkCaseSensitive.Checked = FindSubClass.Parameters.isCaseSensitive;
            chkWholeWord.Checked = FindSubClass.Parameters.isWholeWord;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            FindSubClass.Parameters.textToFind = txtFind.Text;
            btnFind.Enabled = txtFind.Text.Length > 0;
        }

        private void chkCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            FindSubClass.Parameters.isCaseSensitive = chkCaseSensitive.Checked;
        }

        private void chkWholeWord_CheckedChanged(object sender, EventArgs e)
        {
            FindSubClass.Parameters.isWholeWord = chkWholeWord.Checked;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (FindSubClass.Find() == -1)
            {
                FindSubClass.showNotFoundMessageBox();
            }
        }
    }
}

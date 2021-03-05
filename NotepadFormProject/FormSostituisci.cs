using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotepadFormProject
{
    public partial class FormSostituisci : NotepadFormProject.FormBaseTrovaSostituisci
    {
        public FormSostituisci()
        {
            InitializeComponent();
            txtFind.TextChanged += TxtFind_TextChanged;
            txtReplace.TextChanged += TxtReplace_TextChanged;
            btnReplace.Click += BtnReplace_Click;
            btnReplaceAll.Click += BtnReplaceAll_Click;
            TxtFind_TextChanged(null, null);
        }

        private void TxtFind_TextChanged(object sender, EventArgs e)
        {
            btnReplace.Enabled = btnReplaceAll.Enabled = txtFind.Text.Length > 0;
        }

        private void TxtReplace_TextChanged(object sender, EventArgs e)
        {
            FindSubClass.Parameters.textToReplace = txtReplace.Text;
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            if (FindSubClass.Replace() == -1)
            {
                FindSubClass.showNotFoundMessageBox();
            }
        }

        private void BtnReplaceAll_Click(object sender, EventArgs e)
        {
            FindSubClass.ReplaceAll();
        }
    }
}

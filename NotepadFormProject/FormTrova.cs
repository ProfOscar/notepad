using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotepadFormProject
{
    public partial class FormTrova : NotepadFormProject.FormBaseTrovaSostituisci
    {
        public FormTrova()
        {
            InitializeComponent();
            rbUp.Checked = FindSubClass.Parameters.isUp;
        }

        private void rbUp_CheckedChanged(object sender, EventArgs e)
        {
            FindSubClass.Parameters.isUp = rbUp.Checked;
        }
    }
}

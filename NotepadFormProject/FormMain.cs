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
    public partial class FormMain : Form
    {
        string savedContent;

        public FormMain()
        {
            this.savedContent = "";
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text += " - " + this.Tag;
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rtbMain.Text != this.savedContent)
            {
                MessageBox.Show("C'è qualcosa da salvare...");
                e.Cancel = true;
            }
        }
    }
}

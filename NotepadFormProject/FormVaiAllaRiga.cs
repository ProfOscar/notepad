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
    public partial class FormVaiAllaRiga : Form
    {
        public int NumeroRiga;

        private bool isBackspaceOrDelete;

        public FormVaiAllaRiga()
        {
            NumeroRiga = 1;
            isBackspaceOrDelete = false;
            InitializeComponent();
            txtNumeroRiga.Text = NumeroRiga.ToString();
        }

        private void txtNumeroRiga_KeyDown(object sender, KeyEventArgs e)
        {
            isBackspaceOrDelete = e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete;
        }

        private void txtNumeroRiga_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.Handled = !(char.IsDigit(e.KeyChar));
            if (!char.IsDigit(e.KeyChar) && !isBackspaceOrDelete)
            {
                // is not a number
                errorProviderGeneric.SetError((Control)sender, "Carattere non ammesso");
                e.Handled = true;
            }
            else
            {
                errorProviderGeneric.Clear();
            }
        }

        private void btnVaiA_Click(object sender, EventArgs e)
        {
            NumeroRiga = int.Parse(txtNumeroRiga.Text);
            // TODO: check max line number
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace NotepadFormProject
{
    public partial class FormMain : Form
    {

        string fileName;
        string filePath;
        string savedContent;

        public FormMain()
        {
            this.fileName = "Senza nome";
            this.filePath = "";
            this.savedContent = "";
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.setFormTitle();
        }

        private void setFormTitle()
        {
            this.Text = this.fileName + " - " + this.Tag;
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult response = checkIfSave();
            if (response == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (response == DialogResult.Yes)
            {
                DialogResult saveResponse = saveFileDialogMain.ShowDialog();
                if (saveResponse == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (saveResponse == DialogResult.OK)
                {
                    saveDocument(saveFileDialogMain.FileName);
                }
            }
        }

        private DialogResult checkIfSave()
        {
            DialogResult result = DialogResult.No;
            if (rtbMain.Text != this.savedContent)
            {
                string message = "Salvare le modifiche a " + this.fileName + "?";
                string caption = "Blocco note";
                result = MessageBox.Show(
                    message, 
                    caption, 
                    MessageBoxButtons.YesNoCancel, 
                    MessageBoxIcon.Question);
            }
            return result;
        }

        private void saveDocument(string pathName)
        {
            try
            {
                File.WriteAllText(pathName, rtbMain.Text);
                this.savedContent = rtbMain.Text;
                this.filePath = pathName;
                string[] mySplit = pathName.Split('\\');
                this.fileName = mySplit[mySplit.Length - 1];
                this.setFormTitle();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Problemi durante il salvataggio del file.",
                    "ATTENZIONE!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void salvaconnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                saveDocument(saveFileDialogMain.FileName);
            }
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.filePath.Length > 0)
            {
                saveDocument(this.filePath);
            }
            else
            {
                salvaconnomeToolStripMenuItem_Click(sender, e);
            }
        }
    }
}

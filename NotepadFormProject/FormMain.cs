﻿using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace NotepadFormProject
{
    public partial class FormMain : Form
    {

        #region Properties

        string fileName;
        string filePath;
        string savedContent;

        // PrinterSettings printerSettings;
        // PageSettings pageSettings;

        #endregion

        #region Form Constructor and Events

        public FormMain()
        {
            // printerSettings = new PrinterSettings();
            // pageSettings = new PageSettings(printerSettings);
            InitializeComponent();
            pageSetupDialogMain.Document = this.printDocumentMain;
            printDialogMain.Document = this.printDocumentMain;
            this.initializeVariables();
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            incollaToolStripMenuItem.Enabled = Clipboard.ContainsText();
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
                saveFileDialogMain.FileName = getFileNameFromPath(this.filePath);
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

        private void rtbMain_TextChanged(object sender, EventArgs e)
        {
            annullaToolStripMenuItem.Enabled = true;
            bool enableButtons = rtbMain.Text.Length > 0;
            trovaToolStripMenuItem.Enabled = enableButtons;
            trovaSuccessivoToolStripMenuItem.Enabled = enableButtons;
            trovaPrecedenteToolStripMenuItem.Enabled = enableButtons;
        }

        private void rtbMain_SelectionChanged(object sender, EventArgs e)
        {
            bool enableButtons = rtbMain.SelectedText.Length > 0;
            copiaToolStripMenuItem.Enabled = enableButtons;
            tagliaToolStripMenuItem.Enabled = enableButtons;
            eliminaToolStripMenuItem.Enabled = enableButtons;
        }

        #endregion

        #region Buttons Event Handlers

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult response = checkIfSave();
            if (response == DialogResult.Yes)
            {
                saveFileDialogMain.FileName = getFileNameFromPath(this.filePath);
                DialogResult saveResponse = saveFileDialogMain.ShowDialog();
                if (saveResponse == DialogResult.Cancel)
                {
                    return;
                }
                else if (saveResponse == DialogResult.OK)
                {
                    saveDocument(saveFileDialogMain.FileName);
                    this.initializeVariables();
                }
            }
            if (response != DialogResult.Cancel) this.initializeVariables();
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult response = checkIfSave();
            if (response == DialogResult.Cancel) return;
            if (response == DialogResult.Yes)
            {
                if (this.filePath.Length > 0)
                {
                    saveDocument(this.filePath);
                }
                else
                {
                    saveFileDialogMain.FileName = getFileNameFromPath(this.filePath);
                    DialogResult saveResponse = saveFileDialogMain.ShowDialog();
                    if (saveResponse == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (saveResponse == DialogResult.OK)
                    {
                        saveDocument(saveFileDialogMain.FileName);
                    }
                }
            }
            openFileDialogMain.FileName = getFileNameFromPath(this.filePath);
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.filePath = openFileDialogMain.FileName;
                    rtbMain.Text = File.ReadAllText(this.filePath);
                    this.savedContent = rtbMain.Text;
                    this.fileName = getFileNameFromPath(this.filePath);
                    this.setFormTitle();
                    annullaToolStripMenuItem.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "Problemi durante l'apertura del file.",
                        "ATTENZIONE!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
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

        private void salvaconnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogMain.FileName = getFileNameFromPath(this.filePath);
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                saveDocument(saveFileDialogMain.FileName);
            }
        }

        private void impostapaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pageSetupDialogMain.PageSettings = this.pageSettings;
            //if (pageSetupDialogMain.ShowDialog() == DialogResult.OK)
            //{
            //    this.pageSettings = pageSetupDialogMain.PageSettings;
            //}
            pageSetupDialogMain.ShowDialog();
        }

        private void stampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocumentMain.DocumentName = this.fileName;
            if (printDialogMain.ShowDialog() == DialogResult.OK)
            {
                printDocumentMain.Print();
                
            }
        }

        private void printDocumentMain_PrintPage(object sender, PrintPageEventArgs e)
        {
            string str = rtbMain.Text;
            Font font = rtbMain.Font;
            e.Graphics.DrawString(str, font, new SolidBrush(System.Drawing.Color.Black), e.MarginBounds.X, e.MarginBounds.Y);
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void annullaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbMain.CanUndo)
            {
                rtbMain.Undo();
            }
        }

        private void ripristinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbMain.CanRedo)
            {
                rtbMain.Redo();
            }

        }

        private void tagliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.Cut();
        }

        private void copiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.Copy();
        }

        private void incollaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.Paste();
        }

        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.SelectedText = "";
        }

        private void cercaConBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO");
        }

        private void trovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrova ft = new FormTrova();
            ft.Show();
        }

        private void trovaSuccessivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO");
        }

        private void trovaPrecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO");
        }

        private void sostituisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSostituisci fs = new FormSostituisci();
            fs.Show();
        }

        private void vaiAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVaiAllaRiga formVaiAllaRiga = new FormVaiAllaRiga();
            if (formVaiAllaRiga.ShowDialog() == DialogResult.OK)
            {
                if (formVaiAllaRiga.NumeroRiga > rtbMain.Lines.Length)
                {
                    MessageBox.Show("Numero di riga maggiore del numero di righe totale", "Blocco note. Vai alla riga");
                }
                else
                {
                    rtbMain.SelectionLength = 0;
                    rtbMain.SelectionStart = rtbMain.GetFirstCharIndexFromLine(formVaiAllaRiga.NumeroRiga - 1);
                }
            }
        }

        private void selezionatuttoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.SelectAll();
        }

        private void oraDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            rtbMain.SelectedText = now.ToString("t") + " " + now.ToString("d");
        }

        private void acapoautomaticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.WordWrap = acapoautomaticoToolStripMenuItem.Checked;
            vaiAToolStripMenuItem.Enabled = !acapoautomaticoToolStripMenuItem.Checked;
        }

        #endregion

        #region Custom Functions

        private void initializeVariables()
        {
            annullaToolStripMenuItem.Enabled = false;
            this.fileName = "Senza nome";
            this.filePath = "";
            this.savedContent = "";
            this.rtbMain.Text = "";
            this.setFormTitle();
        }

        private void setFormTitle()
        {
            this.Text = this.fileName + " - " + this.Tag;
        }

        private string getFileNameFromPath(string filePath)
        {
            string[] mySplit = filePath.Split('\\');
            return mySplit[mySplit.Length - 1];
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

        private void saveDocument(string filePath)
        {
            try
            {
                File.WriteAllText(filePath, rtbMain.Text);
                this.savedContent = rtbMain.Text;
                this.filePath = filePath;
                this.fileName = getFileNameFromPath(filePath);
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

        #endregion

    }
}

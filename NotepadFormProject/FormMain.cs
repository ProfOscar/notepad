﻿using System;
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

        #endregion

        #region Form Constructor and Events

        public FormMain()
        {
            InitializeComponent();
            this.initializeVariables();
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

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Custom Functions

        private void initializeVariables()
        {
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

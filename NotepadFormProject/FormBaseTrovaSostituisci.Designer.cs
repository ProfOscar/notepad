namespace NotepadFormProject
{
    partial class FormBaseTrovaSostituisci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFind = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.chkWholeWord = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(8, 18);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(52, 20);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Trova:";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(64, 15);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(272, 30);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(352, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(164, 35);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Trova successivo";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulla.Location = new System.Drawing.Point(352, 57);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(164, 35);
            this.btnAnnulla.TabIndex = 3;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // chkUpLow
            // 
            this.chkCaseSensitive.AutoSize = true;
            this.chkCaseSensitive.Location = new System.Drawing.Point(12, 163);
            this.chkCaseSensitive.Name = "chkUpLow";
            this.chkCaseSensitive.Size = new System.Drawing.Size(181, 24);
            this.chkCaseSensitive.TabIndex = 4;
            this.chkCaseSensitive.Text = "Maiuscole/minuscole";
            this.chkCaseSensitive.UseVisualStyleBackColor = true;
            this.chkCaseSensitive.CheckedChanged += new System.EventHandler(this.chkCaseSensitive_CheckedChanged);
            // 
            // chkWholeWord
            // 
            this.chkWholeWord.AutoSize = true;
            this.chkWholeWord.Location = new System.Drawing.Point(12, 208);
            this.chkWholeWord.Name = "chkWholeWord";
            this.chkWholeWord.Size = new System.Drawing.Size(124, 24);
            this.chkWholeWord.TabIndex = 5;
            this.chkWholeWord.Text = "Parola intera";
            this.chkWholeWord.UseVisualStyleBackColor = true;
            this.chkWholeWord.CheckedChanged += new System.EventHandler(this.chkWholeWord_CheckedChanged);
            // 
            // FormBaseTrovaSostituisci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 245);
            this.Controls.Add(this.chkWholeWord);
            this.Controls.Add(this.chkCaseSensitive);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBaseTrovaSostituisci";
            this.Text = "FormBaseTrovaSostituisci";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnFind;
        protected System.Windows.Forms.Button btnAnnulla;
        protected System.Windows.Forms.CheckBox chkCaseSensitive;
        protected System.Windows.Forms.CheckBox chkWholeWord;
        protected System.Windows.Forms.TextBox txtFind;
    }
}
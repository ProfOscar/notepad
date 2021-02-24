namespace NotepadFormProject
{
    partial class FormSostituisci
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSubst = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(353, 145);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(133, 15);
            this.txtFind.Size = new System.Drawing.Size(204, 30);
            // 
            // lblSubst
            // 
            this.lblSubst.AutoSize = true;
            this.lblSubst.Location = new System.Drawing.Point(12, 68);
            this.lblSubst.Name = "lblSubst";
            this.lblSubst.Size = new System.Drawing.Size(115, 20);
            this.lblSubst.TabIndex = 6;
            this.lblSubst.Text = "Sostituisci con:";
            // 
            // txtSubst
            // 
            this.txtReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplace.Location = new System.Drawing.Point(133, 61);
            this.txtReplace.Name = "txtSubst";
            this.txtReplace.Size = new System.Drawing.Size(204, 30);
            this.txtReplace.TabIndex = 7;
            // 
            // btnSubst
            // 
            this.btnReplace.Location = new System.Drawing.Point(353, 56);
            this.btnReplace.Name = "btnSubst";
            this.btnReplace.Size = new System.Drawing.Size(163, 35);
            this.btnReplace.TabIndex = 8;
            this.btnReplace.Text = "Sostituisci";
            this.btnReplace.UseVisualStyleBackColor = true;
            // 
            // btnSubstAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(353, 101);
            this.btnReplaceAll.Name = "btnSubstAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(163, 35);
            this.btnReplaceAll.TabIndex = 9;
            this.btnReplaceAll.Text = "Sostituisci tutto";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            // 
            // FormSostituisci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(528, 244);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.lblSubst);
            this.Name = "FormSostituisci";
            this.Text = "Sostituisci";
            this.Controls.SetChildIndex(this.txtFind, 0);
            this.Controls.SetChildIndex(this.btnAnnulla, 0);
            this.Controls.SetChildIndex(this.chkCaseSensitive, 0);
            this.Controls.SetChildIndex(this.chkWholeWord, 0);
            this.Controls.SetChildIndex(this.lblSubst, 0);
            this.Controls.SetChildIndex(this.txtReplace, 0);
            this.Controls.SetChildIndex(this.btnReplace, 0);
            this.Controls.SetChildIndex(this.btnReplaceAll, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubst;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
    }
}

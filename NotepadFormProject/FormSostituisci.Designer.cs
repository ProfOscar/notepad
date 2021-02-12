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
            this.txtSubst = new System.Windows.Forms.TextBox();
            this.btnSubst = new System.Windows.Forms.Button();
            this.btnSubstAll = new System.Windows.Forms.Button();
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
            this.txtSubst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubst.Location = new System.Drawing.Point(133, 61);
            this.txtSubst.Name = "txtSubst";
            this.txtSubst.Size = new System.Drawing.Size(204, 30);
            this.txtSubst.TabIndex = 7;
            // 
            // btnSubst
            // 
            this.btnSubst.Location = new System.Drawing.Point(353, 56);
            this.btnSubst.Name = "btnSubst";
            this.btnSubst.Size = new System.Drawing.Size(163, 35);
            this.btnSubst.TabIndex = 8;
            this.btnSubst.Text = "Sostituisci";
            this.btnSubst.UseVisualStyleBackColor = true;
            // 
            // btnSubstAll
            // 
            this.btnSubstAll.Location = new System.Drawing.Point(353, 101);
            this.btnSubstAll.Name = "btnSubstAll";
            this.btnSubstAll.Size = new System.Drawing.Size(163, 35);
            this.btnSubstAll.TabIndex = 9;
            this.btnSubstAll.Text = "Sostituisci tutto";
            this.btnSubstAll.UseVisualStyleBackColor = true;
            // 
            // FormSostituisci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(528, 244);
            this.Controls.Add(this.btnSubstAll);
            this.Controls.Add(this.btnSubst);
            this.Controls.Add(this.txtSubst);
            this.Controls.Add(this.lblSubst);
            this.Name = "FormSostituisci";
            this.Text = "Sostituisci";
            this.Controls.SetChildIndex(this.txtFind, 0);
            this.Controls.SetChildIndex(this.btnAnnulla, 0);
            this.Controls.SetChildIndex(this.chkCaseSensitive, 0);
            this.Controls.SetChildIndex(this.chkWholeWord, 0);
            this.Controls.SetChildIndex(this.lblSubst, 0);
            this.Controls.SetChildIndex(this.txtSubst, 0);
            this.Controls.SetChildIndex(this.btnSubst, 0);
            this.Controls.SetChildIndex(this.btnSubstAll, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubst;
        private System.Windows.Forms.TextBox txtSubst;
        private System.Windows.Forms.Button btnSubst;
        private System.Windows.Forms.Button btnSubstAll;
    }
}

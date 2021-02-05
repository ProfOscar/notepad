namespace NotepadFormProject
{
    partial class FormTrova
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
            this.gbDirection = new System.Windows.Forms.GroupBox();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.gbDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkUpLow
            // 
            this.chkUpLow.Location = new System.Drawing.Point(12, 105);
            // 
            // chkTextAround
            // 
            this.chkTextAround.Location = new System.Drawing.Point(12, 150);
            // 
            // gbDirection
            // 
            this.gbDirection.Controls.Add(this.rbDown);
            this.gbDirection.Controls.Add(this.rbUp);
            this.gbDirection.Location = new System.Drawing.Point(198, 69);
            this.gbDirection.Name = "gbDirection";
            this.gbDirection.Size = new System.Drawing.Size(139, 63);
            this.gbDirection.TabIndex = 6;
            this.gbDirection.TabStop = false;
            this.gbDirection.Text = "Direzione";
            // 
            // rbDown
            // 
            this.rbDown.AutoSize = true;
            this.rbDown.Checked = true;
            this.rbDown.Location = new System.Drawing.Point(67, 30);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(59, 24);
            this.rbDown.TabIndex = 1;
            this.rbDown.TabStop = true;
            this.rbDown.Text = "Giù";
            this.rbDown.UseVisualStyleBackColor = true;
            // 
            // rbUp
            // 
            this.rbUp.AutoSize = true;
            this.rbUp.Location = new System.Drawing.Point(6, 30);
            this.rbUp.Name = "rbUp";
            this.rbUp.Size = new System.Drawing.Size(54, 24);
            this.rbUp.TabIndex = 0;
            this.rbUp.Text = "Su";
            this.rbUp.UseVisualStyleBackColor = true;
            // 
            // FormTrova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(528, 184);
            this.Controls.Add(this.gbDirection);
            this.Name = "FormTrova";
            this.Text = "Trova";
            this.Controls.SetChildIndex(this.btnAnnulla, 0);
            this.Controls.SetChildIndex(this.chkUpLow, 0);
            this.Controls.SetChildIndex(this.chkTextAround, 0);
            this.Controls.SetChildIndex(this.gbDirection, 0);
            this.gbDirection.ResumeLayout(false);
            this.gbDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDirection;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.RadioButton rbUp;
    }
}

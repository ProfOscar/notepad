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
            this.chkUpLow = new System.Windows.Forms.CheckBox();
            this.chkTextAround = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(5, 12);
            this.lblFind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(38, 13);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Trova:";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(43, 10);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(183, 23);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(235, 8);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Trova successivo";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulla.Location = new System.Drawing.Point(235, 37);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(109, 23);
            this.btnAnnulla.TabIndex = 3;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // chkUpLow
            // 
            this.chkUpLow.AutoSize = true;
            this.chkUpLow.Location = new System.Drawing.Point(8, 106);
            this.chkUpLow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkUpLow.Name = "chkUpLow";
            this.chkUpLow.Size = new System.Drawing.Size(126, 17);
            this.chkUpLow.TabIndex = 4;
            this.chkUpLow.Text = "Maiuscole/minuscole";
            this.chkUpLow.UseVisualStyleBackColor = true;
            // 
            // chkTextAround
            // 
            this.chkTextAround.AutoSize = true;
            this.chkTextAround.Location = new System.Drawing.Point(8, 135);
            this.chkTextAround.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTextAround.Name = "chkTextAround";
            this.chkTextAround.Size = new System.Drawing.Size(88, 17);
            this.chkTextAround.TabIndex = 5;
            this.chkTextAround.Text = "Testo intorno";
            this.chkTextAround.UseVisualStyleBackColor = true;
            // 
            // FormBaseTrovaSostituisci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 159);
            this.Controls.Add(this.chkTextAround);
            this.Controls.Add(this.chkUpLow);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        protected System.Windows.Forms.CheckBox chkUpLow;
        protected System.Windows.Forms.CheckBox chkTextAround;
        protected System.Windows.Forms.TextBox txtFind;
    }
}
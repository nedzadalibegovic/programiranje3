namespace StudentskaSluzba {
    partial class frmUcionica {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.chkZauzeto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(69, 9);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(286, 26);
            this.txtNaziv.TabIndex = 0;
            // 
            // chkZauzeto
            // 
            this.chkZauzeto.AutoSize = true;
            this.chkZauzeto.Location = new System.Drawing.Point(374, 11);
            this.chkZauzeto.Name = "chkZauzeto";
            this.chkZauzeto.Size = new System.Drawing.Size(103, 24);
            this.chkZauzeto.TabIndex = 1;
            this.chkZauzeto.Text = "Zauzeta?";
            this.chkZauzeto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(86, 64);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(117, 49);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Prijavi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmUcionica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkZauzeto);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmUcionica";
            this.Text = "frmUcionica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.CheckBox chkZauzeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
    }
}
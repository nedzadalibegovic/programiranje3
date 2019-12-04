namespace predavanje_2019_11_20 {
    partial class KorisniciAdmin {
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
            this.dgwKorisnici = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNoviKorisnik = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwKorisnici
            // 
            this.dgwKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Username,
            this.Admin});
            this.dgwKorisnici.Location = new System.Drawing.Point(12, 84);
            this.dgwKorisnici.Name = "dgwKorisnici";
            this.dgwKorisnici.RowHeadersVisible = false;
            this.dgwKorisnici.RowHeadersWidth = 62;
            this.dgwKorisnici.RowTemplate.Height = 28;
            this.dgwKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKorisnici.Size = new System.Drawing.Size(776, 320);
            this.dgwKorisnici.TabIndex = 0;
            this.dgwKorisnici.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwKorisnici_MouseClick);
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 8;
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 8;
            this.Prezime.Name = "Prezime";
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            // 
            // Admin
            // 
            this.Admin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Admin.DataPropertyName = "Administrator";
            this.Admin.HeaderText = "Admin";
            this.Admin.MinimumWidth = 8;
            this.Admin.Name = "Admin";
            this.Admin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Admin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnNoviKorisnik
            // 
            this.btnNoviKorisnik.Location = new System.Drawing.Point(671, 37);
            this.btnNoviKorisnik.Name = "btnNoviKorisnik";
            this.btnNoviKorisnik.Size = new System.Drawing.Size(117, 41);
            this.btnNoviKorisnik.TabIndex = 1;
            this.btnNoviKorisnik.Text = "Novi korisnik";
            this.btnNoviKorisnik.UseVisualStyleBackColor = true;
            this.btnNoviKorisnik.Click += new System.EventHandler(this.btnNoviKorisnik_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(13, 44);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(652, 26);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 410);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // KorisniciAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnNoviKorisnik);
            this.Controls.Add(this.dgwKorisnici);
            this.Name = "KorisniciAdmin";
            this.Text = "KorisniciAdmin";
            this.Load += new System.EventHandler(this.KorisniciAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKorisnici;
        private System.Windows.Forms.Button btnNoviKorisnik;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
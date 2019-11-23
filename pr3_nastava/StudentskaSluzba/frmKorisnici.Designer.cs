namespace StudentskaSluzba {
    partial class frmKorisnici {
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwKorisnici
            // 
            this.dgwKorisnici.AllowUserToAddRows = false;
            this.dgwKorisnici.AllowUserToDeleteRows = false;
            this.dgwKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Ime,
            this.Prezime,
            this.Image});
            this.dgwKorisnici.Location = new System.Drawing.Point(8, 62);
            this.dgwKorisnici.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwKorisnici.Name = "dgwKorisnici";
            this.dgwKorisnici.ReadOnly = true;
            this.dgwKorisnici.RowHeadersVisible = false;
            this.dgwKorisnici.RowHeadersWidth = 62;
            this.dgwKorisnici.RowTemplate.Height = 28;
            this.dgwKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKorisnici.Size = new System.Drawing.Size(517, 222);
            this.dgwKorisnici.TabIndex = 0;
            this.dgwKorisnici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKorisnici_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(442, 31);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 28);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Korisnicko Ime";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 150;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 8;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ime.Width = 150;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 8;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 150;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "AccountImage";
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgwKorisnici);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmKorisnici";
            this.Text = "frmKorisnici";
            this.Load += new System.EventHandler(this.frmKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKorisnici;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}
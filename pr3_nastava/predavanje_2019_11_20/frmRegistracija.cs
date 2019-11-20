using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace predavanje_2019_11_20 {
    public partial class frmRegistracija : Form {
        public frmRegistracija() {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e) {
            Korisnik korisnik = new Korisnik() { Ime = txtIme.Text, Prezime = txtPrezime.Text, Password = txtPassword.Text, Username = txtUsername.Text, Administrator = chkAdmin.Checked };

            DBInMemory.korisnici.Add(korisnik);

            DialogResult = DialogResult.OK;
        }
    }
}

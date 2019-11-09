using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezbe_2019_11_09_wfa {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            Korisnik korisnik = Baza.LoginKorisnika(txtUsername.Text, txtPassword.Text);

            if (korisnik == null) {
                MessageBox.Show("Pogresan username ili password!");
            } else {
                MessageBox.Show($"Dobrodosli {korisnik.Ime} {korisnik.Prezime}!");
                Close();
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(txtUsername.Text)) {
                errorProvider1.SetError(txtUsername, "Username obavezan");
                e.Cancel = true;
            } else {
                errorProvider1.Clear();
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(txtPassword.Text)) {
                errorProvider1.SetError(txtPassword, "Password obavezan");
                e.Cancel = true;
            } else {
                errorProvider1.Clear();
            }
        }
    }
}

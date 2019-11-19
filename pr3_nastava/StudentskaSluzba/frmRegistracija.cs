using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace StudentskaSluzba {
    public partial class frmRegistracija : Form {
        public frmRegistracija() {
            InitializeComponent();

            Baza.OnKorisnikSnimljen += Baza_OnKorisnikSnimljen;
        }

        private void Baza_OnKorisnikSnimljen(Korisnik korisnik) {
            MessageBox.Show("Prvi event: " + korisnik.Ime);
        }

        private void btnSnimi_Click(object sender, EventArgs e) {
            try {
                if (this.ValidateChildren()) {
                    Korisnik korisnik = new Korisnik();
                    korisnik.Ime = txtIme.Text;
                    korisnik.Prezime = txtPrezime.Text;
                    korisnik.Username = txtUsername.Text;
                    korisnik.Password = txtPassword.Text;
                    korisnik.Validate();
                    //Baza.Korisnici.Add(korisnik);
                    //Baza.SnimiKorisnika(korisnik, IspisiKorisnika(korisnik));
                    Baza.SnimiKorisnika(korisnik/*, x => MessageBox.Show(x.Ime)*/);

                    this.Close();
                }
            } catch (Exception) {
                MessageBox.Show("", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void IspisiKorisnika(Korisnik korisnik) {
            MessageBox.Show(korisnik.Ime);
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtUsername.Text)) {
                errorProvider.SetError(txtUsername, "Obavezno polje");
                e.Cancel = true;
            } else {
                errorProvider.SetError(txtUsername, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtPassword.Text)) {
                errorProvider.SetError(txtPassword, "Obavezno polje");
                e.Cancel = true;
            } else {
                errorProvider.SetError(txtPassword, "");
            }
        }
    }
}

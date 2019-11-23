using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace StudentskaSluzba {
    public partial class frmRegistracija : Form {
        Korisnik korisnik = null;

        public frmRegistracija(Korisnik korisnik = null) {
            InitializeComponent();

            Baza.OnKorisnikSnimljen += Baza_OnKorisnikSnimljen;
            this.korisnik = korisnik;
        }

        private void Baza_OnKorisnikSnimljen(Korisnik korisnik) {
            MessageBox.Show("Prvi event: " + korisnik.Ime);
        }

        private void btnSnimi_Click(object sender, EventArgs e) {
            try {
                if (this.ValidateChildren()) {
                    if (korisnik == null) {
                        korisnik = new Korisnik();

                        DodijeliAtributeKorisniku(korisnik);
                        //Baza.Korisnici.Add(korisnik);
                        //Baza.SnimiKorisnika(korisnik, IspisiKorisnika(korisnik));
                        Baza.SnimiKorisnika(korisnik/*, x => MessageBox.Show(x.Ime)*/);
                    } else {
                        DodijeliAtributeKorisniku(korisnik);
                    }

                    this.Close();
                }
            } catch (Exception) {
                MessageBox.Show("", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DodijeliAtributeKorisniku(Korisnik korisnik) {
            korisnik.Ime = txtIme.Text;
            korisnik.Prezime = txtPrezime.Text;
            korisnik.Username = txtUsername.Text;
            korisnik.Password = txtPassword.Text;
            korisnik.Validate();
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

        private void frmRegistracija_Load(object sender, EventArgs e) {
            if (korisnik != null) {
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtUsername.Text = korisnik.Username;
                txtPassword.Text = korisnik.Password;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            if (ofdPictureBox.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = Image.FromFile(ofdPictureBox.FileName);
            }
        }
    }
}

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
        Korisnik korisnik = null;

        public frmRegistracija() {
            InitializeComponent();
            cmbSpol.DataSource = DBInMemory.Spolovi;
        }

        public frmRegistracija(Korisnik korisnik) : this() {
            this.korisnik = korisnik;

            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtUsername.Text = korisnik.Username;
            txtPassword.Text = korisnik.Password;
            cmbSpol.Text = korisnik.Spol;
            chkAdmin.Checked = korisnik.Administrator;
        }

        private void btnSpremi_Click(object sender, EventArgs e) {
            if (korisnik == null) {
                korisnik = new Korisnik() {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Password = txtPassword.Text,
                    Username = txtUsername.Text,
                    Spol = cmbSpol.SelectedItem as string,
                    Administrator = chkAdmin.Checked
                };

                DBInMemory.DodajKorisnika(korisnik);
            } else {
                korisnik.Ime = txtIme.Text;
                korisnik.Prezime = txtPrezime.Text;
                korisnik.Password = txtPassword.Text;
                korisnik.Username = txtUsername.Text;
                korisnik.Spol = cmbSpol.SelectedItem as string;
                korisnik.Administrator = chkAdmin.Checked;

                DBInMemory.UpdateKorisnik();
            }

            Close();
        }

        private void frmRegistracija_Load(object sender, EventArgs e) {
        }
    }
}

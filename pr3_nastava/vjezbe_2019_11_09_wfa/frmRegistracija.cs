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
    public partial class frmRegistracija : Form {
        public frmRegistracija() {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e) {
            Korisnik korisnik = new Korisnik();

            korisnik.Ime = txtIme.Text;
            korisnik.Prezime = txtPrezime.Text;
            korisnik.Username = txtUsername.Text;
            korisnik.Password = txtPassword.Text;

            korisnik.Validiraj();

            Baza.Korisnici.Add(korisnik);

            Close();
        }
    }
}

using predavanje_2019_11_06_wfa.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace predavanje_2019_11_06_wfa {
    public partial class Registracija : Form {
        public Registracija() {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e) {
            Korisnik novi = new Korisnik() {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                KorisnickoIme = txtUsername.Text,
                Lozinka = txtPassword.Text
            };

            DBInMemory.RegistrovaniKorisnici.Add(novi);
            Close();
        }

        private void txtIme_TextChanged(object sender, EventArgs e) {
            txtUsername.Text = txtIme.Text.ToLower();
        }
    }
}

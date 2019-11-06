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
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string korisnickoIme = txtUsername.Text;
            string lozinka = txtPassword.Text;

            if (string.IsNullOrEmpty(korisnickoIme) || string.IsNullOrEmpty(lozinka)) {
                return;
            }

            foreach (var korisnik in DBInMemory.RegistrovaniKorisnici) {
                if (korisnickoIme == korisnik.KorisnickoIme && lozinka == korisnik.Lozinka) {
                    MessageBox.Show($"Hello {korisnik}!");
                    return;
                }
            }

            MessageBox.Show("No no no!");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }
    }
}

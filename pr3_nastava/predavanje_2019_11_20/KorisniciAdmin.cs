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
    public partial class KorisniciAdmin : Form {
        public KorisniciAdmin() {
            InitializeComponent();
            dgwKorisnici.AutoGenerateColumns = false;
            DBInMemory.DodanKorisnik += DBInMemory_DodanKorisnik;
        }

        private void DBInMemory_DodanKorisnik() {
            dgwKorisnici.DataSource = null;
            dgwKorisnici.DataSource = DBInMemory.korisnici;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e) {
            dgwKorisnici.DataSource = DBInMemory.korisnici;
        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e) {
            frmRegistracija forma = new frmRegistracija();
            forma.ShowDialog();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e) {
            string trazeniText = txtPretraga.Text.ToLower();

            var rezultatPretrage = DBInMemory.korisnici.FindAll(x => x.Ime.ToLower().Contains(trazeniText) || x.Prezime.ToLower().Contains(trazeniText));

            //foreach (var korisnik in DBInMemory.korisnici) {
            //    if (korisnik.Ime.Contains(trazeniText) || korisnik.Prezime.Contains(trazeniText)) {
            //        rezultatPretrage.Add(korisnik);
            //    }
            //}

            dgwKorisnici.DataSource = null;
            dgwKorisnici.DataSource = rezultatPretrage;
        }

        private void dgwKorisnici_MouseClick(object sender, MouseEventArgs e) {
            Korisnik korisnik = dgwKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            Text = korisnik?.Ime;
        }
    }
}

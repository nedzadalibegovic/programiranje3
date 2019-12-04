using System;
using System.Collections.Generic;
using System.Linq;
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

            // var - compile-time
            var Ime = "Nedzad";
            // Ime.Length

            // dynamic - run-time, moguce mijenjati tip podatka
            dynamic dyIme = "Nedzad";
            // npr. dyIme = 12;
            // dyIme.Length ???

            // extend method
            //MessageBox.Show(Ime.Enkripcija());

            //Tuple<string, string> tuple = Tuple.Create("Nedzad", "Alibegovic");
            var tuple = (Ime: "Nedzad", Prezime: "Alibegovic");

            var student = new { Ime = "Nedzad", Indeks = 180037 };

            // LINQ
            List<Korisnik> denisi = (from korisnik in DBInMemory.korisnici
                                     where korisnik.Ime == "Denis"
                                     select korisnik).ToList();

            //List<Korisnik> test = DBInMemory.korisnici.FindAll(x => x.Ime == "Denis");
        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e) {
            frmRegistracija forma = new frmRegistracija();
            forma.ShowDialog();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e) {
            string trazeniText = txtPretraga.Text.ToLower();

            //foreach (var korisnik in DBInMemory.korisnici) {
            //    if (korisnik.Ime.Contains(trazeniText) || korisnik.Prezime.Contains(trazeniText)) {
            //        rezultatPretrage.Add(korisnik);
            //    }
            //}

            //var rezultatPretrage = DBInMemory.korisnici.FindAll(x => x.Ime.ToLower().Contains(trazeniText) || x.Prezime.ToLower().Contains(trazeniText));

            //var rezultatPretrage = (from korisnik in DBInMemory.korisnici
            //                        where korisnik.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
            //                        select korisnik).ToList();

            //var rezultatPretrage = DBInMemory.korisnici.Where(x => x.Ime.ToLower().Contains(trazeniText)).ToList();

            var rezultatPretrage = DBInMemory.korisnici.Where(x => x.Ime.ToLower().Contains(trazeniText) || x.Prezime.ToLower().Contains(trazeniText)).ToList();

            var comboBox = DBInMemory.korisnici.FindAll(x => x.Ime.ToLower().Contains(trazeniText) || x.Prezime.ToLower().Contains(trazeniText));

            comboBox1.DisplayMember = "Ime";
            comboBox1.DataSource = comboBox;

            dgwKorisnici.DataSource = null;
            dgwKorisnici.DataSource = rezultatPretrage;
        }

        private void dgwKorisnici_MouseClick(object sender, MouseEventArgs e) {
            Korisnik korisnik = dgwKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            Text = korisnik?.Ime;
        }
    }
}

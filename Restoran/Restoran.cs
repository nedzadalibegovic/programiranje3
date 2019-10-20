using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran
{
    class Restoran
    {
        public string naziv { get; set; }
        public string adresa { get; set; }
        public string brojTelefona { get; set; }
        public Meni meni { get; set; }
        public List<Narudzba> narudzbe { get; set; }

        public Restoran(string naziv, string adresa, string brojTelefona)
        {
            this.naziv = naziv;
            this.adresa = adresa;
            this.brojTelefona = brojTelefona;
            meni = new Meni();
        }

        public void dodajPice(string naziv, double cijena)
        {
            meni.pica.Add(new Pice(naziv, cijena));
        }

        public void dodajJelo(string naziv, double cijena)
        {
            meni.jela.Add(new Jelo(naziv, cijena));
        }

        public override string ToString()
        {
            return $"Naziv: {naziv}\nAdresa: {adresa}\nBroj telefona: {brojTelefona}\n<=== Meni ===>\n{meni}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran
{
    class Klijent
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public string brojTelefona { get; set; }

        public Klijent(string ime, string prezime, string adresa, string brojTelefona)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.brojTelefona = brojTelefona;
        }

        public override string ToString()
        {
            return $"{ime} {prezime}\n{adresa}\n{brojTelefona}";
        }
    }
}

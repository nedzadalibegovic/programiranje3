using System;
using System.Collections.Generic;
using System.Text;

namespace vjezbe_2019_11_09_wfa {
    class Korisnik {
        public string Username { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Password { get; set; }

        public void Validiraj() {
            if (Password.Length < 3) {
                throw new ApplicationException("Neispravan password!");
            }
        }
    }
}

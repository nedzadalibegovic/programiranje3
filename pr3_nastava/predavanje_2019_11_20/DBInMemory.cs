using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predavanje_2019_11_20 {
    static class DBInMemory {
        public static List<Korisnik> korisnici = new List<Korisnik>();

        public static event Action DodanKorisnik;

        static DBInMemory() {
            korisnici.Add(new Korisnik() { Ime = "Nedzad", Prezime = "Alibegovic", Username = "nele", Password = "nele", Administrator = true });
            korisnici.Add(new Korisnik() { Ime = "Denis", Prezime = "Music", Username = "denis", Password = "denis", Administrator = false });
        }

        public static void DodajKorisnika(Korisnik korisnik) {
            korisnici.Add(korisnik);
            DodanKorisnik();
        }
    }

    class Korisnik {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Administrator { get; set; }
    }
}

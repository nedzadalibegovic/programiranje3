using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predavanje_2019_11_06_wfa.database {
    class DBInMemory {
        public static List<Korisnik> RegistrovaniKorisnici { get; set; }

        static DBInMemory() {
            RegistrovaniKorisnici = new List<Korisnik>();
            UcitajOsnovneKorisnike();
        }

        private static void UcitajOsnovneKorisnike() {
            Korisnik k1 = new Korisnik() {
                Ime = "Denis",
                Prezime = "Music",
                KorisnickoIme = "denis",
                Lozinka = "denis"
            };

            Korisnik k2 = new Korisnik() {
                Ime = "Jasmin",
                Prezime = "Azemovic",
                KorisnickoIme = "jasmin",
                Lozinka = "jasmin"
            };

            RegistrovaniKorisnici.Add(k1);
            RegistrovaniKorisnici.Add(k2);
        }
    }

    class Korisnik {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public override string ToString() {
            return $"{Ime} ({KorisnickoIme}) {Prezime}";
        }
    }
}

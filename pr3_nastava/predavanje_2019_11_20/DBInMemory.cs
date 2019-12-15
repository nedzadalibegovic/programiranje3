using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predavanje_2019_11_20 {
    static class DBInMemory {
        public static List<Korisnik> korisnici = new List<Korisnik>();
        public static List<string> Spolovi { get; set; } = new List<string>();

        public static event Action DodanKorisnik;

        static DBInMemory() {
            korisnici.Add(new Korisnik() {
                Ime = "Nedzad",
                Prezime = "Alibegovic",
                Username = "nele",
                Password = "nele",
                Spol = "Muski",
                Administrator = true
            });

            korisnici.Add(new Korisnik() {
                Ime = "Denis",
                Prezime = "Music",
                Username = "denis",
                Password = "denis",
                Spol = "Muski",
                Administrator = false
            });

            Spolovi.Add("Muski");
            Spolovi.Add("Zenski");
            Spolovi.Add("******");
        }

        public static void DodajKorisnika(Korisnik korisnik) {
            korisnici.Add(korisnik);
            DodanKorisnik?.Invoke();
        }

        public static void UpdateKorisnik() {
            DodanKorisnik?.Invoke();
        }
    }

    public class Korisnik {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Spol { get; set; }
        public bool Administrator { get; set; }
    }

    public class Predmet {
        public string Naziv { get; set; }
    }

    public class PolozeniPredmet : Predmet {
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
    }
}

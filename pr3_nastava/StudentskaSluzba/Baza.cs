using System;
using System.Collections.Generic;

namespace StudentskaSluzba {
    static class Baza {
        public static List<Korisnik> Korisnici { get; set; } = new List<Korisnik>();
        public static List<Ucionica> Ucionice { get; set; } = new List<Ucionica>();

        public delegate void KorisnikSnimljen(Korisnik korisnik);
        public static event KorisnikSnimljen OnKorisnikSnimljen;
        //public static event Action<Korisnik> OnKorisnikSnimljen;

        public static event Action<Ucionica> OnUcionicaSnimljen;

        static Baza() {
            Korisnici.Add(new Korisnik { Ime = "Nedzad", Prezime = "Alibegovic", Username = "nedzad", Password = "qweasd" });
            Korisnici.Add(new Korisnik { Ime = "Adis", Prezime = "Kubat", Username = "adis", Password = "qwerty" });
        }

        public static void SnimiKorisnika(Korisnik korisnik/*, Action<Korisnik> prikaz*/) {
            Korisnici.Add(korisnik);

            OnKorisnikSnimljen(korisnik);
        }

        public static void SnimiUcionicu(Ucionica ucionica) {
            Ucionice.Add(ucionica);

            OnUcionicaSnimljen(ucionica);
        }

        public static bool Login(string username, string password) {
            foreach (var item in Korisnici) {
                if (item.Username.Equals(username, StringComparison.InvariantCultureIgnoreCase)
                    && item.Password == password) {
                    return true;
                }
            }

            return false;
        }
    }
}

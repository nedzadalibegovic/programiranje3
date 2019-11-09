using System;
using System.Collections.Generic;
using System.Text;

namespace vjezbe_2019_11_09_wfa {
    static class Baza {
        public static List<Korisnik> Korisnici { get; set; } = new List<Korisnik>();

        public static Korisnik LoginKorisnika(string username, string password) {
            foreach (var korisnik in Korisnici) {
                if (korisnik.Username.Equals(username, StringComparison.InvariantCultureIgnoreCase) && korisnik.Password == password) {
                    return korisnik;
                }
            }

            return null;
        }
    }
}
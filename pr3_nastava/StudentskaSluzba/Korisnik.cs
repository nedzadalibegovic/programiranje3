using System;

namespace StudentskaSluzba {
    public class Korisnik {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void Validate() {
            if (Password.Length < 3) {
                throw new ApplicationException("Password nije ispravan!");
            }
        }
    }
}

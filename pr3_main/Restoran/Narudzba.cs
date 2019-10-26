using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran {
    class Narudzba {
        public Klijent klijent { get; set; }
        public Dictionary<Namirnica, int> namirnice { get; set; }
        public double cijena { get; set; }
        public bool isporuceno { get; set; }

        public Narudzba(Klijent klijent) {
            this.klijent = klijent;
            this.namirnice = new Dictionary<Namirnica, int>();
            this.cijena = 0;
            this.isporuceno = false;
        }

        private void updateCijena() {
            double ukupno = 0;

            foreach (var namirnica in namirnice) {
                ukupno += namirnica.Key.cijena * namirnica.Value;
            }

            cijena = ukupno;
        }

        public void ispisRacuna() {
            Console.WriteLine($"Klijent:\n{klijent}");
            Console.WriteLine("Namirnice:");

            foreach (var namirnica in namirnice) {
                Console.WriteLine($"{namirnica.Key} Kolicina: {namirnica.Value}");
            }

            Console.WriteLine($"Konacna cijena: {cijena} KM");
        }

        public void dodajNamirnicu(Namirnica namirnica, int kolicina) {
            if (namirnice.ContainsKey(namirnica)) {
                namirnice[namirnica] += kolicina;
            } else {
                namirnice.Add(namirnica, kolicina);
            }

            updateCijena();
        }
    }
}

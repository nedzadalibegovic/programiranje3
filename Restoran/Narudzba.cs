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

        public void dodajNamirnicu(Namirnica namirnica, int kolicina) {
            if (namirnice.ContainsKey(namirnica)) {
                namirnice[namirnica] += kolicina;
            } else {
                namirnice.Add(namirnica, kolicina);
            }
        }
    }
}

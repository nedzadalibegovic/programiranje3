using System;
using System.Collections.Generic;
using System.Text;

namespace vjezbe_2019_10_26 {
    abstract class Osoba {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public virtual void PrikaziPodatke() {
            Console.WriteLine($"{Ime} {Prezime}");
        }
    }
}

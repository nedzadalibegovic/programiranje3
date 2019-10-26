using System;
using System.Collections.Generic;
using System.Text;

namespace vjezbe_2019_10_26 {
    class Profesor : Osoba {
        public string Titula { get; set; }

        public override void PrikaziPodatke() {
            Console.Write($"Profesor: {Titula} ");
            base.PrikaziPodatke();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace vjezbe_2019_10_26 {
    class Student : Osoba {
        public int Index { get; set; }
        public int[] Ocjene { get; set; } = new int[20];

        public void Deconstruct(out string ime, out string prezime) {
            ime = this.Ime;
            prezime = this.Prezime;
        }

        public int this[int index] {
            get { return Ocjene[index]; }
            set { Ocjene[index] = value; }
        }

        public override void PrikaziPodatke() {
            Console.Write("Student: ");
            base.PrikaziPodatke();
        }
    }
}

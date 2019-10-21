using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran {
    class Meni {
        public List<Jelo> jela { get; set; }
        public List<Pice> pica { get; set; }

        public Meni() {
            jela = new List<Jelo>();
            pica = new List<Pice>();
        }

        public override string ToString() {
            string output = new string("Jela:\n");

            foreach (var jelo in jela) {
                output += jelo.ToString() + "\n";
            }

            output += "\nPica:\n";

            foreach (var pice in pica) {
                output += pice.ToString() + "\n";
            }

            return output;
        }
    }
}

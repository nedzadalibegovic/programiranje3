using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran {
    abstract class Namirnica {
        public string naziv { get; set; }
        public double cijena { get; set; }

        public override string ToString() {
            return $"{naziv} - {cijena}KM";
        }
    }
}

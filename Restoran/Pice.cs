using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran
{
    class Pice : Namirnica
    {
        public Pice(string naziv, double cijena)
        {
            this.naziv = naziv;
            this.cijena = cijena;
        }
    }
}

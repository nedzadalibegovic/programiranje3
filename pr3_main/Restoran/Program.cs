using System;

namespace Restoran {
    class Program {
        static void napraviMeni(Restoran restoran) {
            restoran.dodajPice("Coca-Cola", 3.00);
            restoran.dodajPice("Cockta", 3.00);
            restoran.dodajPice("Cedevita", 2.50);
            restoran.dodajPice("Jogurt", 1.00);
            restoran.dodajPice("Red Bull", 5.00);
            restoran.dodajPice("Karlovacko", 3.00);
            restoran.dodajPice("Karlovacko Toceno", 3.20);
            restoran.dodajPice("Fanta", 3.00);
            restoran.dodajPice("Kisela voda", 2.00);
            restoran.dodajPice("Senzacija", 2.00);
            restoran.dodajPice("Cappy", 3.50);
            restoran.dodajPice("Hell", 3.00);

            restoran.dodajJelo("Palacinak", 4.00);
            restoran.dodajJelo("Piletina Cordon Blau", 7.50);
            restoran.dodajJelo("Biftek", 12.00);
            restoran.dodajJelo("Grah", 4.50);
            restoran.dodajJelo("Hamburger", 4.50);
            restoran.dodajJelo("Pomfrit", 2.00);
            restoran.dodajJelo("Kadaif", 2.30);
            restoran.dodajJelo("Marzipan", 2.50);
            restoran.dodajJelo("Pizza", 5.00);
            restoran.dodajJelo("Pizza Velika", 10.00);
            restoran.dodajJelo("Teleca snicla", 9.50);
            restoran.dodajJelo("Karadzordjeva snicla", 8.50);
        }

        static void Main(string[] args) {
            Restoran maksumic = new Restoran("Maksumic", "Jablanica bb", "33445566");
            napraviMeni(maksumic);

            //Console.WriteLine(maksumic.ToString());

            Klijent harun = new Klijent("Harun", "Suckblyatovic", "Marsala Tita 76", "+666");

            Narudzba narudzba = new Narudzba(harun);

            narudzba.dodajNamirnicu(maksumic.meni.jela[5], 2);
            narudzba.dodajNamirnicu(maksumic.meni.jela[5], 3);
            narudzba.dodajNamirnicu(maksumic.meni.pica[5], 1);

            narudzba.ispisRacuna();
        }
    }
}

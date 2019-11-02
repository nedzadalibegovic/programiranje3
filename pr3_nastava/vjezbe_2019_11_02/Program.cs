using System;

namespace vjezbe_2019_11_02 {
    class Program {
        static void Main(string[] args) {
            ILista<int> lista = new DotNetLista<int>();

            lista.Dodaj(4000);
            lista.Dodaj(21);
            lista.Brisi();

            lista.Ispis("Test");
        }
    }
}

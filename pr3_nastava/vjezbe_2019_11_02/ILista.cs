using System;
using System.Collections.Generic;
using System.Text;

namespace vjezbe_2019_11_02 {
    interface ILista<T> {
        T[] Elementi { get; }

        void Dodaj(T vrijednost);
        void Brisi();
        void Ispis<Z>(Z vrijednost);
    }

    class FITLista<T> : ILista<T> {
        public T[] Elementi { get; private set; }
        int pozicija = 0;

        public FITLista() {
            Elementi = new T[100];
        }

        public void Brisi() {
            Elementi[--pozicija] = default;
        }

        public void Dodaj(T vrijednost) {
            Elementi[pozicija++] = vrijednost;
        }

        public void Ispis<Z>(Z vrijednost) {
            Console.WriteLine(typeof(Z).ToString());
        }
    }

    class DotNetLista<T> : ILista<T> {
        List<T> privatnaLista = new List<T>();
        public T[] Elementi => privatnaLista.ToArray();

        public void Brisi() {
            privatnaLista.RemoveAt(0);
        }

        public void Dodaj(T vrijednost) {
            privatnaLista.Add(vrijednost);
        }

        public void Ispis<Z>(Z vrijednost) {
            Console.WriteLine(typeof(Z).ToString());
        }
    }
}

using System;

namespace ConsoleApp1 {
    class Program {

        static void kopiranjePoVrijednosti(Student student) {
            // ne kopira se objekt, kopira se referenca!
            // parametri se kopiraju po vrijednosti, ako bismo preusmjerili
            // pokazivac, ne bismo promijenili orginalni objekat
            student.index = 1;
        }

        static void primjerReferenca(ref Student student) {
            // u pozivu mora biti ref i objekat mora biti inicijalizovan
            student = new Student() { index = 555555 };
        }

        static void primjerOut(out Student student) {
            // imamo obavezu inicijalizovati poslani objekat (takoder se po
            // referenci salje u funkciju)
            student = new Student() { index = 11111 };
        }

        static int Sumiraj(params int[] niz) {
            int suma = 0;

            for (int i = 0; i < niz.Length; i++) {
                suma += niz[i];
            }

            return suma;
        }

        static void PrikaziStudentInfo(Student student) {
            int? index = student?.index;
            int index2 = student?.index ?? 0;

            Console.WriteLine(student);
        }

        static void Main(string[] args) {
            Student denis = new Student() {
                index = 150051,
                ime = "denis",
                prezime = "music"
            };

            //Console.WriteLine(denis);
            //kopiranjeReferencePoVrijednosti(denis);
            //Console.WriteLine(denis);

            int extIndex;
            string extIme;
            string extPrezime;

            denis.Deconstruct(out extIndex, out extIme, out extPrezime);
            Console.WriteLine($"{extIndex} {extIme} {extPrezime}");
            Console.WriteLine(denis);

            Console.WriteLine(Sumiraj(1, 34, 6, 3, 6347));

            PrikaziStudentInfo(null);

            Student s = new Student();

            s[0] = 9;

            Console.WriteLine(s[0]);
        }
    }

    class Student {
        // vrijednost se mora odmah postaviti: 
        // public const int const_index = 150000;

        // vrijednost se moze jedino postaviti u ctoru:
        // public readonly int readonly_index;
        public int index { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }

        int[] ocjene = new int[40];

        public int this[int lokacija] {
            get { return ocjene[lokacija]; }
            set { ocjene[lokacija] = value; }
        }

        public void Deconstruct(out int index, out string ime, out string prezime) {
            index = this.index;
            ime = this.ime;
            prezime = this.prezime;
        }

        public override string ToString() {
            return $"{index} {ime} {prezime}";
        }
    }

    struct Predmet {
        public string naziv { get; set; }

        public override string ToString() {
            return naziv;
        }
    }
}

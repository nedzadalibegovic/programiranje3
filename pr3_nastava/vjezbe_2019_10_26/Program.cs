using System;

namespace vjezbe_2019_10_26 {
    class Program {
        static void Main(string[] args) {
            Student amel = new Student();
            amel.Ime = "Amel";
            amel.Prezime = "Music";
            amel.Ocjene[19] = 10;
            amel[11] = 9;

            Console.WriteLine(amel[11]);

            //promjeniIme(amel);

            //string strBroj = Console.ReadLine();

            //int broj;
            ////var brIndexa = int.Parse(strBroj);
            //if (int.TryParse(strBroj, out broj)) {
            //    amel.Index = broj;
            //}

            //(var ime, _) = amel;

            Profesor denis = new Profesor();
            denis.Ime = "Denis";
            denis.Prezime = "Music";
            denis.Titula = "doc.dr";

            amel.PrikaziPodatke();
            denis.PrikaziPodatke();

            Console.WriteLine($"Student: {amel.Ime} {amel.Prezime}");
            Console.WriteLine($"Profesor: {denis.Ime} {denis.Prezime}");
        }

        static void promjeniIme(Student student) {
            student.Ime = "Denis";
        }
    }
}

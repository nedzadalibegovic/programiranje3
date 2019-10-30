using System;
using System.IO;

// interfejsi, using, genericke klase, login
namespace predavanje_2019_10_30 {
    class Program {
        static void Zamjeni<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }

        static void InterfaceDemo(ILogger logger) {
            try {
                throw new Exception("Greska");
            } catch (Exception ex) {
                logger.Log();
            }
        }

        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            int a = 10, b = 20;

            Console.WriteLine($"{a}{b}");
            Zamjeni(ref a, ref b);
            Console.WriteLine($"{a}{b}");

            FileLogger logg = new FileLogger();
            ((ILogger)logg).Log();

            InterfaceDemo(new DBLogger());
            InterfaceDemo(new FileLogger());
        }
    }

    interface ILogger {
        void Log() {
            Console.WriteLine("test");
        }
    }

    class FileLogger : ILogger {
        public string PutanjaFajla { get; set; }
    }

    class DBLogger : ILogger {
        public void Log() {
            Console.WriteLine("Upisujem u bazu podataka");
        }
    }

    interface IKultura {
        void PredstaviSe();
    }

    class Student : IKultura {
        public void PredstaviSe() {
            Console.WriteLine("Ja sam student FIT-a");
        }
    }

    class Ucenik : IKultura {
        public void PredstaviSe() {
            Console.WriteLine("Ja sam ucenik srednje skole");
        }
    }

    class Baza<T> where T : class {
        T GetByID(int id) { return null; }
        int Insert(T obj) { return 0; }
    }

    class DBStudent : Baza<Student> { 
    }
}

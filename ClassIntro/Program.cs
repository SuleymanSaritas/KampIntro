using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmeni = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmeni = "Kerem Varıs";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.Egitmeni = "BErkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Egitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (Kurs kurs  in kurslar)
            {
                Console.WriteLine(kurs.kursAdi+" : " +kurs.Egitmeni);
            }
      

           
        }
    }



    class Kurs
    {
        public string kursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

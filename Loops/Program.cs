using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //array 
            string[] kurslar = new string[] {"Yazılım Geliştirme Kampı",
                "Programlamaya Başlangıç için temel kurs ","Java","c#"}; 

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu -footer"); //footer alt bilgi 

        }
    }
}

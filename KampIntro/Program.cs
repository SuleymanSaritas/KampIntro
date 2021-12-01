using System;
using System.Collections.Generic;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {   //type safety 
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis butonu ");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artis butonu ");
            }
            else
            {
                Console.WriteLine("Esittir butonu ");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu ");
            }
            else
            {
                Console.WriteLine("Giris yap butonu ");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{          //encapsulation
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
            
        }
        public void Ekle2(Urun urun) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(string Adi,string Soyadi)
        {
            Console.WriteLine(Adi + Soyadi+" Tebrikler. Müşteri eklendi..." );
        }

        public double Listele(double Maas)
        {
            double zam = Maas + 1000;
            Console.WriteLine("Zam eklenmiş yeni maaşınız: "+zam);
            return zam;
        }

        public void Kontrol(string Aciklama)
        {
            if (Aciklama.Length.ToString() == "10")
            {
                Console.WriteLine("Bilgileriniz: "+Aciklama);
            }
            else
            {
                Console.WriteLine("Aciklama çok uzun .Daha kısa bilgiler girin lütfen");
            }
        }


    }
}

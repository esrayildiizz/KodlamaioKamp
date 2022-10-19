using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123";
            musteri1.Adi = "Esra";
            musteri1.Soyadi = "Yıldız";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "987";
            musteri2.SirketAdi = "Kodlamaio";
            musteri2.VergiNo = "2356";
        }
    }
}

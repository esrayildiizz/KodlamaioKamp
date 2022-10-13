using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteri = new MusteriManager();
            musteri.Ekle("Ahmet","YILDIZ");
            musteri.Listele(5000);
            musteri.Kontrol("Ekim ayında işe girdi");
            Console.ReadLine();
        }
    }
}

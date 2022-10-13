using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Kursu";
            //string kurs2 = "Temel Kursu";
            //string kurs3 = "Java";

            //Yukarıdaki ifadeleri tek tek tanımlamak yerine bunları tek bir listede tuttuk.
            //array-dizi

            string[] kurslar = new string[]
            {"Yazılım Kursu","Temel Kurs","Java","Pyton","C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.ReadLine();
        }
    }
}

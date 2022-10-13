using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin DEMİROĞ";
            kurs1.IzlenmeOrani=76;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ali YILDIZ";
            kurs2.IzlenmeOrani = 46;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Kerem Can";
            kurs3.IzlenmeOrani = 96;

            Console.WriteLine("1.Kursun adı ve eğitmeni : " + kurs1.KursAdi + ", " + kurs1.Egitmen);
            Console.WriteLine("2.Kursun adı ve eğitmeni : " + kurs2.KursAdi + ", " + kurs2.Egitmen);
            Console.WriteLine("3.Kursun adı ve eğitmeni : " + kurs3.KursAdi + ", " + kurs3.Egitmen);

            Console.ReadLine();
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}

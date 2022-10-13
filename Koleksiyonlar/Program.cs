using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Esra", "Enes", "Nur", "Ayla" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string> { "Esra", "Enes", "Nur", "Ayla" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ayşe"); //Koleksiyonumuzda Ayşe yoktu fakat biz LİST koleksiyonunun içinde hazır gelen Add komutu ile ekleme işlemi yaptık.
            Console.WriteLine(isimler2[4]);

            Console.ReadLine();

        }
    }
}

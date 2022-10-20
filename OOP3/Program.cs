using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bunları kredi çeşitleri ekranı gibi düşün
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager);
            basvuruManager.BasvuruYap(tasitKrediManager);
            basvuruManager.BasvuruYap(ıhtiyacKrediManager);
;
        }
    }
}

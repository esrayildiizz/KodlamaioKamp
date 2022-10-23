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

            //elimde iki tane loglayıcı var.
            ILoggerService datababaseloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            


            List<IKrediManager> krediler = new List<IKrediManager> {ıhtiyacKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
;
        }
    }
}

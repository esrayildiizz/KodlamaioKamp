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
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            //elimde iki tane loglayıcı var.
            ILoggerService datababaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService(); //instance oluşturmuş oluyoruz.



            //Kendi listemi oluşturdum ve adını loggers koydum.
            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService(), new FileLoggerService() };



            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, loggers); //Burada istediğimi çağırırım.
            // yukarı parantez içine :( new EsnafKrediManager(), new DatabaseLoggerService() )da yazabilirim. Yani ister böyle istersem de instance halini yazabilirim.
            
            //krediler adında listemi oluşturdum.Bunu istediğim yere çağırabilirim.
            List<IKrediManager> krediler = new List<IKrediManager> {ıhtiyacKrediManager,tasitKrediManager,esnafKrediManager,konutKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
;
        }
    }
}

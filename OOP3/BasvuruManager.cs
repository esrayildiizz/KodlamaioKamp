using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Önemli
        //Parantez içine IKrediManager yazdık çünkü tüm kredi tiplerinin referens tutucusudur.
        //Ben bu metodu aynı zamanda loglamak da istediğim ile virgül koyup ILoggerService yi de eklendim.
        //Soyut hallerini parantez içine yazıp somut hallerini aşağıya yazıyorum.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) 
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }


        //ben hangi kredi türünden bilgilendirme istiyorsam o bana liste olarak dönsün .O liste de IKrediManager den alsın bilgileri
        //çünkü IKrediManager tüm kredi türlerinin referansını tutuyor.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            //burada bir liste olduğu için her bir krediyi tek tek dolaşmak gerekir.
            foreach (var kredi in krediler)
            {
                kredi.Hesapla(); //listedeki her bir kredinin hesabını yap.
            }
        }


    }
}

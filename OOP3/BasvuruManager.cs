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
        public void BasvuruYap(IKrediManager krediManager) //Parantez içine IKrediManager yazdık çünkü tüm kredi tiplerinin referens tutucusudur.
        {
            krediManager.Hesapla();
        }

        //ben hangi kredi türünden bilgilendirme istiyorsam o bana liste olarak dönsün .O liste de IKrediManager den alsın bilgileri
        //çünkü IKrediManager tüm kredi türlerinin referansını tutuyor.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{   //kendimizi tekrar edeceğimiz kod bloklarımız olursa onları birer metot haline getirin ve o metotları tekrar tekrar kullanalım.
    //Tabi bu metotlarla birlikte Clean Code denilen temiz kod yazma teknikleri kendini gösterir.
    //Best Practice :doğru uygulama teknikleri.
    //dont repait yoursef =DRY (kendini tekrar etme)
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 3.5d;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 9.5d;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            Console.WriteLine("ÜRÜN LİSTESİ");
            //type-safe  -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("------------------Metotlar------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);









            Console.ReadLine();
        }
    }
    
}

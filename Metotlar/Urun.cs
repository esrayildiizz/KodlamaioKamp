using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     public class Urun
    {
        // ID :bir data yı diğerlerinden ayırt etmek için kullandığımız eşsiz değeri anlatır.
        //Property:Özellik demek. Aşağıdakilerin her biri birer property dir.

        public int Id { get; set; }

        public string Adi { get; set; }

        public double Fiyati { get; set; }

        public string Aciklama { get; set; }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{    //product sınıfının özelliklerini class içerisinde tanımlıyoruz.
    public class Product
    {

        public int Id { get; set; }

        public int CategoryId { get; set; } //İlişkili tablomuz yani foreign key.

        public string ProductName { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }


    }
}

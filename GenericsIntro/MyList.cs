using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T> //Bana tip(T) ver ben aşağıda ona göre işlem yapacağım
    {
        T[] items;

        public MyList() //constructor metot :Sınıf ismi ile aynı olmalıdır.Class ı bir yerde new lediğimde burası çalışıyor.
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items; //Eklenen itemler new lendiğinde kaybolur ve kaybolmasını istemediğimiz için biz bunları tempArray de saklarız.
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items [items.Length - 1] = item;
        }
    }
}

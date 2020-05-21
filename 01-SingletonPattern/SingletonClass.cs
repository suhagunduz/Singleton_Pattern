using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingletonPattern
{
    class SingletonClass
    {
        //1) private static ve geriye class tipinde dönen bir field tanımlanır.
        private static SingletonClass _tekNesne;

        //2) constructor private veya protected yapılarak erişim newleme yapılması engellenir
        private SingletonClass()
        {
        }
        //3) newleme işleminin yapıldığı geriye class tipinde dönen bir metot / property oluşturulur. Bu yapı içerisinde nesne önceden üretilmiş mi kontrol edilir üretilmediyse üretililir üretildiyse aynı nesne geri gönderilir.
        public static SingletonClass Sinif
        {
            get
            {
                if(_tekNesne == null)
                {
                    _tekNesne = new SingletonClass();
                }
                return _tekNesne;
            }
        }

        private DateTime now = DateTime.Now;

        public DateTime GetCurrentDate() => now;

        public int toplam(int s1, int s2)
        {
            return s1 + s2;
        }

        public int carp (int s1, int s2)
        {
            return s1 * s2;
        }

        public string yaz()
        {
            return ("Mühendislik Tamamlama - Süha Aşkın Gündüz - 192803079");
        }


    }
}

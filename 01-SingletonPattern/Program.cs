using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_SingletonPattern
{
    class Program
    {
        //.NET KONF
        static void Main(string[] args)
        {
            int toplam1 = SingletonClass.Sinif.toplam(3, 2);
            int carpim = SingletonClass.Sinif.carp(3, 2);
            Console.WriteLine("Toplam Sonucu: "+toplam1);
            Console.WriteLine("Carpim Sonucu: "+carpim);
            Console.WriteLine("Toplam + Carpim Sonucu = " + (toplam1 + carpim));
            Console.WriteLine(SingletonClass.Sinif.yaz());
            
            Console.WriteLine(SingletonClass.Sinif.GetCurrentDate());
            Thread.Sleep(3000);
            Console.WriteLine(SingletonClass.Sinif.GetCurrentDate());

            Console.ReadKey();
        }
    }
}

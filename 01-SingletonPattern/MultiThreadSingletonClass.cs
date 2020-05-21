using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingletonPattern
{
    class MultiThreadSingletonClass
    {
        private static MultiThreadSingletonClass _tekNesne;
        private static Object lockObject = new Object();
        private MultiThreadSingletonClass()
        {

        }

        public static MultiThreadSingletonClass Sinif
        {
            get
            {
                if (_tekNesne == null)
                {
                    lock(lockObject)
                    {
                        if (_tekNesne == null)
                        {
                            _tekNesne = new MultiThreadSingletonClass();
                        }
                    }
                }
                return _tekNesne;
            }
        }

    }
}

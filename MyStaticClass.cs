using EXTENSION_METHOD_DEMO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exception_Handling
{
    static class MyStaticClass
    {
        public static void Func3(this Person P,int i)
        {
            Console.WriteLine("This is third Method...."+i);
        }
        public static bool IsGraterThan(this int i, int value)
        {
            return i > value;
        }
    }
}

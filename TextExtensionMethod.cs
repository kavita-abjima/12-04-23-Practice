using EXTENSION_METHOD_DEMO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class TextExtensionMethod
    {
        static void Main()
        {
            Person P = new Person();
            P.Func1();
            P.Func2();
            P.Func3(20);

            int i = 30;
            bool result = i.IsGraterThan(50);
            Console.WriteLine(result);
            Console.ReadLine();
        }
       

    }
}
 
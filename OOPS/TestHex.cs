using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class TestHex
    {
        static void Main()
        {
            Hex h1 = new Hex();
            Hex h2 = new Hex();

            Console.WriteLine(h1.getNum());

            h1.setNum("FF");
            h2.setNum("10");

             Console.WriteLine(h2.getNum());

             Console.WriteLine(h2.toDecimal());

             Console.WriteLine(h2.toBinary());
           
        }
    }
}

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

            Console.WriteLine(h1.getNum());

            h1.setNum("FF");

            Console.WriteLine(h1.getNum());

            Console.WriteLine(h1.toDecimal());

            Console.WriteLine(h1.toBinary());
        }
    }
}

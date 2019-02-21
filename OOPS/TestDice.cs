using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class TestDice
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Dice d1 = new Dice();
                Dice d2 = new Dice(3);

                d1.Roll();
                Console.WriteLine("D1 Value : " + d1.getFace());
                d2.Roll();
                Console.WriteLine("D2 Value : " + d2.getFace());

                Console.WriteLine("\n\n");
            }
        }
    }
}

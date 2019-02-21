using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class RationalTest
    {
        static void Main()
        {
            Rational r1 = new Rational(8,16);
          //  r1.Print();
            r1.Reduce();
            r1.Print();

            Rational r2 = new Rational(30, 3);

           
           r2.Reduce();
            r2.Print();

            Console.WriteLine("After Multiplication :");
            (r2.Multiply(r1)).Print();

            Rational ans = r2.Multiply(r1);
            ans.Reduce();
            ans.Print();

        }
    }
}

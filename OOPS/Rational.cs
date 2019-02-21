using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Rational
    {
        int numerator;
        int denomenator;

        public Rational() { numerator = 1; denomenator= 1;}  //default constructor
        public Rational(int x,int y)                        //parameterised constructor
        {
            numerator = x;
            denomenator = y;
        }
        public void Reduce()
        {
            int x = numerator;
            int y = denomenator;
            int temp_x = 1, temp_y=1;
            
            for(int i = 2; i < x / 2; i++)
            {
                while((x%i)==0 && (y % i) == 0)
                {
                    x = x / i;
                    y = y / i;
                }
            }
            numerator = x;  denomenator = y;
        }
        public void Print()
        {
            Console.WriteLine("\t\t\t\t" + numerator + " / " + denomenator);
        }
        public Rational Multiply(Rational Y)
        {
            Rational result = new Rational();
            result.numerator=this.numerator * Y.numerator;
            result.denomenator=this.denomenator * Y.denomenator;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Dice
    {
        int faceUp;

        public void Roll()
        {
            Random n = new Random();
            int k = n.Next(1,6);
            faceUp = k;
        }
        public Dice()
        {
            faceUp = 1;
        }
        public int getFace()
        {
            return faceUp;
        }
        public Dice(int x)
        {
            faceUp = x;
        }
    }
}

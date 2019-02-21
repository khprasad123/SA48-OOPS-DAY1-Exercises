using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPS
{
    /// <summary>
    /// TESTING CLASS NAME IS TEST HEX
    /// </summary>
    public class HEX_Value   ///TEMPORARY CLASS TI HOLD THE ARRAY H --FOR  GETTING THE DECIMAL VALUE OF HEX
    {
        char[] HEX = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };  //this can be written in seperate files----here also possible
        public int getIndex(char s) 
        {
            int i = 0;
            while (i != HEX.Length)
            {
                if (HEX[i] == s)
                    return (i + 10);
                i++;
            }
            return -1;
        }
    }

    /// <summary>
    /// //////////ORIGINAL CLASS STARTS BELOW
    /// </summary>
    class Hex
    {
        string value;
        public string getNum()
        {
            return value;
        }
        public void setNum(string s)
        {
            value = s;
        }

        public int toDecimal()
        {
            double dec = 0;
            char[] temp = value.ToCharArray();
            for(int i = temp.Length-1,j=0; i >=0; i--)
            {
                if (int.TryParse((temp[i]).ToString(), out int n))
                {
                    dec += (n * Math.Pow(16, j++));
                }
                else
                {
                    HEX_Value h = new HEX_Value();
                    int index = h.getIndex(temp[i]);
                    if(index!=-1)
                      dec += (index * Math.Pow(16, j++));
                    else
                    {
                        Console.WriteLine("The Number Is not a Valid Hex Number");
                        return 0;
                    }
                }
            }
            int t = int.Parse(dec.ToString());
            return t;

        }

        public int toBinary()
        {
            int dec = int.Parse(toDecimal().ToString());
            int value = dec;
            int rem = 0,output=0;

            while (value != 0)
            {
                output *= 10;
                rem = value % 2;
                value = value / 2;
                output += rem;
            }
            return output;
        }
    }
}

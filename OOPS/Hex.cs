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
                    int k = 10;
                    switch (temp[i].ToString())
                    {
                        case "A": dec += (10 * Math.Pow(16, j++));  
                                    break;
                        case "B":
                            dec += (11 * Math.Pow(16, j++));
                            break;
                        case "C":
                            dec += (12 * Math.Pow(16, j++));
                            break;
                        case "D":
                            dec += (13 * Math.Pow(16, j++));
                            break;
                        case "E":
                            dec += (14 * Math.Pow(16, j++));
                            break;
                        case "F":
                            dec += (15 * Math.Pow(16, j++));
                            break;
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
                output *= 10;//0//10//110//1110
                rem = value % 2;//1//1//1//0
                value = value / 2;//11//5//2//0
                output += rem;//1//11//111//1110
            }
            
            
            return output;
        }
    }
}

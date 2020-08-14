using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Classes
{
    public class NegateButton
    {       
        public string Negate(string numberToNegate)
        {
            if (numberToNegate.StartsWith("-"))
            {
                char[] Negative = { '-' };
                return numberToNegate.TrimStart(Negative);
            }
            else if (numberToNegate.Equals(""))
            {
                return "";
            }
            else
            {
                return "-" + numberToNegate;
            }
        }
    }
}

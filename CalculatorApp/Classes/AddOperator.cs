using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class AddOperator
    {        
        public double firstValue;
        public string mathOperator;
        public string Operator(string MathOperator, string FirstNumberString)
        {
            mathOperator = MathOperator;
            AddValue.currentValue = null;
            if (FirstNumberString != "" && FirstNumberString != "." && FirstNumberString != "-")
            {
                firstValue = Convert.ToDouble(FirstNumberString);
                return firstValue + " " + MathOperator + " ";
            }
            else
            {
                return String.Empty;
            }
        }
    }
}

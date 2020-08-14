using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    static class AddValue
    {
        public static string currentValue;        
        public static string Value(string ValueInput)
        {    
            currentValue += ValueInput;
            return currentValue;
        }        
    }
}

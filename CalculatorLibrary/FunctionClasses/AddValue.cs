using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class AddValue
    {
        public string currentValue;        
        public string Value(string ValueInput)
        {    
            currentValue += ValueInput;
            return currentValue;
        }

        public void ClearCurrentValue()
        {
            currentValue = null;
        }
    }
}

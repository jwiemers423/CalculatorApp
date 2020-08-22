using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    /// <summary>
    /// This method takes in a value and square roots it.
    /// </summary>

    public class SquareRootButton
    {
        private double _firstNumberDouble;
                        
        public string SquareRoot(string firstNumberString)
        {
            if (firstNumberString != "" && firstNumberString != "." && firstNumberString != "-")
            {
                _firstNumberDouble = Convert.ToDouble(firstNumberString);                
                return Convert.ToString(Math.Sqrt(_firstNumberDouble));
            }
            else
            {                
                return firstNumberString;                
            }   
        }
    }    
}
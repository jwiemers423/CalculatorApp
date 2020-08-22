using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    /// <summary>
    /// This method takes both entered values and decides what equation to conduct depending on the mathOperator used. The result is returned.
    /// </summary>

    public class EqualsButton
    {     
        public string ComputeAnswer(double FirstValue, string SecondNumberString, string MathOperator)
        {
            //AddValue.currentValue = null;
            try
            {
                switch (MathOperator)
                {
                    case "+":
                        return Convert.ToString(FirstValue + Convert.ToDouble(SecondNumberString));                       

                    case "-":
                        return Convert.ToString(FirstValue - Convert.ToDouble(SecondNumberString));
                        
                    case "X":
                        return Convert.ToString(FirstValue * Convert.ToDouble(SecondNumberString));
                        
                    case "/":
                        return Convert.ToString(FirstValue / Convert.ToDouble(SecondNumberString));
                        
                    case "^":
                        return Convert.ToString(Math.Pow(FirstValue, Convert.ToDouble(SecondNumberString)));
                        
                    default:
                        return Convert.ToString(FirstValue);
                }
            }
            catch (DivideByZeroException)
            {
                return String.Empty;
            }
            catch
            {
                return Convert.ToString(FirstValue);
            }
        }
    }
}

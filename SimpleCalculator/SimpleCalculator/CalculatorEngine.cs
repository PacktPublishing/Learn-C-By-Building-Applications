using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumnber)
        {
            double result;
            switch (argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumnber;
                    break;
                case "subtract":
                case "-":
                    result = argFirstNumber - argSecondNumnber;
                    break;
                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumnber;
                    break;
                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumnber;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized.");
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class operações
    {

        public double operations (string operações)
        {

            double result = 0;

            if (operações.Contains("+"))
            {
                string[] numbers = operações.Split("+");

                if( numbers.Length == 2)
                {

                    if (double.TryParse(numbers[0], out double number1) && double.TryParse(numbers[1], out double number2))
                    {

                        result = number1 + number2;

                    }

                }
            }
            else if (operações.Contains("-"))
            {
                string[] numbers = operações.Split("-");

                if (numbers.Length == 2)
                {

                    if (double.TryParse(numbers[0], out double number1) && double.TryParse(numbers[1], out double number2))
                    {

                        result = number1 - number2;

                    }

                }
            }
            else if (operações.Contains("x"))
            {
                string[] numbers = operações.Split("x");

                if (numbers.Length == 2)
                {

                    if (double.TryParse(numbers[0], out double number1) && double.TryParse(numbers[1], out double number2))
                    {

                        result = number1 * number2;

                    }

                }
            }

            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");

            double operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double operand2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите знак арифметического действия: ");
            string sign = Console.ReadLine();

            switch(sign)
            {
                case"+": Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand1 + operand2);
                    break;
                case"-": Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
                    break;
                case"*": Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2);
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        Console.WriteLine("{0} / {1} = {2}", operand1, operand2, operand1 / operand2);
                    }

                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                    }
                    break;

                default:
                    Console.WriteLine("Вы ввели знак не арифметической операции.");
                    break;
            }
            Console.ReadKey();

        }
    }
}

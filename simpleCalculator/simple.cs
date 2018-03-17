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

            double operand1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double operand2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите знак арифметического действия: ");
            string sign = Console.ReadLine();

            switch(sign)
            {
                case"+":
                    Console.WriteLine(operand1 + operand2);
                    break;
                case"-":
                    Console.WriteLine(operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;
                case "/":
                    if (operand2 == 0)                  
                        Console.WriteLine("Деление на ноль невозможно.");                       
                    else
                        Console.WriteLine(operand1 / operand2);
                    break;
                default:
                    Console.WriteLine("Такая операция не поддерживается этой программой.");
                    break;
            }
            Console.ReadKey();

        }
    }
}

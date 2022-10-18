using System;
using Service.Services.Interfaces;

namespace Service.Services.Implementations
{
    public class Calculation : ICalculation
    {
        public int Calculate()
        {
            int res = 0;
            Console.WriteLine("Please, enter first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the operation: ");
            Operator: string operation = Console.ReadLine();
            
            if(operation == "+" || operation == "-" || operation == "*" || operation == "/")
            {
                if (operation == "+")
                {
                    return res = num1 + num2;
                }
                else if (operation == "-")
                {
                    return res = num1 - num2;
                }
                else if (operation == "*")
                {
                    return res = num1 * num2;
                }
                else if (operation == "/")
                {
                    return res = num1 / num2;
                }
                return res;
            }
            else
            {
                Console.WriteLine("Please, enter correct operation: ");
                goto Operator;
            }
            
        }
    }
}


using System;
namespace Math
{
    public class Factorial
    {
        
        public int findFactorial()
        {    
            int res = 1;
            Console.WriteLine("Please, enter number to the console:");
            int num = Int32.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}


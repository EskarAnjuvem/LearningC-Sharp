using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRecursion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a integer for Factorial :");
            int number = int.Parse(Console.ReadLine());

            decimal factorial = Factorial(number);
            Console.WriteLine("The factorial of {0} is {1}.", number, factorial);

            Console.ReadLine();
        }

        static decimal Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }

            
        }
    }
}

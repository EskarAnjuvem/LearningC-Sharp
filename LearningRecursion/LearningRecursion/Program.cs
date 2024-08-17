using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a integer for Factorial :");
            int number = int.Parse(Console.ReadLine());
                        
            
            Stopwatch stopwatch = Stopwatch.StartNew();
            decimal factorial = FactorialRecursive(number);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("The factorial of {0} is {1}.", number, factorial);
            Console.WriteLine("Elapsed time for Recursive Factorial is {0} ms. ", ts.TotalMilliseconds);

            stopwatch = Stopwatch.StartNew();
            factorial = FactorialIterative(number);
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            Console.WriteLine("The factorial of {0} is {1}.", number, factorial);
            Console.WriteLine("Elapsed time for Iterative Factorial is {0} ms. ", ts.TotalMilliseconds);


            Console.ReadLine();
        }

        static decimal FactorialRecursive(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * FactorialRecursive(n - 1);
            }            
        }

        static decimal FactorialIterative(int n)
        {
            decimal fact = 1;
              
            for (int i = 1; i <= n; i++)
            {
                fact = i * fact;
            }
            return fact;            
        }
    }
}

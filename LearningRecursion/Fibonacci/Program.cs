using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Program
    {
        static long[] numbers;
        static void Main(string[] args)
        {
            Console.Write("Which nth Fibonacci number is required:");
            int n = int.Parse(Console.ReadLine());

            Stopwatch sw = Stopwatch.StartNew();
            long result = RecursiveFib(n);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("{0}th Fibonaaci number : {1}", n, result);
            Console.WriteLine("Time Elapsed in Recursive is {0} ms.",ts.TotalMilliseconds);

            Stopwatch sw2 = Stopwatch.StartNew();
            numbers = new long[n + 2];
            numbers[1] = 1;
            numbers[2] = 1;
            long newResult = MemoizationFib(n);
            sw2.Stop();
            TimeSpan ts2 = sw2.Elapsed;
            Console.WriteLine("{0}th Fibonaaci number : {1}", n, newResult);
            Console.WriteLine("Time Elapsed in Memoization Recursive is {0} ms.", ts2.TotalMilliseconds);

            Stopwatch sw3 = Stopwatch.StartNew();
            long newFibResult = IterativeFib(n);
            sw3.Stop();
            TimeSpan ts3 = sw3.Elapsed;
            Console.WriteLine("{0}th Fibonaaci number : {1}", n, newFibResult);
            Console.WriteLine("Time Elapsed in Iteration is {0} ms.", ts3.TotalMilliseconds);

            Console.ReadLine();
        }

        static long IterativeFib(int n)
        {
            long fn = 1;
            long fnMin1 = 1;
            long fnMin2 = 1;

            for(int i = 2; i< n; i++)
            {
                fn = fnMin1 + fnMin2;
                fnMin2 = fnMin1;
                fnMin1 = fn;
            }
            return fn;
        }

        static long MemoizationFib(int n)
        {
            if(0 == numbers[n])
            {
                numbers[n] = MemoizationFib(n - 1) + MemoizationFib(n - 2);
            }
            return numbers[n];
        }

        static long RecursiveFib(int n)
        {
            if (n <= 2) 
            {
                return 1;
            }
            return RecursiveFib(n - 1) + RecursiveFib(n - 2);
        }
    }
}

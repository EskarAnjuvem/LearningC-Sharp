using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Http;

namespace Learning_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            string firstString = "Hello C#";
            char letter = firstString[2];
            char hashSymbol = firstString[7];

            Console.WriteLine("The message is : {0}", firstString);
            Console.WriteLine("The message length is {0} characters long.",firstString.Length);

            for (int i = 0; i < firstString.Length; i++)
            {
                Console.WriteLine("message[{0}] : {1}" , i, firstString[i]);
            }

            Console.WriteLine("The title is \"Harry Potter\".");
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Execution Time: {0} ms", ts.TotalMilliseconds);

            Console.ReadLine();
        }
    }
}

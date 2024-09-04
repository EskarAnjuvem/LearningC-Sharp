using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace ExtensionMethodsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            number.DisplayDefiningAssembly();            
            Console.WriteLine("Reverse of {0} is {1}", number, number.ReverseDigits());


            Console.ReadLine();
        }
    }
}

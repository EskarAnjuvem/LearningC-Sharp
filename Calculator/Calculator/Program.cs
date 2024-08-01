using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum, secondNum;
            string choice;

            Console.WriteLine("Calculator App");

            Console.WriteLine("Enter Your First Number:");
            firstNum = Convert.ToDecimal (Console.ReadLine());
            Console.WriteLine("Enter Your Second Number:");
            secondNum = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Press a for Addition, s for Subtraction, m for Multiplication and any other key for division");
            choice = Console.ReadLine();

            if (choice == "a")
            {
                Console.WriteLine("The Sum is " + (firstNum + secondNum));
            }
            else if (choice == "s")
            {
                Console.WriteLine("The difference is " + (firstNum - secondNum));
            }
            else if (choice == "m")
            {
                Console.WriteLine("The product is " + (firstNum * secondNum));
            }
            else
            {
                Console.WriteLine("The quotient is " + (firstNum / secondNum));
            }

            
            Console.ReadKey();

        }
    }
}

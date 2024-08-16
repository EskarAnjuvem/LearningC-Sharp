using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Methods
{
    internal class Program
    {
        static public int Cube(int x)           // Syntax: modifiers type methodname(formal-parameter-list)
        {                          // methodname is any valid C# identifier - Cube
                                   // parameter list- contains all variable names with type which we give as input
            return x * x * x;      // Type of value method returns (type in declaration)- can also be any class type
        }
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a Number for Cubing: ");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The cube is: {0}", Arithmetic.Cube(num));

            Console.ReadLine();
        }
        //---------------------------------Methods-------------------------------//
        class Arithmetic               // Every method must be contained within a class 
        {
               public static int Cube(int x)           // Syntax: modifiers type methodname(formal-parameter-list)
               {                          // methodname is any valid C# identifier - Cube
                                       // parameter list- contains all variable names with type which we give as input
                   return x * x * x;      // Type of value method returns (type in declaration)- can also be any class type
               }

                float Product(float x, float y) // Each formal parameter must be declared for their type individually
                {
                    float m = x * y;            // m - local variable
                    return m;
                }

                void Sum(float x, float y)     // Can never omit return type even if method doesn't return anything- void
                {
                    Console.WriteLine("Sum is " + (x + y)); // return statement is omitted
                }

                static int Add(int x, int y) => x + y; // Expression-bodied members shorten the syntax for single line methods
                                                   // The above is just syntactic sugar, i.e, the generated IL or CIL (Common Intermediate Language) is same.
                                                   // => Lambda Operation
        }


    }
}


    


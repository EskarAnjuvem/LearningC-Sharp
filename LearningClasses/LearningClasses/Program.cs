using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public class Dog
        {
            private string name; // Field member

            public Dog() // Empty Constructor
            {
            }

            public Dog(string name) // Constructor
            {
                this.name = name;
            }

            public string Name // Property
            {
                get { return name; }
                set { name = value; }
            }

            public void Bark()  // Method 
            {
                Console.WriteLine("{0} said Woof Woof", name ?? "[unnamed Dog]");

            }

        }

    }
}

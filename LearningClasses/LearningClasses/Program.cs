using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Monday is Days);  // Returns True
            // Each constant, declared within an enum is associated with a certain integer-by default for this hidden integer
            // representation, int is being used
            // Each constant in one enum is actually a textual representation of an integer, by default this number is the constant's
            // index in the list of constants of a particular enumeration type
            Console.WriteLine((int)Days.Monday + " " + (int)Days.Sunday);  // Returns 0 6
            Console.WriteLine(Days.Sunday); // On print we get a textual representation given at the time of declaration

            Coffee firstCoffee = new Coffee(CoffeeSize.Normal); // Using class Coffee to create an instance/object but with normal size chosen from enum
            Console.WriteLine("The first order is {0} coffee of {1} ml.", firstCoffee.Size, (int)firstCoffee.Size);
            // Note how we access the Size property from created instance, but cannot access 'size' due to its protection level-private
            // But Size returns size of type enum CoffeeSize - gives textual description; to obtain numeric representation we use typecasting

            Coffee SecondCoffee = new Coffee(CoffeeSize.Double, Coffee.AddOn.Burger);
            Console.WriteLine("The second order is {0} coffee of size {1} ml, with add-on {2}", SecondCoffee.Size,(int)SecondCoffee.Size,SecondCoffee.ExtraItem);

            Console.WriteLine("Coffee Sizes Available: Small = 100 ml, Normal = 150 ml, Double = 300 ml");
            Console.Write("Please Enter your Coffee Order Size(in ml): ");
            int orderSize = int.Parse(Console.ReadLine());
            while (!Enum.IsDefined(typeof(CoffeeSize),orderSize))
            {
                Console.Write("Invalid Input. Please Input a Valid order size:");
                orderSize = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Add on Items Available: Burger, ChocoLava, Custard");
            Console.Write("Select Any one Add on Item. Enter 1 for Burger, 2 for ChocoLava, 3 for Custard, 4 for None:");
            int orderAddOn = int.Parse(Console.ReadLine());
            while (!Enum.IsDefined(typeof(Coffee.AddOn), orderAddOn))
            {
                Console.Write("Invalid Input. Please Input a Valid Add-on order number:");
                orderAddOn = int.Parse(Console.ReadLine());
            }
            Coffee thirdOrder = new Coffee((CoffeeSize)orderSize, (Coffee.AddOn)orderAddOn );
            Console.WriteLine("The third order is {0} coffee of size {1} ml and add on {2}", thirdOrder.Size, (int)thirdOrder.Size, thirdOrder.ExtraItem);
            Console.WriteLine($"The price for your Coffee order is {thirdOrder.CoffeePrice() + thirdOrder.AddOnPrice()}.");
            Console.ReadLine();
        }

        class Coffee
        {
            private CoffeeSize size; // note we define a field variable of type enum Coffeesize
            // An enumerated variable can have as a value any one of the constants listed but cannot have null.
            private AddOn extraItem; // Instance variable of enumerated type
            // Sometime enumeration should and can be declared within a class for better encapsulation
            public enum AddOn  // Note there is no static modifier; 
            {
                Burger = 1, ChocoLava =2, Custard=3, None =4  // We can always add new constants with time 
            }

            public double CoffeePrice()
            {
                switch (this.size)
                {
                    case CoffeeSize.Small:
                        return 0.20;
                    case CoffeeSize.Normal:
                        return 0.50;
                    case CoffeeSize.Double:
                        return 0.80;
                    default:
                        throw new InvalidOperationException("Unsupported Size");
                }
            }

            public double AddOnPrice()
            {
                switch (this.extraItem)
                {
                    case AddOn.Burger:
                        return 0.10;
                    case AddOn.ChocoLava:
                        return 0.15;
                    case AddOn.Custard:
                        return 0.20;
                    case AddOn.None:
                        return 0.0;
                    default:
                        throw new InvalidOperationException("Unsupported Size");
                }
            }

            public Coffee(CoffeeSize consumeSize, AddOn extra = AddOn.None) // Constructor takes the enum type variable as parameter
            {
                this.size = consumeSize;
                this.extraItem = extra;
            }
            public CoffeeSize Size  // declare a property for obtaining size
            {
                get { return size; } // using get method to return size
            }
            public AddOn ExtraItem
            {
                get { return extraItem; }
            }
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

        // Enumeration is like class but differs from it in the sense that we can declare only constants within it.
        // It is declared using the keyword enum; and can have access modifiers like public, private and internal
        // Constants are separated by commas within enumeration block
        // Enums in C# are inherently static; you do not and cannot declare them as static(throws compilation error)
        // Since the constants are tied to the type itself and not to an instance of the type, enum is implicitly static
        // We can access the members of enum directly through enum type without needing to instantiate anything.
        enum Days                     
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday // Each constant listed here is of 'type' this enum-Days
        }

        public enum CoffeeSize
        {
            Small = 100, Normal = 150, Double = 300  // We can change the numerical value of constants in an enumeration
        }   // Assign the values to each constant during declaration

    }
}

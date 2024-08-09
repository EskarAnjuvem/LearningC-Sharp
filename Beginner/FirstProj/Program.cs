using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!"); // Outputs this line on terminal and appends a new line

            int marks;     // Variable Declaration- int can hold only integers of 32-bit signed integer - default
            marks = 21;    // Variable initialization using assignment operator, done from right to left
            int age=33, salary = 2400000; // Multiple Variable Declaration and initialization.
            // x = 5, y= 6; Cannot assign like this using comma separator
            long ageOfUniverse = 160000000000L; // long integer - 64 bit signed 
            double score = 36.4342D; // double precision floating point number - default
            float weight = 65.4f; // single precision floating point number - suffix f or F.
            decimal money = 793.34M; // decimal number
            string firstName="Bob", // Variable decalaration and initialization done this way
                   middleName = "Julian",
                   lastName = "Singer";
            // String concatenation operator '+' : combine smaller literal & variable strings into a single string.
            Console.WriteLine(firstName + " " +middleName + " " + lastName); // String Concat without using intermediate variable
            string greeting = "Hello";
            string message = "Hello " + firstName;
            Console.WriteLine(message);
            Console.WriteLine(greeting + ' ' + firstName + ' ');
            string newMessage = $"{greeting} {firstName} {lastName}!";
            Console.WriteLine(newMessage);
            string projectName = "C-sharp Beginner";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
            Console.WriteLine(age);
            Console.WriteLine(salary);
            Console.WriteLine(ageOfUniverse);
            Console.WriteLine(score);
            Console.WriteLine(weight);
            Console.WriteLine(money);
            Console.WriteLine(marks);

            

            Console.ReadLine();

            
        }
        

    }


    //----------------------------------------Classes---------------------------------------------//
    /* A Software models real world things (goods, cars, spheres) or abstract concepts like vectors, list, stacks etc as Objects.*/
    // All those real world or abstract Objects have two distinct characteristics - State and Behaviour
    // State - characteristics which define the condition of object at a given moment / general time
    // State - represented by values of data members / fields / member variables
    // Behaviour - specific distinctive actions that can be done by the objects 
    // Behaviour - modelled by function members/ methods
    // Class - User defined data type with template for field data & members which operate on this data(contructors,properties,methods,events,etc)
    // The data members of class - field and properties are collectively called Attributes.
    /* Properties - special elements which control access to fields, extend the functionality of the fields by giving the 
     * ability of extra data management when extracting and recording it in the class fields (using get , set).*/ 
    // Objects - Variables of this user-defined data type/class; called Instances of the class; object creation: Instantiation
    // The state is specific to instance/object but behaviour is common to all instances of the class.


    class EmptyMan      // class - keyword , followed by valid C# identifier
    {
                        // State, Behaviour are all optional
    }                   // Empty class has many uses : Marker interfaces, Type parameters in generics, Singleton pattern, Placeholder Code, etc

    public partial class Molecules // Syntax: Access-modifier Type-modifier class ClassName
    {
        public int radius;       // Instance Variable: All objects will have their own copy/different value of this field.
        public float velocity;
        public float charge;
        public string name;
        protected double VolumeConstant = 4 * Math.PI / 3;  // 

        public void PrintState()
        {
            Console.WriteLine("This {0} molecule is moving with a speed {1}",name,velocity);
        }

        public void RadiusChange(int delta) => radius += delta;
    }











    

    

}

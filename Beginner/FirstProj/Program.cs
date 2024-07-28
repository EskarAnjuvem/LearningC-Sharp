using System;
using System.Collections.Generic;
using System.Linq;
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------Arrays-------------------------------//
            //Array - ordered sequence(set of contiguous data points) of elements/variables of the same type (primitive or reference)
            //This list is given a single variable name - but each element is accessed by a numerical index/subscript starting from 0(called lower bound)
            // 1-dimensional arrays - vectors ; 2-dimensional arrays - matrices

            int[] marks;                 // [] indicates we are declaring an array of int type elements, not a single element
            string[] names;              // On declaration, we create a variable with the identifier marks, names in the program's execution stack
            float[] average, percentile; // No memory is allocated yet; declaration only creates a reference which doesn't have a value(points to null)
            //In above lines, we declared int array reference, string array reference, etc.
            marks = new int[5];         // We create array with the 'new' keyword - allocates area for 5 integers in the dynamic memory(heap)
            names = new string[5];      // Array creation automatically initializes the array elements to a default value, in case user didn't initialize it
            // For bool array, default value is false ; for int array, it is set to 0
            Console.WriteLine(marks[2] + " " + names[3] ); // Outputs: 0    ; string is initialized to null, not seen on output 
            if ( names[4] == null )
            {
                Console.WriteLine("The value is null");  // Outputs: The value if null ; this is how we check
            }
            Console.ReadLine();
        }
    }
}

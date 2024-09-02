using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleException;
using CustomException;

namespace LearningExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Exception Problem ***********");
            Console.WriteLine("Creating a Car and stepping on it");
            Car myCar = new Car("Bugatti", 50);
            myCar.CrankTunes(true);

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }

            }

            //catch ( CarIsDeadException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.ErrorTimeStamp);
            //    Console.WriteLine(e.CauseOfError);
            //}
            catch (Exception e)
            {
                Console.WriteLine("\n *** Error!! *****");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Help Link: {0}", e.HelpLink);
                Console.WriteLine("\nCustom Data:");
                foreach (DictionaryEntry de in e.Data)
                {
                    Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                }
                Console.WriteLine("Stack Trace: {0}", e.StackTrace);
            }
            Console.WriteLine("**** Program Continues with out of Exception Logic******");

            Console.ReadLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    myCar.Accelerate(10);
            //}
            //Console.ReadLine();
        }


    }
}

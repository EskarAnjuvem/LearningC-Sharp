using System;
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
            Console.WriteLine("***********   No Exception   ****************");

            Console.WriteLine("Creating a instance of Car");
            Car car = new Car("Bugatti", 50);

            Console.WriteLine("Revving Up....");
            car.TurnOnRadio(true);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Iteration {0} : ", i);
                car.Accelerate(10);
            }
            Console.WriteLine();
            Console.WriteLine("***********   Throwing Exception and Handling it  ****************");

            Console.WriteLine("Creating another instance of Car");
            Car AnotherCar = new Car("Chevrolet", 40);

            Console.WriteLine("Revving Up....");
            AnotherCar.TurnOnRadio(true);

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Iteration {0} : ", i);
                    AnotherCar.AccelerateWithSimpleException(10);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Help Link: {0}", e.HelpLink);
                Console.WriteLine("Time: {0}", e.Data["TimeStamp"] );
                Console.WriteLine("Cause: {0}", e.Data["Cause"]);
                Console.WriteLine("Source: {0}",e.Source);
                Console.WriteLine("Stack Trace: {0}", e.StackTrace);
            }

            Console.WriteLine("***********   Throwing Customised Exception and Handling it  ****************");

            Console.WriteLine("Creating another instance of Car");
            Car CustomCar = new Car("Chevrolet", 40);

            Console.WriteLine("Revving Up....");
            AnotherCar.TurnOnRadio(true);

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Iteration {0} : ", i);
                    CustomCar.AccelerateWithSimpleException(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Help Link: {0}", e.HelpLink);
                Console.WriteLine("Time: {0}", e.Data["TimeStamp"]);
                Console.WriteLine("Cause: {0}", e.Data["Cause"]);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack Trace: {0}", e.StackTrace);
            }


            Console.ReadLine();
            
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming....." : "Quiet Time....");
        }
    }

    public class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string CarName { get; set; } = "";

        private bool _carIsDead;

        private readonly Radio _jukeBox = new Radio();

        public Car() { }

        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            CarName = name;
        }

        public void CrankTunes(bool state)
        {
            _jukeBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Console.WriteLine("{0} is out of order...", CarName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    _carIsDead = true;
                    //Console.WriteLine("{0} has overheated!!", CarName);
                    throw new Exception($"{CarName} has overheated!!") { 
                        HelpLink = "Car Website Link",
                        Data =
                        {
                            { "TimeStamp", $"The car exploded at {DateTime.Now}" },
                            { "Cause", "Engine Overheat." }
                        }
                    };
                }
                else
                {
                    Console.WriteLine("=> Current Speed = {0}", CurrentSpeed);
                }
            }
        }

    }
}

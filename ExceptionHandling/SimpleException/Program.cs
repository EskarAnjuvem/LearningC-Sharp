using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomException;

namespace SimpleException
{
    public class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming!!!" : "Quiet.....");
        }
    }

    public class Car
    {
        public string CarName { get; set; } = "";
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; } = 0;
        public bool _carIsDead;
        private readonly Radio _jukebox = new Radio();

        public Car() { }
        public Car(string name, int speed)
        {
            CarName = name;
            CurrentSpeed = speed;
        }

        public void TurnOnRadio(bool state)
        {
            _jukebox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {

            if (CurrentSpeed > MaxSpeed)
            {
                //CurrentSpeed = 0;
                _carIsDead = true;
                Console.WriteLine("{0} is out of order", CarName);
            }
            else
            {
                Console.WriteLine("=> Current Speed: {0}", CurrentSpeed);
                CurrentSpeed += delta;
            }
        }

        public void AccelerateWithSimpleException(int delta)
        {
            CurrentSpeed += delta;
            if (CurrentSpeed > MaxSpeed)
            {
                throw new Exception($"{CarName} is dead!!")
                {
                    HelpLink = "Car Website Link",
                    Data =
                    {
                        { "TimeStamp", $"The engine exploded at {DateTime.Now}" },
                        { "Cause", "The Engine has overheated on reaching Maximum Speed"}
                    }
                };
            }
            else
            {
                Console.WriteLine("=> Current Speed : {0}", CurrentSpeed);
            }
        }

        public void AccelerateWithCustomException(int delta)
        {
            CurrentSpeed += delta;
            if (CurrentSpeed > MaxSpeed)
            {
                throw new Exception($"{CarName} is dead!!")
                {
                    HelpLink = "Car Website Link",
                    Data =
                    {
                        { "TimeStamp", $"The engine exploded at {DateTime.Now}" },
                        { "Cause", "The Engine has overheated on reaching Maximum Speed"}
                    }
                };
            }
            else
            {
                Console.WriteLine("=> Current Speed : {0}", CurrentSpeed);
            }
        }
    }
}

namespace CustomException
{
    public class CarIsDeadException : ApplicationException
    {
        private string _messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException()
        {
        }

        public CarIsDeadException(string message, string cause, DateTime time)
        {
            _messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        public override string Message => $"Car Error Message: {_messageDetails}";
    }

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
                    throw new CarIsDeadException(
                        $"{CarName} has overheated!!",
                        "Engine Failure",
                        DateTime.Now)
                    {
                        HelpLink = "Car Website Link",
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

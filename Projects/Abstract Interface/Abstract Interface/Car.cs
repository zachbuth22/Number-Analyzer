using System;
namespace Abstract_Interface
{
    internal class Car
    {
        //properties
        public string Type { get; set; }
        public int MaxSpeed { get; set; }
        public iTurbo Turbo { get; set; }

        //constructor
        public Car(string type, int _maxSpeed)
        {
            Type = type;
            MaxSpeed = _maxSpeed;
        }

        //method
        public void Drive()
        {
            Console.WriteLine($"{Type} drives at {MaxSpeed} mph");
            if(Turbo!= null)
            {
                Turbo.UseTurbo(MaxSpeed);
            }
        }

    }
}

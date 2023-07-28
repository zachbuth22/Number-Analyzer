using System;
namespace Abstract_Interface
{
    internal class MaxTurbo : iTurbo
    {
        public void UseTurbo(int speed)
        {
            Console.WriteLine($"Turn on MAXTURBO. Car is now going {speed * 5}");
        }
    }
}


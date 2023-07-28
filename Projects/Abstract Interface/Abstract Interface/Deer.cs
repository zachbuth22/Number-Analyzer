using System;
namespace Abstract_Interface
{
    public class Deer : Animal
    {
        public int PointNumber { get; set; }
        public bool Scared { get; set; }

        public Deer(string _name, int _weight, int _age, int _pointNumber, bool _scared) :
            base(_name, _weight, _age)
        {
            PointNumber = _pointNumber;
            Scared = _scared;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} eats a healthy diet of veggies and nuts.");
        }

        public override void Move()
        {
            if (Scared)
            {
                Console.WriteLine($"{Name} runs like the wind.");
            }
            else
            {
                Console.WriteLine($"{Name} is slowly trodding and enjoying nature.");
            }
        }

public override void Speak()
        {
            Console.WriteLine($"{Name} brags that he has a {PointNumber} point rack");
        }
    }
}


using System;
namespace Abstract_Interface
{
    public class Cat : Animal
    {
        public string FurColor { get; set; }
        public bool Angry { get; set; }

        public Cat(string _name, int _weight, int _age, string _furColor, bool _angry)
            : base(_name, _weight, _age)
        {
            FurColor = _furColor;
            Angry = _angry;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} eats way too much kibble.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} looks like a {FurColor} blob moving");
        }

        public override void Speak()
        {
            if (Angry)
            {
                Console.WriteLine($"{Name} screams dark magic at you.");
            }
            else
            {
                Console.WriteLine($"{Name} ignores you.");
            }
        }
    }
}


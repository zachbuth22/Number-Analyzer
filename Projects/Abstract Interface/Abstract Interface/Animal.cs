using System;
namespace Abstract_Interface
{
    //Cannot create instances of it

    public abstract class Animal
	{
        //properties
        public string Name { get; set; }
        public int Weight { get; set; }
        public int MaxAge { get; set; }

        //constructor
        public Animal(string _name, int _weight, int _age)
        {
            Name = _name;
            Weight = _weight;
            MaxAge = _age;
        }

        //methods
        public string GetDetails()
        {
            return $"{Name} Weight: {Weight} Max Age: {MaxAge}";
        }

        //abstract methods
        //child must add functionality
        public abstract void Eat();
        public abstract void Move();
        public abstract void Speak();







	}
}

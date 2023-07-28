using Abstract_Interface;

Cat c = new Cat("Yumi", 500, 9, "Tabby", true);
Console.WriteLine(c.GetDetails());
c.Eat();
c.Move();
c.Speak();

//polymorphism
List<Animal> Zoo = new List<Animal>()
{
    new Cat("Boo", 8, 2, "Black", false),
  
};

Console.WriteLine();
//interfaces
Car car1 = new Car("Mustang", 200);
car1.Drive();
Car car2 = new Car("Mustangv2", 220);
car2.Turbo = new BasicTurbo();
car2.Drive();
car2.Turbo = new MaxTurbo();
car2.Drive();
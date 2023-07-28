using OOP_Lecture;

Pen myPen = new Pen("Blue", "Pilot", "Gel", 1.50m, 5);
//myPen.Color = "Blue";
//myPen.Brand = "Pilot";
//myPen.InkType = "Gel";
//myPen.Price = 1.50m;
//myPen.Length = 5;

Pen myPen2 = new Pen("Red","Bic","Gel",.75m, 5);
myPen2.Color = "Red";
myPen2.InkType = "Gel";
myPen2.Price = 0.75m;
myPen2.Length = 5;

Pen myPen3 = new Pen("Black", "Pilot", "Gel", 1.50m, 6.5f);

Console.WriteLine(myPen.Color);
Console.WriteLine(myPen2.Color);

myPen.Draw();
myPen2.Draw();

//array/lists
List<Pen> CupOfPens = new List<Pen>()
{
    myPen, //useobjects
    myPen2,
    myPen3,
    new Pen("Pink","Sharpie","Ball point", 5m, 6.3f) //generate new ones

};

foreach(Pen p in CupOfPens)
{
    p.Draw();
}

//methods
static void DisplayPenDetails(Pen p)
{
    Console.WriteLine($"{p.Brand} {p.Color} {p.InkType} {p.Length} inches ${p.Price}");
}













Console.ReadLine();
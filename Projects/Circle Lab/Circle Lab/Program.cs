using Circle_Lab;

Console.WriteLine("Welcome to the circle lab");

//create circle
Console.WriteLine("Please enter a radius for the circle");
double r = Validator.GetPositiveInputInt();
//double r = -1;

//while(double.TryParse(Console.ReadLine(), out r) ==false || r<=0)
//{
//    Console.WriteLine("Please enter a valid positive number");
//}

//Create circle
Circle c = new Circle(r);

//Loop
bool runMethods = true;
while (runMethods)
{
    //Call methods
    Console.WriteLine($"Diameter:{c.CalculateDiameter()}");
    Console.WriteLine($"Circumference: {c.CalculateCircumference()}");
    Console.WriteLine($"Area:{c.CalculateArea()}");
    runMethods = Validator.GetContinue();
    if (runMethods == true)
    {
        c.Grow();
    }
    else
    {
        Console.WriteLine($"Goodbye! The circle radius is {c.GetRadius}");
    }

    //    //Ask to grow(keep loop going)
    //    Console.WriteLine("Would you like the circle to grow? y/n");
    //    while (true)
    //    {
    //        string choice = Console.ReadLine().ToLower().Trim();
    //        if (choice =="y")
    //        {
    //            c.Grow();
    //            break;
    //        }
    //        else if (choice == "n")
    //        {
    //            Console.WriteLine($"Goodbye! The circle radius is {c.GetRadius}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid. Try again.");
    //        }
    //    }
    //}
}

    Console.ReadLine();
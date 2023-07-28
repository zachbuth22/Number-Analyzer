string greeting = GetHelloUser("Zach");
Console.WriteLine(greeting);
string name = "Alice";
string greeting2 = GetHelloUser(name);
Console.WriteLine(greeting2);
Console.WriteLine(GetHelloUser("Bob"));
string userName = GetCleanInput();
Console.WriteLine(userName);
double sum = AddThreeNumbers(9, 5, 3);
Console.WriteLine(sum);
DisplayDate();

Console.WriteLine(IsEnoughMoney(2, 3));

string house = GetHouse(67000);
Console.WriteLine(house);

//--------------------------------------------

//1
int seconds = convertMinuteToSeconds(40);
Console.WriteLine(seconds);

//2
double area = areaTriangle(5, 10);
Console.WriteLine(area);

//3
int convert = convertNegative(7);
Console.WriteLine(convert);

//4
int convert2 = convertPositive(-5);
Console.WriteLine(convert2);

//5
greetUser();

//----------------------------------------------

//methods
static string GetHelloUser(string user)
{
    string result = $"Hello, {user}";
    return result;
}

static string GetCleanInput()
{
    Console.WriteLine("Please enter a name");
    return Console.ReadLine().ToLower().Trim();
}

static double AddThreeNumbers(double x, double y, double z)
{
    return x + y + z;
}

//void means no return
static void DisplayDate()
{
    DateTime date = DateTime.Now;
    Console.WriteLine(date);
}


//Practice Questions

//1. Create a method called convertMinuteToSeconds. It should take in an int called minutes. It should convert and return it as seconds.

static int convertMinuteToSeconds(int minutes)
{
    return minutes * 60;
}

//2. Create a method that is called areaTriangle. It should take in a double height and a double length. Return the area as a double.

static double areaTriangle(double x, double y)
{
    return (x * y) / 2;
}

//3. Create a method called convertNegative(). It should take in an int and return it as a negative version of that int. If it is already negative, don’t do anything with it. 0 should stay 0.

static int convertNegative(int x)
{
    if (x > 0)
    {
        return x * -1;
    }
    else
    {
        return x * 1;
    }

}


//4. Create a method called convertPostive(). It should take in an int and return it as a positive version of that int. If it is already positive, don’t do anything with it. 0 should stay 0.

static int convertPositive(int x)
{
    if (x > 0)
    {
        return x * 1
    }
    else
    {
        return x * -1;
    }

}


//5. Create a method called greetUser(). It will have no parameter and no return. Get the name from the user and display “Hello “ and then their name.

static void greetUser()
{
    Console.WriteLine("What is your name?: ");
    string name2 = Console.ReadLine();
    Console.WriteLine($"Hello {name2}");
}

//Called IsEnoughMoney. Take in 2 doubles, cost and payment, return a bool.
//if there is enough payment, return true, else false


Console.WriteLine(IsEnoughMoney(2, 3));

static bool IsEnoughMoney(double x, double y)

{
    if (x >= y)
    {
        return true;
    }

    else
    {
        return false;
    }

}
//method called GetHouse. Take in a double called salary and it will return a string


static string GetHouse(double salary)
{
    if (salary <= 60000)
    {
        return "Apartment";
    }
    if (salary <= 80000)
    {
        return "1 br house";
    }
    if (salary <= 100000)
    {
        return "2 br house";
    }
    else
    {
        return "3 br house";
    }
}

static string CombineWords(string w1, string w2, string w3)
{
    return $"{x}, {y}, {z}";
}

//----------------------------------------------------------

// Methods Revisited

int num1 = 5;
int num2 = 10;
FlipValues(ref num1, ref num2);

Console.WriteLine(num1);
Console.WriteLine(num2);

//pass by reference
static void FlipValues(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}


//Out parameter

double item = 80;
double money = 100;
double remainder = 0;
if(CanPurchase(item,money,out remainder))
{
    Console.WriteLine($"Item purchased! ${remainder} in change");
}
else
{
    Console.WriteLine("Could not purchase");
}
static bool CanPurchase(double cost, double wallet, out double change)
{
    if (wallet >= cost)
      {
        change = wallet - cost;
        return true;
      }
    else
    {
        change = wallet;
        return false;
    }
}


double remain = 0;
double result = Divider(5, 2, out remain);
Console.WriteLine($"Result = {result}");
Console.WriteLine($"Remainder = {remain}");

static double Divider(double x, double y, out double remainder)
{
    remainder = x % y;
    return x / y;
}











Console.ReadLine();

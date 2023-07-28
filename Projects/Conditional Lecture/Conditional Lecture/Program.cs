//if statements
int age = 30;

if (age >= 21)
{ Console.WriteLine("Can Drink"); }

else if (age >= 18)
{ Console.WriteLine("Can Vote"); }

else if (age >= 16)
{ Console.WriteLine("Can Drive"); }

else
{ Console.WriteLine("Too Young"); }

//switch case

Console.WriteLine("Please enter a menu choice 1-3");

int menuChoice = int.Parse(Console.ReadLine());

switch (menuChoice)
{ case 1:
        Console.WriteLine("Here are all books");
        break;
  case 2:
        Console.WriteLine("Check out a book");
        break;
  case 3:
        Console.WriteLine("Return book");
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}

//ternary
int age2 = 25;
string status = age2 >= 18 ? "Adult" : "Child";
Console.WriteLine(status);
string status2 = age2 >= 18 ? "Adult" : (age2 >= 13 ? "Teen" : "Child");

//--------------------------------------

//Loops

//For loop
//If you know the amount of times you want to loop
//1 variable holds loop count
//2 boolean expression (true =run, false = stop)
//3 counter increment/decrement

for (int i =0; i<=10; i++)
{ Console.WriteLine(i); }

//starts at 10, count down to 0

for (int i =10; i>=0; i--)
{ Console.WriteLine(i); }

//While loop
//IMPORTANT! CON-TIN-U?

bool runProgram = true;
while (runProgram)
{
    //Main code here

    Console.WriteLine("Would you like to continue? y/n");
    string choice = Console.ReadLine();
    if (choice == "n")
    { runProgram = false; }
}

//Do while loop

int menu = -1;
do
{
    Console.WriteLine("Menu choice 1-3 (0 to leave)");
    menu = int.Parse(Console.ReadLine());
    if (menu == 1)
    {
        Console.WriteLine("See all books");
    }
    else if (menu == 2)
    {
        Console.WriteLine("Check out");
    }
    else if (menu == 3)
    {
        Console.WriteLine("return");
    }
} while (menu != 0);

//Foreach loop

string[] staff = { "Justin", "Ethan", "Billy" };
foreach (string s in staff)
{ Console.WriteLine(s); }


//break
//IMPORTANT

int positive = -1;
while(true)
{ Console.WriteLine("Please enter a number. Must be positive");
    positive = int.Parse(Console.ReadLine());
    if (positive >=1)
    { break; }
    else { Console.WriteLine("Invalid. Try again"); }
}
Console.WriteLine(positive);

//continue
for(int i = 0; i<=10; i++)
{if (i % 2 == 1)
    { //skip to next loop
        continue;
}

Console.WriteLine(i);}

















Console.ReadLine();
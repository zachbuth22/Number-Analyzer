Console.WriteLine("Welcome to the robot fights");

int bot1 = 0;
int bot2 = 0;

int maxAtk1 = 5;
int maxAtk2 = 7;


Random hit = new Random();


for (int i = 0; i < 3; i++)
{

    int hit1 = hit.Next(0, maxAtk1+1);
    int hit2 = hit.Next(0, maxAtk2+1);
    Console.WriteLine($"Bot 1 hit for {hit1}");
    Console.WriteLine($"Bot 2 hit for {hit2}");
    if (hit1 > hit2)
    {
        bot1++;
        Console.WriteLine("Bot 1 won that fight");
    }
    else if (hit2 > hit1)
    {
        bot2++;
        Console.WriteLine("Bot 2 won that fight");
    }
    else 
    {
        Console.WriteLine("The bots tied");
        continue;
    }
}

Console.WriteLine("Bot 1 won " + bot1 + " matches");
Console.WriteLine("Bot 2 won " + bot2 + " matches");

if (bot1>bot2)
{ Console.WriteLine("Bot 1 Wins!"); }
else if (bot1==bot2)
{ Console.WriteLine("The bots have tied"); }
else
{ Console.WriteLine("Bot 2 Wins!"); }

Console.ReadLine();
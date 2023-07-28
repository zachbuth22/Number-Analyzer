
Console.WriteLine("Welcome to the Student Database!");

string[] names = { "Justin Jones", "Zach Buth", "Omar Abdulla", "Ethan Thomas", "Joe Heath", "Forrest Verellen", "Doug Chu", "Maya Araquil", "Shane Chastain", "Timothy Montague", "Maria Ragone" };
string[] towns = { "Columbus", "Grand Rapids", "Dearborn", "Rolla", "Howell", "Traverse City, MI", "Poughkeepsie", "West bloomfield", "Rochester Hills", "Clio", "Farmington Hills" };
string[] foods = { "Baja Blast", "Pizza", "Cheese Pizza", "Hot Wings", "Tacos", "Spaghetti", "Sushi", "Sinigang", "Pizza", "Mole", "Lasagna" };

bool loop = true;
do
{
    foreach (string n in names)
    {
        Console.WriteLine();
    }
    Console.WriteLine($"Which student would you like to learn more about? Enter a number 1 - {names.Length}: "); int choice = int.Parse(Console.ReadLine());
    if (choice <= 11 && choice >= 1)
    {
        bool runProgram = true;
        while (runProgram)
        {


            Console.WriteLine("You have chosen " + names[choice - 1]);
            Console.WriteLine("Enter hometown to learn about their hometown or favorite food to learn their favorite food");
            bool runStudent = true;
            while (runStudent)
            {

                string info = Console.ReadLine().ToLower().Trim();
                if (info == "hometown")
                {
                    Console.WriteLine($"{names[choice - 1]} is from {towns[choice - 1]}");
                    runStudent = false;
                }
                else if (info == "favorite food")
                {
                    Console.WriteLine($"{names[choice - 1]}'s favorite food is {foods[choice - 1]}");
                    runStudent = false;
                }
                else
                {
                    Console.WriteLine("Invald entry, please type hometown or favorite food");
                }

            }
            Console.WriteLine("Would you like to learn about another student? y/n");
            string pick = Console.ReadLine();
            if (pick == "n")
            {
                runProgram = false;
                Console.WriteLine("Thank you for using the Student Database");
            }
        }
    }
    else
    {
        Console.WriteLine("Number out of range, try again.");
    }
} while (loop != false);


Console.ReadLine();

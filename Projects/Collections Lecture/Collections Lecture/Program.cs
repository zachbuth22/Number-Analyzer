using System.Collections;

//Generics my love<3
//Lists
List<decimal> prices = new List<decimal>();
prices.Add(1.99m);
prices.Add(2.99m);
prices.Add(5.00m);
prices.Insert(0,3.99m); //insert adds at index
foreach (decimal p in prices)
{
    Console.WriteLine(p);
}
Console.WriteLine(prices[1]);
Console.WriteLine(prices.Count);
int index = prices.IndexOf(2.99m); //returns index of matching item, -1 if not found
prices[index] = 2.50m;

prices.Remove(5.00m); //remove by value
prices.RemoveAt(0); //remove by index
foreach (decimal p in prices)
{
    Console.WriteLine(p);
}

//Create list with starting values
List<string> shows = new List<string>()
{
"Spongebob",
"Breaking Bad",
"The Price is Right"
};

foreach(string s in shows)
{
    Console.WriteLine(s);
}

//Dictionaries
Dictionary<string, bool> tasty = new Dictionary<string, bool>();
tasty.Add("Chicken Curry",true);
tasty.Add("Asparagus", true);

Console.WriteLine(tasty["Chicken Curry"]);

foreach(KeyValuePair<string,bool> kvp in tasty)
{
    if (kvp.Value == true)
    {
        Console.WriteLine($"{kvp.Key} is tasty!");
    }
    else
    {
        Console.WriteLine($"{kvp.Key} is nasty!");
    }
}

//Exercise1
//Create a list of strings
//loop should start after list creation
//ask the user to enter text
//add the input into the list
//display all in list
//ask in they want to add more

List<string> gvg = new List<string>();

bool runProgram = true;
while (runProgram)
{

    Console.WriteLine("Welcome to the list of good video games. Please enter a game you enjoy: ");
gvg.Add(Console.ReadLine());
    Console.WriteLine("Here's the list so far!");
foreach (string i in gvg)
{
    Console.WriteLine(i);
}
    Console.WriteLine("Would you like to add another video game to the list? y/n");
    string choice = Console.ReadLine();
    if (choice == "n")
    {
        runProgram = false;
    }
}

//Exercise2
//create a dictionary called translate
//key = string (English)
//value = string (Spanish)
//add 5 or more words to translate
//ask the user for an English word (key)
//display the translation (value)

Dictionary<string, string> translate = new Dictionary<string, string>();

translate.Add("blue", "azul");
translate.Add("red", "rojo");
translate.Add("yellow", "amarillo");
translate.Add("black", "negro");
translate.Add("white", "blanco");

Console.WriteLine("Welcome to the English/Spanish Color Translator. Please enter, blue, red, yellow, black or white for translation");
string english = Console.ReadLine();
if (translate.ContainsKey(english))
{
    string spanish = translate[english];
    Console.WriteLine($"{english} in spanish is {spanish}");
}
else
{
    Console.WriteLine("word doesn't exist");
}

































//------------------------------------------------------------
//Non generics
//Do not use or else Justin will fight

//ArrayList trashList = new ArrayList();
//trashList.Add(2);
//trashList.Add(9);
//trashList.Add(new Random());
//trashList.Add(new ArrayList());
//foreach (var x in trashList)
//{
//    Console.WriteLine(x);
//}

////hashtable
//Hashtable trashTable = new Hashtable();
//trashTable.Add("Taco Bell", 1234567890);
//trashTable.Add("McDonalds", "123-456-789");

//Console.WriteLine(trashTable["Taco Bell"]);

//Console.ReadLine();
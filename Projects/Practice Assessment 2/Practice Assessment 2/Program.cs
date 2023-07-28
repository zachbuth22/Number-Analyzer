﻿//Question 1

//Create a static method named AddStarWarsCharacters() that takes in a string[].
//This method then searches for and returns the index of “Yoda”.
//If “Yoda” is not in the array, return -1.

using System;

string[] star2 = { "Yoda", "R2D2", "C3PO", "Chewbacca", "Mace Windu" };
Console.WriteLine(AddStarWarsCharacters(star2));
static int AddStarWarsCharacters(string[] star2)
{
    int index = -1;
    for (int i = 0; i < star2.Length; i++)
    {
        if (star2[i] == "Yoda")
        {
            index = i;
        }
    }
    return index;
}


//Question 2

//Create a static method named DeathStarCombat() that takes in a Dictionary<string,int> of Star Wars characters (key) and their attack values (value)
//This method should return the name of the Jedi with the highest Attack value.

Dictionary<string, int> star = new Dictionary<string, int>();
star.Add("Obi", 10);
star.Add("Anakin", 5);
star.Add("JarJar", 7);
star.Add("Darth Maul", 14);
star.Add("Qui Gon", 14);


Console.WriteLine(DeathStarCombat(star));

static string DeathStarCombat(Dictionary<string, int> star)
{
    //string highest = star.First().Key;
    //foreach (KeyValuePair<string, int> c in star)
    //{

    //    if (c.Value > star[highest])
    //    {
    //        highest = c.Key;
    //    }
    //}
    //return highest;
    return star.OrderByDescending(c => c.Value).First().Key;
}


//Question 3

//Create a static method named ConvertPlanets() takes in one parameter: an array of planet names
//The method will convert the array of planets into a list of planets
//in the reverse order.
//Return List.

string[] planets =
{
"Mercury",
"Venus",
"Earth",
"Mars",
"Jupiter",
"Saturn",
"Uranus",
"Neptune",
"Pluto",
};

List<string> planetList = ConvertPlanets(planets);
foreach (string plan in planetList)
{
    Console.WriteLine(plan);
}

static List<string> ConvertPlanets(string[] planetList)
{
    return planetList.Reverse().ToList();

    //List<string> result = new List<string>();
    //{
    //    for (int i = planetList.Length - 1; i >= 0; i--)
    //    {
    //        result.Add(planetList[i]);
    //    }
    //    return result;
    //}
}


//Question 4
//Create a static method named AverageDroids() takes in an integer List for droids
//The method will search through the list and calculate the average of all even-numbered droids. 
//Return average.

List<int> droid = new List<int>();
droid.Add(1);
droid.Add(2);
droid.Add(3);
droid.Add(4);
droid.Add(5);
droid.Add(6);
droid.Add(7);
droid.Add(8);
droid.Add(9);
droid.Add(10);


Console.WriteLine(AverageDroids(droid));

static double AverageDroids(List<int> droid)
{
    List<int> evendroid = new List<int>();
    int sum = 0;
    foreach (int bot in droid)
    {
        if (bot % 2 == 0)
        {
            evendroid.Add(bot);
            sum += bot;
        }
    }
    double avg = sum / evendroid.Count;
    return avg;

    //return droid.Where(d => d % 2 == 0).Average();
}

//Question 5
Console.WriteLine(TryToCatchDarthVader("Yoda"));
static string TryToCatchDarthVader(string charSearch)
{
    try
    {
        int x = int.Parse(charSearch);
        return "Vader was captured";
    }
    catch (Exception e)
    {
        return "Vader got away!";
    }
}


































Console.ReadLine();
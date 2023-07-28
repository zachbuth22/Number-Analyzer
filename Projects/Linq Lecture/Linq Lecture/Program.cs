
List<int> ages = new List<int> { 23, 21, 19, 39, 25 };

//Count method
//Return how many match the condition
int adultCount = ages.Count(p => p >= 21);
Console.WriteLine($"There are {adultCount} adults");


//int counter = 0;
//foreach (int p in ages)
//{
//    if (p >= 21)
//    {
//        counter++;
//    }
//}
//return counter;

//Any method
//return a true or false if any elements match
bool childCheck = ages.Any(p=> p < 21);
Console.WriteLine($"Is there a child here? {childCheck}");

bool seniorCheck = ages.Any(p => p >= 65);
Console.WriteLine($"Is there a senior here? {seniorCheck}");

//All method
//returns true if all match condition, false if any don't
bool allAdult = ages.All(p => p >= 18);
Console.WriteLine($"Is everyone 18 or older? {allAdult}");
//create allCanDrink. Check if everyone is 21+
bool allCanDrink = ages.All(p => p >= 21);
Console.WriteLine($"Is everyone 21 or older? {allCanDrink}");

//Where
//Create a new collection based on condition
//filtering
List<double> clothes = new List<double>()
{
40.00,
50.00,
200.99,
500.00,
10.00,
100.02
};
//returns iEnumerable .ToList() converts it to a list
List<double> expensive = clothes.Where(c => c >= 100).ToList();
foreach(double e in expensive)
{
    Console.WriteLine(e);
}
//Create a new list. Use where to filter it where the value equals 100
//display it (NOTE: You won't get any back)

List<double> furniture = new List<double>()
{
43.56,
670.43,
1200.67,
59.42,
98.99,
100.00,
50.50
};
List<double> hundo = furniture.Where(c => c == 100).ToList();
foreach(double e in hundo)
{
    Console.WriteLine(e);
}
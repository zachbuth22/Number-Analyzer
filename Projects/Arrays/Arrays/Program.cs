//creating array
int[] grades = new int[9]; //empty array
string[] names = { "Justin", "Ethan", "Billy" };
//accessing values
Console.WriteLine(names[1]);
int chosen = 2;
Console.WriteLine(names[chosen]);
//write full array
foreach(string n in names)
{
    Console.WriteLine(n);
}
//Changing values
names[2] = "Yumi";
Console.WriteLine(names[2]);

//Looping through arrays
double[] prices = { 40, 1000, 150, 5, 200 };
//for loop
//i == index
//Can edit array mid loop
for(int i = 0;i < prices.Length; i++)
{
    if (prices[i]>= 100)
    {
        prices[i] = prices[i] * 0.85;
    }
    Console.WriteLine(prices[i]);
}

double total = 0;
    for(int i = 0; i< prices.Length;i++)
{
    total += prices[i];
}
double avg = total / prices.Length;
Console.WriteLine($"Average price with discounts {avg}");
Console.WriteLine(prices.Average());

//foreach
//simplifies code
//always run through all
//can't change value as you loop
//don't have access to index

double[] prices2 = { 8, 10, 13, 10, 25 };

//double largest = prices2[0]
double largest = double.MinValue;
foreach (double p in prices2)
{
    if (p > largest)
    {
        largest = p;
    }
    Console.WriteLine(p);
}
Console.WriteLine($"Largest = {largest}");

//Find the lowest value in the array
double smallest = double.MaxValue;
foreach (double p in prices2)
{
    if (p < smallest)
    {
        smallest = p;
    }
    Console.WriteLine(p);
}
Console.WriteLine($"Smallest = {smallest}");

//rectangle array
int[,] rectangle = new int[3, 5];
rectangle[2, 3] = 100;
Console.WriteLine(rectangle[2,3]);
Console.WriteLine(rectangle[1,3]);

//jagged arrays
int[][] jagged = new int[3][];
jagged[0] = new int[5];
jagged[1] = new int[3];
jagged[2] = new int[4];
jagged[0][2] = 9;
Console.WriteLine(jagged);

//Methods
int[] values = { 1, 2, 3, 4 };
int[] result = AddOne(values);
Console.WriteLine("Values");
foreach(int v in values)
{
    Console.WriteLine(v);
}
Console.WriteLine("Results");
foreach (int r in result)
{
    Console.WriteLine(r);
}

static int[] AddOne(int[] numArr)
{
    //any changes to arrays in methods effect the original array
    int[] temp = new int[numArr.Length];
for(int i = 0; i<numArr.Length; i++)
    {
        temp[i] = numArr[i] +1;
    }
    return temp;
}

//Exercise 1
//make an array of values
//ask user to choose an index 0 - (length-1)
//use the index and display the value in console

int[] numbers = { 5, 10, 311, 46, 2, 76, 7 };
Console.WriteLine("Please enter a choice from the index between 0-6");
int choice = int.Parse(Console.ReadLine());
Console.WriteLine(numbers[choice]);

//Exercise 2
//create another array of values (Make sure there are some duplicates)
//ask user to choose any number
//loop through the array and diplay index location when value matches

int[] numbers2 = { 1,2,3,4,5,1,2,3,4,5 };
Console.WriteLine($"Please enter a choice from the index between 0 - {numbers2.Length -1}");
int choice2 = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers2.Length; i++)
{
    if (numbers2[i] == choice2)
    {
        Console.WriteLine ($"Your choice is at the {i} location in the index");
    }
}



Console.ReadLine();
//Exercise 1
//create an int array
//Fill it with the numbers of 1-5
//loop through the numbers and display all to console

int[] numbers = { 1, 2, 3, 4, 5 };
foreach(int n in numbers)
{
    Console.WriteLine(n);
}

//Exercise 2
//Ask the user for a sentence. Save it in a string
//Split the sentence into an array of words (strings)
//Display each word in console
Console.WriteLine("Please enter a sentence");
string sentence = Console.ReadLine();
string[] words = sentence.Split(" ");
foreach (string w in words)
{
    Console.WriteLine(w);
}

//Exercise 3
//make a method called AvgArray
//take in a double array
//return a double
//find the average of the values in the array and return it

//double[] AvgArray = { 2.2, 3.5, 1.1, 7.0, 6.4 };
//Console.WriteLine(AvgArray);

//static double
//double total = 0;
//foreach(double n in AvgArray)
//{
//    total += n;
//}
//Console.WriteLine(); total / AvgArray.Length;

//Exercise 4
//method called findindex
//take in a string list and a string
//retun an int
//look through the string list and reutnr the index of the string parameter
//if not found, return -1
//"egg","bacon","cheese"
//"bacon"
//return 1

List<string> count = new List<string>()
{
    "Zero",
    "One",
    "Two",
    "Three",
    "Four"
};

Console.WriteLine(FindIndex(count,"Zero"));

static int FindIndex(List<string> count,string search)
{
    return count.FindIndex(s => s == search);

    //int index = -1;
    //for (int i = 0; i < count.Count; i++)
    //{
    //    if (count[i] == search)
    //    {
    //        index = i;
    //    }
    //}
    //return index;
}
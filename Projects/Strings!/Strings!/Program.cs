//initializing strings

string myString = "Cow";
char[] letters = { 'E', 't', 'h', 'a', 'n' };
string myString2 = new string(letters);

Console.WriteLine(myString);
Console.WriteLine(myString2);

//add two strings together
string myString3 = myString + myString2;
Console.WriteLine(myString3);
myString = myString + " whatever";
myString2 = string.Concat(myString2," whatever");

Console.WriteLine(myString);
Console.WriteLine(myString2);

//comparing strings
//pretend these are if statements
//ascii table compares values

string val1 = "hi";
string val2 = "Hi";
string sentence = "I am a GC student";

Console.WriteLine(val1 == val2); //total search
Console.WriteLine(val2.Contains("i")); //partial search
Console.WriteLine(sentence.Contains("i")); //<-- Justin's Favorite
Console.WriteLine(String.Compare(val1,val2,true)); //Non case sensitive
//don't match -1
//match 0
//partial 1
Console.WriteLine(val1.ToLower() == val2.ToLower()); //<-- Justin's Favorite

//Useful built in methods

//index of
string value = "session";
Console.WriteLine(value.IndexOf("s"));

//last index of
Console.WriteLine(value.LastIndexOf("s"));

//ends with
string value2 = "I entered bootcamp!";
Console.WriteLine(value2.EndsWith("!"));

//replace
string value3 = "where_the_sidewalk_ends";
string result3 = value3.Replace('_',' ');
Console.WriteLine(result3);

//split
string value4 = "Dungeon and Dragon";
string[] splitLetters = value4.Split(" "); //empty to get every char out
//easier
foreach(string word in splitLetters)
{
    Console.WriteLine(word);
}

//substring
string value5 = "Storm";
string firstLetter = value5.Substring(0,1);
Console.WriteLine(firstLetter);
string lastLetter = value5.Substring(value5.Length -1);
Console.WriteLine(lastLetter);


//length (property)
Console.WriteLine(value5.Length);

//ToUpper or ToLower
string value6 = "hSYUjfawadfJH";
Console.WriteLine(value6.ToUpper());
Console.WriteLine(value6.ToLower());

//Trim
string value7 = "                   Hello Kevin                     ";
Console.WriteLine(value7);
Console.WriteLine(value7.Trim());

//Example uses

Console.WriteLine(CorrectCasing("zACH"));

string FullName = "zACH buTh";
string result = "";
foreach(string n in FullName.Split(" "))
{
    result += CorrectCasing(n) + " ";
}
Console.WriteLine(result);

static string CorrectCasing(string dirty)
{
    string cleaned = dirty.Substring(0, 1).ToUpper() + dirty.Substring(1).ToLower();
    return cleaned;
}

//loop through letters
string Input = "Cocktails";

for(int i = 0; i < Input.Length; i++)
{
    Console.WriteLine(Input[i]);
        if (Input[i] == 'a')
    {
        Console.WriteLine("A spotted");
    }
    
}



Console.ReadLine();
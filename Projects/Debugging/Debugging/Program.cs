int x = 0;
if(x <=0)
{
    Console.WriteLine("negative or 0");
}

//--
for(int i = 0; i<=5; i++)
{
    Console.WriteLine(i);
}
//--
int myAge = 26;
string result = ageLimit(myAge);
Console.WriteLine(result);

//-- slides example
string[] vowels = { "a", "e", "i", "o", "u" };
string letter = "i";
bool isVowel = false;
foreach(string v in vowels)
{
    if(v == letter)
    {
        isVowel = true;
    }
}
Console.WriteLine(isVowel);

//--dictionary
Dictionary<int, string> staff = new Dictionary<int, string>()
{
    {0,"Justin"},
    {1,"Ethan" },
    {2,"Billy" },
};
Console.WriteLine();

static string ageLimit(int age)
{
    if (age >= 16 && age <18)
    {
        return "Can Drive";
    }
    else if (age >= 18 && age<21)
    {
        return "Can Vote";
    }
    else if (age >= 21)
    {
        return "Can Drink";
    }
    else
    {
        return "Too Young";
    }
}
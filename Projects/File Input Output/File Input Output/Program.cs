string filepath = "../../../file1.txt";

//if exists
if (File.Exists(filepath)== false)
{
    StreamWriter tempWriter = new StreamWriter(filepath);
    tempWriter.WriteLine("This is temp");
    tempWriter.Close();
}


//write
//StreamWriter writer = new StreamWriter(filepath);
//writer.WriteLine("Hello");
//writer.WriteLine("sdfgfeg");
//writer.WriteLine(Console.ReadLine());
//writer.Close();

//read
StreamReader reader = new StreamReader(filepath);
while (true)
{
    string line = reader.ReadLine();
    if (line == null)
    {
        break;
    }
    else
    {
        Console.WriteLine(line);
    }
}

Console.ReadLine();
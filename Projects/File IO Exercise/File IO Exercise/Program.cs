//where file is located
using File_IO_Exercise;

string filePath = "../../../Students.txt";

//if file doesn't exist
if(File.Exists(filePath) == false)
{
    StreamWriter tempWriter = new StreamWriter(filePath);
    tempWriter.WriteLine("Zach Buth|30|20");
    tempWriter.Close();
}

//Read file, fill the list
StreamReader reader = new StreamReader(filePath);
List<Student> allStudents = new List<Student>();
while (true)
{
    //name|age|grade
    string line = reader.ReadLine();

    if(line== null)
    {
        break;
    }
    else
    {
        //name|age|grade
        string[] parts = line.Split("|");
        //parts[0] = name
        //parts[1] = age
        //parts[2] = grade
        Student s = new Student(parts[0], int.Parse(parts[1]), int.Parse(parts[2]) );
        allStudents.Add(s);
    }
}
reader.Close();

//display all students

foreach (Student s in allStudents)
{
    Console.WriteLine($"{s.Name} {s.Grade} {s.Age}");
}

//add another student
Console.WriteLine("Enter new student's name");
string name = Console.ReadLine();
Console.WriteLine("Enter age");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Enter grade");
int grade = int.Parse(Console.ReadLine());
Student newStu = new Student(name, age, grade);

allStudents.Add(newStu);

//add list updates to file (End my code with this)
StreamWriter writer = new StreamWriter(filePath);
foreach (Student stu in allStudents)
{
    writer.WriteLine($"{stu.Name}|{stu.Age}|{stu.Grade}");
}
writer.Close();






Console.ReadLine();
using System;
namespace File_IO_Exercise
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        //constructor
        public Student(string _name, int _age, int _grade)
        {
            Name = _name;
            Age = _age;
            Grade = _grade;
        }
    }
}


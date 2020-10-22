using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<Student> savedStudents = new List<Student>();

            while (students[0] != "end")
            {
                string firstName = students[0];
                string lastName = students[1];
                string age = students[2];
                string town = students[3];

                Student info = new Student();

                info.firstName = firstName;
                info.lastName = lastName;
                info.age =int.Parse(age);
                info.homeTown = town;

                savedStudents.Add(info);

                students = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            string filterCity = Console.ReadLine();

            //foreach (Student student in savedStudents)
            //{
            //    if (filterCity == student.homeTown)
            //    {
            //        Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} year old.");
            //    }
            //}

            List<Student> filterStudents = savedStudents
                .Where(s => s.homeTown == filterCity)
                .ToList();

            foreach (Student student in filterStudents)
            {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");

            }
        }
    }
}

class Student
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public string homeTown { get; set; }

}

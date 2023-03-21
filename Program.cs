using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Courses { get; set; }


    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        Courses = new List<string>();
    }

    public void AddCourse(string course)
    {
        Courses.Add(course);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine("Courses:");
        foreach (string course in Courses)
        {
            Console.WriteLine($"- {course}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Student alice = new Student("Alice", 20);
        alice.AddCourse("C# Programming");
        alice.AddCourse("Web Development");

        Student bob = new Student("Bob", 22);
        bob.AddCourse("Java Programming");
        bob.AddCourse("Database Design");



        List<Student> students = new List<Student>();
        students.Add(alice);
        students.Add(bob);

        foreach (Student student in students)
        {
            student.PrintInfo();
            Console.WriteLine();
        }
    }


}
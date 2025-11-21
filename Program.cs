using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id  { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        Id   = id;
        Name = name;
        Age  = age;
    }

    public void Show()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        List<Student> students = new List<Student>()
        {
            new Student(1, "An",      16),
            new Student(2, "Binh",    14),
            new Student(3, "Anh",     18),
            new Student(4, "Cuong",   17),
            new Student(5, "Alice",   19),
            new Student(6, "Dat",     15)
        };


        Console.WriteLine("a) Danh sach toan bo hoc sinh:");
        foreach (var s in students)
            s.Show();
        Console.WriteLine();


        Console.WriteLine("b) Hoc sinh co tuoi tu 15 den 18:");
        var age15to18 =
            from s in students
            where s.Age >= 15 && s.Age <= 18
            select s;

        foreach (var s in age15to18)
            s.Show();
        Console.WriteLine();


        Console.WriteLine("c) Hoc sinh co ten bat dau bang chu 'A':");
        var nameStartA =
            from s in students
            where s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)
            select s;

        foreach (var s in nameStartA)
            s.Show();
        Console.WriteLine();


        Console.WriteLine("d) Tong tuoi tat ca hoc sinh:");
        var totalAge =
            (from s in students
             select s.Age).Sum();

        Console.WriteLine("Tong tuoi = " + totalAge);
        Console.WriteLine();


        Console.WriteLine("e) Hoc sinh co tuoi lon nhat:");
        var maxAge =
            (from s in students
             select s.Age).Max();

        var oldestStudents =
            from s in students
            where s.Age == maxAge
            select s;

        foreach (var s in oldestStudents)
            s.Show();
        Console.WriteLine();


        Console.WriteLine("f) Danh sach sap xep theo tuoi tang dan:");
        var sorted =
            from s in students
            orderby s.Age ascending
            select s;

        foreach (var s in sorted)
            s.Show();
    }
}

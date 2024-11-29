////12 List<T> with Custom Objects
////Define a class Student with properties Id and Name.
////Use a List<Student> to store and display a list of students.

//using System;
//using System.Collections.Generic;

//public class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public Student(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        List<Student> students = new List<Student>();

//        students.Add(new Student(1, "Alice"));
//        students.Add(new Student(2, "Bob"));
//        students.Add(new Student(3, "Charlie"));
//        students.Add(new Student(4, "David"));
//        students.Add(new Student(5, "Eve"));

//        Console.WriteLine("List of Students:");
//        foreach (var student in students)
//        {
//            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
//        }
//        Console.ReadLine();
//    }
//}

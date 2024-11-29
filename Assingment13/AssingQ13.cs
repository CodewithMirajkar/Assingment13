////13 Dictionary<TKey, TValue> Basics
////Create a Dictionary<string, int> to store and
////retrieve the marks of 5 students.
//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static void Main()
//    {
//        Dictionary<string, int> studentMarks = new Dictionary<string, int>();

//        studentMarks.Add("Alice", 85);
//        studentMarks.Add("Bob", 92);
//        studentMarks.Add("Charlie", 78);
//        studentMarks.Add("David", 90);
//        studentMarks.Add("Eve", 88);

//        Console.WriteLine("Student Marks:");
//        foreach (var student in studentMarks)
//        {
//            Console.WriteLine($"Student: {student.Key}, Marks: {student.Value}");
//        }
//        string studentName = "Bob";
//        if (studentMarks.ContainsKey(studentName))
//        {
//            Console.WriteLine($"\n{studentName}'s marks: {studentMarks[studentName]}");
//        }
//        else
//        {
//            Console.WriteLine($"\n{studentName} not found.");
//        }
//        Console.ReadLine();
//    }
//}

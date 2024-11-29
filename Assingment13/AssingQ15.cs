////15 LINQ with Generics
////Create a List<int> and use LINQ to: 	Find all even numbers.
////	Calculate the sum of all numbers greater than 10.

//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Program
//{
//    public static void Main()
//    {
//        List<int> numbers = new List<int> { 5, 12, 8, 21, 15, 30, 3, 10, 7, 18 };

//        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

//        Console.WriteLine("Even Numbers:");
//        foreach (var number in evenNumbers)
//        {
//            Console.WriteLine(number);
//        }

//        int sumGreaterThan10 = numbers.Where(n => n > 10).Sum();

//        Console.WriteLine($"\nSum of numbers greater than 10: {sumGreaterThan10}");
//        Console.ReadLine();
//    }
//}



////1.	Understanding Delegates
////Define a delegate called MyDelegate that accepts an int and returns a bool.
////Create a method IsEven(int number) that uses this delegate to check if a number is even.

//using System;

//public class Program
//{
//    public delegate bool MyDelegate(int number);
//    public static bool IsEven(int number, MyDelegate myDelegate)
//    {
//        return myDelegate(number);
//    }
//    public static bool CheckIfEven(int number)
//    {
//        return number % 2 == 0;
//    }

//    public static void Main()
//    {
//        MyDelegate myDelegate = new MyDelegate(CheckIfEven);

//        int number = 4;
//        bool result = IsEven(number, myDelegate);

//        Console.WriteLine($"Is {number} even? {result}");
//        Console.ReadLine();
//    }
//}

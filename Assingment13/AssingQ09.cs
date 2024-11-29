////099.	Generic Methods
////Write a generic method Swap<T> that swaps two variables of any type.
////Test it with integers and strings.

//using System;

//public class Program
//{
//    public static void Swap<T>(ref T a, ref T b)
//    {
//        T temp = a;
//        a = b;
//        b = temp;
//    }

//    public static void Main()
//    {
//        int x = 10, y = 20;
//        Console.WriteLine($"Before Swap: x = {x}, y = {y}");
//        Swap(ref x, ref y);
//        Console.WriteLine($"After Swap: x = {x}, y = {y}");

//        string str1 = "Hello", str2 = "World";
//        Console.WriteLine($"Before Swap: str1 = {str1}, str2 = {str2}");
//        Swap(ref str1, ref str2);
//        Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");
//        Console.ReadLine();
//    }
//}

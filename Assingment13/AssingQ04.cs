////04 lambda expression
////Rewrite the program from Question 3
////using a lambda expression.
//using System;

//public class Program
//{
//    public delegate bool CheckNumber(int number);

//    public static void Main()
//    {
//        CheckNumber isGreaterThanTen = (number) => number > 10;
//        int testNumber = 15;
//        bool result = isGreaterThanTen(testNumber);

//        Console.WriteLine($"Is {testNumber} greater than 10? {result}");
//        testNumber = 5;
//        result = isGreaterThanTen(testNumber);

//        Console.WriteLine($"Is {testNumber} greater than 10? {result}");
//        Console.ReadLine();
//    }
//}

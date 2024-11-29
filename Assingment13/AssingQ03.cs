////03.	Anonymous Methods
////Use an anonymous method with a delegate to check
////if a number is greater than 10.

//using System;

//public class Program
//{
//    public delegate bool CheckNumber(int number);

//    public static void Main()
//    {
//        CheckNumber isGreaterThanTen = delegate (int number)
//        {
//            return number > 10;
//        };
//        int testNumber = 15;
//        bool result = isGreaterThanTen(testNumber);

//        Console.WriteLine($"Is {testNumber} greater than 10? {result}");
//        testNumber = 5;
//        result = isGreaterThanTen(testNumber);

//        Console.WriteLine($"Is {testNumber} greater than 10? {result}");
//        Console.ReadLine();
//    }
//}

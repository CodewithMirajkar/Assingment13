////14 Generic Constraints
////Create a generic class Calculator<T> with a method Add(T a, T b). Ensure T supports addition.

//using System;

//public class Calculator<T>
//{
    
//    public T Add(T a, T b)
//    {
//        dynamic result = a + b;
//        return result;
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Calculator<int> intCalculator = new Calculator<int>();
//        int intResult = intCalculator.Add(10, 20);
//        Console.WriteLine($"Addition of 10 and 20 (int): {intResult}");

//        Calculator<double> doubleCalculator = new Calculator<double>();
//        double doubleResult = doubleCalculator.Add(10.5, 20.5);
//        Console.WriteLine($"Addition of 10.5 and 20.5 (double): {doubleResult}");

//        Calculator<string> stringCalculator = new Calculator<string>();
//        string stringResult = stringCalculator.Add("Hello, ", "World!");
//        Console.WriteLine($"Concatenation of 'Hello, ' and 'World!' (string): {stringResult}");
//        Console.ReadLine();
//    }
//}

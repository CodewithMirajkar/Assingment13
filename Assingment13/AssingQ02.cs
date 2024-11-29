////02 2.	Basic Delegate Usage
////	Write a program where a delegate is used to call two methods: Add(int a, int b)
//// and Multiply(int a, int b).

//using System;

//public class Program
//{    
//    public delegate int MathOperation(int a, int b);
//    public static int Add(int a, int b)
//    {
//        return a + b;
//    }
//    public static int Multiply(int a, int b)
//    {
//        return a * b;
//    }

//    public static void Main()
//    {
//        MathOperation addOperation = new MathOperation(Add);
//        MathOperation multiplyOperation = new MathOperation(Multiply);
//        int sum = addOperation(5, 3);
//        Console.WriteLine($"5 + 3 = {sum}");
//        int product = multiplyOperation(5, 3);
//        Console.WriteLine($"5 * 3 = {product}");
//        Console.ReadLine();
//    }
//}

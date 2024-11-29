////055.	Multicast Delegates
////Create a multicast delegate that invokes two methods:
////PrintHello() and PrintGoodbye().

//using System;

//public class Program
//{
//    public delegate void PrintMessage();
//    public static void PrintHello()
//    {
//        Console.WriteLine("Hello");
//    }
//    public static void PrintGoodbye()
//    {
//        Console.WriteLine("Goodbye");
//    }

//    public static void Main()
//    {
//        PrintMessage printMessages = PrintHello;
//        printMessages += PrintGoodbye;
//        printMessages();

//        Console.ReadLine();
//    }
//}

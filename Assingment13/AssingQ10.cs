////10	Generic Classes
////Create a generic class Box<T> with a property Value of type T.
////Demonstrate storing and retrieving values of different types.

//using System;

//public class Box<T>
//{
//    public T Value { get; set; }
//    public Box(T value)
//    {
//        Value = value;
//    }

//    public void DisplayValue()
//    {
//        Console.WriteLine($"The value in the box is: {Value}");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Box<int> intBox = new Box<int>(10);
//        intBox.DisplayValue();

//        Box<string> stringBox = new Box<string>("Hello, Generics!");
//        stringBox.DisplayValue();

//        Box<double> doubleBox = new Box<double>(3.14);
//        doubleBox.DisplayValue();
//        Box<bool> boolBox = new Box<bool>(true);
//        boolBox.DisplayValue();
//        Console.ReadLine();
//    }
//}

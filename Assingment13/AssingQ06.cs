////06 6.	Creating an Event
////Define an event called NumberChanged.
////Trigger the event when a new number is set in a property.

//using System;

//public class Program
//{
//    public event EventHandler NumberChanged;

//    private int _number;

//    public int Number
//    {
//        get { return _number; }
//        set
//        {
//            if (_number != value)
//            {
//                _number = value;
//                OnNumberChanged();
//            }
//        }
//    }
//    protected virtual void OnNumberChanged()
//    {
//        NumberChanged?.Invoke(this, EventArgs.Empty);
//    }
//    public void HandleNumberChanged(object sender, EventArgs e)
//    {
//        Console.WriteLine("The number has changed.");
//    }

//    public static void Main()
//    {
//        Program program = new Program();
//        program.NumberChanged += program.HandleNumberChanged;
//        program.Number = 10;
//        program.Number = 20;
//        program.Number = 20;
//        Console.ReadLine();
//    }
//}

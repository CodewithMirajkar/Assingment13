////077.	Subscribing to Events
////Create an event OnThresholdReached in a class.
////Subscribe to this event from another class
////and execute a method when the threshold is reached.

//using System;

//public class ThresholdNotifier
//{
//    public event EventHandler OnThresholdReached;

//    private int _threshold = 10;
//    private int _currentValue;
//    public int CurrentValue
//    {
//        get { return _currentValue; }
//        set
//        {
//            _currentValue = value;
//            if (_currentValue >= _threshold)
//            {
//                OnThresholdReached?.Invoke(this, EventArgs.Empty);
//            }
//        }
//    }
//    public void SetThreshold(int threshold)
//    {
//        _threshold = threshold;
//    }
//}

//public class Subscriber
//{
//    public void ThresholdReachedHandler(object sender, EventArgs e)
//    {
//        Console.WriteLine("Threshold reached! Executing the threshold reached handler.");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        ThresholdNotifier notifier = new ThresholdNotifier();
//        Subscriber subscriber = new Subscriber();
//        notifier.OnThresholdReached += subscriber.ThresholdReachedHandler;
//        notifier.SetThreshold(5);
//        notifier.CurrentValue = 3;
//        notifier.CurrentValue = 5;
//        notifier.CurrentValue = 7;
//        Console.ReadLine();
//    }
//}

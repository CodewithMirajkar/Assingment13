////08	Event Handler with Arguments
////Create a custom event handler OnDataChanged that passes
////the old and new values of a string property.

//using System;

//public class DataChangedEventArgs : EventArgs
//{
//    public string OldValue { get; }
//    public string NewValue { get; }

//    public DataChangedEventArgs(string oldValue, string newValue)
//    {
//        OldValue = oldValue;
//        NewValue = newValue;
//    }
//}

//public class DataNotifier
//{
//    public event EventHandler<DataChangedEventArgs> OnDataChanged;

//    private string _data;
//    public string Data
//    {
//        get { return _data; }
//        set
//        {
//            if (_data != value)
//            {
//                string oldValue = _data;
//                _data = value;

//                OnDataChanged?.Invoke(this, new DataChangedEventArgs(oldValue, _data));
//            }
//        }
//    }
//}

//public class Subscriber
//{
//    public void DataChangedHandler(object sender, DataChangedEventArgs e)
//    {
//        Console.WriteLine($"Data changed from '{e.OldValue}' to '{e.NewValue}'");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        DataNotifier dataNotifier = new DataNotifier();
//        Subscriber subscriber = new Subscriber();

//        dataNotifier.OnDataChanged += subscriber.DataChangedHandler;

//        dataNotifier.Data = "Hello";
//        dataNotifier.Data = "World";
//        dataNotifier.Data = "C#";
//        Console.ReadLine();
//    }
//}

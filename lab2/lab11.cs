using System;

namespace GenericDemo
{
    public class Box<T>
    {
        private T _value;
        public Box(T value)
        {
            _value = value;
        }
        public void SetValue(T value)
        {
            _value = value;
        }

        public T GetValue()
        {
            return _value;
        }
        public void Display()
        {
            Console.WriteLine($"The value is: {_value}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box<int> intBox = new Box<int>(123);
            intBox.Display();  

            Box<string> strBox = new Box<string>("Hello, Generics!");
            strBox.Display(); 
            
            intBox.SetValue(456);
            intBox.Display(); 

            strBox.SetValue("Generics in C#");
            strBox.Display(); 

            Console.ReadLine();
        }
    }
}

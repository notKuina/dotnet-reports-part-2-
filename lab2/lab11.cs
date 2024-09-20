using System;

namespace GenericDemo
{
    // Generic class Box<T>
    public class Box<T>
    {
        private T _value;

        // Constructor
        public Box(T value)
        {
            _value = value;
        }

        // Method to set the value
        public void SetValue(T value)
        {
            _value = value;
        }

        // Method to get the value
        public T GetValue()
        {
            return _value;
        }

        // Method to display the value
        public void Display()
        {
            Console.WriteLine($"The value is: {_value}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Box instance for int
            Box<int> intBox = new Box<int>(123);
            intBox.Display();  // Output: The value is: 123

            // Creating a Box instance for string
            Box<string> strBox = new Box<string>("Hello, Generics!");
            strBox.Display();  // Output: The value is: Hello, Generics!

            // Modifying the value in the integer box
            intBox.SetValue(456);
            intBox.Display();  // Output: The value is: 456

            // Modifying the value in the string box
            strBox.SetValue("Generics in C#");
            strBox.Display();  // Output: The value is: Generics in C#

            Console.ReadLine();
        }
    }
}

using System;

namespace OperatorOverloading
{
    public class Number
    {
        public int Value { get; set; }
        public Number(int value)
        {
            Value = value;
        }
        public static Number operator -(Number n)
        {
            return new Number(-n.Value);
        }
        public void Display()
        {
            Console.WriteLine($"Value: {Value}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number(5);
            Console.WriteLine("Original value:");
            num.Display();

            Number negatedNum = -num;
            Console.WriteLine("Negated value:");
            negatedNum.Display();
            Console.ReadLine();
        }
    }
}

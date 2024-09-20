using System;

namespace BinaryOperator
{
    public class ComplexNumber
    {
        public double Real { get; set; }  
        public double Imaginary { get; set; }  
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            // Adding the real parts and the imaginary parts
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }
        public void Display()
        {
            Console.WriteLine($"{Real} + {Imaginary}i");
        }
    }

    class Program
    {
            static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(2.5, 3.5);
            ComplexNumber c2 = new ComplexNumber(1.5, 2.5);

            Console.WriteLine("Complex Number 1:");
            c1.Display();

            Console.WriteLine("Complex Number 2:");
            c2.Display();

            ComplexNumber c3 = c1 + c2;

            Console.WriteLine("Result after adding the two complex numbers:");
            c3.Display();

            Console.ReadLine();
        }
    }
}

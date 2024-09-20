using System;

namespace lab10
{
  
    public class Shape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Shape()
        {
            Length = 0;
            Breadth = 0;
        }

        public Shape(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(double length, double breadth) : base(length, breadth)
        
       
        public double CalculateArea()
        {
            return Length * Breadth;
        }
        public void DisplayArea()
        {
            Console.WriteLine($"The area of the rectangle is: {CalculateArea()} square units.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5.0, 3.0);
            rect.DisplayArea();
            Console.ReadLine();
        }
    }
}

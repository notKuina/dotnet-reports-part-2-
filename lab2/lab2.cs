using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third integer:");
        int num3 = Convert.ToInt32(Console.ReadLine());
        
        int sum = num1 + num2 + num3;
        Console.WriteLine("The sum of the three integers is: " + sum);
    }
}

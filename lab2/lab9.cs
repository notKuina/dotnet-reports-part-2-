using System;

namespace Properties
{
    public class Student
    {
        private string _name;
        private int _age;

        // Read-Write Property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Read-Only Property
        public int Age
        {
            get { return _age; }
        }

        // Write-Only Property
        public int WriteOnlyAge
        {
            set { _age = value; }
        }

        // Auto-Implemented Property
        public double GPA { get; set; }

        // Computed Property
        public string Status
        {
            get
            {
                return _age >= 18 ? "Adult" : "Minor";
            }
        }
        public Student(string name, int age, double gpa)
        {
            _name = name;
            _age = age;
            GPA = gpa;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, GPA: {GPA}, Status: {Status}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Gon", 12, 3.8);

            Console.WriteLine("Using Read-Write Property:");
            student.Name = "Killua";
            Console.WriteLine("Name: " + student.Name); 

            Console.WriteLine("\nUsing Read-Only Property:");
            Console.WriteLine("Age: " + student.Age);

            Console.WriteLine("\nUsing Write-Only Property:");
            student.WriteOnlyAge = 11;  
            Console.WriteLine("Updated Age (Read-Only): " + student.Age);

            Console.WriteLine("\nUsing Auto-Implemented Property:");
            student.GPA = 3.9; 
            Console.WriteLine("GPA: " + student.GPA);

            Console.WriteLine("\nUsing Computed Property:");
            Console.WriteLine("Status: " + student.Status);

            Console.WriteLine("\nStudent Details:");
            student.Display();

            Console.ReadLine();
        }
    }
}

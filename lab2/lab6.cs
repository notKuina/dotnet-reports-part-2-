using System;

namespace Constructors
{
    public class Person
    {
        public string Name;
        public int Age;

        // Default Constructor
        public Person()
        {
            Name = "Unknown";
            Age = 0;
            Console.WriteLine("Default constructor called.");
        }

        // Parameterized Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Parameterized constructor called.");
        }

        // Copy Constructor
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
            Console.WriteLine("Copy constructor called.");
        }

        // Static Constructor
        static Person()
        {
            Console.WriteLine("Static constructor called.");
        }

        // Private Constructor
        private Person(int secret)
        {
            Name = "Secret";
            Age = secret;
            Console.WriteLine("Private constructor called.");
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public static Person CreateSecretPerson(int secret)
        {
            return new Person(secret);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Display();

            Person person2 = new Person("Samjhana", 22);
            person2.Display();

            Person person3 = new Person(person2);
            person3.Display();

            // The static constructor is called only once, when the first instance is created or any static member is accessed.The static constructor was already called before `person1` was created.

            Person secretPerson = Person.CreateSecretPerson(22);
            secretPerson.Display();

            Console.ReadLine();
        }
    }
}

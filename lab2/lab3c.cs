using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("samjhana", "Magar");
            person.ShowFullName();
            person.ShowGreeting();
            Console.ReadLine();
        }
    }
}

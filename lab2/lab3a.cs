using System;

namespace PartialClass
{
    public partial class Person
    {
        private string firstName;
        private string lastName;
         public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
            public void ShowFullName()
        {
            Console.WriteLine($"Full Name: {firstName} {lastName}");
        }
    }
}

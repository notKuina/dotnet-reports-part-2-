using System;

namespace PartialClass
{
    public partial class Person
    {        public void ShowGreeting()
        {
            Console.WriteLine($"Hello, {firstName}!");
        }
    }
}

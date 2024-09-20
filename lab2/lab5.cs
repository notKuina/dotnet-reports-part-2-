using System;

namespace VirtualMethod
{
    public class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal(); 
            Animal myDog = new Dog();     
            Animal myCat = new Cat();      

 
            myAnimal.Sound();  
            myDog.Sound();    
            myCat.Sound();    

            Console.ReadLine();
        }
    }
}

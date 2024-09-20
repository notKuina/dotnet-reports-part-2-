using System;

namespace Inheritance
{   public class Animal
    { public void Eat(){
            Console.WriteLine("Animal is eating.");
        }
    }

    //  Single Inheritance
    public class Dog : Animal {
        public void Bark() {
            Console.WriteLine("Dog is barking.");
        }
    }

    // Multilevel Inheritance
    public class Puppy : Dog{
        public void Weep(){
            Console.WriteLine("Puppy is weeping.");
        }
    }

    // Hierarchical Inheritance
    public class Cat : Animal
    {
        public void Meow(){
            Console.WriteLine("Cat is meowing.");
        }
    }

    class Program{
        static void Main(string[] args){
            Console.WriteLine("Single Inheritance:");
            Dog dog = new Dog();
            dog.Eat();  // From Animal
            dog.Bark(); // From Dog

            Console.WriteLine("\nMultilevel Inheritance:");
            Puppy puppy = new Puppy();
            puppy.Eat();  // From Animal
            puppy.Bark(); // From Dog
            puppy.Weep(); // From Puppy

            Console.WriteLine("\nHierarchical Inheritance:");
            Cat cat = new Cat();
            cat.Eat();  // From Animal
            cat.Meow(); // From Cat

            Console.ReadLine();
        }
    }
}

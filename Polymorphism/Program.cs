using System;
namespace Polymorphism
{
    abstract class Animal // Base class (parent)
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    //class Animal // Base class (parent)
    //{
    //    public abstract void animalSound()
    //    {
    //        Console.WriteLine("animal can speaks");
    //    }
    //    public void sleep()
    //    {
    //        Console.WriteLine("Zzz");
    //    }
    //}
    class Pig : Animal // Derived class (child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Dog : Animal // Derived class (child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Animal myAnimal = new Animal(); // Create a Animal object
            Animal myPig = new Pig(); // Create a Pig object
            Animal myDog = new Dog(); // Create a Dog object
            //myAnimal.animalSound();
            //myPig.animalSound();
            //myDog.animalSound();
            //Console.WriteLine();
            myPig.animalSound();
            myPig.sleep();
            myDog.animalSound();
            myDog.sleep();
            
            Console.ReadLine(); 
        }
    }
}
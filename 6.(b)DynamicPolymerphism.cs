using System;

namespace Lab_Report_SadhanaKhadka
{
        class DynamicPolymerphismDemo
        {
            class Animal
            {
                public virtual void MakeSound()
                {
                    Console.WriteLine("Showing general animal sound");
                }
            }

            class Dog : Animal
            {
                public override void MakeSound()
                {
                    Console.WriteLine("Woof, woof!");
                }
            }
        class Cow : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Moo, moo!");
            }
        }

        static void Main(string[] args)
            {
                Animal allanimal = new Animal();
                Animal dog = new Dog();
                Animal Cow = new Cow();

                allanimal.MakeSound(); // Calls the base class method
                Cow.MakeSound(); // Calls the overridden method in Dog class
                dog.MakeSound(); // Calls the overridden method in Cat class
                Console.WriteLine("\n Lab NO :5");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");
        }
        }
}

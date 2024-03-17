using System;
namespace Lab_Report_SadhanaKhadka
{
        class methodOverridingDemo
        {
            class Father
            {
                public virtual void marriageType()
                {
                    Console.WriteLine("I prefer Arrange marriage");
                }

                public void Greeting() // Not virtual, cannot be overridden
                {
                    Console.WriteLine("Hello and Namaste eveyone. I am father");
                }
            }

            class Daughter : Father
            {
                public override void marriageType()
                {
                    Console.WriteLine("I prefer Court marriage");
                }

                public new void Greeting() // Hides the base class Greeting()
                {
                    Console.WriteLine("Thank you everyone from Sadhan Khadka");
                }
            }

            static void Main(string[] args)
            {
                Father f1 = new Father();
                Daughter sadhana = new Daughter();
                sadhana.Greeting(); // Calls Son's Greeting() due to method hiding
                sadhana.marriageType(); // Calls Son's marriageType() due to overriding
                Console.WriteLine("\n Lab NO :5");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");
        }
        }
    }


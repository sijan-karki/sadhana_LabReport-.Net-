using System;

namespace Lab_Report_SadhanaKhadka
{
    public partial class Person
    {
        public string FirstName;
        public string LastName;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public partial class Person
    {
        public void Display()
        {
            Console.WriteLine("The person's name is {0} {1}", FirstName, LastName);
        }
    }

    internal class PartialClassDemo
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Sandhya", "Khadka");
            person1.Display();
            Console.WriteLine("\n Lab NO :8'c'");
            Console.WriteLine(" Name : Sadhana Khadka");
            Console.WriteLine(" Roll No:20");
        }
    }
}

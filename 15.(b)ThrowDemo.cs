using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_Report_SadhanaKhadka
{ 
        internal class ThrowDemo
        {
            class Student
            {
                public void Age(int age)
                {
                    if (age <= 0)
                    {
                        throw new ArgumentException("Age cannot be zero or less than zero.");
                    }
                    else if (age >= 150)
                    {
                        throw new ArgumentException("Age cannot be greater than or equal to 150.");
                    }
                    else
                    {
                        Console.WriteLine("The age of the student is: " + age);
                    }
                }
            }

            static void Main(string[] args)
            {
                Student s = new Student();
                try
                {
                    s.Age(25);  // Valid age
                    s.Age(-9);  // This will throw an exception
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Exception occurred: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("We are out of the exception.");
                }
               Console.WriteLine("\n Lab NO :15'b'");
               Console.WriteLine(" Name : Sadhana Khadka");
               Console.WriteLine(" Roll No:20");
            }
        }

}

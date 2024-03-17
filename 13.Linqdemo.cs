using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_Report_SadhanaKhadka
{
        internal class LinqDemo
        {
            static void Main(string[] args)
            {
                string[] names = { "Sijan", "Sadhana", "Lal", "Nishan", "Sanjaya", "tammana", "Gaurav" };
                var result = from src in names where src.EndsWith("n") select src;
                Console.WriteLine("The names ending with S are ::");
                foreach (var name in result)
                {
                    Console.WriteLine(name + " ");
                }

                var result1 = from src in names where src.Length <= 5 select src;
                Console.WriteLine("\nThe names with length less than or equals to 3 length are ::");
                foreach (var name in result1)
                {
                    Console.WriteLine(name + " ");
                }

                var result2 = from src in names where src.Contains("d") select src;
                Console.WriteLine("\nThe names containing a are ::");
                foreach (var name in result2)
                {
                    Console.WriteLine(name + " ");
                }
                Console.WriteLine("\n Lab NO :13");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");
            }

        }
}

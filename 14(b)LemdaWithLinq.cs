using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab_Report_SadhanaKhadka
{
        internal class DemoProgram
        {
            public static void Main(string[] args)
            {
                List<int> numbers = new List<int> { 3, 7, 2, 8, 1, 5, 4, 6 };

                // Filtering: Select numbers greater than 3
                var filteredNumbers = numbers.Where(n => n > 3);
                Console.WriteLine("Numbers greater than 3:");
                foreach (var number in filteredNumbers)
                {
                    Console.Write(number+",");
                }

                // Ordering: Sort numbers in ascending order
                var orderedNumbers = numbers.OrderBy(n => n);
                Console.WriteLine("\nNumbers sorted in ascending order:");
                foreach (var number in orderedNumbers)
                {
                    Console.Write(number+",");
                }

                // Projection: Select squares of each number
                var squaredNumbers = numbers.Select(n => n * n);
                Console.WriteLine("\nSquares of numbers:");
                foreach (var number in squaredNumbers)
                {
                    Console.Write(number+",");
                }
              Console.WriteLine("\n Lab NO :14'a'");
              Console.WriteLine(" Name : Sadhana Khadka");
              Console.WriteLine(" Roll No:20");
        }
        }

}

using System;
using System.Threading.Tasks;

namespace Lab_Report_SadhanaKhadka
{
    internal class AsyncronousProgrammingDemo
    {
        public static async Task Task1()
        {
            Console.WriteLine("Task 1 Starting...");
            await Task.Delay(5000); // Simulating asynchronous operation
            Console.WriteLine("Task 1 Completed.");
        }

        public static async Task Task2()
        {
            Console.WriteLine("Task 2 Starting...");
            await Task.Delay(4000); // Simulating asynchronous operation
            Console.WriteLine("Task 2 Completed.");
        }

        public static async Task Task3()
        {
            Console.WriteLine("Task 3 Starting...");
            await Task.Delay(1000); // Simulating asynchronous operation
            Console.WriteLine("Task 3 Completed.");
        }

        public static async Task Task4()
        {
            Console.WriteLine("Task 4 Starting...");
            await Task.Delay(3000); // Simulating asynchronous operation
            Console.WriteLine("Task 4 Completed.");
        }

        static async Task Main(string[] args)
        {
            await Task.WhenAll(Task1(), Task2(), Task3(), Task4());

            Console.WriteLine("\n Lab NO :17");
            Console.WriteLine(" Name : Sadhana khadka");
            Console.WriteLine(" Roll No:20");

            Console.ReadLine(); // to hold console window
        }
    }
}

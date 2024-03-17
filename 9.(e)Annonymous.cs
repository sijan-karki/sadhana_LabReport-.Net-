using System;

namespace Lab_Report_SadhanaKhadka
{
        internal class anonymos
        {
            static void Main(string[] args)
            {
                Func<int, int, int> obj1 = (a, b) => a + b;
                Console.WriteLine("The sum of Two number is:: " + obj1(93, 37));

                Func<int, double, int, double> obj2 = (a, b, c) => a + b + c;
                Console.WriteLine("The sum of three number is:: " + obj2(77, 23.83,63));

                Action<string> obj3 = x => Console.WriteLine("Namaste " + x); // Action delegate
                obj3("Sadhana Khadka");
                Console.WriteLine("\n Lab NO :9'e'");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");
            }
        }
}

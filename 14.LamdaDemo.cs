using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_Report_SadhanaKhadka
{
    public delegate void Greetingdelegate(string name);
        public delegate int MathOperation(int num1, int num2);
        internal class LemdaDemo
        {
            static void Main(string[] args)
            {
                LemdaDemo L1 = new LemdaDemo();
                Greetingdelegate hd = (name) =>
                {
                    Console.WriteLine("Hello Good Morning {0}", name);
                };
                MathOperation M1 = (num1, num2) => num1 * num2;
                hd("Sadhana Khadka");
                long c = M1(23, 78);
                Console.WriteLine("The multiply of 23 and 78 is {0}", c);
                Console.WriteLine("\n Lab NO :14'a'");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");

        }
        }
}

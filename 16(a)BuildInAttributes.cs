using System;

namespace Lab_Report_SadhanaKhadka
{
        public class Calculator
        {
            [Obsolete("Use Multiplynumber(List<int> numbers) method")]
            public static int Multiplynumber(int a, int b)
            {
                return a * b;
            }
            public static int Multiplynumber(List<int> numbers)
            {
                int result = 1;
                foreach (int number in numbers)
                {
                    result *= number;
                }
                return result;
            }
        }
        internal class BuildInAttribute
        {
            static void Main(string[] args)
            {
                int c = Calculator.Multiplynumber(31, 72);
                Console.WriteLine("The Multiplication of two number is :" + c);
                int b = Calculator.Multiplynumber(new List<int> { 1, 3, 4, 7 });
                Console.WriteLine("The Multiplication of numbers of list : " + b);
                Console.WriteLine("\n Lab NO :16'a'");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");
            }

        }
}

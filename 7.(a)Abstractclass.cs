using System;

namespace Lab_Report_SadhanaKhadka
{
        class AbstractClassDemo
        {
            public abstract class Calculator
            {
                public abstract void Sum(int a, int b);
                public abstract void diff(int a, int b);
                public void DisplayInfo()
                {
                    Console.WriteLine("This is the abstract base class Calculator");
                }
            }
            abstract class SimpleCalculator : Calculator
            {
                public override void Sum(int a, int b)
                {
                    Console.WriteLine("The sum of {0} and {1} = {2}", a, b, (a + b));
                }
            }
            class ScientificCalculator : Calculator
            {
                public override void Sum(int a, int b)
                {
                    Console.WriteLine("The sum of {0} and {1} = {2}", a, b, (a + b));
                }
                public override void diff(int a, int b)
                {
                    Console.WriteLine("The difference of {0} and {1} = {2}", a, b, (a - b));
                }
            }

            static void Main(string[] args)
            {
                Calculator calculator = new ScientificCalculator();
                calculator.Sum(167, 28);
                calculator.diff(34, 27);
                Console.WriteLine("\n Lab NO :7'a'");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");
        }

        }
    }

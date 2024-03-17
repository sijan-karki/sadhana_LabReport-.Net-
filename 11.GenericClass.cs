using System;
using System.Collections.Generic;
namespace Lab_Report_SadhanaKhadka
{
        class GenericClassDemo
        {

            class Calculator<T>
            {
                T value;

                public Calculator(T value)
                {
                    this.value = value;
                    Console.WriteLine("This is your value :: " + value);
                }

                public T AreaofRectangle<T1, T2>(T1 length, T2 breadth)
                {
                    dynamic a = length;
                    dynamic b = breadth;
                    return a * b;
                }
            }

            static void Main(string[] args)
            {
                Calculator<int> c1 = new Calculator<int>(12);
                int areaInt = c1.AreaofRectangle(6, 9);
                Console.WriteLine($"Area of rectangle (int):{areaInt}");
                Calculator<double> c2 = new Calculator<double>(7.9);
                double areaDouble = c2.AreaofRectangle(9.2, 8.9);
                Console.WriteLine($"Area of rectangle (double):{areaDouble}");
                Console.WriteLine("\n Lab NO :11");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");
        }
        }
}

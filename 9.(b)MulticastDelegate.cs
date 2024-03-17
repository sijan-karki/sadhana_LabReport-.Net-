﻿using System;

namespace Lab_Report_SadhanaKhadka
{
        public delegate void CalcDelegate(int a, int b);

        public class areaRectangle
        {
            public void Area(int length, int breadth)
            {
                Console.WriteLine("The area of rectangle is::" + (length * breadth));
            }
        }
        public class periRectangle
        {
            public void Perimeter(int length, int breadth)
            {
                Console.WriteLine("The perimeter of rectangle is::" + 2 * (length * breadth));
            }
        }
        internal class MulticastingDemo
        {
            static void Main(string[] args)
            {
                areaRectangle a1 = new areaRectangle();
                periRectangle p1 = new periRectangle();
                CalcDelegate c1 = new CalcDelegate(a1.Area);
                CalcDelegate c2 = p1.Perimeter;
                c1(7, 9);
                // Multicasting of delegate 
                CalcDelegate c3 = c1 + c2; // here in c3 both c1 and c2 delegate is cast
                c3(23, 45);// so it will show first area of rectange and than perimeter of rectangle
                Console.WriteLine("\n Lab NO :5");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");
        }
        }
}

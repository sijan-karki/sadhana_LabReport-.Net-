// Simple c# program to illustrate the concept of Funct delegate 

/* Func delegate is a generic delegate 
   * Func delegae is used for return type 
   * Action delegate is used for void type
  */
using System;

namespace Lab_Report_SadhanaKhadka
{ 
        class funcDelegate
        {
            public int sumofTwoNumber(int a, int b)
            {
                return a + b;
            }
            public double sumofThreeNumber(int a, double b, int c)
            {
                return a + b + c;
            }
            public void Greeting(string name)
            {
                Console.WriteLine("Namaste " + name);
            }

            static void Main(string[] args)
            {
                funcDelegate f1 = new funcDelegate();
                Func<int, double, int, double> obj2 = f1.sumofThreeNumber;
                Console.WriteLine("The sum of three number is:: " + obj2(12,7.89,21));
                Func<int, int, int> obj1 = f1.sumofTwoNumber;//Func delegate
                Console.WriteLine("The sum of Two number is:: " + obj1(56,36));
                Action<string> obj3 = f1.Greeting; // Action delegate
                obj3("Sadhana Khadka");
                Console.WriteLine("\n Lab NO :9'c,d'");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");
        }
        }
}

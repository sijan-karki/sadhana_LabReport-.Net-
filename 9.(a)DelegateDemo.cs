using System;

namespace Lab_Report_SadhanaKhadka
{
        public delegate void GreetingDelegat(string name);
        class DelegateDemo
        {
            public void Greeting(string name)
            {
                Console.WriteLine("Good Morning " + name);
            }

            static void Main(string[] args)
            {
                DelegateDemo d1 = new DelegateDemo();
                GreetingDelegat gd = new GreetingDelegat(d1.Greeting);
                gd("Sadhana");
                gd("Tamanna kC");
               Console.WriteLine("\n Lab NO :5");
               Console.WriteLine(" Name : Sadhana Khadka");
               Console.WriteLine(" Roll No:20");
        }
        }
    }

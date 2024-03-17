using System;
using System.Collections;

namespace Lab_Report_SadhanaKhadka
{
    internal class NonGenericCollection
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(9);
            al.Add('X');
            al.Add(9.1);
            al.Add("Sadhana");
            al.Add("Khadka");
            al.Add(true);

            Console.WriteLine("Capacity = {0}", al.Capacity);
            Console.WriteLine("Count = {0}", al.Count);
            Console.WriteLine("The elements in non-generic collection are ::");
            foreach (object i in al)
                Console.Write(i + ", ");

            Console.WriteLine("\nLab NO :10'a'");
            Console.WriteLine("Name : Sadhana Khadka");
            Console.WriteLine("Roll No:20");
        }
    }
}

using System;

namespace Lab_Report_SadhanaKhadka
{
    internal class VegetableEnumDemo
    {
        enum VegetableName
        {
            Potato=59,
            Tomato =333,
            Carrot,
            Spinach,
            Cabbage
        }

        static void Main(string[] args)
        {
            int a = (int)VegetableName.Potato;
            Console.WriteLine(VegetableName.Potato + " = " + a);
            Console.WriteLine(VegetableName.Tomato + " = " + (int)VegetableName.Tomato);
            Console.WriteLine(VegetableName.Carrot + " = " + (int)VegetableName.Carrot);

            Console.WriteLine("\n Lab NO :8'b'");
            Console.WriteLine(" Name : Sadhana Khadka");
            Console.WriteLine(" Roll No:20");
        }
    }
}

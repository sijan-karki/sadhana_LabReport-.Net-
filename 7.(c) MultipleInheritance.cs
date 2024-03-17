using System;

namespace Lab_Report_SadhanaKhadka
{
    interface IReader
    {
        void Read();
    }

    interface IWriter
    {
        void Write();
    }
    public class Bookworm : IReader, IWriter
    {
        public void Read()
        {
            Console.WriteLine("Reading books to gain knowledge.");
        }

        public void Write()
        {
            Console.WriteLine("Writing down thoughts and ideas.");
        }
    }

    internal class InterfaceExample
    {
        static void Main(string[] args)
        {
            Bookworm Laxmi = new Bookworm();
            Laxmi.Read();
            Laxmi.Write();
            Console.WriteLine("\n Lab NO :5");
            Console.WriteLine(" Name : Sadhana Khadka");
            Console.WriteLine(" Roll No:20");
        }
    }
}

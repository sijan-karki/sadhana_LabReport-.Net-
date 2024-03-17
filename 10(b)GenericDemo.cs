using System;
using System.Collections.Generic;
namespace Lab_Report_SadhanaKhadka
{
        class GenericCollectionDemo
        {
            static void Main(string[] args)
            {
                // Creating a generic List to store strings
                List<string> stringList = new List<string>();

                // Adding elements to the list
                stringList.Add("Apple");
                stringList.Add("Banana");
                stringList.Add("Orange");

                // Accessing elements in the list
                Console.WriteLine("Fruits in the List:");
                foreach (string fruit in stringList)
                {
                    Console.WriteLine(fruit);
                }

                // Modifying an element in the list
                stringList[1] = "Papaya";

                // Removing an element from the list
                stringList.Remove("Banana");

                // Displaying the modified list
                Console.WriteLine("\nModified List:");
                foreach (string fruit in stringList)
                {
                    Console.WriteLine(fruit);
                }
                Console.WriteLine("\n Lab NO: 10'b'");
                Console.WriteLine(" Name: Sadhana Khadka");
                Console.WriteLine(" Roll No: 20");
            }
    }
}

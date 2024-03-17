﻿using System;
namespace Lab_Report_SadhanaKhadka
{
        class Program
        {
            static void Main()
            {
                // Get input from the keyboard
                Console.Write("Enter text to write to the file: ");
                string inputText = Console.ReadLine();

                // Specify the file path (you can change the path as needed)
                string filePath = "D:\\TestFile.txt";

                // Write the input to the file
                WriteToFile(filePath, inputText);

                Console.WriteLine("Data has been written to the file successfully.");
                Console.WriteLine("\n Lab NO :12");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");
            }

            static void WriteToFile(string filePath, string content)
            {
                try
                {
                    // Use File.WriteAllText to write content to the file in one line
                    File.WriteAllText(filePath, content);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

            }
        }
}

using System;
using System.Collections.Generic;

namespace Lab_Report_SadhanaKhadka
{
        public class InvalidEmailException : Exception
        {
            public InvalidEmailException(string message) : base(message) { }
        }

        public class EmailValidator
        {
            public void ValidateEmail(string email)
            {
                if (!email.Contains("@") || !email.Contains("."))
                {
                    throw new InvalidEmailException("Invalid email address format.");
                }
                else
                {
                    Console.WriteLine("Email address '{0}' is valid.", email);
                }
            }
        }

        class TestProgram
        {
            static void Main(string[] args)
            {
                EmailValidator validator = new EmailValidator();
                try
                {
                    Console.WriteLine("Enter an email address: ");
                    string inputEmail = Console.ReadLine();
                    validator.ValidateEmail(inputEmail);
                }
                catch (InvalidEmailException ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Finally we are out of the exception handling block.");
                }
                Console.WriteLine("\n Lab NO :15'c");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");
        }
        }

}

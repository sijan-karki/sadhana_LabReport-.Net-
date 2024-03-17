using System;
namespace Lab_Report_SadhanaKhadka
{
        class StructDemo
        {
            struct Book
            {
                public string bookName;
                public string authorName;
                public Book(string bookName, string authorName)
                {
                    this.bookName = bookName;
                    this.authorName = authorName;
                }
                public void display()
                {
                    Console.WriteLine("The author of {0} is {1}", bookName, authorName);
                }

            }

            static void Main(string[] args)
            {
                Book b1 = new Book("DSA", "Ramesh singh Saud");
                Book b2 = new Book("Operating System", "Ken Thompson");
                b1.display();
                b2.display();
                Console.WriteLine("\n Lab NO :5");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");

        }
        }
}

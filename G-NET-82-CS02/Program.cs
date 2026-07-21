using System;

namespace Session1
{
    internal class Book
    {
        public required string Title { get; set; }
        public int Pages { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            //int pages = 464;
            //bool isAvailable = true;
            //if(pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}

            //==========================================================

            // Question 2

            //string title = "Refactoring";
            //switch(title)
            //{
            //    case "Clean code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}

            //==========================================================

            //Question 3

            //int pages = 464;
            //string sizeLabel = (pages > 300) ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);

            //==========================================================

            //Question 4

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for(int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.{books[i]}");
            //}

            //==========================================================

            //Question 5

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int index = 0;
            //while(index < books.Length)
            //{
            //    Console.WriteLine($"{index + 1}.{books[index]}");
            //    index++;
            //}

            //==========================================================

            //Question 6

            //int count = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    count++;
            //} while (count < 3);

            //==========================================================

            //Question 7

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach(string book in books)
            //{
            //    Console.WriteLine(book);
            //}

            //==========================================================

            //Question 8

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books)
            //{
            //    if(book == "Refactoring")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(book);
            //}

            //==========================================================

            //Question 9

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books)
            //{
            //    if(book == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(book);
            //}

            //==========================================================

            //Question 10

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            PrintFirstBook(books);
        }

        static void PrintFirstBook(string[] books)
        {
            if(books == null || books.Length == 0)
            {
                return;
            }
            Console.WriteLine(books[0]);
        }

    }

}

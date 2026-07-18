using System;

namespace Session1
{
    internal class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // RunBookAssignment();
            // RunCodeAssignment();
            // RunStringAssignment();
            // RunNullAssignment();

            Console.WriteLine("\nPress Any Key To Exit");
            Console.ReadKey();
        }


        //=============================================================


        //Question 1
        //static void RunBookAssignment()
        //{
        //    Book myBook = new Book { Title = "The Black Woman", Pages = 464 };
        //    object objBook = myBook;

        //    Console.WriteLine("\nPART 1");
        //    Console.WriteLine(objBook);
        //    Console.WriteLine();

        //    Console.WriteLine("\nPART 2");
        //    Console.WriteLine($"1. ToString(): {objBook.ToString()}");
        //    Console.WriteLine($"2. Equals(): {objBook.Equals(objBook)}"); 
        //    Console.WriteLine($"3. GetHashCode(): {objBook.GetHashCode()}");
        //    Console.WriteLine($"4. GetType(): {objBook.GetType()}");
        //}


        //===============================================================


        //Question 2
        //    static void RunCodeAssignment()
        //    {
        //        try
        //        {
        //            int num = 10;
        //            int result = num / 10;
        //        }
        //        catch(DivideByZeroException)
        //        {
        //            Console.WriteLine("Cannot divide by zero");
        //        }
        //        finally
        //        {
        //            Console.WriteLine("Done");
        //        }

        //        int pages = 300;
        //        double doublePages = pages;
        //        Console.WriteLine($"Int: {pages}, Double: {doublePages}");

        //        double price = 49.99;
        //        int intPrice = (int)price;
        //        Console.WriteLine($"Double: {price}, Int: {intPrice}");

        //        string text = "464";
        //        int number = Convert.ToInt32(text);
        //        Console.WriteLine($"String: {text}, Int: {number}");
        //    }


        //===============================================================


        //Question 3
        //static void RunStringAssignment()
        //{
        //    string testYear = "2023";
        //    int parsedYear = int.Parse(testYear);
        //    Console.WriteLine($"Parsed Year: {parsedYear}");

        //    string badText = "abc";
        //    if (int.TryParse(badText, out int resultYear))
        //    {
        //        Console.WriteLine($"Successfully parsed: {resultYear}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input");
        //    }

        //    int pages = 494;
        //    string stringPages = pages.ToString();
        //    Console.WriteLine($"Value: {stringPages}, Type: {stringPages.GetType()}");

        //    int copies = 100;
        //    object boxCopies = copies;
        //    int unboxCopies = (int)boxCopies;
        //    Console.WriteLine($"The Original: {boxCopies}, Unboxed: {unboxCopies}");

        //    int? year = null;
        //    Console.WriteLine($"Has Value: {year.HasValue}");
        //    year = 2023;
        //    Console.WriteLine($"Value after assignment: {year}");
        //}


        //===============================================================

        //Question 4
        //static void RunNullAssignment()
        //{
        //    string? reviewer = null;
        //    Console.WriteLine($"Is reviewer null: {reviewer == null}");

        //    Book? nullBook = null;
        //    string? bookTitle = nullBook?.Title;
        //    Console.WriteLine($"Safe Title Read: {bookTitle}");

        //    string? title = bookTitle;
        //    Console.WriteLine($"Title using ??: {title ?? "Untitled"}");
        //    title ??= "Untitled";
        //    Console.WriteLine($"Title after ??=: {title}");

        //    string? name = "Ahmed";
        //    string confirmedName = name!;
        //    Console.WriteLine($"Confirmed Name: {confirmedName}");
        //}
    }

}

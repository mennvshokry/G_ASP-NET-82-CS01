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
        //Question 3
        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine($"Welcome to the Library!");
        //}


        //==================================================


        //Question 4
        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine($"Book title: " + title);
        //}


        //==================================================


        //Question 5
        //static void AddBounsPages(int pages)
        //{
        //    pages += 50;
        //}


        //==================================================


        //Question 6
        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5;
        //}


        //==================================================


        //Question 7
        //static void AddBounsPagesRef(ref int pages)
        //{
        //    pages += 50;
        //}


        //==================================================


        //Question 8
        //static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] { 10.0, 12.5, 15.0 };
        //}


        //==================================================


        //Question 9
        //static bool TryGetPricse(string title, out double price)
        //{
        //    if(title == "Clean Code")
        //    {
        //        price = 25.5;
        //        return true;
        //    }
        //    price = 0;
        //    return false;
        //}


        //==================================================


        //Question 10
        //static void PrintBookInFo(string title, int pages = 300)
        //{
        //    Console.WriteLine($"Title: {title}, pages: {pages}");
        //}


        //==================================================


        //Question 11
        //static void PrintAllTitles(params string[] titles)
        //{
        //    foreach(string title in titles)
        //    {
        //        Console.WriteLine(title);
        //    }
        //}


        static void Main(string[] args)
        {
            //Question 1
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);


            //==================================================


            //Question 2
            //int[,] shelfCopies =
            //{
            //    { 3, 5 },
            //    { 1, 4 }
            //};
            //Console.WriteLine(shelfCopies[1,0]);


            //==================================================


            //Question 3
            //PrintWelcomeMessage();


            //==================================================


            //Question 4
            //PrintBookTitle("Clean Code");


            //==================================================


            //Question 5
            //int pages = 400;
            //AddBounsPages(pages);
            //Console.WriteLine(pages);


            //==================================================


            //Question 6
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);


            //==================================================


            //Question 7
            //int pages = 400;
            //AddBounsPagesRef(ref pages);
            //Console.WriteLine(pages);


            //==================================================


            //Question 8
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);


            //==================================================


            //Question 9
            //if (TryGetPricse("Clean Code", out double price))
            //{
            //    Console.WriteLine("Price: " + price);
            //}
            //else
            //{
            //    Console.WriteLine($"Book Not Found.");
            //}


            //==================================================


            //Question 10
            //PrintBookInFo($"Clean Code");
            //PrintBookInFo($"Clean Code", 450);


            //==================================================


            //Question 11
            //PrintAllTitles($"Clean Code.","programming of AI.", "Design of c#.");
        }


    }
}

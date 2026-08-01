using System;

namespace Session5
{
    //Question 4, 5, 6, 7, 8, 9
    //enum Genre
    //{
    //    Fiction,
    //    NonFiction,
    //    Science
    //}

    internal class Book
    {
        // Question 1
        //private string password = "secret";

        //=======================================================

        //Question 2
        //internal int copiesInStock = 5;

        //=======================================================

        //Question 3
        //public string Title;

        //=======================================================

        //Question 4
        //public Genre Genre { get; set; }

        //=======================================================


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            //Book myBook = new Book();
            //Console.WriteLine(myBook.password);
            /**
             هيحصل compilation error وال program مش هيشتغل علشان المتغير
            متعرف private واحنا عاوزين نطبع من class al main
                **/

            //=======================================================

            // Question 2
            //Book myBook = new Book();
            //Console.WriteLine(myBook.copiesInStock);
            /**
            هنا ال program هيشتغل معانا عادي جدا علشان ال internal
            معناها ان اي حاجه مكتوبه في ال program يقدر يشوف ال variable
            عادي ويستخدمه فالبتالل هيحلص compilation عادي جدا
            **/

            //=======================================================

            //Question 3
            //Book myBook = new Book();
            //myBook.Title = "Backend Programming";
            //Console.WriteLine(myBook.Title);

            //=======================================================

            //Question 4
            //Book myBook = new Book();
            //myBook.Genre = Genre.Science;
            //Console.WriteLine(myBook.Genre);

            //=======================================================

            //Question 5
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);

            //=======================================================

            //Question 6
            //int genreNumber = 1;
            //Genre genreValue = (Genre)genreNumber;
            //Console.WriteLine(genreValue);

            //=======================================================

            //Question 7
            //Genre genre = Genre.Fiction;
            //string genreString = genre.ToString();
            //Console.WriteLine(genreString);

            //=======================================================

            //Question 8
            //string genreText = "Science";
            //Genre genreValue = (Genre)Enum.Parse(typeof(Genre),
            //    genreText);
            //Console.WriteLine(genreValue);

            //=======================================================

            //Question 9
            //string genreText = "Mystery";
            //if(Enum.TryParse(genreText, out Genre result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Unkown genre!");
            //}
        }
    }
}

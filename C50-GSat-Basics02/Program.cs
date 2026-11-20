// Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it

using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Assignment01
{
    class Book
    {
        public string Title { get; set; } = "";
        public int Pages { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book { Title = "X", Pages = 100 };

            #region
            //Console.WriteLine("Q01");
            // {
            //   object obj = book;
            // Console.WriteLine(obj);
            //}
            #endregion

            #region 2
            // Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book

            //  Console.WriteLine("Q02");
            // {
            //    Console.WriteLine(book.ToString());
            ///    Console.WriteLine(book.Equals(book));
            //    Console.WriteLine(book.GetHashCode());
            //     Console.WriteLine(book.GetType());
            //  }
            #endregion

            #region 3

            // Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.int pages = "464";

            //  Console.WriteLine("Q03");
            // {
            // int pages = "464";   // compile-time error
            //    int pages = 464;                  // We canot assgin a string value to integer value

            // }
            #endregion

            #region 4

            // Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.

            // Console.WriteLine(" Q04 ");
            //{
            //   int zero = 0;
            //   try
            //   {
            //        int result = 10 / zero;
            //        Console.WriteLine(result);
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Console.WriteLine("Cannot divide by zero");
            //     }
            //     finally
            //     {
            //         Console.WriteLine("Done");

            //      }
            //  }
            #endregion

            #region 5

            //Declare an int pages = 300; then store it in a double variable without using a cast
            //   Console.WriteLine(" Q05 ");
            //   {
            //      int pages = 300;
            //     double pagesDouble = pages;
            //     Console.WriteLine(pagesDouble);
            // }
            #endregion

            #region 6
            //Declare a double price = 49.99; then convert it into an int using a cast.
            //  Console.WriteLine(" Q06 ");
            //  {
            //      double price = 49.99;
            //      int priceInt = (int)price;
            //      Console.WriteLine(priceInt);
            //  }
            #endregion

            #region 7

            // Given string pagesText = "464";, convert it into an int using the Convert class

            // Console.WriteLine(" Q07 ");
            // {
            //    string pagesText = "464";
            //    int pages = Convert.ToInt32(pagesText);
            //     Console.WriteLine(pages);
            // }
            #endregion

            #region 8
            // Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            // Console.WriteLine(" Q08 ");
            // {
            //   string yearText = "2023";
            //  int year = int.Parse(yearText);
            //  Console.WriteLine(year);

            //  string badText = "abc";
            //  int number;
            // if (int.TryParse(badText, out number))
            //     Console.WriteLine(number);
            //  else
            //     Console.WriteLine("Invalid number");
            // }
            #endregion

            #region 9
            // Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string
            // Console.WriteLine(" Q09 ");
            // {
            //    int pages = 464;
            //    string pagesText = pages.ToString();
            //     Console.WriteLine(pagesText.GetType());
            // }
            #endregion
            #region 10

            // Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            Console.WriteLine(" Q10 ");
            {
                int copies = 100;
                object boxed = copies;
                int unboxed = (int)boxed;
                Console.WriteLine(boxed);
                Console.WriteLine(unboxed);
            }
            #endregion

        }

    }
}

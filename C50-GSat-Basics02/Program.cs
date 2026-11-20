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

            Console.WriteLine("Q02");
            {
                Console.WriteLine(book.ToString());
                Console.WriteLine(book.Equals(book));
                Console.WriteLine(book.GetHashCode());
                Console.WriteLine(book.GetType());
            }
            #endregion

            #region 3

            // Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.int pages = "464";

            Console.WriteLine("Q03");
            {
                // int pages = "464";   // compile-time error
                int pages = 464;                  // We canot assgin a string value to integer value

            }
            #endregion
        }

    }
}

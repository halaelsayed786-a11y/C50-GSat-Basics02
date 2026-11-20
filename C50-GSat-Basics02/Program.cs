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
            Console.WriteLine("Q01");
             {
                object obj = book;
               Console.WriteLine(obj);
            }
            #endregion

        }

    }
}

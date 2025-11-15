using Simple_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    /// <summary>
    /// Helps to represent how the books are stored.
    /// </summary>
    public static class Library
    {
        public static List<Book> _library = new List<Book>();
        public static List<Borrower> _database = new List<Borrower>();

        /// <summary>
        /// Controlled getting of the library property of the Library
        /// </summary>
        /// <returns></returns>
        public static List<Book> GetLibrary () { return _library; }

        // <summary>
        /// Controlled getting of the database property of the Library
        /// </summary>
        /// <returns></returns>
        public static List<Borrower> GetUserDatabase() { return _database; }





        /// <summary>
        /// Shows all books in the library (Lists<Book> _library).
        /// </summary>
        public static void DisplayLibrary()
        {
            List<Book> selection = Library.GetLibrary();

            Console.WriteLine("Here is our selection of books:");
            for (int i = 0; i < selection.Count; i++)
            {
                Console.Write($"{i + 1}.\n" +
                              $"Name: {selection[i].GetName()}\n" +
                              $"Genre: {selection[i].GetGenre()}\n" +
                              $"Author: {selection[i].GetAuthor()}\n" +
                              $"Status: ");

                if (selection[i].GetBorrowedStatus() == false)
                    Console.Write("Available\n\n");
                else
                    Console.Write("Borrowed\n\n");
            }
        }





        /// <summary>
        /// Shows the works of the author.
        /// </summary>
        /// <param name="value"></param>
        public static void DisplayBooksByAuthor(string author)
        {
            Console.WriteLine($"Here are {author}'s works!");
            foreach (Book book in _library)
            {
                Console.WriteLine(book.GetAuthor() == author);
            }
        }





        /// <summary>
        /// Searches for a particular book or author. Put 'N' in the type argument to search for a name. Put 'A' in the type argument to search for an author.
        /// </summary>
        /// <param name="search"></param>
        public static string Search(string search, char type)
        {
            string value = "";
            bool found = false;

            foreach (Book book in _library)
            {
                if (type == 'N')
                {
                    value = book.GetName();

                    if (value.ToLower() == search.ToLower())
                    {
                        Console.WriteLine($"The book \"{value}\" was found");
                        found = true;
                    }

                    if (found == false)
                        Console.WriteLine($"The book \"{search}\" was not found");

                    break;
                }
                else if (type == 'A')
                {
                    value = book.GetAuthor();

                }
            }

            return value;
        }
    }
}

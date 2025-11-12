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

        public static List<Book> GetLibrary () { return _library; }

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
        /// Searches for a book by its name.
        /// </summary>
        /// <param name="search"></param>
        public static void SearchName(string search)
        {
            bool found = false;

            foreach (Book book in _library)
            {
                string name = book.GetName();
                if (name.ToLower() == search.ToLower())
                {
                    Console.WriteLine($"The book \"{name}\" was found");
                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine($"The book \"{search}\" was not found");
            }
        }
    }
}

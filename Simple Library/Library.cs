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
        /// Shows all books in the library (Lists<Book> _library).
        /// </summary>
        public static void DisplayLibrary()
        {
            List<Book> selection = Library._library;

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
        private static void DisplayBooksByAuthor(string author)
        {
            Console.WriteLine($"Here are {author}'s works!");
            foreach (Book book in _library)
                Console.WriteLine(book.GetName());
        }





        /// <summary>
        /// Searches for a particular book or author. Put 'N' in the type argument to search for a name. Put 'A' in the type argument to search for an author.
        /// </summary>
        /// <param name="search"></param>
        public static void Search(string search, char type)
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
                        break;
                    }
                }
                else if (type == 'A')
                {
                    value = book.GetAuthor();
                    if (value.ToLower() == search.ToLower())
                    {
                        found = true;
                        DisplayBooksByAuthor(value);
                        break;
                    }
                    break;
                }
            }

            if (found == false && type == 'N')
                Console.WriteLine($"The book \"{search}\" was not found");
            else if (found == false && type == 'A')
                Console.WriteLine($"The author \"{search}\" was not found");
        }
    }
}

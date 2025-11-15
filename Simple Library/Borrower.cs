using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Library
{
    /// <summary>
    /// Helps to represent information of a person that can borrow a book.
    /// </summary>
    public class Borrower
    {
        private string _name = "";
        private string _password = "";
        private bool _loginStatus = false;

        private int _borrowLimit = 1;

        public List<Book> _borrowedBooks = new List<Book>();





        /// <summary>
        /// Controlled getting of the log in status property of Borrower.
        /// </summary>
        /// <returns></returns>
        public bool GetLogInStatus() { return _loginStatus; }

        /// <summary>
        /// Controlled setting of the log in status property of Borrower.
        /// </summary>
        /// <returns></returns>
        public void SetLogInStatus(bool value) { _loginStatus = value; }

        /// <summary>
        /// Controlled getting of the name property of Borrower.
        /// </summary>
        /// <returns></returns>
        public string GetName() { return _name; }

        /// <summary>
        /// Controlled setting of the name property of Borrower.
        /// </summary>
        /// <returns></returns>
        public void SetName(string value) { _name = value; }

        /// <summary>
        /// Controlled getting of the password property of Borrower.
        /// </summary>
        /// <returns></returns>
        public string GetPassword() { return _password; }

        /// <summary>
        /// Controlled setting of the password property of Borrower.
        /// </summary>
        /// <returns></returns>
        public void SetPassword(string value) { _password = value; }





        /// <summary>
        /// Represent borrowers with non-null properties.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public Borrower (string name, string password)
        {
            _name = name;
            _password = password;
        }

        /// <summary>
        /// Used to create an empty borrower.
        /// </summary>
        public Borrower()
        {
            _name = "";
            _password = "";
        }





        /// <summary>
        /// Borrow a book from the library.
        /// </summary>
        /// <param name="book"></param>
        public void Borrow (string borrow)
        {
            bool found = false;

            if (_borrowedBooks.Count < 1)
            {
                foreach (Book book in Library._library)
                {
                    if (borrow == book.GetName().ToLower() && book.GetBorrowedStatus() == false && _borrowedBooks.Count < 1)
                    {
                        book.SetBorrowedStatus(true);
                        _borrowedBooks.Add(book);
                        Console.WriteLine($"You borrowed {book.GetName()}!");
                        found = true;
                        break;
                    }

                    else if (borrow == book.GetName().ToLower() && !(book.GetBorrowedStatus() == false))
                    {
                        found = true;
                        Console.WriteLine("This book is already being borrowed by someone else");
                        break;
                    }
                }

                if (found == false)
                    Console.WriteLine($"The book you're trying to borrow doesn't exist.");
            }
            else
                Console.WriteLine("You can't borrow anymore");

        }





        /// <summary>
        /// Shows the books you borrowed.
        /// </summary>
        public void DisplayBorrowedBooks()
        {
            Console.WriteLine("Here are your borrowed books");
            foreach (Book book in _borrowedBooks)
                Console.WriteLine(book.GetName());
        }
    }
}

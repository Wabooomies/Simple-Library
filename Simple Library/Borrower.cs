using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Library
{
    /// <summary>
    /// Helps to represent information of a person that can borrow a book.
    /// </summary>
    public class Borrower
    {
        private string _name;
        private string _password;
        private bool _loginStatus = false;

        private int _borrowLimit = 1;

        public static List<Book> _borrowedBooks;

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
        /// Contorlled setting of the name property of Borrower.
        /// </summary>
        /// <returns></returns>
        public void SetName(string value) { _name = value; }

        /// <summary>
        /// Contorlled getting of the password property of Borrower.
        /// </summary>
        /// <returns></returns>
        public string GetPassword() { return _password; }

        /// <summary>
        /// Contorlled setting of the password property of Borrower.
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

            foreach (Book book in Library.GetLibrary())
            {
                if (borrow.ToLower() == book.GetName().ToLower() && book.GetBorrowedStatus() == false && _borrowedBooks.Count < _borrowLimit)
                {
                    book.SetBorrowedStatus(true);
                    _borrowedBooks.Add(book);
                    found = true;
                    break;
                }
                else if (borrow.ToLower() == book.GetName().ToLower() && !(_borrowedBooks.Count < _borrowLimit))
                {
                    Console.WriteLine($"You have borrowed too many books.");
                    found = true;
                }
                else if (borrow.ToLower() == book.GetName().ToLower() && !(book.GetBorrowedStatus() == false))
                {
                    Console.WriteLine($"Book has been borrowed.");
                    found = true;
                }
            }

            if (found == false)
                Console.WriteLine($"The book you're trying to borrow doesn't exist.");
        }
    }
}

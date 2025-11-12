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

        public List<Book> _borrowedBooks;

        /// <summary>
        /// Represent borrowers.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public Borrower (string name)
        {
            _name = name;
        }

        /// <summary>
        /// Borrow a book from the library.
        /// </summary>
        /// <param name="book"></param>
        public void Borrow (Book book)
        {
            if (book.GetBorrowedStatus() == false && _borrowedBooks.Count < 1)
            {
                book.SetBorrowedStatus(true);
                this._borrowedBooks.Add(book);
            }
        }
    }
}

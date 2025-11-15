using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Library
{
    /// <summary>
    /// Helps to represent basic information of a book.
    /// </summary>
    public class Book
    {
        private string _name;
        private string _genre;
        private string _author;

        private bool _borrowedStatus;

        /// <summary>
        /// Create books.
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="bookGenre"></param>
        /// <param name="bookAuthorName"></param>
        public Book(string name, string genre, string author)
        {
            _name = name;
            _genre = genre;
            _author = author;
            _borrowedStatus = false;
        }

        /// <summary>
        /// Controlled getting of the name property of the book.
        /// </summary>
        /// <returns></returns>
        public string GetName() { return _name; }

        /// <summary>
        /// Controlled getting of the genre property of the book.
        /// </summary>
        /// <returns></returns>
        public string GetGenre() { return _genre; }

        /// <summary>
        /// Controlled getting of the author property of the book.
        /// </summary>
        /// <returns></returns>
        public string GetAuthor() { return _author; }

        /// <summary>
        /// Controlled getting of the borrowed status property of the book.
        /// </summary>
        /// <returns></returns>
        public bool GetBorrowedStatus() { return _borrowedStatus; }

        /// <summary>
        /// Controlled editing of the borrowed status property of the book.
        /// </summary>
        /// <param name="value"></param>
        public void SetBorrowedStatus(bool value) { _borrowedStatus = value;  }
    }
}

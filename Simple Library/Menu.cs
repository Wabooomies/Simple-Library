using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Library
{
    /// <summary>
    /// Allows for users to login and interact with the library.
    /// </summary>
    internal static class Menu
    {
        /// <summary>
        /// The login process to the library.
        /// </summary>
        public static void LogIn ()
        {
            Borrower loggedUser = new Borrower();

            while (true)
            {
                Console.Clear();
                Console.Write("Username: ");

                string userName = Console.ReadLine();

                Console.Write("\nPassword: ");

                string userPassword = Console.ReadLine();

                foreach (Borrower user in Library._database)
                {
                    if (user.GetName().ToLower() == userName.ToLower() && user.GetPassword() == userPassword)
                    {
                        user.SetLogInStatus(true);
                        loggedUser = user;
                        break;
                    }
                }

                if (!(loggedUser.GetLogInStatus() == true))
                {
                    Console.WriteLine("Invalid Credentials");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You logged in!");
                    Console.ReadKey();
                    MainMenu(loggedUser);
                }
            }
        }

        /// <summary>
        /// Shows the main menu for the user to interact with the library and their profile.
        /// </summary>
        /// <param name="borrower"></param>
        private static void MainMenu(Borrower borrower)
        {
            while (borrower.GetLogInStatus() == true)
            {
                Console.Clear();
                Console.WriteLine($"What do you want to do?\n" +
                                  $"1. Search for a book\n" +
                                  $"2. Search for an author\n" +
                                  $"3. Show all books\n" +
                                  $"4. Borrow a book\n" +
                                  $"5. Check borrowed books\n" +
                                  $"6. Change username\n" +
                                  $"7. Change password\n" +
                                  $"8. Log Out");

                Console.Write($"Choice: ");

                Choices(Console.ReadLine(), borrower);

                Console.ReadKey();
            }
        }

        /// <summary>
        /// The choices the library offers.
        /// </summary>
        /// <param name="choice"></param>
        /// <param name="borrower"></param>
        private static void Choices(string choice, Borrower borrower)
        {
            switch (choice)
            {
                case "1":
                    Console.Write($"Which book do you want to find?");

                    Library.Search(Console.ReadLine(), 'N');
                    break;

                case "2":
                    Console.Write($"Which author do you want to find?");

                    Library.Search(Console.ReadLine(), 'A');
                    break;

                case "3":

                    Library.DisplayLibrary();
                    break;

                case "4":
                    Console.Write($"Which book do you want to borrow?");

                    borrower.Borrow(Console.ReadLine());
                    break;

                case "5":

                    borrower.DisplayBorrowedBooks();
                    break;

                case "6":
                    Console.Write($"New Username: ");

                    borrower.SetName(Console.ReadLine());
                    Console.WriteLine($"Successfully changed it to {borrower.GetName()}");
                    break;

                case "7":
                    Console.Write($"New Password: ");

                    borrower.SetPassword(Console.ReadLine());
                    Console.WriteLine($"Successfully changed it to {borrower.GetPassword()}");
                    break;

                case "8":

                    borrower.SetLogInStatus(false);
                    Console.WriteLine($"You have logged out!");
                    break;

                default:

                    Console.WriteLine($"Choose a valid choice");
                    break;
            }
        }
    }
}

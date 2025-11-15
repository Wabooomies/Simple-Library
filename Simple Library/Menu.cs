using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Library
{
    internal static class Menu
    {
        /// <summary>
        /// The login process to the library.
        /// </summary>
        public static void LogIn ()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Username: ");

                string userName = Console.ReadLine();

                Console.Write("\nPassword: ");

                string userPassword = Console.ReadLine();

                Borrower loggedUser = new Borrower();

                foreach (Borrower user in Library.GetUserDatabase())
                {
                    if (user.GetName().ToLower() == userName.ToLower() && user.GetPassword() == userPassword)
                    {
                        user.SetLogInStatus(true);
                        loggedUser = user;
                        break;
                    }
                    else if (user.GetName().ToLower() != userName.ToLower())
                        Console.WriteLine($"Username not found in the database");
                    else if (user.GetName().ToLower() == userName.ToLower() && user.GetPassword() != userPassword)
                        Console.WriteLine($"Wrong password for {userName}");
                    Console.ReadKey();
                }

                MainMenu(loggedUser);
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
                                  $"5. Change password\n" +
                                  $"6. Change name\n" +
                                  $"7. Log Out");

                Console.Write($"Choice: ");

                Choices(Console.ReadLine(), borrower);

                Console.ReadKey();
            }
        }

        /// <summary>
        /// Performs a task chosen by the user from the main menu.
        /// </summary>
        /// <param name="choice"></param>
        private static void Choices(string choice, Borrower user)
        {
            switch (choice)
            {
                case "1": Console.Write($"Which book do you want to find?");

                    Library.Search(Console.ReadLine(), 'N');
                    break;

                case "2": Console.Write($"Which author do you want to find?");

                    Library.DisplayBooksByAuthor(Library.Search(Console.ReadLine(), 'A'));
                    break;

                case "3":

                    Library.DisplayLibrary();
                    break;

                case "4": Console.Write($"Which book do you want to borrow?");

                    user.Borrow(Console.ReadLine());
                    break;

                case "5": Console.Write($"New Username: ");

                    user.SetName(Console.ReadLine());
                    Console.WriteLine($"Successfully changed it to {user.GetName()}");
                    break;

                case "6": Console.Write($"New Password: ");

                    user.SetPassword(Console.ReadLine());
                    Console.WriteLine($"Successfully changed it to {user.GetPassword()}");
                    break;

                case "7":

                    user.SetLogInStatus(false);
                    Console.WriteLine($"You have logged out!");
                    break;

                default:

                    Console.WriteLine($"Choose a valid choice");
                    break;
            }
        }
    }
}

using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library._library.Add(new Book("Diary of a Wimpy Luis", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Julius Rules", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: The Last Line", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Banana Days", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: The Ugly Code", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Fourth Else-If", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Hard LOL Match", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: The Long Lag", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Old Cringe", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Double Right Shift", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: The Great Escape", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: The Break Down", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: The PC is Breakable", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: The Big Clown Down", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: The Missing Coat", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Finding The Coat", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Found the Coat", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Truth Table", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Maid to Impress", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: To Let", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Hours in the Bathroom", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Lost Never Found", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Hons", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Clashing", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Against Royalty", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Dirty Tissue", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Losing Lane", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Pantheon Things", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Valorant Champion", "Diary", "Luis"));
            Library._library.Add(new Book("Lord of the Luis", "Anthology", "Li Leander Mendoza Abella"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Job Application", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Putting in (No) Time", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Love at First Sight", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Staring at each other", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Pregnancy", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Abortion", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Second Incident", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Second Abortion", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: All Over the Wall", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Yellow Pad", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Missing Ballpen", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Missing Bag", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Where Did My Coat Go", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Losing Money", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Lollipop", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Julius Returns", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Call Me For A Magical Time: (0926) 087 2757", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: 323 Aguirre Ave, Parañaque, Metro Manila", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Fernando Jalandoni Cawa", "Diary", "Luis"));
            Library._library.Add(new Book("Diary of a Wimpy Luis: Final Days", "Diary", "Luis"));

            Library._database.Add(new Borrower("George", "1"));
            Library._database.Add(new Borrower("Wally", "2"));
            Library._database.Add(new Borrower("Rey", "3"));
            Library._database.Add(new Borrower("Monarch", "4"));
            Library._database.Add(new Borrower("Alice", "5"));

            Menu.LogIn();
        }
    }
}

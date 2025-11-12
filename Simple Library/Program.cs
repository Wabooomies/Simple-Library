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
            List<Book> books = Library.GetLibrary();
            books.Add(new Book("Diary of a Wimpy Luis", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Julius Rules", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: The Last Line", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Banana Days", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: The Ugly Code", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Fourth Else-If", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Hard LOL Match", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: The Long Lag", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Old Cringe", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Double Right Shift", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: The Great Escape", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: The Break Down", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: The PC is Breakable", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: The Big Clown Down", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: The Missing Coat", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Finding The Coat", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Found the Coat", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Truth Table", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Maid to Impress", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: To Let", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Hours in the Bathroom", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Lost Never Found", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Hons", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Clashing", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Against Royalty", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Dirty Tissue", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Losing Lane", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Pantheon Things", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Valorant Champion", "Diary", "Luis"));// address ni luis : 
            books.Add(new Book("Lord of the Luis", "Anthology", "Li Leander Mendoza Abella"));
            books.Add(new Book("Diary of a Wimpy Luis: Job Application", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Putting in (No) Time", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Love at First Sight", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Staring at each other", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Pregnancy", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Abortion", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Second Incident", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Second Abortion", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: All Over the Wall", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Yellow Pad", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Missing Ballpen", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Missing Bag", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Where Did My Coat Go", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Losing Money", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Lollipop", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Julius Returns", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Call Me For A Magical Time: (0926) 087 2757", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: 323 Aguirre Ave, Parañaque, Metro Manila", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Fernando Jalandoni Cawa", "Diary", "Luis"));
            books.Add(new Book("Diary of a Wimpy Luis: Final Days", "Diary", "Luis"));

            Menu.SearchName("Diary of a wimpy luisss");
        }
    }
}

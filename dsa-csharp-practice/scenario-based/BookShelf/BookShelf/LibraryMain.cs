using System;

namespace BookShelf
{
    internal class LibraryMain
    {
        static void Main(string[] args)
        {
            LibraryMenu menu = new LibraryMenu();
            menu.Start();
        }
    }
}

using System;
using System.Collections.Generic;

namespace BrowserBuddy
{
    internal class BrowserBuddyMenu
    {
        private BrowserBuddy browser;

        public BrowserBuddyMenu()
        {
            browser = new BrowserBuddy();
        }

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== BrowserBuddy Menu =====");
                Console.WriteLine("1. Visit New Site");
                Console.WriteLine("2. Back");
                Console.WriteLine("3. Forward");
                Console.WriteLine("4. Show Current Page");
                Console.WriteLine("5. Close Tab");
                Console.WriteLine("6. Restore Closed Tab");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter website URL: ");
                        string url = Console.ReadLine();
                        browser.CurrentTab.Visit(url);
                        break;

                    case 2:
                        browser.CurrentTab.Back();
                        break;

                    case 3:
                        browser.CurrentTab.Forward();
                        break;

                    case 4:
                        Console.WriteLine("Current Page: " +
                            browser.CurrentTab.CurrentPage());

                        break;

                    case 5:
                        browser.CloseTab(); 
                        break;

                    case 6:
                        browser.RestoreTab();
                        break;

                    case 0:
                        Console.WriteLine("Exiting BrowserBuddy...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 0);
        }
    }
}

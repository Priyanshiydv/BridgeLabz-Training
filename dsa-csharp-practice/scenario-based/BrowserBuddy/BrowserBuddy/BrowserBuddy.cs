using System;
using System.Collections.Generic;

namespace BrowserBuddy
{
    internal class BrowserBuddy
    {
        public Tab CurrentTab { get; private set; }
        private Stack<Tab> closedTabs;

        public BrowserBuddy()
        {
            CurrentTab = new Tab();
            closedTabs = new Stack<Tab>();
        }

        //close tab
        public void CloseTab()
        {
            closedTabs.Push(CurrentTab);
            CurrentTab = new Tab();
            Console.WriteLine("Tab closed.");
        }

        //restore tab
        public void RestoreTab()
        {
            if (closedTabs.Count > 0)
            {
                CurrentTab = closedTabs.Pop();
                Console.WriteLine("Tab restored. Current page: " +
                                  CurrentTab.CurrentPage());
            }
            else
            {
                Console.WriteLine("No tabs to restore.");
            }
        }
    }
}



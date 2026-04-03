using System;
using System.Collections;
using System.Collections.Generic;

namespace BrowserBuddy
{
    internal class Tab
    {
        private PageNode head;
        private PageNode current;

        // Visit a new page
        public void Visit(string url)
        {
            PageNode newPage = new PageNode(url);

            if (head == null)
            {
                head = newPage;
                current = newPage;
            }
            else
            {
                current.Next = newPage;
                newPage.Prev = current;
                current = newPage;
            }

            Console.WriteLine("Visited: " + url);
        }

        // Go Back
        public void Back()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Back to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No previous page.");
            }
        }

        // Go Forward
        public void Forward()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Forward to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No next page.");
            }
        }

        //current page
        public string CurrentPage()
        {
            return current != null ? current.Url : "No page";
        }
    }
}
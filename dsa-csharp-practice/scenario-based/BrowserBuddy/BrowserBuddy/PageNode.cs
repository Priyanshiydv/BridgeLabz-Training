using System;
using System.Collections.Generic;

namespace BrowserBuddy
{
    internal class PageNode
    {
        public string Url;
        public PageNode Prev;
        public PageNode Next;

        public PageNode(string url)
        {
            Url = url;
            Prev = null;
            Next = null;
        }
    }
}

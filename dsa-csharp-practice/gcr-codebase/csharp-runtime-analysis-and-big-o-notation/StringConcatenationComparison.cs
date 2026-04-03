using System;
using System.Text;

class StringConcatenationComparison
{
    static void Main()
    {
        int n = 10000;

        // Using string (O(N^2))
		// very slow creates new object every time
        string str = "";
        for (int i = 0; i < n; i++)
        {
            str += i;
        }
        Console.WriteLine("String concatenation done");

        //  Using StringBuilder (O(N))
		//not thread-safe
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append(i);
        }
        Console.WriteLine("StringBuilder concatenation done");

        //  Thread-safe StringBuilder (like StringBuffer)
		// safe for multi threading uses locks
        StringBuilder safeSb = new StringBuilder();
        object lockObj = new object();

        for (int i = 0; i < n; i++)
        {
            lock (lockObj)
            {
                safeSb.Append(i);
            }
        }
        Console.WriteLine("Thread-safe StringBuilder concatenation done");
    }
}

using System;
using System.Collections.Generic;

class BankingSystem
{
    static void Main()
    {
        Dictionary<int, double> accounts = new Dictionary<int, double>();
        accounts.Add(101, 5000);
        accounts.Add(102, 3000);
        accounts.Add(103, 7000);

        Queue<int> withdrawalQueue = new Queue<int>();
        withdrawalQueue.Enqueue(101);
        withdrawalQueue.Enqueue(103);

        while (withdrawalQueue.Count > 0)
        {
            int accNo = withdrawalQueue.Dequeue();

            if (accounts[accNo] >= 1000)
            {
                accounts[accNo] = accounts[accNo] - 1000;
                Console.WriteLine("Withdrawal successful for Account " + accNo);
            }
            else
            {
                Console.WriteLine("Insufficient balance for Account " + accNo);
            }
        }

        int[] accKeys = new int[accounts.Count];
        accounts.Keys.CopyTo(accKeys, 0);

        Console.WriteLine("Final Balances:");
        for (int i = 0; i < accKeys.Length; i++)
        {
            Console.WriteLine(accKeys[i] + " : " + accounts[accKeys[i]]);
        }
    }
}

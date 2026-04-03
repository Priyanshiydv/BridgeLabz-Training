using System;
using System.Collections.Generic;

class ReverseQueue
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Reverse(queue);

        Console.Write("Reversed Queue: ");
        while (queue.Count > 0)
        {
            Console.Write(queue.Dequeue() + " ");
        }
    }

    static void Reverse(Queue<int> queue)
    {
        if (queue.Count == 0)
            return;

        int value = queue.Dequeue();
        Reverse(queue);
        queue.Enqueue(value);
    }
}

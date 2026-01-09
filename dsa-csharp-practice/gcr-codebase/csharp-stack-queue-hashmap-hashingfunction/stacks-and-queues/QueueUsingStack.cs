using System;
using System.Collections.Generic;

class QueueUsingStacks
{
    // Stack used for enqueue operation
    private Stack<int> stackEnqueue = new Stack<int>();

    // Stack used for dequeue operation
    private Stack<int> stackDequeue = new Stack<int>();

    // Add element to queue
    public void Enqueue(int value)
    {
        stackEnqueue.Push(value);
        Console.WriteLine(value + " added to queue");
    }

    // Remove element from queue
    public void Dequeue()
    {
        // If both stacks are empty, queue is empty
        if (stackEnqueue.Count == 0 && stackDequeue.Count == 0)
        {
            Console.WriteLine("Queue is empty. Cannot dequeue.");
            return;
        }

        // If dequeue stack is empty, move elements
        if (stackDequeue.Count == 0)
        {
            while (stackEnqueue.Count > 0)
            {
                stackDequeue.Push(stackEnqueue.Pop());
            }
        }

        int removedValue = stackDequeue.Pop();
        Console.WriteLine(removedValue + " removed from queue");
    }

    // Display front element
    public void Peek()
    {
        if (stackEnqueue.Count == 0 && stackDequeue.Count == 0)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        if (stackDequeue.Count == 0)
        {
            while (stackEnqueue.Count > 0)
            {
                stackDequeue.Push(stackEnqueue.Pop());
            }
        }

        Console.WriteLine("Front element is: " + stackDequeue.Peek());
    }
}

class Program
{
    static void Main()
    {
        QueueUsingStacks queue = new QueueUsingStacks();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        queue.Peek();
        queue.Dequeue();
        queue.Peek();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue(); // underflow case
    }
}

using System;
using System.Collections.Generic;

class SortStack
{
    // Function to sort the stack
    static void Sort(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int temp = stack.Pop();   // Remove top
            Sort(stack);              // Sort remaining stack
            InsertSorted(stack, temp);
        }
    }

    // Insert element at correct position
    static void InsertSorted(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || value > stack.Peek())
        {
            stack.Push(value);
            return;
        }

        int temp = stack.Pop();
        InsertSorted(stack, value);
        stack.Push(temp);
    }

    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(30);
        stack.Push(10);
        stack.Push(20);

        Sort(stack);

        Console.WriteLine("Sorted Stack:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}

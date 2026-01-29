// Insert an element at the bottom of the stack using recursion

using System;
using System.Collections.Generic; 

class Insertion
{
    //recursive method for inserting element
    static void InsertAtBottom(Stack<int> stack, int item)
    {
        
        if (stack.Count == 0)
        {
            stack.Push(item);   //for add item
            return;             
        }

        int top = stack.Pop();  //for removing item

        InsertAtBottom(stack, item); // recursive call for bottom

        stack.Push(top);     //add back removed element
    }

    //method for display
    static void Display(Stack<int> stack)
    {
        Stack<int> tempStack = new Stack<int>(); //temporary data

        Console.WriteLine("Stack elements (Top to Bottom):");

        // Loop runs until stack becomes empty
        while (stack.Count > 0)
        {
            int value = stack.Pop();  //remove element from original stack
            Console.WriteLine(value); //print element
            tempStack.Push(value);    //store in temporary
        }

        //restore
        while (tempStack.Count > 0)
        {
            stack.Push(tempStack.Pop());
        }
    }
    static void Main()
    {
        Stack<int> stack = new Stack<int>(); 

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine()); 

        Console.WriteLine("Enter elements of stack:");
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine()); 
            stack.Push(num); 
        }

        Console.Write("Enter element to insert at bottom: ");
        int item = int.Parse(Console.ReadLine()); 

        InsertAtBottom(stack, item); //calling fuction

        Console.WriteLine("\nAfter inserting at bottom:");
        Display(stack); 
    }
}


    

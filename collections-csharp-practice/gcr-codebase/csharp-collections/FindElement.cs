using System;
using System.Collections.Generic;

class FindElement{
    static void Main(){
        LinkedList<string> list = new LinkedList<string>();
        list.AddLast("A"); list.AddLast("B"); list.AddLast("C"); list.AddLast("D"); list.AddLast("E");
        int N = 2;
        LinkedListNode<string> fast = list.First;
        LinkedListNode<string> slow = list.First;
        for(int i=0;i<N;i++) fast = fast.Next; // move fast N nodes ahead
        while(fast.Next != null){
            fast = fast.Next;
            slow = slow.Next;
        }
        Console.WriteLine("Nth from end: " + slow.Value);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

class ReverseList {
    static void Main() {
        // ArrayList
        ArrayList arrList = new ArrayList() {1,2,3,4,5};
        for (int i = arrList.Count - 1; i >= 0; i--)
            Console.Write(arrList[i] + " ");
        Console.WriteLine();

        // LinkedList
        LinkedList<int> linked = new LinkedList<int>();
        linked.AddLast(1); linked.AddLast(2); linked.AddLast(3); linked.AddLast(4); linked.AddLast(5);
        LinkedListNode<int> node = linked.Last;
        while (node != null) {
            Console.Write(node.Value + " ");
            node = node.Previous;
        }
    }
}

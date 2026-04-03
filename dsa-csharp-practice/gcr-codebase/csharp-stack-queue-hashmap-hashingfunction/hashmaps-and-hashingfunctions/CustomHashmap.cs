using System;
using System.Collections.Generic;

class MyHashMap
{
    private const int SIZE = 10;
    private LinkedList<KeyValuePair<int, int>>[] table;

    public MyHashMap()
    {
        table = new LinkedList<KeyValuePair<int, int>>[SIZE];
    }

    private int Hash(int key)
    {
        return key % SIZE;
    }

    public void Put(int key, int value)
    {
        int index = Hash(key);

        if (table[index] == null)
            table[index] = new LinkedList<KeyValuePair<int, int>>();

        table[index].AddLast(new KeyValuePair<int, int>(key, value));
    }

    public int Get(int key)
    {
        int index = Hash(key);

        if (table[index] != null)
        {
            foreach (var pair in table[index])
            {
                if (pair.Key == key)
                    return pair.Value;
            }
        }

        return -1;
    }
}

class Program
{
    static void Main()
    {
        MyHashMap map = new MyHashMap();
        map.Put(1, 100);
        map.Put(11, 200); // collision

        Console.WriteLine(map.Get(1));
        Console.WriteLine(map.Get(11));
    }
}

using System;
using System.Collections.Generic;

class FindFrequency {
    static void Main() {
        string[] arr = {"apple", "banana", "apple", "orange"};
        Dictionary<string, int> freq = new Dictionary<string, int>();
        for(int i=0; i<arr.Length; i++){
            if(freq.ContainsKey(arr[i])) freq[arr[i]]++;
            else freq[arr[i]] = 1;
        }
        foreach(var kv in freq)
            Console.WriteLine(kv.Key + ": " + kv.Value);
    }
}

using System;
using System.Collections.Generic;

class RotateElements {
    static void Main(){
        List<int> list = new List<int>(){10,20,30,40,50};
        int rotate = 2;
        List<int> result = new List<int>();
        for(int i=rotate; i<list.Count; i++) result.Add(list[i]);
        for(int i=0; i<rotate; i++) result.Add(list[i]);
        for(int i=0; i<result.Count; i++) Console.Write(result[i]+" ");
    }
}

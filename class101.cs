using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S, int[] C) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        List<int> resultList = new List<int>();
        //List<string> sList = new List<string>();
        for (int i=0; i<S.Length-1; i++)
        {
            string prevString = S.Substring(i, 1);
            string nextString = S.Substring(i+1, 1);
            //Console.Write(string.Format("{0}, {1} \n", prevString, nextString));

            if (prevString.Equals(nextString)) 
            {
                var addValue = (C[i] < C[i+1]) ? C[i] : C[i+1];

                //Console.Write(string.Format("{0} \n", addValue));
                resultList.Add(addValue);
            }
        }

        

        int result = resultList.Sum();

        return result;

    }
}

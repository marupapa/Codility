using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class BinaryGap {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        string binary = Convert.ToString(N, 2);

        int gapCnt = 0;
        int topCnt = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            var item = binary.Substring(i, 1);

            if (item.Equals("1"))
            {
                if (topCnt < gapCnt) 
                {
                    topCnt = gapCnt;
                }
                gapCnt = 0;
            }
            else 
            {
                gapCnt ++;
            }
        }
        
        return topCnt;
    }
}

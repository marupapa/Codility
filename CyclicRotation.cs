using System;
// using System.Collections.Generic;
// using System.Linq;

class CyclicRotation 
{ 
    public int[] solution(int[] A, int K)
    {
        if (A == null || A.Length == 0) return A;
        int arrLength = A.Length;

        for (int i = 0; i < K; i++)
        {
            int[] changedArr = new int[arrLength]; // changed array
            var changeArrayValue = A[arrLength - 1]; // Last value array 
            changedArr[0] = changeArrayValue; // last Arr value change to first array
            for (int y = 0; y < arrLength - 1; y++) changedArr[y + 1] = A[y];

            A = changedArr;
        }
     
        return A;
    }
}


// Unhandled Exception:
// System.IndexOutOfRangeException: Array index is out of range.
//   at Solution.solution (System.Int32[] A, Int32 K) [0x00000] in <filename unknown>:0 
//   at SolutionWrapper.run (System.String input, System.String output) [0x00000] in <filename unknown>:0 
//   at SolutionWrapper.Main (System.String[] args) [0x00000] in <filename unknown>:0 
// [ERROR] FATAL UNHANDLED EXCEPTION: System.IndexOutOfRangeException: Array index is out of range.
//   at Solution.solution (System.Int32[] A, Int32 K) [0x00000] in <filename unknown>:0 
//   at SolutionWrapper.run (System.String input, System.String output) [0x00000] in <filename unknown>:0 
//   at SolutionWrapper.Main (System.String[] args) [0x00000] in <filename unknown>:0 
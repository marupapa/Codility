using System;

class OddOccurrencesInArray
{
    public int solution(int[] A) 
    {

        //Console.Write(string.Format("A:{0}  \n", string.Join(",", A)));
        int arrLen = A.Length;
        if (A == null || A.Length == 0) return 0;

        // [9, 3, 9, 3, 9, 7, 9]

        int result = 0;
        for(int i=0; i<arrLen; i++)
        {
            int count = 0;
            
            for(int y=0; y<arrLen; y++)
            {
                if(A[i] == A[y]) count++;
                //Console.Write(string.Format("x:{0}, y:{1} \n", A[i], A[y]));
            }
            //Console.Write(string.Format("A:{0}, count:{1} \n", A[i], count));
            //Console.Write(">>>>>>>>>>>>>>\n");

            if (count == 1) result = A[i];
        }

        return result;
    }
}
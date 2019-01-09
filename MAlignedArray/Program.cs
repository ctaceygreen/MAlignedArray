using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public static void Main(string[] args)
    {
        solution(new int[] { -3, -2, 1, 0, 8, 7, 1 }, 3);
    }

    public static int mod(int x, int m)
    {
        //Fix for % as C# doesn't do a proper modulus, it does the remainder. For negative numbers this is not the modulus we need, so this is a fix.
        return (x % m + m) % m;
    }

    public static int solution(int[] A, int M)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        //Mathematically, this can be done by creating a freq array of each element % M
        //The largest M aligned subset is then the greatest freq within this freq array

        int[] freqArray = new int[M]; //Length M as only M possible values to % M

        for(int aIndex = 0; aIndex < A.Length; aIndex++)
        {
            int aModM = mod(A[aIndex], M);
            freqArray[aModM]++;
        }

        //Now find the greatest freq within this array
        int greatestFreq = 0;
        for(int freqIndex = 0; freqIndex < M; freqIndex++)
        {
            int freq = freqArray[freqIndex];
            if(freq > greatestFreq)
            {
                greatestFreq = freq;
            }
        }
        return greatestFreq;
    }
}
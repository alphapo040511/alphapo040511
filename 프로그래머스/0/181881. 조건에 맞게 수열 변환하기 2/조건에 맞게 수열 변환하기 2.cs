using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int solution(int[] arr)
    {
        int min = 0;

        while (true)
        {
            int[] temp = new int[arr.Length];
            Array.Copy(arr, 0, temp, 0, arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 50 && arr[i] % 2 == 0)
                    arr[i] = arr[i] / 2;
                else if (arr[i] < 50 && arr[i] % 2 == 1)
                    arr[i] = (arr[i] * 2) + 1;
            }

            if (temp.SequenceEqual(arr))
                break;

            min++;
        }
        return min;
    }
}
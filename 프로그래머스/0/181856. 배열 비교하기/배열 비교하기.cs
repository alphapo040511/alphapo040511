using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        if(arr1.Length == arr2.Length)
        {
            int Array1 = SumArray(arr1);
            int Array2 = SumArray(arr2);
            if(Array1 == Array2)
            {
                return 0;
            }
            else
            {
                return Array1 > Array2 ? 1 : -1;
            }
        }
        else
        {
            return arr1.Length > arr2.Length ? 1 : -1;
        }
    }
    
    int SumArray(int[] arr)
    {
        int n = 0;
        foreach(int i in arr)
        {
            n += i;
        }
        return n;
    }
}
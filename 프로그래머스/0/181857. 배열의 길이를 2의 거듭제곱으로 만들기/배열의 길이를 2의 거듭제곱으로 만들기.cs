using System;

public class Solution {
    public int[] solution(int[] arr) {
        int temp = (int)Math.Pow(2,arrPow(arr.Length));
        int[] answer = new int[temp];
        Array.Copy(arr, answer, arr.Length);
        return answer;
    }
    
    int arrPow(int i)
    {
        int Count = 0;
        while(true)
        {
            if(i <= Math.Pow(2,Count))
            {
                return Count;
            }
            Count++;
        }
    }
}
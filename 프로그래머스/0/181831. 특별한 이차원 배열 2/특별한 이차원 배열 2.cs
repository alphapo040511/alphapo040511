using System;

public class Solution {
    public int solution(int[,] arr) {
        int answer = 1;
        int arrLength = arr.GetLength(0);
        for(int i = 0; i < arrLength; i++)
        {
            if(arr[i, arrLength - 1 - i] != arr[arrLength - 1 - i, i])
            {
                answer = 0;
            }

        }
        return answer;
    }
}
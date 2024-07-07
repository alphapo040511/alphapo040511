using System;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        int[] answer = new int[] {};
        for(int i = 0; i < intervals.GetLength(0); i ++)
        {
            for(int j = intervals[i,0]; j <= intervals[i,1]; j++)
            {
                Array.Resize(ref answer, answer.Length + 1);
                answer[answer.Length - 1] = arr[j];
            }
        }
        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[arr.Length];
        answer = arr;
        int temp1 = 0;
        int temp2 = 0;
        
        for(int i = 0; i < queries.GetLength(0); i ++)
        {
            temp1 = answer[queries[i,0]];
            temp2 = answer[queries[i,1]];
            
            answer[queries[i,0]] = temp2;
            answer[queries[i,1]] = temp1;
        }
        
        return answer;
    }
}
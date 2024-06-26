using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        int answer_int = -1;
        for(int i = 0; i < queries.GetLength(0); i ++)
        {
            for(int j = queries[i,0]; j <= queries[i,1]; j++)
            {
                if(arr[j] > queries[i,2] && arr[j] < answer_int ||
                   arr[j] > queries[i,2] && answer_int == -1)
                {
                    answer_int = arr[j];
                }
                
            }
            
            answer[i] = answer_int;
            answer_int = -1;
        }
        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = arr;
        for(int n = 0; n < queries.GetLength(0); n++)
        {
for(int i = 0; i < arr.Length; i++)
{
    if(i >= queries[n,0] && i <= queries[n,1])
        answer[i]++;
}
}
        return answer;
    }
}
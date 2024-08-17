using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = arr;
        int k = 0;
        if(answer.Length % 2 == 0)
        {
            k = 1;
        }
        for(int i = k; i < answer.Length; i += 2)
        {
            answer[i] += n;
        }
        return answer;
    }
}
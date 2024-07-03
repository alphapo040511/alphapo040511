using System;

public class Solution {
    public int[] solution(int n, int k) {
        int[] answer = new int[] {};
        for(int i = 1; i * k <= n; i++)
        {
            Array.Resize(ref answer, answer.Length +1);
            answer[answer.Length - 1] = i*k;    
        }
        return answer;
    }
}
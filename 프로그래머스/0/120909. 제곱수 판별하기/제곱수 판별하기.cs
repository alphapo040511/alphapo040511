using System;

public class Solution {
    public int solution(int n) {
        int answer = 2;
        if(Math.Sqrt(n) % 1 == 0)
        {
            answer = 1;
        }
        return answer;
    }
}
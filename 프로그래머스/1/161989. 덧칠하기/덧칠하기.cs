using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int lastNum = -m;
        for(int i = 0; i < section.Length; i++)
        {
            if(section[i] >= lastNum + m)
            {
                answer++;
                lastNum = section[i];
            }
        }
        return answer;
    }
}
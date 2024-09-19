using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int minSize = 0;
        int maxSize = 0;
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            int min = Math.Min(sizes[i,0], sizes[i,1]);
            int max = Math.Max(sizes[i,0], sizes[i,1]);
            
            minSize = minSize < min ? min : minSize;
            maxSize = maxSize < max ? max : maxSize;
        }
        answer = minSize * maxSize;
        return answer;
    }
}
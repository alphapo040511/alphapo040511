using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        char x = ' ';
        bool isFirst = true;
        int xCount = 0;
        int otherCount = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(isFirst)
            {
                x = s[i];
                isFirst = false;
            }
            
            if(s[i] == x)
            {
                xCount++;
            }
            else
            {
                otherCount++;
            }
            
            if(xCount == otherCount || i == s.Length - 1)
            {
                answer++;
                xCount = 0;
                otherCount = 0;
                isFirst = true;
            }
        }
        return answer;
    }
}
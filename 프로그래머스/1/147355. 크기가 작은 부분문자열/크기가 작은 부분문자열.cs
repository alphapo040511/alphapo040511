using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        int tLen = t.Length;
        int pLen = p.Length;
        for(int i = 0; i < tLen - pLen + 1; i++)
        {
            if(t[i] - p[0] <= 0)
            {
                for(int j = 0; j < p.Length; j++)
                {
                    if(t[i + j] - p[j] < 0)
                    {
                        answer++;
                        break;
                    }
                    else if(t[i + j] - p[j] > 0)
                    {
                        break;
                    }
                    
                    if(j == p.Length - 1)
                    {
                        answer++;
                        break;
                    }
                }             
            }
        }
        return answer;
    }
}
using System;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int answer = 0;
        int a = -1;
        int b = -1;
        int c = -1;
        int Count = 1;
        while(c < 0)
        for(int i = 0; i < rank.Length; i++)
        {
            if(rank[i] == Count)
            {
                Count++;
                if(attendance[i])
                {
                    if(a < 0)
                    {
                        a = i;
                    }
                    else if(b < 0)
                    {
                        b = i;
                    }
                    else if(c < 0)
                    {
                        c = i;
                    }
                    break;
                }
            }
        }
        
        answer = 10000 * a + 100 * b + c;
        
        return answer;
    }
}
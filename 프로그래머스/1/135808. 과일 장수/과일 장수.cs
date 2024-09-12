using System;
using System.Collections.Generic;

public class Solution {
    public Dictionary<int, int> applesCount = new Dictionary<int, int> {};
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        int NowMaxValue = k;
        applesCount = new Dictionary<int, int> {};
        
        foreach(int i in score)
        {
            AddApple(i);
        }
        
        for(int i = 1; i <= score.Length; i++)
        {
            if(i % m == 0)
            {
                answer += NowMaxValue * m;
            }
            NowMaxValue = CheckAppleCount(NowMaxValue);
        }
        
        return answer;
    }
    
    void AddApple(int i)
    {
        if(applesCount.ContainsKey(i))
        {
            applesCount[i] += 1;
        }
        else
        {
            applesCount.Add(i, 1);
        }
    }
    
    int CheckAppleCount(int value)
    {
        int i = value;
        applesCount[i] -= 1;
        if(applesCount[i] <= 0)
        {
            while(true)
            {
                i--;
                if(applesCount.ContainsKey(i))
                {
                    return i;
                }
                else if(i <= 0)
                {
                    return 0;
                }
            }
        }
        
        return i;
    }
}
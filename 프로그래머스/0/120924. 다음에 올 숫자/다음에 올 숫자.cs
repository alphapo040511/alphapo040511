using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;
        if(CheckArithmetic(common))
        {
            answer = common[common.Length - 1] + (common[1] - common[0]);
        }
        else
        {
            answer = common[common.Length - 1] * (common[1] / common[0]);
        }
        
        return answer;
    }
    
    bool CheckArithmetic(int[] common)
    {
        if(common[1] - common[0] == common[2] - common[1])
        {
            return true;
        }
        
        return false;
    }
}
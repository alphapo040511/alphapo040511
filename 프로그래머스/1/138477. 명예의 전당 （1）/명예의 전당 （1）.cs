using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int scoreLength = score.Length;
        int[] answer = new int[scoreLength];
        List<int> highScore = new List<int> {};
        for(int i = 0; i < scoreLength; i++)
        {
            if(inRank(highScore, k, score[i]))
            {
                int temp = CheckRank(highScore, score[i]);
                highScore.Insert(temp, score[i]);
                if(highScore.Count > k)
                {
                    highScore.RemoveAt(0);
                }
            }
            answer[i] = highScore[0];
        }
        return answer;
    }
    
    bool inRank(List<int> highScore, int k, int nowNum)
    {
        if(highScore.Count == 0) return true;

        else if(nowNum > highScore[0] || highScore.Count < k)
        {
            return true;
        }
        
        return false;
    }
    
    int CheckRank(List<int> highScore, int nowNum)
    {
        for(int i = highScore.Count - 1; i >= 0; i--)
        {
            if(nowNum >= highScore[i])
            {
                return i + 1;
            }
        }
        return 0;
    }
}
using System;

public class Solution {
    public string[] solution(string[] picture, int k) {
        string[] answer = new string[picture.Length * k];
        for(int i = 0; i < picture.Length; i++)
        {
            for(int m = 0; m < picture[i].Length; m++)
            for(int j = 0; j < k; j++)
            { 
                for(int n = 0; n < k; n++)
                {
answer[i*k + j] += picture[i][m];
}
            }
        }
        return answer;
    }
}
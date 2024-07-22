using System;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = strArr;
        for(int i = 0; i < answer.Length; i++)
        {
             if(i % 2 != 0)
             {
                answer[i] = answer[i].ToUpper();
             }
            else
            {
                answer[i] = answer[i].ToLower();
            }
        }
        return answer;
    }
}
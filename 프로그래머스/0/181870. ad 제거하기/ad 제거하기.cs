using System;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = new string[] {};
        foreach(string str in strArr)
        {
            if(!str.Contains("ad"))
            {
                Array.Resize(ref answer, answer.Length + 1);
                answer[answer.Length - 1] = str;
            }
        }
        return answer;
    }
}
using System;

public class Solution {
    public string solution(string myString, string pat) {
        string answer = "";
        int temp = myString.LastIndexOf(pat,myString.Length - 1);
        
        if(temp == -1)
        {
            return answer;
        }
        
        answer = myString.Substring(0,temp + pat.Length);
        
        return answer;
    }
}
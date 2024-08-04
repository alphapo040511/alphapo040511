using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        string newPat = pat.Replace("A","b");
        newPat = newPat.Replace("B","a");
        
        if(myString.Contains(newPat.ToUpper()))
            answer = 1;
        
        return answer;
    }
}
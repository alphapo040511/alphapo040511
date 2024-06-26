using System;

public class Solution {
    public string solution(int[] numLog) {
        string answer = "";
        int Beint = 0;
        int Nowint = 0;
        foreach(int i in numLog)
        {
            Nowint = i - Beint;
            
            if(Nowint == 1)
                answer += "w";
            if(Nowint == -1)
                answer += "s";
            if(Nowint == 10)
                answer += "d";
            if(Nowint == -10)
                answer += "a";
            
            Beint = i;
        }
        return answer;
    }
}
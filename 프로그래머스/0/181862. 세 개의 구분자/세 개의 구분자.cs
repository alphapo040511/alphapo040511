using System;

public class Solution {
    public string[] solution(string myStr) {
        string temp = myStr.Replace('a', ' ');
        temp = temp.Replace('b', ' ');
        temp = temp.Replace('c', ' ');
            
            
        string[] answer = temp.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        if(answer.Length == 0) return new string[1] {"EMPTY"};
        return answer;
    }
}
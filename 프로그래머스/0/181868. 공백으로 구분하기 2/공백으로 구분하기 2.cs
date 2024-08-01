using System;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[] {};
        string[] temp = my_string.Split(' ');
        foreach(string str in temp)
        {
            if(str != "")
            {
Array.Resize(ref answer, answer.Length + 1);
                answer[answer.Length-1] = str;
}
        }
        return answer;
        
    }
}
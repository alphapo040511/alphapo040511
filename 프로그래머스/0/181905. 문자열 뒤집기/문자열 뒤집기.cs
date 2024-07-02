using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = "";
        char[] strings = my_string.ToCharArray();
        Array.Reverse(strings,s,e-s+1);
        foreach(char c in strings)
        {
            answer += c;
        }
        return answer;
    }
}
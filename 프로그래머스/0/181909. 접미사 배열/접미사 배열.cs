using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[] {};
        answer = new string[my_string.Length];
        for(int i = 0; i < my_string.Length; i++)
        {
            answer[i] = my_string.Substring(my_string.Length - 1 - i);
        }
        Array.Sort(answer);
        return answer;
    }
}
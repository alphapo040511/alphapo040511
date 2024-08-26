using System;

public class Solution {
    public string solution(string n_str) {
        string answer = "";
        for(int i = 0; i < n_str.Length; i++)
        {
            if(n_str[i] != '0')
            {
                for(int j = i; j < n_str.Length; j++)
                {
                    answer += n_str[j];
                }
                return answer;
            }
        }
        return answer;
    }
}
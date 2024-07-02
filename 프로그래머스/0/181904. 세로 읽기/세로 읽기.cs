using System;

public class Solution {
    public string solution(string my_string, int m, int c) {
        string answer = "";
        int count = my_string.Length / m;
            for(int i = 0; i < count; i++)
            {
                answer +=my_string[m*i + c -1];
            }
        return answer;
    }
}
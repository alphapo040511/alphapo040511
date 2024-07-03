using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[52];
        char[] strings = my_string.ToCharArray();
        foreach(char c in strings)
        {
            if(char.IsUpper(c))
                answer[c - 'A']++;
            else
                answer[c - 'a' + 26]++;
        }
        return answer;
    }
}
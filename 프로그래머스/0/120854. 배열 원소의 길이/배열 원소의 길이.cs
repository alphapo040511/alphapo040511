using System;

public class Solution {
    public int[] solution(string[] strlist) {
        int strlistLen = strlist.Length;
        int[] answer = new int[strlistLen];
        for(int i = 0; i < strlistLen; i++)
        {
            answer[i] = strlist[i].Length;
        }
        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(string myString) {
        string[] temp = myString.Split("x");
        int[] answer = new int[temp.Length];
        for(int i = 0; i < temp.Length; i++)
        {
            answer[i] = temp[i].Length;
        }
        return answer;
    }
}
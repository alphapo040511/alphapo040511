using System;

public class Solution {
    public string[] solution(string[] names) {
        string[] answer = new string[(int)(Math.Ceiling(names.Length /5.0f))];
        for(int i = 0; i < answer. Length; i++)
        {
answer[i] = names[i * 5];
}
        return answer;
    }
}
using System;

public class Solution {
    public int solution(string number) {
        int answer = 0;
        int temp = 0;
        
        for(int i = 0; i < number.Length; i ++)
        {
            temp += number[i] - '0';
        }
        answer = temp % 9;
        return answer;
    }
        
}
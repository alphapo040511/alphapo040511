using System;

public class Solution {
    public int solution(string[] order) {
        int answer = 0;
        for(int i = 0; i < order.Length; i++)
        {
            if(order[i].IndexOf("latte") != -1)
            {
                answer += 5000;
            }
            else
            {
                answer += 4500;
            }
            
        }
        return answer;
    }
}
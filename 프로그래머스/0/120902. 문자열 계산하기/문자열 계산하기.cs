using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        
        string[] datas = my_string.Split(" ");
        answer += Int32.Parse(datas[0]);
        
        for(int i = 0; i < datas.Length / 2; i++)
        {
            int b = Int32.Parse(datas[2 * i + 2]);
            if(datas[2 * i + 1] == "+")
            {
                answer += b;
            }
            else
            {
                answer -= b;
            }
        }
        return answer;
    }
}
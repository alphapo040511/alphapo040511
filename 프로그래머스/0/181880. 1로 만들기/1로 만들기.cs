using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        for(int i = 0; i < num_list.Length; i++)
        {
            int n = num_list[i];
            while(true)
            {
                if(n == 1)
                {
                    break;
                }
                
                if(n % 2 == 0)
                {
                    n = n / 2;
                    answer++;
                }
                else
                {
                    n = (n - 1) / 2;
                    answer++;
                }
            }
        }
        return answer;
    }
}
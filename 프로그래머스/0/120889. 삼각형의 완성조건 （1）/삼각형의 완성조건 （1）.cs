using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        int sum = 0;
        int large = 0;
        for(int i = 0; i < sides.Length; i++)
        {
            if(sides[i] > large)
            {
                large = sides[i];
            }
            sum += sides[i];
        }
        sum -= large;
        if(large < sum)
        {
            answer = 1;
        }
        else
        {
            answer = 2;
        }
        
        return answer;
    }
}
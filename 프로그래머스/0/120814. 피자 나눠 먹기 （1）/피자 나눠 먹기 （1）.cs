using System;

public class Solution {
    public int solution(int n) {
        if(n <= 7)
        {
            return 1;
        }
        else
        {
            for(int i = 0; ; i++)
            {
                if(i * 7 >= n)
                {
                   return i; 
                }
            }
        }
    }
}
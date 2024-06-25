using System;

public class Solution {
    public int solution(int a, int b, int c) {
        int answer = 0;
        int sameCount = 0;
        sameCount += check(a,b);
        sameCount += check(b,c);
        sameCount += check(c,a);
        
        answer = a + b + c;

        
        if(sameCount >= 1)
        {
            answer *= a*a + b*b + c*c;
        }
        
        if(sameCount >= 3)
        {
            answer *= a*a*a + b*b*b + c*c*c;
        }
        return answer;
    }
    
    int check(int A, int B)
    {
        if(A == B)
            return 1;
        else
            return 0;
    }
}
using System;

public class Solution {
    public string solution(string a, string b) {
        string answer = "";
        bool LastOverTen = false;
        
        for(int i = 0; i < (a.Length >= b.Length ? a.Length : b.Length); i++)
        {
            int one = 0;
            int A = 0;
            int B = 0;
            if(a.Length - 1 - i >= 0)
            {
                A = a[a.Length - 1 - i] - '0';
            }
            
            if(b.Length - 1 - i >= 0)
            {
                B = b[b.Length - 1 - i] - '0';
            }
            
            if(LastOverTen)
            {
                A += 1;
                LastOverTen = false;
            }
            
            if(A+B >= 10)
            {
                one = (A+B) % 10;
                LastOverTen = true;
            }
            else
            {
                one = A + B;
            }
            
            answer = one.ToString() + answer;
        }
        
        if(LastOverTen)
        {
            answer = '1' + answer;
        }
        
        return answer;
    }
}
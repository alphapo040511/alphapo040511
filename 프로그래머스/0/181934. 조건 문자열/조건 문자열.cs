using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        int answer = 0;
        
        if(n > m && ineq == ">")
            return 1;
        else if(n < m && ineq == "<")
            return 1;
        else if(n == m && eq == "=")
            return 1;
        else
            return 0;
        
        return answer;
    }
}
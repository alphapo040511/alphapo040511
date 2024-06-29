using System;

public class Solution {
    public bool solution(bool x1, bool x2, bool x3, bool x4) {
        bool answer = false;
        bool temp1 = false;
        bool temp2 = false;
        
        if(x1 || x2) temp1 = true;
        if(x3 || x4) temp2 = true;
        if(temp1 && temp2) answer = true;
        
        
        return answer;
    }
}
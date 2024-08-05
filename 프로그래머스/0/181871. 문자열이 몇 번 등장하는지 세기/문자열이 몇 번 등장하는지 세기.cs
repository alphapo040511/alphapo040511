using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        int startIndex = -1;
        while(true)
        {
            startIndex = myString.IndexOf(pat,startIndex + 1);
            
            if(startIndex == -1)
            {
return answer;
            }
            else
            {
answer++;
}

            
}
        return answer;
    }
}
using System;

public class Solution {
    public int solution(string binomial) {
        int answer = 0;
        string[] strArray= binomial.Split(' ');
        int a = Int32.Parse(strArray[0]);
        int b = Int32.Parse(strArray[2]);
        
        if(strArray[1] == "+")
        {
answer = a+b;
}
        if(strArray[1] == "*")
        {
answer = a*b;
}
        if(strArray[1] == "-")
        {
answer = a-b;
}
        
        return answer;
    }
}
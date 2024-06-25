using System;

public class Solution {
    public string solution(string code) {
        string answer = "";
        bool mode = false; //false = 0
        
        for(int i = 0; i < code.Length; i++)
        {
            if(code[i] == '1')
            {
                mode = mode ? false : true;
            }
            else{
                if(!mode && i % 2 == 0)
                {
                    answer += code[i];
                }
                else if(mode && i % 2 != 0)
                {
                    answer += code[i];
                }
            }
        }
        
        if(answer == "")
        {
            answer = "EMPTY";
        }
        
        return answer;
    }
}
using System;

public class Solution {
    public string solution(string my_string, int[,] queries) {
        string beAnswer = my_string;
        string answer = "";
        int s = 0;
        int e = 0;
        for(int n = 0; n < queries.GetLength(0); n ++)
        {
            s = queries[n,0];
            e = queries[n,1];
            answer = "";
            for(int i = 0; i < beAnswer.Length; i++)
            {
                
                if(i < s || e < i)
                {
                    answer += beAnswer[i];
                }
                else
                {
                    answer += beAnswer[e - i + s];
                }
                
            }
            beAnswer = answer;
        }
        

        return answer;
    }
}
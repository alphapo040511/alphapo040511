using System;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        int[] answer = new int[0] {};
        int temp = 0;


        for(int i = 0; i < intStrs.Length; i++)
        {
        temp = Int32.Parse(intStrs[i].Substring(s,l));
        if(temp > k)
        {
        Array.Resize(ref answer, answer.Length + 1);    
answer[answer.Length - 1] = temp;
        }
        }
        
        
        return answer;
    }
}
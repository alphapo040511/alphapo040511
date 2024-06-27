using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[1] {n};
        int nowNum = n;
        
        while(nowNum != 1)
        {
            if(nowNum % 2 == 0)
                nowNum = nowNum / 2;
            else
                nowNum = 3 * nowNum + 1;
            
            Array.Resize(ref answer, answer.Length +1);
            answer[answer.Length - 1] = nowNum;
        }
        
        return answer;
    }
}
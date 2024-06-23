using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int L = num_list.Length;
        int lastNum = num_list[L - 1];
        int scondeNum = num_list[L - 2];
        int[] answer = new int[L + 1];
        for(int i = 0; i < L; i ++)
        {
            answer[i] = num_list[i];            
        }
        
        answer[L] = lastNum > scondeNum ? lastNum - scondeNum : lastNum * 2;
        
        return answer;
    }
}
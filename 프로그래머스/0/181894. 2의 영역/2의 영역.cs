using System;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        int temp = 0;
        int start_index = -1;
        int end_index = -1;
        for(int i = 0; i < arr.Length; i++)
        {
            if(start_index == -1 && arr[i] == 2)
                start_index = i;
            
            if(arr[i] == 2)
                end_index = i;
        }
        
        if(start_index == -1)
        {
            answer = new int[1] {-1};
            return answer;
        }
            
        answer = new int[end_index - start_index + 1];
        for(int j = start_index; j <= end_index; j++)
        {
            answer[temp++] = arr[j];
        }
        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        int[] answer = new int[] {};
        int a = slicer[0];
        int b = slicer[1];
        int c = slicer[2];
        int start_num = 0;
        int end_num = 0;
        int distance = 1;
        switch(n)
        {
            case 1:
                end_num = b;
                break;
                
            case 2:
                start_num = a;
                end_num = num_list.Length - 1;
                break;
                
            case 3:
                start_num = a;
                end_num = b;
                break;
                
            case 4:
                start_num = a;
                end_num = b;
                distance = c;
                break;
                
        }
        
        for(int i = start_num; i <= end_num;)
        {
            Array.Resize(ref answer, answer.Length + 1);
                answer[answer.Length - 1] = num_list[i];
            
            
            i += distance;
        }
        
        
        return answer;
    }
}
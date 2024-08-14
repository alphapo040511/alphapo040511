using System;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int[] answer = new int[k];
        for(int n = 0; n < answer.Length; n++)
        {
            answer[n] = -1;
        }
        
        int Count = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(DifNum(answer, arr[i]))
            {
                answer[Count] = arr[i];
                Count++;
            }
            
            if(Count >= k)
                break;
        }
        
        
        return answer;
    }
    
    public bool DifNum(int[] answer, int num)
    {
        foreach(int i in answer)
        {
            if(i == num)
            {
                return false;
            }
        }
        return true;
    }
}
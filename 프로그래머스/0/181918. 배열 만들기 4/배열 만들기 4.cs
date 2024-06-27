using System;

public class Solution {
    public int[] solution(int[] arr) {
        int[] stk = new int[0] {};
        int i = 0;
        while(i < arr.Length)
        {
            
            if(stk.Length == 0)
            {
                stk = new int[1] {arr[i]};
                i++;
            }

            if(stk[stk.Length - 1] < arr[i] && stk.Length != 0)
            {
                Array.Resize(ref stk, stk.Length + 1);
                stk[stk.Length - 1] = arr[i];
                i++;
            }
            else if(stk[stk.Length - 1] >= arr[i] && stk.Length != 0)
            {
                Array.Resize(ref stk, stk.Length - 1);
            }
            
        }
        
        return stk;
    }
}
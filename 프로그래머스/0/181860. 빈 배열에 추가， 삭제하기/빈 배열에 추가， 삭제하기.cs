using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        List<int> arrList = new List<int>();
        for(int i = 0; i < arr.Length; i++)
        {
            if(flag[i] == true)
            {
                for(int j = 0; j < arr[i] * 2; j ++)
                {
                    arrList.Add(arr[i]);
                }
            }
            else
            {
                arrList.RemoveRange(arrList.Count - arr[i], arr[i]);
            }
        }
        int[] answer = new int[arrList.Count];
        for(int n = 0; n < arrList.Count; n++)
        {
            answer[n] = arrList[n];
        }
        return answer;
    }
}
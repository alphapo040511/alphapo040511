using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        List<int> answer = new List<int>{};
        for(int i = 0; i < arr.Length; i++)
        {
if(!Array.Exists(delete_list,ex => ex == arr[i]))
{
    answer.Add(arr[i]);
}
        }
        int[] answerArray =new int[answer.Count];
        for(int n = 0; n < answer.Count; n++)
        {
            answerArray[n] = answer[n];
}
        return answerArray;
    }
}
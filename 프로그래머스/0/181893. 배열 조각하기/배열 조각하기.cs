using System;

public class Solution {
    public int[] solution(int[] arr, int[] query) {
        int[] tempArr = new int[] {};
        int[] answer = arr;
        for(int i = 0; i < query.Length; i ++)
        {
            if(i % 2 == 0)
            {
                tempArr = new int[query[i] + 1];
                Array.Copy(answer, 0,tempArr,0,query[i] + 1);
            }
            else
            {
                tempArr = new int[answer.Length - query[i]];
                Array.Copy(answer, query[i],tempArr,0, answer.Length - query[i]);
            }
            answer = tempArr;
        }
        answer = tempArr;
        return answer;
    }
}
using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int[] arr = array;
        for(int i = 0; i < arr.Length; i++)
        {
            for(; 7 <= arr[i];)
            {
                int temp = arr[i] % 10;
                if(temp == 7)
                {
                    answer++;
                }
                arr[i] = (arr[i] - temp) / 10;
            } 
        }
        return answer;
    }
}
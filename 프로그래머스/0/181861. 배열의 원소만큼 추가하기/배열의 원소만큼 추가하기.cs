using System;

public class Solution {
    public int[] solution(int[] arr) {
        int answerLength = 0;
        int Index = 0;
        for(int i = 0; i < arr.Length; i++)
        {
answerLength += arr[i];
}
        int[] answer = new int[answerLength];
        
        for(int j = 0; j < arr.Length; j++)
        {
for(int n = 0; n < arr[j]; n++)
{
answer[Index++] = arr[j];
}
}
        
        return answer;
    }
}
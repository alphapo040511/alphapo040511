using System;

public class Solution {
    public int solution(string[] strArr) {
        int[] strLength = new int[30];
        for(int i = 0; i < strArr.Length; i++)
        {
            strLength[strArr[i].Length - 1]++;
        }
        Array.Sort(strLength);
        
        return strLength[29];
    }
}
using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] arrList = num_list;
        Array.Sort(arrList);
        int[] answer = new int[arrList.Length - 5];
        Array.Copy(arrList, 5, answer, 0, arrList.Length - 5);
        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] arrList = num_list;
        Array.Sort(arrList);
        int[] answer = new int[5];
        Array.Copy(arrList, answer, 5);
        return answer;
    }
}
using System;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        string[] answer = new string[] {};
        int toDoCount = 0;
        int j = 0;
        for(int i = 0; i < finished.Length; i++)
        {
if(finished[i] == false) toDoCount++;
        }
        answer = new string[toDoCount];
        for(int i = 0; i < finished.Length; i++)
        {
if(finished[i] == false)
{
    answer[j++] = todo_list[i];
}
}
        return answer;
    }
}
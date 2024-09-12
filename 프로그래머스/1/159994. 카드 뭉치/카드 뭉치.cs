using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int cards1index = 0;
        int cards2index = 0;
        foreach(string str in goal)
        {
            if(CheckString(str, cards1, cards1index))
            {
                cards1index++;
            }
            else if(CheckString(str, cards2, cards2index))
            {
                cards2index++;
            }
            else
            {
                return "No";
            }
        }
        return "Yes";
    }
    
    bool CheckString(string str, string[] cards, int index)
    {
        if(index >= cards.Length) return false;
        
        if(str == cards[index])
        {
            return true;
        }
        
        return false;
    }
}
using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        string[] answer = players;
        Dictionary<string, int> playerData = new Dictionary<string, int> {};
        for(int i = 0; i < players.Length; i++)
        {
            playerData.Add(players[i], i);
        }
        
        foreach(string player in callings)
        {
            int order = playerData[player];
            string tempName = answer[order - 1];
            answer[order - 1] = answer[order];
            answer[order] = tempName;
            playerData[player] = order - 1;
            playerData[tempName] = order;
        }
        
        return answer;
    }
}
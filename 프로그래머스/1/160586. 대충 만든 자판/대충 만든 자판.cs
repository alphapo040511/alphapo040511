using System;
using System.Collections.Generic;

public class Solution {
    Dictionary<char,int> index = new Dictionary<char,int>{};
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        index = new Dictionary<char,int>{};
        for(int i = 0; i < keymap.Length; i++)
        {
            for(int j = 0; j < keymap[i].Length; j++)
            {
                AddDictionary(keymap[i][j],j + 1);
                //Console.WriteLine(keymap[i][j] + "" + index[keymap[i][j]]);
            }
        }
        
        for(int n = 0; n < targets.Length; n++)
        {
            for(int m = 0; m < targets[n].Length; m++)
            {
                bool temp = FindDictionary(targets[n][m]);
                if(temp)
                {
                    answer[n] += index[targets[n][m]];
                }
                else
                {
                    answer[n] = -1;
                    break;
                }
            }
        }
        return answer;
    }
    
    void AddDictionary(char C, int j)
    {
        bool isBool = FindDictionary(C);
        if(isBool)
        {
            if(index[C] > j)
            {
                index[C] = j;
            }
        }
        else
        {
            index.Add(C,j);
        }
    }
    
    bool FindDictionary(char C)
    {
        if(index.ContainsKey(C))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        int[,] answer = new int[,] {{}};
        int Row = arr.GetLength(0);
        int Column = arr.GetLength(1);
        if(Row > Column)
        {
            answer = new int[Row,Row];
            
            for(int i = 0; i < Row; i++)
            {
                for(int j = 0; j < Column; j++)
                {
                    answer[i,j] = arr[i,j];
                }
            }
        }
        else
        {
            answer = new int[Column,Column];
            for(int i = 0; i < Row; i++)
            {
                for(int j = 0; j < Column; j++)
                {
                    answer[i,j] = arr[i,j];
                }
            }
        }
        return answer;
    }
}
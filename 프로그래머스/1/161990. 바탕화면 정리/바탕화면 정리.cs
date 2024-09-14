using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int xMax = 0;
        int xMin = wallpaper[0].Length;
        int yMax = 0;
        int yMin = wallpaper.Length;
        
        for(int y = 0; y < wallpaper.Length; y++)
        {
            for(int x = 0; x < wallpaper[0].Length; x++)
            {
                if(wallpaper[y][x] == '#')
                {
                    xMax = xMax < x ? x : xMax;
                    yMax = yMax < y ? y : yMax;
                    xMin = xMin > x ? x : xMin;
                    yMin = yMin > y ? y : yMin;
                }
            }
        }
    int[] answer = new int[4] {yMin, xMin, yMax + 1, xMax + 1};
   return answer;
}
}
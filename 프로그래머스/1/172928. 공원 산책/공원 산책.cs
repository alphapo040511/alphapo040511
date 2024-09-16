using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] nowPosition = new int[2];
        int parkYSize = park.Length;
        int parkXSize = park[0].Length;
        int[,] parkMap = new int[parkYSize,parkXSize];
        for(int y = 0; y < parkYSize; y++)
        {
            for(int x = 0; x < parkXSize; x++)
            {
                int index = MapChecking(park[y][x]);
                parkMap[y,x] = index;
                if(index == 2)
                {
                    nowPosition = new int[2] {y,x};
                }
            }
        }
        
        for(int i = 0; i < routes.Length; i++)
        {
            string[] data = routes[i].Split(' ');
            int n = Int32.Parse(data[1]);
            int x = nowPosition[1];
            int y = nowPosition[0];
            switch(data[0])
            {
                case "N":
                    if(VerticalCheck(parkMap, y, y - n, x))
                    {
                        nowPosition[0] = y - n;
                    }
                    break;
                case "S":
                    if(VerticalCheck(parkMap, y, y + n, x))
                    {
                        nowPosition[0] = y + n;
                    }
                    break;
                case "W":
                    if(HorizontalCheck(parkMap, x, x - n, y))
                    {
                        nowPosition[1] = x - n;
                    }
                    break;
                case "E":
                    if(HorizontalCheck(parkMap, x, x + n, y))
                    {
                        nowPosition[1] = x + n;
                    }
                    break;
            }
            
            Console.WriteLine(data[0] + y.ToString()+x.ToString() + n.ToString());
        }
        
        
        return nowPosition;
    }
    
    int MapChecking(char C)
    {
        switch(C)
        {
            case 'S':
                return 2;
            case 'X':
                return 1;
            default:
                return 0;
        }
    }
    
    bool HorizontalCheck(int[,] map, int startPos, int endPos, int y)
    {
                if(endPos < 0 || endPos >= map.GetLength(1))
        {
            return false;
        }
        
        for(int x = Math.Min(startPos,endPos); x <= Math.Max(startPos,endPos); x++)
        {
            if(map[y,x] == 1)
            {
                return false;
            }
        }
        
        return true;
    }
    
    bool VerticalCheck(int[,] map, int startPos, int endPos, int x)
    {
        if(endPos < 0 || endPos >= map.GetLength(0))
        {
            return false;
        }
        
        for(int y = Math.Min(startPos,endPos); y <= Math.Max(startPos,endPos); y++)
        {
            if(map[y,x] == 1)
            {
                return false;
            }
        }
        
        return true;
    }
}
using System;

public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        string answer = "";
        
        string[] VideoTimes = video_len.Split(":");
        int VideoTime = Int32.Parse(VideoTimes[0]) * 60 + Int32.Parse(VideoTimes[1]);
        
        string[] NowTimes = pos.Split(":");
        int NowTime = Int32.Parse(NowTimes[0]) * 60 + Int32.Parse(NowTimes[1]);
        
        string[] OpStartTimes = op_start.Split(":");
        int OpStartTime = Int32.Parse(OpStartTimes[0]) * 60 + Int32.Parse(OpStartTimes[1]);
        
        string[] OpEndTimes = op_end.Split(":");
        int OpEndTime = Int32.Parse(OpEndTimes[0]) * 60 + Int32.Parse(OpEndTimes[1]);
        
        for(int i = 0; i < commands.Length; i++)
        {
            NowTime = CheckOp(NowTime, OpStartTime, OpEndTime);
            
            if(commands[i] == "prev")
            {
                NowTime = Prev(NowTime);
            }
            else if(commands[i] == "next")
            {
                NowTime = Next(NowTime, VideoTime);
            }
            
        }
        
         NowTime = CheckOp(NowTime, OpStartTime, OpEndTime);
        
        answer = ((int)(NowTime / 60)).ToString("00") + ":" + (NowTime % 60).ToString("00");
        
        return answer;
    }
    
    int Prev(int NowTime)
    {
        int time = NowTime - 10;
        if(time < 10)
        {
            return 0;
        }
        else
        {
            return time;
        }
    }
    
    int Next(int NowTime, int VideoTime)
    {
        int time = NowTime + 10;
        if(VideoTime - time < 10)
        {
            return VideoTime;
        }
        else
        {
            return time;
        }
    }
    
    int CheckOp(int NowTime, int OpStartTime, int OpEndTime)
    {
        if(OpStartTime <= NowTime && NowTime <= OpEndTime)
        {
            return OpEndTime;
        }
        else
        {
            return NowTime;
        }
    }
}
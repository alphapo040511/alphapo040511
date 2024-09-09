using System;

public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        string answer = "";
        int VideoTime = StrSplit(video_len);
        int NowTime = StrSplit(pos);
        int OpStartTime = StrSplit(op_start);
        int OpEndTime = StrSplit(op_end);

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
        return time;
    }
    
    int CheckOp(int NowTime, int OpStartTime, int OpEndTime)
    {
        if(OpStartTime <= NowTime && NowTime <= OpEndTime)
        {
            return OpEndTime;
        }
        return NowTime;
    }
    
    int StrSplit(string Str)
    {
        string[] str = Str.Split(":");
        return Int32.Parse(str[0]) * 60 + Int32.Parse(str[1]);
    }
}
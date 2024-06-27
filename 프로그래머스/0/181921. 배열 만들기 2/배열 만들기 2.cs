using System;

public class Solution {
    public int[] solution(int l, int r) {
        int[] answer = new int[1] {-1};
        int NowNum = 0;
        
        while(true)
        {
            NowNum += 5;
            NowNum = CheckNum(NowNum);
            if(NowNum >= l && NowNum <= r)
            {
                Array.Resize(ref answer, answer.Length + 1);
                answer[answer.Length - 2] = NowNum;
            }
            
            if(NowNum > r)
                break;
        }
        
        if(answer[0] != -1)
            Array.Resize(ref answer, answer.Length - 1);
        
        return answer;
    }
    
    int CheckNum(int nowNum)
    {
        int temp = nowNum;
        int Return_Num = 0;
        for(int i = 0; ;i++)
        {
            if(temp % 10 == 0 || temp % 10 == 5)
            {
            Return_Num += (Int32)(temp % 10 * Math.Pow(10 , i));
            temp = (temp - temp % 10)/10;
            }
            else if(temp % 10 == 1)
            {
                temp = (temp - 1)/10;
                Return_Num += (Int32)(5 * Math.Pow(10 , i));
            }
            else if(temp % 10 == 6)
            {
                temp = (temp - 6)/10;
                temp += 5;
            }

            
            if(temp <= 0)
                break;
        }
        
        return Return_Num;
        
    }
}
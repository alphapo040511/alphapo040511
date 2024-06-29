using System;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        int answer = 0;
        int[] numberList = {a,b,c,d};
        int fourCard = 0;
        int threeCard = 0;
        int pair1 = 0;
        int pair2 = 0;
        int noPair1 = 0;
        int noPair2 = 0;
        int noPair3 = 0;
        int noPair4 = 0;
        
        
        for(int i = 0; i < numberList.Length; i++)
        {
            int sameNum = 0;
            for(int n = 0; n < numberList.Length; n++)
            {
                if(numberList[i] == numberList[n])
                    sameNum++;
            }
            switch(sameNum)
            {
                case 4:
                  fourCard = numberList[i];
                    break;
                    
                case 3:
                  threeCard = numberList[i];
                    break;
                    
                case 2:
                    if(pair1 == 0 || pair1 == numberList[i])
                    {
                        pair1 = numberList[i];
                    }
                    else
                    {
                        pair2 = numberList[i];
                    }
                    break;
                    
                    case 1:
                    if(noPair1 == 0 || noPair1 == numberList[i])
                    {
                        noPair1 = numberList[i];
                    }
                    else if(noPair2 == 0 || noPair2 == numberList[i])
                    {
                        noPair2 = numberList[i];
                    }
                    else if(noPair3 == 0 || noPair3 == numberList[i])
                    {
                        noPair3 = numberList[i];
                    }
                    else if(noPair4 == 0 || noPair4 == numberList[i])
                    {
                        noPair4 = numberList[i];
                    }
      
                    break;
                    
                    
                default:
                    break;

            }
            
            
            if(fourCard != 0)
                answer = fourCard * 1111;
            
            else if(threeCard != 0)
                answer = (10 * threeCard + noPair1) * (10 * threeCard + noPair1);
            
            else if(pair1 != 0)
            {
                if(pair2 != 0)
                    answer = (pair1 + pair2) * Math.Abs(pair1 - pair2);
                else
                    answer = noPair1 * noPair2;
            }
            else
            {
                int temp = a;
                for(int n = 0; n < 4; n++)
                {
                    if(numberList[n] < temp)
                        temp = numberList[n];
                }
                answer = temp;
            }
        }
        
        
        return answer;
    }
}
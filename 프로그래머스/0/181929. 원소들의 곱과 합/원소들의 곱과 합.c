#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// num_list_len은 배열 num_list의 길이입니다.
int solution(int num_list[], size_t num_list_len) {
    int answer = 0;
    int answer1 = 1;
    int answer2 = 0;
    for(int i = 0; i < num_list_len; i++)
    {
        answer1 *= num_list[i];
        answer2 += num_list[i];
    }

    
    answer = answer1 < answer2 * answer2 ? 1 : 0;
    
    
    return answer;
}
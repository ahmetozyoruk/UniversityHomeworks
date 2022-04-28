#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int Rec_Func(int num_);

int main()
{
    int num;

    printf("Input: ");
    scanf("%d",&num);

    Rec_Func(num);

    return 0;
}

        /*
        Only, tronsformed from formula to c language by using recursive function.
        */

int Rec_Func(int num)
{
    printf("%d ", num);

    if(num<2) return 0;

    if(num%2 == 0)
    {
        num /= 2;
        return Rec_Func(num);
    }
    else if(num%2 == 1)
    {
        num = num*3+1;
        return Rec_Func(num);
    }
}


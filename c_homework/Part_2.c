#include <stdio.h>
#include <stdlib.h>

int main()
{
    int heighNumber = 0;

    printf("Please enter number: ");
    scanf("%d",&heighNumber);

                //Upper Trianguler

    for(int i=0; i<heighNumber; i++)    // press lines, one after the other
    {
        for(int j=0; j< heighNumber-i-1; j++) printf(" ");  // press space until heighNumber-i*1
        printf("/");
        for(int j=0; j<i*2; j++) printf("*");   // press * until being square of i
        printf("\\");
        for(int j=0; j< heighNumber-i-1; j++) printf(" ");   // right spaces
        printf("\n");
    }

                //lower Trianguler

    for(int i=0; i<heighNumber; i++)
    {
        for(int j=0; j< i;j++) printf(" ");
        printf("\\");
        for(int j=(heighNumber-i-1)*2; j>0;j--) printf("*");
        printf("/");
        printf("\n");
    }
                                                
    return 0;
}

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#define SIZE 3

int main()
{

    char oprtr[SIZE] = " ";            // storing operation as string
    float num1=0,num2=0,sum=0;
    int isContinue=1, which;

    system("clear");        //clear console screen
    //system("cls");        //according to operation system, chancing

    while(isContinue)
        {
            ////////////////// Screen of calculator \\\\\\\\\\\\\\\\\\\\\\

        printf("--------------------------\n");
        printf("|       CALCULATOR       |\n");
        printf("|                        |\n");
        printf("|                        |\n");
        printf("|       Equation: %.2f   |\n",sum);
        printf("|                        |\n");
        printf("|       +   -   *        |\n");
        printf("|       /   ^   %        |\n");
        printf("|                        |\n");
        printf("| For calculating, enter;|\n");
        printf("|    1             2     |\n");     //1  2
        printf("|(+ 10.6) or (+ 10.0 2.0)|\n");     //+  *
        printf("|  For quit, press: (q)  |\n");     //8  9
        printf("--------------------------\n");     //9
        printf("                          \n");
        printf("  Values : \n");

        //////////////////Taking Values\\\\\\\\\\\\\\\\\\\\\

        scanf("%d", &which);
        scanf("%s", oprtr);
                    if(strcmp(oprtr,"q")==0) break;


        ////////////////Calculate result\\\\\\\\\\\\\\\\\\\\\

        /*
            according to taken value (which),
            select process will be happen.
        */

        if(which==1)
        {
            scanf("%f", &num1);

            if(strcmp(oprtr,"+")==0)  {sum += num1 + num2;}
            else if(strcmp(oprtr,"-")==0) {sum -= num1 - num2;}
            else if(strcmp(oprtr,"*")==0) {sum *= num1 * num2;}
            else if(strcmp(oprtr,"/")==0) {sum /= num1 / num2;}
            else if(strcmp(oprtr,"^")==0) {sum = pow( sum, num1);}
            else if(strcmp(oprtr,"%")==0) {sum = (int)sum % (int) num1;}
            else   {printf("\n\nEntered wrong, try againg.\n\n");}
        }
        else if(which==2)
        {
            scanf("%f", &num1);
            scanf("%f", &num2);

            if(strcmp(oprtr,"+")==0)  {sum = num1 + num2;}
            else if(strcmp(oprtr,"-")==0) {sum = num1 - num2;}
            else if(strcmp(oprtr,"*")==0) {sum = num1 * num2;}
            else if(strcmp(oprtr,"/")==0) {sum = num1 / num2;}
            else if(strcmp(oprtr,"^")==0) {sum = pow(  num1, num2);}
            else if(strcmp(oprtr,"%")==0) {sum = (int)num1 % (int)num2;}
            else  {printf("\n\nEntered wrong, try againg.\n\n");}
        }
        else{ printf("\n\nEntered wrong, try againg.\n\n");}

            system("clear");
        }
    return 0;					
}

#include <stdio.h>
#include <stdlib.h>
#define SIZE 50

char Func(char *str_);

int main()
{
    char str[SIZE];

    printf("Input: ");
    scanf("%s", str);

    printf("Output: %c",Func(str));

    return 0;
}

        /*
        By using ascii table value,
        first big word is found.
        */
char Func(char *str_)
{
    char result;

    while(*str_ != '\0')
    {
        if(*str_ >= 65 && *str_ <=90 )
        {
            result = *str_;
            break;
        }
        str_++;
    }

    return result;
}

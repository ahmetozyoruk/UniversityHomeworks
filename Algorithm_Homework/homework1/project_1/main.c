#include <stdio.h>
#include <stdlib.h>


int _size;

int * ToOrder(int arr[_size]);

int main()
{


    printf("Enter the lenght of the list: ");
    scanf("%d",&_size);

    int arr[_size];

    printf("Enter the elements of list:\n");

    for(int i=0; i<_size; i++)
    {
        scanf("%d",&arr[i]);
    }


    int *OrderedArr = ToOrder(arr);

        /*
        print the changed OrderArr which point the start of arr;
        */

    printf("Sorted array is: ");
    for(int i=0; i<_size; i++)
    {
        printf("%d ",OrderedArr[i]);
    }

    return 0;
}
        /*
        ordered the array by using:
                temp= temporary varaible,
                _size= I used global type because the value of size is taked in main and it's used the inside of array as paramater
                        , so I can't define as #define size --
        */
int * ToOrder(int arr_new[_size])
{
    int temp;

    for(int i=0; i<_size; i++)
    {
        for(int j=i+1;j<_size; j++)
        {
            if(arr_new[i]>arr_new[j])
            {
                temp = arr_new[j];
                arr_new[j] = arr_new[i];
                arr_new[i] = temp;
            }
        }
    }

    return arr_new;
}












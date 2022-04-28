#include <stdio.h>
#include <stdlib.h>
#include<time.h>
#include <stdbool.h>

/*
    I could do:
                Printing table,
                Botanist movement,
                Escape from obstacles,
    process.

    I couldn't do:
                find flower (because The process ends before it finds the flower. )
    process
*/

typedef struct{ /*Create Forest struct*/
	int width;
	int height;
	char **map;
	int flower_x;
	int flower_y;
}Forest;

typedef struct{ /*Create Botanist struct*/
	int coord_x;
	int coord_y;
	int water_bottle_size;
}Botanist;


void print_map (Forest *forest);
void search (Forest *forest, Botanist *botanist);
void init_game(Forest *forest, Botanist *botanist);



int main(int argc, char const *argv[])
{
    Forest forest;
    Botanist botanist;

    init_game(&forest,&botanist);

	/* code */
	return 0;
}
void init_game(Forest *forest, Botanist *botanist){ /* Read game in file*/
	int i,j;
	char com;
	FILE *input;
	input=fopen("init.csv","r"); /* Open file*/

	if (input != NULL)
	{
		fscanf(input, "%d\n", &(botanist->water_bottle_size)); /* Read first row */

		fscanf(input,"%d%c%d%c",&(forest->width),&com, &(forest->height),&com);

		forest->map =(char**)malloc(sizeof(char*)*(forest->height+1));
		        for(i=0; i<(forest->height+1); i++){ /*Allocate space in memory.*/
		                forest->map[i]=(char*)malloc(sizeof(char)*(forest->width*2));
		        }
	                        for(i=0; i<(forest->height+1); i++){ /* Read game*/
	                                for(j=0; j<(forest->width*2); j++){
	                                        fscanf(input,"%c", &(forest->map[i][j]));
	                                          if(forest->map[i][j]=='B'){
	                                            /*
													... put code here
	                                            */
	                                            botanist->coord_x = j;
	                                            botanist->coord_y = i;
	                                          }
	                                          if(forest->map[i][j]=='F'){
	                                            /*
													... put code here
	                                            */
	                                            forest->flower_x = j;
	                                            forest->flower_y = i;
	                                          }
	                                        printf("%c",forest->map[i][j]);
	                                }
	                        }

		fclose(input);	/* code */

		forest->map[botanist->coord_y][botanist->coord_x] = ' ';

		printf("\n\n");

        search(forest,botanist);

		forest->map[botanist->coord_y][botanist->coord_x] = 'B';
		print_map(forest);
	}
}

void print_map (Forest *forest)
{
    int i,j;
    for(i=0; i<(forest->height+1); i++){ /* Read game*/
	                                for(j=0; j<(forest->width*2); j++){
	                                        printf("%c", forest->map[i][j]);
	                                          if(forest->map[i][j]=='B'){
	                                            /*
													... put code here
	                                            */
	                                          }
	                                          if(forest->map[i][j]=='F'){
	                                            /*
													... put code here
	                                            */
	                                          }
	                                }
	                        }
}

bool isSafe(Forest *forest, int x, int y)
{
    if(forest->map[y][x] == ' ' || forest->map[y][x] == 'B')
       return true;

       return false;
 //   x<=0 || x>=forest->width*2 ||
   //    y<=0 || y>=forest->height+1 ||
}

char options[3];
bool findFlower(Forest *forest, Botanist *botanist,int x, int y, char direction)
{

    if(forest->map[y][x] == 'F' )
    {
        return true;
    }

//usleep(10000);
    if(isSafe(forest, x, y))
    {
        botanist->water_bottle_size--;
        forest->map[y][x] = 'B';
        if(direction=='l')
        {
                            for(int i=0; i<3; i++){if('r'==options[i])options[i] = 'l'; break;}
                            direction = options[rand()%3];printf("\n[%c]=> '%d,%d'\n",direction,y,x);
                            x=x-2;
                            if(findFlower(forest, botanist,x, y,direction) == true)
                                return true;
        }
        if(direction=='r')
        {
                            for(int i=0; i<3; i++){if('l'==options[i])options[i] = 'r'; break;}
                            direction = options[rand()%3];
                            printf("\n[%c]=> '%d,%d'\n",direction,y,x);
                            x=x+2;
                            if(findFlower(forest, botanist,x, y,direction) == true)
                                return true;
        }
        if(direction=='u')
        {
                            for(int i=0; i<3; i++){if('d'==options[i])options[i] = 'u'; break;}
                            direction = options[rand()%3];
                            printf("\n[%c]=> '%d,%d'\n",direction,y,x);
                            x=x-1;
                            y=y-1;
                            if(findFlower(forest, botanist,x, y,direction) == true)
                                return true;
        }
        if(direction=='d')
        {
                            for(int i=0; i<3; i++){if('u'==options[i])options[i] = 'd'; break;}
                            direction = options[rand()%3];printf("\n[%c]=> '%d,%d'\n",direction,y,x);
                            x=x+1;
                            y=y+1;
                            if(findFlower(forest, botanist,x, y,direction) == true)
                                return true;
        }
    }

    return false;
}
void search (Forest *forest, Botanist *botanist)
{
    srand(time(NULL));
    options[0]='l';
    options[1]='d';
    options[2]='u';
    if(findFlower(forest, botanist,botanist->coord_x, botanist->coord_y, 'r') == false)
    {
        printf("Help me!");
    }
    else
    {
        printf("I find flower at '%d,%d'",botanist->coord_x,botanist->coord_y);
    }
}
      /*  switch(direction)
        {
            case 'l':
                            for(int i=0; i<3; i++){if('l'==options[i])options[i] = 'r'; break;}
                            direction = options[rand()%3];
                            if(findFlower(forest, x-2, y,direction) == true)
                                return true;
            break;
            case 'r':
                            for(int i=0; i<3; i++){if('r'==options[i])options[i] = 'l'; break;}
                            direction = options[rand()%3];
                            if(findFlower(forest, x+2, y,direction) == true)
                                return true;
            break;
            case 'u':
                            for(int i=0; i<3; i++){if('u'==options[i])options[i] = 'd'; break;}
                            direction = options[rand()%3];
                            if(findFlower(forest, x-1, y-1,direction) == true)
                                return true;
            break;
            case 'd':
                            for(int i=0; i<3; i++){if('d'==options[i])options[i] = 'u'; break;}
                            direction = options[rand()%3];
                            if(findFlower(forest, x+1, y+1,direction) == true)
                                return true;
            break;
            default:
                {
                    printf("There is a problem in switch");
                    return false;
                }

        }
        */


/*void search (Forest *forest, Botanist *botanist, int direction)
{

        //Direction meaning:
        //up = 0
        //down = 1
        //left = 2
        //right =3



        switch(direction) {

       case 0:usleep(100000);printf("\naaaaa\n");
           if (forest->map[botanist->coord_y-1][botanist->coord_x-1] != ' ')
           {
                   if(forest->map[botanist->coord_y][botanist->coord_x-2]!= ' ' &&
                    forest->map[botanist->coord_y][botanist->coord_x+2] != ' ')
                    break;
               while(1)
                   {
                            srand(time(NULL));
                            direction = rand()%4;
                    if((direction == 0 && passed == 1 ) ||
                        (direction == 1 && passed == 0 ) ||
                        (direction == 2 && passed == 3 ) ||
                        (direction == 3 && passed == 2))
                         {
                            continue;
                         }
                    else if(direction!=passed)
                        break;
                   }
               return search(forest, botanist,direction);
           }
                    if(direction == 0) passed = 1;
                    if(direction == 1) passed = 0;
                    if(direction == 2) passed = 3;
                    if(direction == 3) passed = 2;
                botanist->coord_x = botanist->coord_x-1;
                botanist->coord_y = botanist->coord_y-1;

                printf("\nI entered up.\n");
                printf("%d %d\n", botanist->coord_y, botanist->coord_x);
          break;

       case 1:usleep(100000);printf("\nbbbbb\n");
           if (forest->map[botanist->coord_y+1][botanist->coord_x+1] != ' ')
            {
                   if(forest->map[botanist->coord_y][botanist->coord_x-2]!= ' ' &&
                    forest->map[botanist->coord_y][botanist->coord_x+2] != ' ')
                    break;
               while(1)
                   {
                            srand(time(NULL));
                            direction = rand()%4;
                    if((direction == 0 && passed == 1 ) ||
                        (direction == 1 && passed == 0 ) ||
                        (direction == 2 && passed == 3 ) ||
                        (direction == 3 && passed == 2))
                         {
                            continue;
                         }
                    else if(direction!=passed)
                        break;
                   }

               return search(forest, botanist,direction);
            }
                    if(direction == 0) passed = 1;
                    if(direction == 1) passed = 0;
                    if(direction == 2) passed = 3;
                    if(direction == 3) passed = 2;
                botanist->coord_x = botanist->coord_x+1;
                botanist->coord_y = botanist->coord_y+1;
                printf("\nI entered down.\n");
                printf("%d %d\n", botanist->coord_y, botanist->coord_x);
          break;

       case 2:usleep(100000);printf("\ncccccc\n");

           if (forest->map[botanist->coord_y][botanist->coord_x-2]!= ' ')
           {
                   if(forest->map[botanist->coord_y+1][botanist->coord_x+1] != ' ' &&
                    forest->map[botanist->coord_y-1][botanist->coord_x-1]!= ' ')
                    break;
               while(1)
                   {
                            srand(time(NULL));
                            direction = rand()%4;
                    if((direction == 0 && passed == 1 ) ||
                        (direction == 1 && passed == 0 ) ||
                        (direction == 2 && passed == 3 ) ||
                        (direction == 3 && passed == 2))
                         {
                            continue;
                         }
                    else if(direction!=passed)
                        break;
                   }
               return search(forest, botanist,direction);
           }
                    if(direction == 0) passed = 1;
                    if(direction == 1) passed = 0;
                    if(direction == 2) passed = 3;
                    if(direction == 3) passed = 2;
                botanist->coord_x = botanist->coord_x-2;
                printf("\nI entered left.\n");
            printf("%d %d\n", botanist->coord_y, botanist->coord_x);
          break;

       case 3:usleep(100000);printf("\nddddd\n");

           if (forest->map[botanist->coord_y][botanist->coord_x+2] != ' ')
           {
                   if(forest->map[botanist->coord_y+1][botanist->coord_x+1] != ' ' &&
                    forest->map[botanist->coord_y-1][botanist->coord_x-1]!= ' ')
                    break;
               while(1)
                   {
                            srand(time(NULL));
                            direction = rand()%4;
                    if((direction == 0 && passed == 1 ) ||
                        (direction == 1 && passed == 0 ) ||
                        (direction == 2 && passed == 3 ) ||
                        (direction == 3 && passed == 2))
                         {
                            continue;
                         }
                    else if(direction!=passed)
                        break;
                   }
             return search(forest, botanist,direction);
           }
                    if(direction == 0) passed = 1;
                    if(direction == 1) passed = 0;
                    if(direction == 2) passed = 3;
                    if(direction == 3) passed = 2;
                botanist->coord_x = botanist->coord_x+2;

                printf("\nI entered right.\n");
                printf("%d %d\n", botanist->coord_y, botanist->coord_x);
          break;
       default :
           printf("...There is a unexpected problem....");
    }
}
*/


/*
srand(time(NULL));
            direction = rand()%4;
*/

/*if (//botanist->coord_y == 9 ||
               forest->map[botanist->coord_y+1][botanist->coord_x+1] == '\0' ||
               forest->map[botanist->coord_y+1][botanist->coord_x+1] == '#' ||
               forest->map[botanist->coord_y+1][botanist->coord_x+1] == ',')
               return search(forest, botanist);
*/


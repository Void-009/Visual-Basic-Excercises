#include<stdio.h>
int main()
{	
	float score1;
float gpa,result;
	int totalC;
	float n;
	float twp;
	char q,y,Y;
	do{
	printf("enter total course credit unit\n");
	scanf("%d",&totalC);
	printf("enter your total point of all course\n");
	scanf("%f",&score1);
	gpa =score1/totalC;	
	printf("\t\" your point (GPA) is %.2f\n\n",gpa);
	
	if(gpa>= 4.00)
	{
	printf("congratulation you get distintion!\n");
	}
	else if(gpa>=3.00||gpa>=2.99)
	{
	printf(" you get upper credit\n");}
	else if(gpa>=2.00||gpa>=1.99){
	printf("you get lower credit\n");}
	else if(gpa>=1.00||gpa<=0.55){
	printf("your are in prob be carefull\n");}
	scanf("%C",&n);
	printf("do you wish to continue pree (Y) or else to terminate\n");
	q=getchar();}
	while(q=='y'|q=='Y');
	getchar();
}		

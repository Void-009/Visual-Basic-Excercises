#include <stdio.h>//to allows printf to print out the output
main ()
{
  float score[10];
int C[10];

    float score1,score2,score3,score4,score5,score6,score7,score8,score9,score10;//to declear the variable
    float gpa,result,totalC;//to declear the variable
    int C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,n;//to declear the variable
    float a,b,c,d,e,f,g,h,i,j,twp;
    char q,y,Y;//to declear the variable
    do{
    printf("name:IDRIS MUHAMMAD MUSA\n");//to printf out your input
    printf("REG NO= ND/CET/16/0122\n");//to printf out your input
    printf("TITLE= CALCULATION OF GPA\n");//to printf out your input
    printf("enter course 1 Credit unit \n");//to printf out your input.
    scanf("%d",&C1);//to colect your input
    printf("enter course 2 Credit unit \n");//to printf out your input
    scanf("%d",&C2);//to colect your input
    printf("enter course 3 Credit unit \n");//to printf out your input
    scanf("%d",&C3);//to colect your input
    printf("enter course 4 Credit unit \n");//to printf out your input
    scanf("%d",&C4);//to colect your input
    printf("enter course 5 Credit unit\n");//to printf out your input
    scanf("%d",&C5);//to colect your input
    printf("enter course 6 Credit unit\n");//to printf out your input
    scanf("%d",&C6);//to colect your input
    printf("enter course 7 Credit unit \n");//to printf out your input
    scanf("%d",&C7);//to colect your input
    printf("enter course 8 Credit unit \n");//to printf out your input
    scanf("%d",&C8);//to colect your input
    printf("enter course 9 Credit unit\n");//to printf out your input
    scanf("%d",&C9);//to colect your input
    printf("enter course 10 Credit unit\n");//to printf out your input
    scanf("%d",&C10);//to colect your input
    printf("enter your point in course 1\n");//to printf out your input
    scanf("%f",&score1);//to colect your input
    printf("enter your point in course 2\n");//to printf out your input
    scanf("%f",&score2);//to colect your input
    printf("enter your point incourse 3\n");//to printf out your input
    scanf("%f",&score3);//to colect your input
    printf("enter your point in course 4\n");//to printf out your input
    scanf("%f",&score4);//to colect your input
    printf("enter your point in course 5\n");//to printf out your input
    scanf("%f",&score5);//to colect your input
    printf("enter your point in course 6\n");//to printf out your input
    scanf("%f",&score6);//to colect your input
    printf("enter your point in course 7\n");//to printf out your input
    scanf("%f",&score7);//to colect your input
    printf("enter your point in course 8\n");//to printf out your input
    scanf("%f",&score8);//to colect your input
    printf("enter your point in course 9\n");//to printf out your input
    scanf("%f",&score9);//to colect your input
    printf("enter your point incourse 10\n");//to printf out your input
    scanf("%f",&score10);//to colect your input
    totalC = C1+C2+C3+C4+C5+C6+C7+C8+C9+C10;//formular.
        a= score1*C1;
        b= score2*C2;
        c= score3*C3;
        d= score4*C4;
        e= score5*C5;
        f= score6*C6;
        g= score7*C7;
        h= score8*C8;
        i= score9*C9;
        j= score10*C10;
        twp = a+b+c+d+e+f+g+h+i+j;
      gpa = twp/totalC; 
    printf("total credite unit is %.2f\n\n",totalC);//to printf out your input
    printf("your total weight point (TWP) is %.2f\n\n",twp);//to printf out your input
    printf("\t\"your point(GPA) is %.2f\n",gpa);//to printf out your input
    if(gpa =4.00){//conditional statement
	printf("congratulation you get distintion!\n");}//to printf out your input
	else if(gpa<=3.00||gpa>=2.99){//conditional statement
    printf("you get upper credite\n");}//to printf out your input
    else if(gpa<=2.00||gpa>=1.99){//conditional statement
    printf("you get lower credite\n");}//to printf out your input
    else if(gpa<=1.00||gpa>=0.55){//conditional statement
    printf("you are in prob. be carefull\n");}//to printf out your input
    printf("do you wish to continue,press (Y) or else to terminate\n");//to printf out your input
    scanf("%c",&n);//to colect your input
    q=getchar();}
    while(q=='y'|q=='Y');
    getchar();
}

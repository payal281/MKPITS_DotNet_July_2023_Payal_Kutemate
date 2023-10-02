#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char auther[50];
	int bookid;
};
int main()
{
	struct book b1;
	printf("enter title name,auther name and book id \n");
	scanf("%s",b1.title);
	scanf("%s",b1.auther);
	scanf("%d",&b1.bookid);
	
	
    printf("\ntitle=%s",b1.title);
	printf("\n auther=%s",b1.auther);
	printf("\nbookid=%d",b1.bookid);
	
}


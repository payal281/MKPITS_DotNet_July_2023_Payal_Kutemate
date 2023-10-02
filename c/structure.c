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
	strcpy(b1.title,"Dotnet");
	strcpy(b1.auther,"ashish");
	b1.bookid=123;
	
	printf("\ntitle=%s",b1.title);
	printf("\n auther=%s",b1.auther);
	printf("\nbookid=%d",b1.bookid);
	
}

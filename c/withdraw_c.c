#include<stdio.h>
deposit(int amt,int bal);
void withdrawl(int amt,int bal);
void main()
{
	int amt,bal=1000;
	printf("enter amt");
	scanf("%d",&amt);
	deposit(amt,bal);
	withdrawal(amt,bal);
}
int deposit(int amt,int bal)
{
	bal=bal+amt;
	printf("amt deposited,bal is=%d",bal);
}
int withdrawal( int amt,int bal)
{
	bal=bal-amt;
	printf("amt with,bal is =%d",bal);
}

create table fstudent (rno int,fdate date,amount int)
insert into fstudent values(1,'2020-2-1',200000)
insert into fstudent values(2,'2020-3-2',200000)
insert into fstudent values(3,'2020-5-3',200000)
select *from fstudent
select sum(amount)as "sum of amount"
from fstudent
group by rno


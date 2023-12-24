exec sp_help customer
create table orders (orderid int , custid int, orderdate date,
productname varchar(20),qty int)
insert into orders values(1,1,'2022-2-2','mouse',5)
insert into orders values(1,1,'2022-2-2','keyboard',5)
insert into orders values(2,2,'2022-2-2','desktop',5)
insert into orders values(2,2,'2022-2-2','ram',5)
insert into orders values(3,3,'2022-2-2','laptop',5)
insert into orders values(4,3,'2022-1-2','mouse',5)
insert into orders values(5,4,'2022-2-2','mouse',5)
insert into orders values(6,4,'2022-2-2','ram',5)
insert into orders values(7,5,'2022-2-2','desktop',5)
insert into orders values(7,5,'2022-2-2','ram',5)
select * from orders







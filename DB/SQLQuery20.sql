create table product(productname varchar(20)not null,
quantity int NOT NULL,
price int NOT NULL)
insert into product values('computer',10,100)
insert into product values('laptop',20,200)
insert into product values('iphone',40,400)
insert into product values('smart phone',50,500)
select *from product
select productname,
min(price) as "minimum price"
from product 
group by productname
having min(price)>300
drop table product
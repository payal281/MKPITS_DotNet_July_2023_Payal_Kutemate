create table fproduct(productname varchar(20)not null,
quantity int NOT NULL,
price int NOT NULL)
insert into fproduct values('computer',10,100)
insert into fproduct values('laptop',20,200)
insert into fproduct values('iphone',40,400)
insert into fproduct values('smart phone',50,500)
select *from fproduct
select productname,quantity,price 
from fproduct
where price=(select Max(price) AS "minimum quantity"
from fproduct)


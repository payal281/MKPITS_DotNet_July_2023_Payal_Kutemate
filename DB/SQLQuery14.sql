create table vendor_groups(group_id int IDENTITY PRIMARY KEY,group_name varchar(100)not null);
CREATE TABLE vendors (vendor_id INT IDENTITY PRIMARY KEY,vendor_name VARCHAR(100) NOT NULL,group_id INT NOT NULL)
select * from vendor_groups
insert into vendors(vendor_name,group_id) values('amit',123)
select*from vendors
insert into vendors(vendor_name,group_id) values('payal',1)

CREATE TABLE stores (store_id INT IDENTITY (1, 1) PRIMARY KEY,store_name VARCHAR (255) NOT NULL,phone VARCHAR (25),email VARCHAR (255),street VARCHAR (255),city VARCHAR (255),state VARCHAR (10),zip_code VARCHAR (5))
insert into stores (store_name,phone,email,street,city,state,zip_code) values ('mana','1234567890','mana@gmail.com','sadar','nagpur','maharastra','4400')
select * from stores
insert into stores(store_name,phone,email,street,city,state,zip_code) values ('dhanush','2234567890','d@gmail.com','sadar','nagpur','maharastra','4400')
insert into stores(phone,email) values('3222','ab@gmail.com')
insert into stores(store_name,phone,email) values('radha','3222','ab@gmail.com')



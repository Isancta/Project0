
Create database BibliothequeAPP
 
 use BibliothequeAPP
 Go

 select * from LibraryCatalogues

 create table LibraryCatalogues
   (
   bookCode int Primary key Identity(0001,1),
   bookTitle varchar(200) not null,
   bookSection varchar(10) not null,
   bookIsAvailable bit,
   unitPrice int not null,
   quantityInStore int not null
    
   )

   Insert into LibraryCatalogues values ('The richest man in Babilon','Sell',1, 16, 106)
   Insert into LibraryCatalogues values ('SAS_mission Cuba','Lease',1,5,5)
   Insert into LibraryCatalogues values ('The Rabbit listened','Borrow',0,0,10)
   Insert into LibraryCatalogues values ('Get your sh*t together','Sell',0,11,150)
   Insert into LibraryCatalogues values ('Brand Aid','Sell',1,25,54)
   Insert into LibraryCatalogues values ('In case you missed it','Borrow',1,0,2)
   Insert into LibraryCatalogues values ('Manual of Percutaneous Coronary Interventions','Lease',1,35,4)

Select*from LibraryCatalogues

 create table UserInfo
    (
	  username varchar(20) primary key,
	  password varchar(20)
	  
    )

insert into UserInfo values('Dwodd', '2512ww')
insert into UserInfo values('CarSue', 'Labb44')
insert into UserInfo values('Kelsey', 'Kelk10$1')
insert into UserInfo values('JennyH', '44&Haha')

select*from UserInfo

create table NewUser
   (
       username varchar(20),
       name varchar(50) ,
	   age int check (age >=0),
	   email varchar (50)
   )
insert into NewUser values('Dwodd','David Woodruff',36,'Dwood@gmail.com')
insert into NewUser values('CarSue','Sue Carson',42,'Carson.sue@gmail.com')
insert into NewUser values('Kelsey','Lindsey Kelk',16,'Lili@gmail.com')
insert into NewUser values('JennyH','Jenny Halley',60,'JennyHa@gmail.com')

Select*from NewUser

create table Cart

   (
      bookCode int primary key Identity(0001,1),
	  bookTitle Varchar(200),
	  booksection Varchar(10),
	  quantity int,
	  bookIsAvailable Bit,
	  unitPrice int, 
   )

Select*from Cart


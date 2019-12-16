create database ¿ªÏäÄ£Äâ
create table Regist
(num varchar(10) primary key not null,
name varchar(20) not null,
pwd varbinary(1024) not null,
phone char(11),
remain money CONSTRAINT ck_test_rowid check(remain>=0) not null,
)
insert into Regist values ('1625121006','¼Ù¿¨',pwdencrypt('chen'),'13385926029','100')
select * from Regist
select * from Regist where num='1625121006'
select pwdcompare('chen',(select pwd from Regist where num='1625121006'),1)

drop table Regist

delete from Regist where num='123'

create table item 
(item_id int identity(1,1) primary key,
item_typeid int not null,
item_owner varchar(10),
item_color int not null,
item_level varchar(20) not null,
item_price money CONSTRAINT chk_money check(item_price>=0),
item_state bit
)
insert into item values ('11','1625121006','4','6','230','0')
select * from item 
delete from item where item_owner='ghj5121006'

update item set item_state='0'

drop table item
alter table item drop constraint chk_money

select item_worth from item,item_type where item_type.item_typeid='1' and item_type.item_color='1' and item_owner='1625121006'

create table item_type
(item_typeid int,
item_color int,
item_typename varchar,
item_colorname varchar,
item_worth int,
item_box int,
item_boxname varchar,
)
select * from item_type

select * from item,item_type where item.item_typeid = item_type.item_typeid and item.item_color = item_type.item_color
select item_typename,item_typeid,item_colorname,item_color,item_level from item_type 

create table test
(num int identity(3,2) not null,
name varchar(10) primary key
)
insert into test values('jhjkks')
select * from test
drop table test


drop table Regist
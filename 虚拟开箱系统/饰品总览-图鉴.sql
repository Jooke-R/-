create table item_type
(item_typeid int,
 item_color int primary key(item_typeid,item_color),
 item_typename varchar(20),
 item_colorname varchar(20),
 item_worth int,
 item_box int,
 item_boxname varchar(20),
 item_level int,
 item_levelname varchar(20)
 ) 
 
 ,'1','��ͨ'
 ,'2','ϡ��'
 ,'3','ʷʫ'
 ,'4','��˵'
 insert into item_type values
 (1,1,'�̵�','��Ϳװ',1000,1,'��Ӱ����' ,'3','ʷʫ'),
 (1,2,'�̵�','������',1300,1,'��Ӱ����','4','��˵'),
 (1,3,'�̵�','���֮��',1500,1,'��Ӱ����','4','��˵'),
 (1,4,'�̵�','����֮ɫ',1700,1,'��Ӱ����','4','��˵');

 insert into item_type values
 (2,1,'צ�ӵ�','��Ϳװ',1500,2,'��������','3','ʷʫ'),
 (2,2,'צ�ӵ�','������',2400,2,'��������' ,'4','��˵'),
 (2,3,'צ�ӵ�','���֮��',3600,2,'��������' ,'4','��˵'),
 (2,4,'צ�ӵ�','����֮ɫ',3400,2,'��������' ,'4','��˵')

  insert into item_type values
 (3,1,'������','��Ϳװ',1600,3,'ͻΧ����','3','ʷʫ'),
 (3,2,'������','������',2800,3,'ͻΧ����','4','��˵'),
 (3,3,'������','���֮��',1700,3,'ͻΧ����','4','��˵'),
 (3,4,'������','����֮ɫ',3500,3,'ͻΧ����','4','��˵')

   insert into item_type values
 (4,1,'��Ӱ˫ذ','��Ϳװ',500,4,'��������','3','ʷʫ'),
 (4,2,'��Ӱ˫ذ','������',800,4,'��������','4','��˵'),
 (4,3,'��Ӱ˫ذ','���֮��',600,4,'��������','4','��˵'),
 (4,4,'��Ӱ˫ذ','����֮ɫ',800,4,'��������','4','��˵')

 insert into item_type values
 (5,1,'USP������','��ʱ��',20,1,'��Ӱ����' ,'1','��ͨ'),
 (5,2,'USP������','ǹ������',200,1,'��Ӱ����' ,'3','ʷʫ'),
 (5,3,'USP������','�Զ���',50,1,'��Ӱ����' ,'2','ϡ��'),
 (5,4,'USP������','��ɫ��Ӱ',100,1,'��Ӱ����' ,'2','ϡ��')
 
 insert into item_type values
 (6,1,'�����18��','����',14,2,'��������' ,'1','��ͨ'),
 (6,2,'�����18��','������¹�',18,2,'��������' ,'1','��ͨ'),
 (6,3,'�����18��','ˮ��',70,2,'��������','2','ϡ��'),
 (6,4,'�����18��','����֮ɫ',2000,2,'��������' ,'3','ʷʫ')

   insert into item_type values
 (7,1,'R8����','��������',4,3,'ͻΧ����' ,'1','��ͨ'),
 (7,2,'R8����','��������',15,3,'ͻΧ����' ,'2','ϡ��'),
 (7,3,'R8����','���֮��',28,3,'ͻΧ����' ,'2','ϡ��'),
 (7,4,'R8����','����֮ɫ',26,3,'ͻΧ����' ,'2','ϡ��')

 insert into item_type values
 (8,1,'ɳĮ֮ӥ','��ͭװ��',5,4,'��������' ,'1','��ͨ'),
 (8,2,'ɳĮ֮ӥ','����籩',150,4,'��������' ,'2','ϡ��'),
 (8,3,'ɳĮ֮ӥ','���֮��',380,4,'��������' ,'3','ʷʫ'),
 (8,4,'ɳĮ֮ӥ','����֮��',760,4,'��������' ,'3','ʷʫ')

 insert into item_type values
 (9,1,'M4A4','����',100,1,'��Ӱ����' ,'2','ϡ��'),
 (9,2,'M4A4','����Ī��',400,1,'��Ӱ����' ,'3','ʷʫ'),
 (9,3,'M4A4','������',1400,1,'��Ӱ����' ,'3','ʷʫ'),
 (9,4,'M4A4','����',6000,1,'��Ӱ����' ,'4','��˵')
 
 insert into item_type values
 (10,1,'M4A1','������',80,2,'��������' ,'2','ϡ��'),
 (10,2,'M4A1','������˹����',300,2,'��������' ,'3','ʷʫ'),
 (10,3,'M4A1','��ŭҰ��',400,2,'��������' ,'3','ʷʫ'),
 (10,4,'M4A1','�������',500,2,'��������' ,'3','ʷʫ')

   insert into item_type values
 (11,1,'AK47','Ѫ���˶�',300,3,'ͻΧ����' ,'2','ϡ��'),
 (11,2,'AK47','������',500,3,'ͻΧ����' ,'3','ʷʫ'),
 (11,3,'AK47','�ʺ�',700,3,'ͻΧ����' ,'3','ʷʫ'),
 (11,4,'AK47','����Ī��',1000,3,'ͻΧ����' ,'3','ʷʫ')

 insert into item_type values
 (12,1,'AWP','��������',50,4,'��������' ,'2','ϡ��'),
 (12,2,'AWP','����Ī��',300,4,'��������' ,'3','ʷʫ'),
 (12,3,'AWP','��ɫ��Ӱ',400,4,'��������' ,'3','ʷʫ'),
 (12,4,'AWP','������˵',9000,4,'��������' ,'4','��˵')

  insert into item_type values
 (13,1,'UMP45','����',3,1,'��Ӱ����' ,'1','��ͨ'),
 (13,2,'UMP45','���ݻ�',50,1,'��Ӱ����' ,'2','ϡ��'),
 (13,3,'UMP45','����',55,1,'��Ӱ����' ,'2','ϡ��'),
 (13,4,'UMP45','����֮��',80,1,'��Ӱ����' ,'2','ϡ��')
 
 insert into item_type values
 (14,1,'P90','������',10,2,'��������' ,'1','��ͨ'),
 (14,2,'P90','����',30,2,'��������','1','��ͨ'),
 (14,3,'P90','����Ī��',150,2,'��������' ,'3','ʷʫ'),
 (14,4,'P90','��֮��ɱ',200,2,'��������' ,'3','ʷʫ')

 

 SELECT * FROM item_type
--�������
INSERT INTO deposit (savingName,descrip) VALUES ('����','������ս�����Ϣ')
INSERT INTO deposit (savingName,descrip) VALUES ('����һ��','�������1��')
INSERT INTO deposit (savingName,descrip) VALUES ('���ڶ���','�������2��')
INSERT INTO deposit (savingName,descrip) VALUES ('��������','�������3��')
INSERT INTO deposit (savingName) VALUES ('��������')
INSERT INTO deposit (savingName) VALUES ('֪ͨ')
INSERT INTO deposit (savingName,descrip) VALUES ('�����ȡһ��','�������1��')
INSERT INTO deposit (savingName,descrip) VALUES ('�����ȡ����','�������2��')
INSERT INTO deposit (savingName,descrip) VALUES ('�����ȡ����','�������3��')
INSERT INTO deposit (savingName,descrip) VALUES ('�汾ȡϢ����','����֧ȡ��Ϣ')
SELECT * FROM DEPOSIT

INSERT INTO userInfo(customerName,PID,telephone,address )
     VALUES('����','123456789012345','010-67898978','��������')
INSERT INTO cardInfo(cardID,savingID,openMoney,balance,customerID)
     VALUES('1010 3576 1234 5678',1,1000,1000,1)

INSERT INTO userInfo(customerName,PID,telephone)
     VALUES('����','321245678912345678','0478-44443333')
INSERT INTO cardInfo(cardID,savingID,openMoney,balance,customerID)
     VALUES('1010 3576 1212 1134',2,1,1,2)

INSERT INTO userInfo(customerName,PID,telephone)
     VALUES('����','567891234532124670','010-44443333')
INSERT INTO cardInfo(cardID,savingID,openMoney,balance,customerID)
     VALUES('1010 3576 1212 1130',2,1,1,3)

INSERT INTO userInfo(customerName,PID,telephone)
     VALUES('����','567891321242345618','0752-43345543')
INSERT INTO cardInfo(cardID,savingID,openMoney,balance,customerID)
     VALUES('1010 3576 1212 1004',2,1,1,4)

SELECT * FROM userInfo
SELECT * FROM cardInfo
GO

/*
�����Ŀ��ţ�1010 3576 1234 5678��ȡ��900Ԫ�����ĵĿ��ţ�1010 3576 1212 1134�����5000Ԫ��Ҫ�󱣴潻�׼�¼���Ա�ͻ���ѯ������ҵ��ͳ�ơ�
˵��������Ǯ��ȡǮ����300Ԫ��ʱ�򣬻���������Ϣ��tradeInfo�������һ�����׼�¼��
      ͬʱӦ�������п���Ϣ��cardInfo���е������������ӻ����300Ԫ��
*/
/*--------------������Ϣ����뽻�׼�¼--------------------------*/
INSERT INTO tradeInfo(tradeType,cardID,tradeMoney) 
      VALUES('֧ȡ','1010 3576 1234 5678',900)  
/*-------------�������п���Ϣ���е��������-------------------*/
UPDATE cardInfo SET balance=balance-900 WHERE cardID='1010 3576 1234 5678'

INSERT INTO tradeInfo(tradeType,cardID,tradeMoney) 
      VALUES('����','1010 3576 1212 1130',300)  
/*-------------�������п���Ϣ���е��������-------------------*/
UPDATE cardInfo SET balance=balance+300 WHERE cardID='010 3576 1212 1130'

INSERT INTO tradeInfo(tradeType,cardID,tradeMoney) 
      VALUES('����','1010 3576 1212 1004',1000)  
/*-------------�������п���Ϣ���е��������-------------------*/
UPDATE cardInfo SET balance=balance+1000 WHERE cardID='1010 3576 1212 1004'

INSERT INTO tradeInfo(tradeType,cardID,tradeMoney) 
      VALUES('֧ȡ','1010 3576 1212 1130',1900)  
/*-------------�������п���Ϣ���е��������-------------------*/
UPDATE cardInfo SET balance=balance+1900 WHERE cardID='010 3576 1212 1130'



/*--------------������Ϣ����뽻�׼�¼--------------------------*/
INSERT INTO tradeInfo(tradeType,cardID,tradeMoney) 
      VALUES('����','1010 3576 1212 1134',5000)   
/*-------------�������п���Ϣ���е��������-------------------*/
UPDATE cardInfo SET balance=balance+5000 WHERE cardID='1010 3576 1212 1134'
GO

/*--------�����������Ƿ���ȷ---------*/
SELECT * FROM cardInfo
SELECT * FROM tradeInfo

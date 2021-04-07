--存款类型
INSERT INTO deposit (savingName,descrip) VALUES ('活期','按存款日结算利息')
INSERT INTO deposit (savingName,descrip) VALUES ('定期一年','存款期是1年')
INSERT INTO deposit (savingName,descrip) VALUES ('定期二年','存款期是2年')
INSERT INTO deposit (savingName,descrip) VALUES ('定期三年','存款期是3年')
INSERT INTO deposit (savingName) VALUES ('定活两便')
INSERT INTO deposit (savingName) VALUES ('通知')
INSERT INTO deposit (savingName,descrip) VALUES ('零存整取一年','存款期是1年')
INSERT INTO deposit (savingName,descrip) VALUES ('零存整取二年','存款期是2年')
INSERT INTO deposit (savingName,descrip) VALUES ('零存整取三年','存款期是3年')
INSERT INTO deposit (savingName,descrip) VALUES ('存本取息五年','按月支取利息')
SELECT * FROM DEPOSIT

INSERT INTO userInfo(customerName,PID,telephone,address )
     VALUES('张三','123456789012345','010-67898978','北京海淀')
INSERT INTO cardInfo(cardID,savingID,openMoney,balance,customerID)
     VALUES('1010 3576 1234 5678',1,1000,1000,1)

INSERT INTO userInfo(customerName,PID,telephone)
     VALUES('李四','321245678912345678','0478-44443333')
INSERT INTO cardInfo(cardID,savingID,openMoney,balance,customerID)
     VALUES('1010 3576 1212 1134',2,1,1,2)

INSERT INTO userInfo(customerName,PID,telephone)
     VALUES('王五','567891234532124670','010-44443333')
INSERT INTO cardInfo(cardID,savingID,openMoney,balance,customerID)
     VALUES('1010 3576 1212 1130',2,1,1,3)

INSERT INTO userInfo(customerName,PID,telephone)
     VALUES('丁六','567891321242345618','0752-43345543')
INSERT INTO cardInfo(cardID,savingID,openMoney,balance,customerID)
     VALUES('1010 3576 1212 1004',2,1,1,4)

SELECT * FROM userInfo
SELECT * FROM cardInfo
GO

/*
张三的卡号（1010 3576 1234 5678）取款900元，李四的卡号（1010 3576 1212 1134）存款5000元，要求保存交易记录，以便客户查询和银行业务统计。
说明：当存钱或取钱（如300元）时候，会往交易信息表（tradeInfo）中添加一条交易记录，
      同时应更新银行卡信息表（cardInfo）中的现有余额（如增加或减少300元）
*/
/*--------------交易信息表插入交易记录--------------------------*/
INSERT INTO tradeInfo(tradeType,cardID,tradeMoney) 
      VALUES('支取','1010 3576 1234 5678',900)  
/*-------------更新银行卡信息表中的现有余额-------------------*/
UPDATE cardInfo SET balance=balance-900 WHERE cardID='1010 3576 1234 5678'

INSERT INTO tradeInfo(tradeType,cardID,tradeMoney) 
      VALUES('存入','1010 3576 1212 1130',300)  
/*-------------更新银行卡信息表中的现有余额-------------------*/
UPDATE cardInfo SET balance=balance+300 WHERE cardID='010 3576 1212 1130'

INSERT INTO tradeInfo(tradeType,cardID,tradeMoney) 
      VALUES('存入','1010 3576 1212 1004',1000)  
/*-------------更新银行卡信息表中的现有余额-------------------*/
UPDATE cardInfo SET balance=balance+1000 WHERE cardID='1010 3576 1212 1004'

INSERT INTO tradeInfo(tradeType,cardID,tradeMoney) 
      VALUES('支取','1010 3576 1212 1130',1900)  
/*-------------更新银行卡信息表中的现有余额-------------------*/
UPDATE cardInfo SET balance=balance+1900 WHERE cardID='010 3576 1212 1130'



/*--------------交易信息表插入交易记录--------------------------*/
INSERT INTO tradeInfo(tradeType,cardID,tradeMoney) 
      VALUES('存入','1010 3576 1212 1134',5000)   
/*-------------更新银行卡信息表中的现有余额-------------------*/
UPDATE cardInfo SET balance=balance+5000 WHERE cardID='1010 3576 1212 1134'
GO

/*--------检查测试数据是否正确---------*/
SELECT * FROM cardInfo
SELECT * FROM tradeInfo

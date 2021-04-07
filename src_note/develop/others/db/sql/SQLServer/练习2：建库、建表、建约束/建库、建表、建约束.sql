--创建建库bankDB
CREATE DATABASE bankDB
 ON
 (
  NAME='bankDB_data',
  FILENAME='d:\project\bankDB_data.mdf',
  SIZE=3mb,
  FILEGROWTH=15%
 )
 LOG ON
 (
  NAME= 'bankDB_log',
  FILENAME='d:\project\bankDB_log.ldf',
  SIZE=3mb,
  FILEGROWTH=15%
 )
GO
/*$$$$$$$$$$$$$建表$$$$$$$$$$$$$$$$$$$$$$$$*/

USE bankDB
GO

CREATE TABLE userInfo  --用户信息表
(
  customerID INT IDENTITY(1,1),
  customerName CHAR(8) NOT NULL,
  PID CHAR(18) NOT NULL,
  telephone CHAR(20) NOT NULL,
  address VARCHAR(50)
)
GO

CREATE TABLE cardInfo  --银行卡信息表
(
  cardID  CHAR(19) NOT NULL,
  curID  VARCHAR(10) NOT NULL,
  savingID INT NOT NULL,
  openDate  DATETIME NOT NULL,
  openMoney  MONEY NOT NULL,
  balance  MONEY NOT NULL,
  pass CHAR(6) NOT NULL,
  IsReportLoss BIT  NOT NULL,
  customerID INT NOT NULL
)
GO

CREATE TABLE tradeInfo  --交易信息表
(
  tradeDate  DATETIME NOT NULL,
  tradeType  CHAR(4) NOT NULL,
  cardID  CHAR(19) NOT NULL,
  tradeMoney  MONEY NOT NULL,
  remark  TEXT   
)
GO

CREATE TABLE Deposit  --存款类型表
(
  savingID  INT  IDENTITY(1,1),
  savingName  VARCHAR(20) NOT NULL,
  descrip VARCHAR(50)
)
GO

/*$$$$$$$$$$$$$加约束$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$*/
ALTER TABLE Deposit
  ADD CONSTRAINT  PK_savingID   PRIMARY KEY(savingID)
GO
/* userInfo表的约束
customerID	顾客编号	自动编号（标识列），从1开始，主键
customerName	开户名	必填
PID	身份证号	必填，只能是18位或15位，身份证号唯一约束
telephone	联系电话	必填，格式为xxxx-xxxxxxxx或手机号13位
address	居住地址	可选输入
*/
ALTER TABLE userInfo
  ADD CONSTRAINT PK_customerID PRIMARY KEY(customerID),
      CONSTRAINT CK_PID CHECK( len(PID)=18 or len(PID)=15 ),
      CONSTRAINT UQ_PID UNIQUE(PID),
      --CONSTRAINT CK_telephone CHECK( telephone like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or telephone like '[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or len(telephone)=13 )
      CONSTRAINT CK_telephone CHECK( telephone like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or telephone like '[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or telephone like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' )
GO

/*cardInfo表的约束
cardID	卡号	必填，主健 , 银行的卡号规则和电话号码一样，一般前8位代表特殊含义，
        如某总行某支行等。假定该行要求其营业厅的卡号格式为：1010 3576 xxxx xxx开始
curType	货币	必填，默认为RMB
savingType	存款种类	活期/定活两便/定期
openDate	开户日期	必填，默认为系统当前日期
openMoney	开户金额	必填，不低于1元
balance	余额	必填，不低于1元,否则将销户
pass	密码	必填，6位数字，默认为6个8
IsReportLoss	是否挂失  必填，是/否值，默认为”否”
customerID	顾客编号	必填，表示该卡对应的顾客编号，一位顾客可以办理多张卡
*/
ALTER TABLE cardInfo     
  ADD CONSTRAINT  PK_cardID  PRIMARY KEY(cardID),
      CONSTRAINT  CK_cardID  CHECK(cardID LIKE '1010 3576 [0-9][0-9][0-9][0-9] [0-9][0-9][0-9][0-9]'),
      CONSTRAINT  DF_curID  DEFAULT('RMB') FOR curID, 
      --CONSTRAINT  CK_savingType  CHECK(savingType IN ('活期','定活两便','定期')),
      CONSTRAINT  DF_openDate  DEFAULT(getdate()) FOR openDate,
      CONSTRAINT  CK_openMoney  CHECK(openMoney>=1),
      CONSTRAINT  CK_balance  CHECK(balance>=1),
      CONSTRAINT  CK_pass  CHECK(pass LIKE '[0-9][0-9][0-9][0-9][0-9][0-9]'),
      CONSTRAINT  DF_pass  DEFAULT('888888') FOR pass,
      CONSTRAINT  DF_IsReportLoss DEFAULT(0) FOR IsReportLoss,
      CONSTRAINT  FK_customerID FOREIGN KEY(customerID) REFERENCES userInfo(customerID),
	  CONSTRAINT  FK_savingID  FOREIGN KEY(savingID) REFERENCES deposit(savingID)
GO

/* tradeInfo表的约束
tradeType       必填，只能是存入/支取 
cardID	卡号	必填，外健，可重复索引
tradeMoney	交易金额	必填，大于0
tradeDate	交易日期	必填，默认为系统当前日期
remark	备注	可选输入，其他说明
*/

ALTER TABLE tradeInfo
  ADD CONSTRAINT  CK_tradeType  CHECK(tradeType IN ('存入','支取')),
      CONSTRAINT  FK_cardID  FOREIGN KEY(cardID) REFERENCES cardInfo(cardID),
      CONSTRAINT  CK_tradeMoney  CHECK(tradeMoney>0),
      CONSTRAINT  DF_tradeDATE DEFAULT(getdate()) FOR tradeDate
GO
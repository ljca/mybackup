--��������bankDB
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
/*$$$$$$$$$$$$$����$$$$$$$$$$$$$$$$$$$$$$$$*/

USE bankDB
GO

CREATE TABLE userInfo  --�û���Ϣ��
(
  customerID INT IDENTITY(1,1),
  customerName CHAR(8) NOT NULL,
  PID CHAR(18) NOT NULL,
  telephone CHAR(20) NOT NULL,
  address VARCHAR(50)
)
GO

CREATE TABLE cardInfo  --���п���Ϣ��
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

CREATE TABLE tradeInfo  --������Ϣ��
(
  tradeDate  DATETIME NOT NULL,
  tradeType  CHAR(4) NOT NULL,
  cardID  CHAR(19) NOT NULL,
  tradeMoney  MONEY NOT NULL,
  remark  TEXT   
)
GO

CREATE TABLE Deposit  --������ͱ�
(
  savingID  INT  IDENTITY(1,1),
  savingName  VARCHAR(20) NOT NULL,
  descrip VARCHAR(50)
)
GO

/*$$$$$$$$$$$$$��Լ��$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$*/
ALTER TABLE Deposit
  ADD CONSTRAINT  PK_savingID   PRIMARY KEY(savingID)
GO
/* userInfo���Լ��
customerID	�˿ͱ��	�Զ���ţ���ʶ�У�����1��ʼ������
customerName	������	����
PID	���֤��	���ֻ����18λ��15λ�����֤��ΨһԼ��
telephone	��ϵ�绰	�����ʽΪxxxx-xxxxxxxx���ֻ���13λ
address	��ס��ַ	��ѡ����
*/
ALTER TABLE userInfo
  ADD CONSTRAINT PK_customerID PRIMARY KEY(customerID),
      CONSTRAINT CK_PID CHECK( len(PID)=18 or len(PID)=15 ),
      CONSTRAINT UQ_PID UNIQUE(PID),
      --CONSTRAINT CK_telephone CHECK( telephone like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or telephone like '[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or len(telephone)=13 )
      CONSTRAINT CK_telephone CHECK( telephone like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or telephone like '[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or telephone like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' )
GO

/*cardInfo���Լ��
cardID	����	������� , ���еĿ��Ź���͵绰����һ����һ��ǰ8λ�������⺬�壬
        ��ĳ����ĳ֧�еȡ��ٶ�����Ҫ����Ӫҵ���Ŀ��Ÿ�ʽΪ��1010 3576 xxxx xxx��ʼ
curType	����	���Ĭ��ΪRMB
savingType	�������	����/��������/����
openDate	��������	���Ĭ��Ϊϵͳ��ǰ����
openMoney	�������	���������1Ԫ
balance	���	���������1Ԫ,��������
pass	����	���6λ���֣�Ĭ��Ϊ6��8
IsReportLoss	�Ƿ��ʧ  �����/��ֵ��Ĭ��Ϊ����
customerID	�˿ͱ��	�����ʾ�ÿ���Ӧ�Ĺ˿ͱ�ţ�һλ�˿Ϳ��԰�����ſ�
*/
ALTER TABLE cardInfo     
  ADD CONSTRAINT  PK_cardID  PRIMARY KEY(cardID),
      CONSTRAINT  CK_cardID  CHECK(cardID LIKE '1010 3576 [0-9][0-9][0-9][0-9] [0-9][0-9][0-9][0-9]'),
      CONSTRAINT  DF_curID  DEFAULT('RMB') FOR curID, 
      --CONSTRAINT  CK_savingType  CHECK(savingType IN ('����','��������','����')),
      CONSTRAINT  DF_openDate  DEFAULT(getdate()) FOR openDate,
      CONSTRAINT  CK_openMoney  CHECK(openMoney>=1),
      CONSTRAINT  CK_balance  CHECK(balance>=1),
      CONSTRAINT  CK_pass  CHECK(pass LIKE '[0-9][0-9][0-9][0-9][0-9][0-9]'),
      CONSTRAINT  DF_pass  DEFAULT('888888') FOR pass,
      CONSTRAINT  DF_IsReportLoss DEFAULT(0) FOR IsReportLoss,
      CONSTRAINT  FK_customerID FOREIGN KEY(customerID) REFERENCES userInfo(customerID),
	  CONSTRAINT  FK_savingID  FOREIGN KEY(savingID) REFERENCES deposit(savingID)
GO

/* tradeInfo���Լ��
tradeType       ���ֻ���Ǵ���/֧ȡ 
cardID	����	����⽡�����ظ�����
tradeMoney	���׽��	�������0
tradeDate	��������	���Ĭ��Ϊϵͳ��ǰ����
remark	��ע	��ѡ���룬����˵��
*/

ALTER TABLE tradeInfo
  ADD CONSTRAINT  CK_tradeType  CHECK(tradeType IN ('����','֧ȡ')),
      CONSTRAINT  FK_cardID  FOREIGN KEY(cardID) REFERENCES cardInfo(cardID),
      CONSTRAINT  CK_tradeMoney  CHECK(tradeMoney>0),
      CONSTRAINT  DF_tradeDATE DEFAULT(getdate()) FOR tradeDate
GO
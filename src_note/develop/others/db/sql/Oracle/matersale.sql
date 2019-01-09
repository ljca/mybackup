prompt PL/SQL Developer import file
prompt Created on 2016年5月25日 星期三 by kyzs
set feedback off
set define off
prompt Creating CUS_CUSTOMER...
create table CUS_CUSTOMER
(
  id       NUMBER not null,
  cus_id   NUMBER not null,
  cus_name NVARCHAR2(100) not null,
  cus_addr NVARCHAR2(500)
)
tablespace PROJECT
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    minextents 1
    maxextents unlimited
  );
alter table CUS_CUSTOMER
  add constraint PK_CUS_ID primary key (ID, CUS_ID)
  using index 
  tablespace PROJECT
  pctfree 10
  initrans 2
  maxtrans 255;

prompt Disabling triggers for CUS_CUSTOMER...
alter table CUS_CUSTOMER disable all triggers;
prompt Deleting CUS_CUSTOMER...
delete from CUS_CUSTOMER;
commit;
prompt Loading CUS_CUSTOMER...
prompt Table is empty
prompt Enabling triggers for CUS_CUSTOMER...
alter table CUS_CUSTOMER enable all triggers;
set feedback on
set define on
prompt Done.

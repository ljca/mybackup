
create or replace procedure usr_proc_test
(v_user_name out nvarchar(30))
is
begin
  select lower(user) into v_user_name from v$instance;
  dbms_output.put_line('用户名'||v_user_name);
end;

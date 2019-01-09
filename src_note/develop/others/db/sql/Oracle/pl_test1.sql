declare
test_number number := 0;
begin
select sal into test_number from Scott.emp where empno = 7369;
if test_number >= 200 then
dbms_output.put_line('该用户工资'||test_number||'大于200');
else
 dbms_output.put_line('该用户工资'||test_number||'小于200了');
end if;
end;
/

declare
test_number number := 0;
begin
select sal into test_number from Scott.emp where empno = 7369;
if test_number >= 200 then
dbms_output.put_line('���û�����'||test_number||'����200');
else
 dbms_output.put_line('���û�����'||test_number||'С��200��');
end if;
end;
/

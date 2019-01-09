declare
test_number number := 1;
begin
while test_number <=100
loop
test_number := test_number+5;
dbms_output.put_line('test_nuberÖµÎª£º'||test_number);
end loop;
end;
/

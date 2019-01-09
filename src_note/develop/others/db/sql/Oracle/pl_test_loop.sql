declare
tmp_number number := 0;
on_number number := 16;
begin
loop
tmp_number := on_number+tmp_number;
exit when tmp_number > 50
;
end loop;
dbms_output.put_line('最后结果：'||tmp_number);
end;
/

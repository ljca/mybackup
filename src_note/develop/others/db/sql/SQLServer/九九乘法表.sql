declare @num int
declare @sum int
set @num = 1
while(@num <=9)
begin
set @sum = 1
	while(@sum <=@num)
		begin
		 print convert(varchar(3),@sum)+'¡Á'+convert(varchar(3),@num)+'='+convert(varchar(3),(@sum*@num))
		 set @sum += 1
		end
set @num += 1
end
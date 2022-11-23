@echo off
diskpart
list disk
select disk 1
select partition 1
assign letter=M
select disk 0
list partition 
list volume
select partition 4
assign letter=G
select partition 5
assign letter=I
list volume
pause
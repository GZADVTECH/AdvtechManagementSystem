/*
序列号信息查询
*/
drop proc pro_select_serial
go
create procedure pro_select_serial
@serid nvarchar(20)=null
as
begin
if(@serid is not null)
select * from serial where serid=@serid
else
select * from serial where serstatus=1
end
go
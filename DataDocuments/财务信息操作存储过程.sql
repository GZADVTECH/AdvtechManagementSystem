--财务信息插入存储过程
drop proc pro_insert_finance
go
create procedure pro_insert_finance
@finpurchase int,
@finstatus bit=0,
@finremark nvarchar(255)=null
as
begin
insert into finance values(@finpurchase,@finstatus,@finremark)
end
go

--财务信息更改存储过程
drop proc pro_update_finance
go
create procedure pro_update_finance
@finid int,
@finpurchase int=null,
@finstatus bit=null,
@finremark nvarchar(255)=null
as
begin
if(@finpurchase is not null)
update finance set finpurchase=@finpurchase where finid=@finid
if(@finstatus is not null)
update finance set finstatus=@finstatus where finid=@finid
if(@finremark is not null)
update finance set finremark=@finremark where finid=@finid
end
go

--财务信息删除存储过程
drop proc pro_delete_finance
go
create procedure pro_delete_finance
@finid int
as
begin
delete finance where finid=@finid
end
go
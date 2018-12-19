--退货信息插入存储过程
drop proc pro_insert_rejected
go
create procedure pro_insert_rejected
@rejname nvarchar(100),
@rejreason nvarchar(255)=null,
@rejtime datetime=null,
@rejremark nvarchar(255)=null,
@rejstatus bit=0
as
begin
insert into rejected values(@rejname,@rejreason,@rejtime,@rejremark,@rejstatus)
end
go

--退货信息更改存储过程
drop proc pro_update_rejected
go
create procedure pro_update_rejected
@rejid int,
@rejname nvarchar(100),
@rejreason nvarchar(255)=null,
@rejtime datetime=null,
@rejremark nvarchar(255)=null
as
begin
if(@rejname is not null)
update rejected set rejname=@rejname where rejid=@rejid
if(@rejreason is not null)
update rejected set rejreason=@rejreason where rejid=@rejid
if(@rejtime is not null)
update rejected set rejtime=@rejtime where rejid=@rejid
if(@rejremark is not null)
update rejected set rejremark=@rejremark where rejid=@rejid
end
go

--退货信息删除储存过程
drop proc pro_delete_rejected
go
create procedure pro_delete_rejected
@rejid int
as
begin
update rejected set rejstatus=1 where rejid=@rejid
end
go
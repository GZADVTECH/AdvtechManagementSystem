--序列号信息插入存储过程
drop proc pro_insert_serial
go
create procedure pro_insert_serial
@serid int,
@sersnid nvarchar(30),
@serstatus bit=1,
@serremark nvarchar(255)=null
as
begin
insert into serial values(@serid,@sersnid,@serstatus,@serremark)
if(@@ERROR=0)
insert into serialrecord values(@sersnid,'录入',GETDATE())
end
go

--序列号信息更改存储过程
drop proc pro_update_serial
go
create procedure pro_update_serial
@serid int=null,
@sersnid nvarchar(30)=null,
@serremark nvarchar(255)=null
as
begin
if(@serremark is not null)
update serial set serremark=@serremark where serid=@serid and sersnid=@sersnid
end
go

--序列号信息删除存储过程
drop proc pro_delete_serial
go
create procedure pro_delete_serial
@serid int,
@sersnid nvarchar(30)=null,
@serstatus bit=null
as
begin
if(@serstatus is not null)
update serial set serstatus=@serstatus where serid=@serid and sersnid=@sersnid
if(@@ERROR=0)
insert into serialrecord values(@sersnid,'售出',GETDATE())
end
go
--序列号信息插入存储过程
drop proc pro_insert_serial
go
create procedure pro_insert_serial
@sersnid nvarchar(30),
@serstatus bit=1,
@serremark nvarchar(255)=null
as
begin
insert into serial values(@sersnid,@serstatus,@serremark)
end
go

--序列号信息更改存储过程
drop proc pro_update_serial
go
create procedure pro_update_serial
@serid int,
@sersnid nvarchar(30)=null,
@serstatus bit=null,
@serremark nvarchar(255)=null
as
begin
if(@sersnid is not null)
update serial set sersnid=@sersnid where serid=@serid
if(@serstatus is not null)
update serial set serstatus=@serstatus where serid=@serid
if(@serremark is not null)
update serial set serremark=@serremark where serid=@serid
end
go

--序列号信息删除存储过程
drop proc pro_delete_serial
go
create procedure pro_delete_serial
@serid int
as
begin
delete serial where serid=@serid
end
go
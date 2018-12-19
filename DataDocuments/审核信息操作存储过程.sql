--审核信息插入存储过程
drop proc pro_insert_auditing
go
create procedure pro_insert_auditing
@audpurchase int,
@auduser int,
@audstatus bit=0,
@audremark nvarchar(255)=null
as
begin
insert into auditing values(@audpurchase,@auduser,@audstatus,@audremark)
end
go

--审核信息更改存储过程
drop proc pro_update_auditing
go
create procedure pro_update_auditing
@audid int,
@audpurchase int,
@auduser int,
@audstatus bit=null,
@audremark nvarchar(255)=null
as
begin
if(@audpurchase is not null)
update auditing set audpurchase=@audpurchase where audid=@audid
if(@auduser is not null)
update auditing set auduser=@auduser where audid=@audid
if(@auduser is not null)
update auditing set auduser=@auduser where audid=@audid
if(@audstatus is not null)
update auditing set audstatus=@audstatus where audid=@audid
if(@audremark is not null)
update auditing set audremark=@audremark where audid=@audid
end
go

--审核信息删除存储过程
drop proc pro_delete_auditing
go
create procedure pro_delete_auditing
@audid int
as
begin
delete auditing where audid=@audid
end
go
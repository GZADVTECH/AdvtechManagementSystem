--销售商信息插入存储过程
drop proc pro_insert_customerinfo
go
create procedure pro_insert_customerinfo
@customname nvarchar(100),
@custompeople nvarchar(20)=null,
@customcontact nvarchar(25)=null,
@customaddress nvarchar(255)=null,
@customremark nvarchar(255)=null,
@customstatus bit=1
as
begin
insert into customerinfo values(@customname,@custompeople,@customcontact,@customaddress,@customremark,@customstatus)
end
go

--销售商信息更改存储过程
drop proc pro_update_customerinfo
go
create procedure pro_update_customerinfo
@customid int,
@customname nvarchar(100)=null,
@custompeople nvarchar(20)=null,
@customcontact nvarchar(25)=null,
@customaddress nvarchar(255)=null,
@customremark nvarchar(255)=null
as
begin
if(@customname is not null)
update customerinfo set customname=@customname where customid=@customid
if(@custompeople is not null)
update customerinfo set custompeople=@custompeople where customid=@customid
if(@customcontact is not null)
update customerinfo set customcontact=@customcontact where customid=@customid
if(@customaddress is not null)
update customerinfo set customaddress=@customaddress where customid=@customid
if(@customremark is not null)
update customerinfo set customremark=@customremark where customid=@customid
end
go

--销售商信息删除存储过程
drop proc pro_delete_customerinfo
go
create procedure pro_delete_customerinfo
@customid int
as
begin
update customerinfo set customstatus=0 where customid=@customid
end
go
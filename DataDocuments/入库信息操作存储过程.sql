--入库信息插入存储过程
drop proc pro_insert_warehousing
go
create procedure pro_insert_warehousing
@wareuserid int,
@wareprice money,
@waretotalprice money,
@waretime datetime,
@wareware nvarchar(20),
@wareremark nvarchar(255)=null,
@warestatus bit=0
as
begin
insert into warehousing values(@wareuserid,@wareprice,@waretotalprice,@waretime,@wareware,@wareremark,@warestatus)
end
go

--入库信息更改存储过程
drop proc pro_update_warehousing
go
create procedure pro_update_warehousing
@wareid int,
@wareuserid int=null,
@wareprice money=null,
@waretotalprice money=null,
@waretime datetime=null,
@wareware nvarchar(20)=null,
@wareremark nvarchar(255)=null
as
begin
if(@wareuserid is not null)
update warehousing set wareuserid=@wareuserid where wareid=@wareid
if(@wareprice is not null)
update warehousing set wareprice=@wareprice where wareid=@wareid
if(@waretotalprice is not null)
update warehousing set waretotalprice=@waretotalprice where wareid=@wareid
if(@waretime is not null)
update warehousing set waretime=@waretime where wareid=@wareid
if(@wareware is not null)
update warehousing set wareware=@wareware where wareid=@wareid
if(@wareremark is not null)
update warehousing set wareremark=@wareremark where wareid=@wareid
end
go

--入库信息删除存储过程
drop proc pro_delete_warehousing
go
create procedure pro_delete_warehousing
@wareid int
as
begin
update warehousing set warestatus=1 where wareid=@wareid
end
go
--出库信息插入存储过程
drop proc pro_insert_delivery
go
create procedure pro_insert_delivery
@deluserid int,
@delamount int=null,
@delprice money=null,
@deltotalprice money=null,
@deltime datetime=null,
@delremark nvarchar(255)=null,
@delstatus bit=0
as
begin
insert into delivery values(@deluserid,@delamount,@delprice,@deltotalprice,@deltime,@delremark,@delstatus)
end
go

--出库信息更改存储过程
drop proc pro_update_delivery
go
create procedure pro_update_delivery
@delid int,
@deluserid int=null,
@delamount int=null,
@delprice money=null,
@deltotalprice money=null,
@deltime datetime=null,
@delremark nvarchar(255)=null
as
begin
if(@deluserid is not null)
update delivery set deluserid=@deluserid where delid=@delid
if(@delamount is not null)
update delivery set delamount=@delamount where delid=@delid
if(@delprice is not null)
update delivery set delprice=@delprice where delid=@delid
if(@deltotalprice is not null)
update delivery set deltotalprice=@deltotalprice where delid=@delid
if(@deltime is not null)
update delivery set deltime=@deltime where delid=@delid
if(@delremark is not null)
update delivery set delremark=@delremark where delid=@delid
end
go

--出库信息删除存储过程
drop proc pro_delete_delivery
go
create procedure pro_delete_delivery
@delid int
as
begin
update delivery set delstatus=1 where delid=@delid
end
go
--采购信息插入存储过程
drop proc pro_insert_purchase
go
create procedure pro_insert_purchase
@purinternal nvarchar(30)=null,
@purofficial nvarchar(30)=null,
@purcargo nvarchar(20)=null,
@puramount int=null,
@purmatch bit=0,
@purinvoice bit=0,
@purtotalprice money=null,
@purtime datetime=null,
@purstatus bit=0,
@purremark nvarchar(255)=null
as
begin
insert into purchase values(@purinternal,@purofficial,@purcargo,@puramount,@purmatch,@purinvoice,@purtotalprice,@purtime,@purstatus,@purremark)
end
go

--采购信息更改存储过程
drop proc pro_update_purchase
go
create procedure pro_update_purchase
@purid int,
@purinternal nvarchar(30)=null,
@purofficial nvarchar(30)=null,
@purcargo nvarchar(20)=null,
@puramount int=null,
@purmatch bit=null,
@purinvoice bit=null,
@purtotalprice money=null,
@purtime datetime=null,
@purstatus bit=null,
@purremark nvarchar(255)=null
as
begin
if(@purinternal is not null)
update purchase set purinternal=@purinternal where purid=@purid
if(@purofficial is not null)
update purchase set purofficial=@purofficial where purid=@purid
if(@purcargo is not null)
update purchase set purcargo=@purcargo where purid=@purid
if(@puramount is not null)
update purchase set puramount=@puramount where purid=@purid
if(@purmatch is not null)
update purchase set purmatch=@purmatch where purid=@purid
if(@purinvoice is not null)
update purchase set purinvoice=@purinvoice where purid=@purid
if(@purtotalprice is not null)
update purchase set purtotalprice=@purtotalprice where purid=@purid
if(@purtime is not null)
update purchase set purtime=@purtime where purid=@purid
if(@purstatus is not null)
update purchase set purstatus=@purstatus where purid=@purid
if(@purremark is not null)
update purchase set purremark=@purremark where purid=@purid
end
go

--采购信息删除存储过程
drop proc pro_delete_purchase
go
create procedure pro_delete_purchase
@purid int
as
begin
delete purchase where purid=@purid
end
go
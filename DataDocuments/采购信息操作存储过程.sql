--采购信息插入存储过程
drop proc pro_insert_purchase
go
create procedure pro_insert_purchase
@purinternal nvarchar(30)=null,
@purofficial nvarchar(30)=null,
@purcargo int=null,
@paramount int=null,
@parmatch bit=0,
@parinvoice bit=0,
@partotalprice money=null,
@partime datetime=null,
@parstatus bit=0,
@parremark nvarchar(255)=null
as
begin
insert into purchase values(@purinternal,@purofficial,@purcargo,@paramount,@parmatch,@parinvoice,@partotalprice,@partime,@parstatus,@parremark)
end
go

--采购信息更改存储过程
drop proc pro_update_purchase
go
create procedure pro_update_purchase
@purid int,
@purinternal nvarchar(30)=null,
@purofficial nvarchar(30)=null,
@purcargo int=null,
@paramount int=null,
@parmatch bit=null,
@parinvoice bit=null,
@partotalprice money=null,
@partime datetime=null,
@parstatus bit=null,
@parremark nvarchar(255)=null
as
begin
if(@purinternal is not null)
update purchase set purinternal=@purinternal where purid=@purid
if(@purofficial is not null)
update purchase set purofficial=@purofficial where purid=@purid
if(@purcargo is not null)
update purchase set purcargo=@purcargo where purid=@purid
if(@paramount is not null)
update purchase set paramount=@paramount where purid=@purid
if(@parmatch is not null)
update purchase set parmatch=@parmatch where purid=@purid
if(@parinvoice is not null)
update purchase set parinvoice=@parinvoice where purid=@purid
if(@partotalprice is not null)
update purchase set partotalprice=@partotalprice where purid=@purid
if(@partime is not null)
update purchase set partime=@partime where purid=@purid
if(@parstatus is not null)
update purchase set parstatus=@parstatus where purid=@purid
if(@parremark is not null)
update purchase set parremark=@parremark where purid=@purid
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
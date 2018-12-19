--货物信息插入存储过程
drop proc pro_insert_cargoinfo
go
create procedure pro_insert_cargoinfo
@cargoname nvarchar(50),
@cargomodal nvarchar(50),
@cargoamount int=null,
@cargopurchase money=null,
@cargosale money=null,
@cargoware nvarchar(20)=null,
@cargounit char=null,
@cargotime datetime=null,
@cargoremark nvarchar(255)=null,
@cargostatus bit=1
as
begin
insert into cargoinfo values(@cargoname,@cargomodal,@cargoamount,@cargopurchase,@cargosale,@cargoware,@cargounit,@cargotime,@cargoremark,@cargostatus)
end
go

--货物信息更改存储过程
drop proc pro_update_cargoinfo
go
create procedure pro_update_cargoinfo
@cargoid int,
@cargoname nvarchar(50)=null,
@cargomodal nvarchar(50)=null,
@cargoamount int=null,
@cargopurchase money=null,
@cargosale money=null,
@cargoware nvarchar(20)=null,
@cargounit char=null,
@cargotime datetime=null,
@cargoremark nvarchar(255)=null
as
begin
if(@cargoname is not null)
update cargoinfo set cargoname=@cargoname where cargoid=@cargoid
if(@cargomodal is not null)
update cargoinfo set cargomodal=@cargomodal where cargoid=@cargoid
if(@cargoamount is not null)
update cargoinfo set cargoamount=@cargoamount where cargoid=@cargoid
if(@cargopurchase is not null)
update cargoinfo set cargopurchase=@cargopurchase where cargoid=@cargoid
if(@cargosale is not null)
update cargoinfo set cargosale=@cargosale where cargoid=@cargoid
if(@cargoware is not null)
update cargoinfo set cargoware=@cargoware where cargoid=@cargoid
if(@cargounit is not null)
update cargoinfo set cargounit=@cargounit where cargoid=@cargoid
if(@cargotime is not null)
update cargoinfo set cargotime=@cargotime where cargoid=@cargoid
if(@cargoremark is not null)
update cargoinfo set cargoremark=@cargoremark where cargoid=@cargoid
end
go

--货物信息删除存储过程
drop proc pro_delete_cargoinfo
go
create procedure pro_delete_cargoinfo
@cargoid int
as
begin
update cargoinfo set caregostatus=0 where cargoid=@cargoid
end
go
--用户信息插入数据
drop proc pro_insert_userinfo
go
create procedure pro_insert_userinfo
@username nvarchar(30),
@userpwd nvarchar(max),
@usergender bit=0,
@userbirth datetime=null,
@userdepart nvarchar(20)='',
@userpost nvarchar(20)='',
@usercontact nvarchar(25)='',
@useraddress nvarchar(255)='',
@userremark nvarchar(255)='',
@userstatus bit=1,
@userpower int
as
begin
insert into userinfo values(@username, @userpwd, @usergender, @userbirth, @userdepart, @userpost, @usercontact, @useraddress, @userremark,@userstatus,@userpower)
end
go
exec pro_insert_userinfo '吴守文','E1ADC3949BA59ABBE56E057F2F883E',0,'1987-08-01','管理部','总经理','13049827283','广州市天河区壬丰大厦2211A室','',1,1
go
--用户信息更改信息
drop proc pro_update_userinfo
go
create procedure pro_update_userinfo
@userid int=null,
@username nvarchar(30)=null,
@userpwd nvarchar(max)=null,
@usergender bit=null,
@userbirth datetime=null,
@userdepart nvarchar(20)=null,
@userpost nvarchar(20)=null,
@usercontact nvarchar(25)=null,
@useraddress nvarchar(255)=null,
@userremark nvarchar(255)=null,
@userstatus bit=null,
@userpower int=null
as
begin
if(@username is not null)
begin
update userinfo set username=@username where userid=@userid or username=@username
end
if(@userpwd is not null)
begin
update userinfo set userpwd=@userpwd where userid=@userid or username=@username
end
if(@usergender is not null)
begin
update userinfo set usergender=@usergender where userid=@userid or username=@username
end
if(@userbirth is not null)
begin
update userinfo set userbirth=@userbirth where userid=@userid or username=@username
end
if(@userdepart is not null)
begin
update userinfo set userdepart=@userdepart where userid=@userid or username=@username
end
if(@userpost is not null)
begin
update userinfo set userpost=@userpost where userid=@userid or username=@username
end
if(@usercontact is not null)
begin
update userinfo set usercontact=@usercontact where userid=@userid or username=@username
end
if(@useraddress is not null)
begin
update userinfo set useraddress=@useraddress where userid=@userid or username=@username
end
if(@userremark is not null)
begin
update userinfo set userremark=@userremark where userid=@userid or username=@username
end
if(@userpower is not null)
begin
update userinfo set userpower=@userpower where userid=@userid or username=@username
end
end
go

--用户信息删除数据
drop proc pro_delete_userinfo
go
create procedure pro_delete_userinfo
@userid int
as
begin
update userinfo set userstatus=0 where userid=@userid
end
go


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
@userstatus bit=1
as
begin
insert into userinfo values(@username, @userpwd, @usergender, @userbirth, @userdepart, @userpost, @usercontact, @useraddress, @userremark,@userstatus)
end
go

--用户信息更改信息
drop proc pro_update_userinfo
go
create procedure pro_update_userinfo
@userid int,
@username nvarchar(30)=null,
@userpwd nvarchar(max)=null,
@usergender bit=null,
@userbirth datetime=null,
@userdepart nvarchar(20)=null,
@userpost nvarchar(20)=null,
@usercontact nvarchar(25)=null,
@useraddress nvarchar(255)=null,
@userremark nvarchar(255)=null,
@userstatus bit=null
as
begin
if(@username is not null)
begin
update userinfo set username=@username where userid=@userid
end
if(@userpwd is not null)
begin
update userinfo set userpwd=@userpwd where userid=@userid
end
if(@usergender is not null)
begin
update userinfo set usergender=@usergender where userid=@userid
end
if(@userbirth is not null)
begin
update userinfo set userbirth=@userbirth where userid=@userid
end
if(@userdepart is not null)
begin
update userinfo set userdepart=@userdepart where userid=@userid
end
if(@userpost is not null)
begin
update userinfo set userpost=@userpost where userid=@userid
end
if(@usercontact is not null)
begin
update userinfo set usercontact=@usercontact where userid=@userid
end
if(@useraddress is not null)
begin
update userinfo set useraddress=@useraddress where userid=@userid
end
if(@userremark is not null)
begin
update userinfo set userremark=@userremark where userid=@userid
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


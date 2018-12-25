/*
用户信息查询
*/
drop proc pro_select_userinfo_contains
go
create procedure pro_select_userinfo_contains
@username nvarchar(30),
@userpwd nvarchar(max)
as
begin
select distinct userid,username,usergender,userremark,userpower from userinfo where username=@username and userpwd=@userpwd and userstatus=1
end
go
/*
用户详细查询
*/
drop view view_userinfo
go
create view view_userinfo
as
select userid,username,usergender,userbirth,userdepart,userpost,usercontact,useraddress,userremark,userpower from userinfo where userstatus=1
go

/*
用户条件查询
*/
drop proc pro_select_userinfo
go
create procedure pro_select_userinfo
@selcttext nvarchar(30)
as
begin
if(PATINDEX('%[^0-9]%', @selcttext)=0)
select userid,username,usergender,userbirth,userdepart,userpost,usercontact,useraddress,userremark,userpower from userinfo where userid=@selcttext
else
select userid,username,usergender,userbirth,userdepart,userpost,usercontact,useraddress,userremark,userpower from userinfo where username like '%'+@selcttext+'%'
end
go

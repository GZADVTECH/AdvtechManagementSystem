create procedure pro_select_userinfo_contains
@username nvarchar(30),
@userpwd nvarchar(max)
as
begin
select distinct userid,username,usergender,userremark from userinfo where username=@username and userpwd=@userpwd and userstatus=1
end
go
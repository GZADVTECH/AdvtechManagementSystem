/*
货物信息查询
*/
drop view view_cargoinfo
go
create view view_cargoinfo
as
select * from cargoinfo
go

/*
货物信息条件查询
*/
drop proc pro_select_cargoinfo
go
create procedure pro_select_cargoinfo
@selecttext nvarchar(30)
as
begin
if(@selecttext like '[A-Z][0-9][0-9][0-9]')
select * from cargoinfo where cargoid like '%'+@selecttext+'%' and cargostatus=1
else
select * from  cargoinfo where (cargoname like '%'+@selecttext+'%' or cargomodal like '%'+@selecttext+'%') and cargostatus=1
end
go

/*
货物信息页数查询
*/
drop proc pro_select_cargoinfo_page
go
create procedure pro_select_cargoinfo_page
@start int=0,
@end int=0
as
begin
select * from (select ROW_NUMBER() over(order by cargoid asc) as rowid,* from cargoinfo)t where t.rowid>@start and t.rowid<=@end and cargostatus=1
end
go

/*
货物信息月份报表
*/
drop proc pro_month_cargoinfo
go
create procedure pro_month_cargoinfo
@starttime datetime,
@endtime datetime
as
begin
select * from cargoinfo where cargotime between @starttime and @endtime
end
go
/*
入库条件查询
*/
drop proc pro_select_warehousing
go
create procedure pro_select_warehousing
@selecttext nvarchar(30)
as
begin
select ware.*,cargo.cargoname,cargo.cargomodal from warehousing ware left join cargoinfo cargo on ware.warecargo=cargo.cargoid where warecargo=@selecttext
end
go
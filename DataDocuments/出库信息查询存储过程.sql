/*
出库条件查询
*/
drop proc pro_select_delivery
go
create procedure pro_select_delivery
@selecttext nvarchar(30)
as
begin
select del.*,cargo.cargoname,cargo.cargomodal from delivery del left join cargoinfo cargo on del.delcargo=cargo.cargoid where del.delcargo=@selecttext
end
go
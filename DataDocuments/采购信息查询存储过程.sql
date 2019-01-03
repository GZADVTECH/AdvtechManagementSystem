/*
查询采购信息
*/
drop view view_purchase
go
create view view_purchase
as
select * from purchase pur left join cargoinfo cargo on pur.purcargo=cargo.cargoid where pur.purstatus=0
go
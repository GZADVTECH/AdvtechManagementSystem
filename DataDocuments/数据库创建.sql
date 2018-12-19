use master
go

drop database DB_AdvtechManagementSystem
go
create database DB_AdvtechManagementSystem
on
(
	name='DB_AdvtechManagementSystem.mdf',
	filename='E:\SelfDocument\CSharp\广州希创旺思管理系统\DataDocuments\DB_AdvtechManagementSystem.mdf'
)
go

use DB_AdvtechManagementSystem
go
/*用户信息表（userinfo）
员工编号，角色名称，密码，性别，出生日期，所属部门，职务，联系电话，地址，备注
*/
drop table userinfo
go
create table userinfo
(
	userid int primary key identity(1,1),
	username nvarchar(30),
	userpwd nvarchar(max),
	usergender bit,
	userbirth datetime,
	userdepart nvarchar(20),
	userpost nvarchar(20),
	usercontact nvarchar(25),
	useraddress nvarchar(255),
	userremark nvarchar(255),
	userstatus bit,

)
go
/*货物信息表（cargoinfo）
货物编号，货物名称，型号，货物数量，采购价格，销售价格，存放仓库，存放单位，存放时间，备注
*/
drop table cargoinfo
go
create table cargoinfo
(
	cargoid int primary key identity(1,1),
	cargoname nvarchar(50),
	cargomodal nvarchar(50),
	cargoamount int,
	cargopurchase money,
	cargosale money,
	cargoware nvarchar(20),
	cargounit char,
	cargotime datetime,
	cargoremark nvarchar(255),
	caregostatus bit,

)
go
/*销售商信息表（customerinfo）
公司名称，公司负责人，公司电话，公司地址，备注，状态
*/
drop table customerinfo
go
create table customerinfo
(
	customid int primary key identity(1,1),
	customname nvarchar(100),
	custompeople nvarchar(20),
	customcontact nvarchar(25),
	customaddress nvarchar(255),
	customremark nvarchar(255),
	customstatus bit,

)
go
/*入库信息表（warehousing）
入库编号，进货员工编号，入库数量，入库单价，入库总值，入库时间，存入仓库，备注，状态
*/
drop table warehousing
go
create table warehousing
(
	wareid int primary key identity(1,1),
	wareuserid int,
	wareprice money,
	waretotalprice money,
	waretime datetime,
	wareware nvarchar(20),
	wareremark nvarchar(255),
	warestatus bit,

)
go
/*出库信息表（delivery）
出库编号，出货员工编号，出库数量，出库单价，出库总值，出库时间，备注，状态
*/
drop table delivery
go
create table delivery
(
	delid int primary key identity(1,1),
	deluserid int,
	delamount int,
	delprice money,
	deltotalprice money,
	deltime datetime,
	delremark nvarchar(255),
	delstatus bit,

)
go
/*退货信息表（rejected）
退货编号，退货公司名称，退货原因，退货时间，备注，状态
*/
drop table rejected
go
create table rejected
(
	rejid int primary key identity(1,1),
	rejname nvarchar(100),
	rejreason nvarchar(255),
	rejtime datetime,
	rejremark nvarchar(255),
	rejstatus bit,

)
go
/*采购订单表（purchase）
采购订单号，内部订单号，合同订单号，货物编号，采购数量，是否配套产品，是否附带发票，采购总值，下单时间，订单完成状态，备注
*/
drop table purchase
go
create table purchase
(
	purid int primary key identity(1,1),
	purinternal nvarchar(30),
	purofficial nvarchar(30),
	purcargo int,
	paramount int,
	parmatch bit,
	parinvoice bit,
	partotalprice money,
	partime datetime,
	parstatus bit,
	parremark nvarchar(255),

)
go
/*审核信息表（auditing）
审核编号，采购订单号，员工编号，通过状态，备注
*/
drop table auditing
go
create table auditing
(
	audid int primary key identity(1,1),
	audpurchase int,
	auduser int,
	audstatus bit,
	audremark nvarchar(255),

)
go
/*财务信息表（finance）
财务编号，采购订单号，支付状态，备注
*/
drop table finance
go
create table finance
(
	finid int primary key identity(1,1),
	finpurchase int,
	finstatus bit,
	finremark nvarchar(255),

)
go

/*序列号表（serial）
货物编号，序列号，状态，备注，状态
*/
drop table serial
go
create table serial
(
	serid int primary key identity(1,1),
	sersnid nvarchar(30),
	serstatus bit,
	serremark nvarchar(255),

)
go
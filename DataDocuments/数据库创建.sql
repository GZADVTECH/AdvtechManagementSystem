use master
go

drop database DB_AdvtechManagementSystem
go
create database DB_AdvtechManagementSystem
on
(
	name='DB_AdvtechManagementSystem.mdf',
	filename='E:\SelfDocument\CSharp\����ϣ����˼����ϵͳ\DataDocuments\DB_AdvtechManagementSystem.mdf'
)
go

use DB_AdvtechManagementSystem
go

/*�û���Ϣ��userinfo��
Ա����ţ���ɫ���ƣ����룬�Ա𣬳������ڣ��������ţ�ְ����ϵ�绰����ַ����ע��Ȩ��
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
	userpower int,

)
go
/*������Ϣ��cargoinfo��
�����ţ��������ƣ��ͺţ������������ɹ��۸����ۼ۸񣬴�Ųֿ⣬��ŵ�λ�����ʱ�䣬��ע
*/
drop table cargoinfo
go
create table cargoinfo
(
	cargoid nvarchar(20),
	cargoname nvarchar(50),
	cargomodal nvarchar(50),
	cargoamount int,
	cargopurchase money,
	cargosale money,
	cargoware nvarchar(20),
	cargounit char(2),
	cargotime datetime,
	cargoremark nvarchar(255),
	caregostatus bit,

)
go
/*��������Ϣ��customerinfo��
��˾���ƣ���˾�����ˣ���˾�绰����˾��ַ����ע��״̬
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
/*�����Ϣ��warehousing��
����ţ�����Ա����ţ�����Ʒ��ţ������������ⵥ�ۣ������ֵ�����ʱ�䣬����ֿ⣬��ע��״̬
*/
drop table warehousing
go
create table warehousing
(
	wareid int primary key identity(1,1),
	wareuserid int,
	warecargo int,
	warecount int,
	wareprice money,
	waretotalprice money,
	waretime datetime,
	wareware nvarchar(20),
	wareremark nvarchar(255),
	warestatus bit,

)
go
/*������Ϣ��delivery��
�����ţ�����Ա����ţ������Ʒ��ţ��������������ⵥ�ۣ�������ֵ������ʱ�䣬��ע��״̬
*/
drop table delivery
go
create table delivery
(
	delid int primary key identity(1,1),
	deluserid int,
	delcargo int,
	delamount int,
	delprice money,
	deltotalprice money,
	deltime datetime,
	delremark nvarchar(255),
	delstatus bit,

)
go
/*�˻���Ϣ��rejected��
�˻���ţ��˻���˾���ƣ��˻���Ʒ��ţ��˻�ԭ���˻�ʱ�䣬��ע��״̬
*/
drop table rejected
go
create table rejected
(
	rejid int primary key identity(1,1),
	rejname nvarchar(100),
	rejcargo int,
	rejreason nvarchar(255),
	rejtime datetime,
	rejremark nvarchar(255),
	rejstatus bit,

)
go
/*�ɹ�������purchase��
�ɹ������ţ��ڲ������ţ���ͬ�����ţ������ţ��ɹ��������Ƿ����ײ�Ʒ���Ƿ񸽴���Ʊ���ɹ���ֵ���µ�ʱ�䣬�������״̬����ע
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
/*�����Ϣ��auditing��
��˱�ţ��ɹ������ţ�Ա����ţ�ͨ��״̬����ע
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
/*������Ϣ��finance��
�����ţ��ɹ������ţ�֧��״̬����ע
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

/*���кű�serial��
�����ţ����кţ�״̬����ע��״̬
*/
drop table serial
go
create table serial
(
	serid int primary key,
	sersnid nvarchar(30),
	serstatus bit,
	serremark nvarchar(255),

)
go
/*���������Ϣ��cargoinout��
�����Ʒ��ţ���������������ʱ�䣬��ע
*/
drop table cargoinout
go
create table cargoinout
(
	cioid int,
	cioamount int,
	ciotime datetime,
	cioremark nvarchar(255),

)
go
/*���кż�¼��serialrecord��
���кţ�״̬����¼ʱ��
*/
drop table serialrecord
go
create table serialrecord
(
	srserial nvarchar(30),
	srstatus nvarchar(20),
	srtime datetime,

)
go

/*���󱨸��errorinfo��
�����ţ�������Ϣ������ʱ��
*/
drop table errorinfo
go
create table errorinfo
(
	errorid int primary key identity(1,1),
	errormsg nvarchar(max),
	errortime datetime,

)
go
/*TABLA USUARIOS */
CREATE TABLE Users(
IdUser INTEGER  IDENTITY(1,1) NOT NULL,
Name VARCHAR(max) NULL,
Login VARCHAR(max) NULL,
Password VARCHAR(max) NULL,
Icon IMAGE NULL,
Email VARCHAR(max) NULL,
Role VARCHAR(max) NULL,
State VARCHAR(max) NULL
)

CREATE TABLE Permissions(
	IdPermissions int IDENTITY(1,1) NOT NULL,
	IdModule int NULL,
	IdUser int NULL,
)

CREATE TABLE Clients(
	idclient int IDENTITY(1,1) NOT NULL,
	Name varchar(max) NULL,
	address varchar(max) NULL,
	FiscalIndentificar varchar(max) NULL,
	Phone varchar(max) NULL,
	State varchar(50) NULL,
	residue numeric(18, 2) NULL,
	document varchar(50) NULL,
)

CREATE TABLE Login(
	Idsesion int IDENTITY(1,1) NOT NULL,
	IdBox int NULL,
	IdUser int NULL,
	)

	CREATE TABLE [dbo].[Tables](
	[Id_table] [int] IDENTITY(1,1) NOT NULL,
	[Table] [varchar](50) NULL,
	[Id_salon] [int] NULL,
	[life_state] [varchar](50) NULL,
	[state_of_availability] [varchar](50) NULL,
)
CREATE TABLE [dbo].[Modules](
	[IdModule] [int] IDENTITY(1,1) NOT NULL,
	[Module] [varchar](max) NULL,
)

CREATE TABLE [dbo].[Salon](
	[Id_salon] [int] IDENTITY(1,1) NOT NULL,
	[Salon] [varchar](50) NULL,
	[State] [varchar](50) NULL,

 )

 CREATE TABLE [dbo].[Box](
	[Id_Box] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
	[Theme] [varchar](50) NULL,
	[Serial_PC] [varchar](max) NULL,
	[State] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
	[Path_to_backup_copies] [varchar](max) NULL,
	[Last_backup_date] [varchar](50) NULL,
	[Last_copy_date_date] [datetime] NULL,
	[Frequency_of_copies] [int] NULL,
	[Backup_State] [varchar](50) NULL,
)

 CREATE TABLE [dbo].[Sales](
	[idsale] [int] IDENTITY(1,1) NOT NULL,
	[idclient] [int] NULL,
	[sale_date] [datetime] NULL,
	[Numer_of_doc] [varchar](50) NULL,
	[Total_amount] [numeric](18, 2) NULL,
	[Payment_type] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[IVA] [numeric](18, 2) NULL,
	[Voucher] [varchar](50) NULL,
	[Id_usuario] [int] NULL,
	[Payment_date] [varchar](50) NULL,
	[Action] [varchar](50) NULL,
	[residue] [numeric](18, 2) NULL,
	[Pay_with] [numeric](18, 2) NULL,
	[Porcentage_IVA] [numeric](18, 2) NULL,
	[Id_box] [int] NULL,
	[Card_Reference] [varchar](50) NULL,
	[Turned] [numeric](18, 2) NULL,
	[Cash] [numeric](18, 2) NULL,
	[Credit] [numeric](18, 2) NULL,
	[Card] [numeric](18, 2) NULL,
	[Id_table] [int] NULL,
	[Number_people] [int] NULL,
	[Where_will_be_consumed] [varchar](50) NULL,
)

CREATE TABLE [dbo].[Product](
	[Id_Product] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
	[Image] [image] NULL,
	[Id_group] [int] NULL,
	[Use_inventories] [varchar](50) NULL,
	[Stock] [varchar](50) NULL,
	[Sale_price] [numeric](18, 2) NULL,
	[Stock_minimum] [numeric](18, 2) NULL,
	[Purchase_price] [numeric](18, 2) NULL,
	[State_image] [varchar](50) NULL,
)

CREATE TABLE [dbo].[Group_of_Products](
	[Idline] [int] IDENTITY(1,1) NOT NULL,
	[Group] [varchar](50) NULL,
	[Default] [varchar](50) NULL,
	[Icon] [image] NULL,
	[State] [varchar](50) NULL,
	[State_of_icon] [varchar](50) NULL,
)
/*INSERTAR USUARIO*/
CREATE PROC insert_Users

@Name As varchar(MAX),
@Login As varchar(MAX),
@Password As varchar(MAX),
@Icon As image,
@Email As varchar(MAX),
@Role As varchar(MAX),
@State As varchar(MAX)
As
if Exists(select Login from Users where Login = @Login)
Raiserror('YA EXISTE UN REGISTRO CON ESE USUARIO, POR FAVOR INGRESE DE NUEVO',16,1)
else
INSERT INTO Users
Values (
@Name,
@Login,
@Password,
@Icon,
@Email,
@Role,
@State
)

/*MOSTRAR USUARIO*/

CREATE PROC show_users
As
Select * FROM Users

/*BORRAR USUARIO*/
CREATE PROC delete_Users
@IdUser As int

As
update Users set State='ELIMINADO'
WHERE IdUser=@IdUser


/*EDITAR USUARIO*/

CREATE PROC edit_User
@IdUser As int,
@Name As varchar(MAX),
@Login As varchar(MAX),
@Password As varchar(MAX),
@Icon As image,
@Email As varchar(MAX),
@Role As varchar(MAX)
As
if EXISTS(Select Login,IdUser  from Users where Login=@Login and IdUser <>@IdUser )
RAISERROR ('Usuario en Uso, usa otro nombre de Usuario por favor', 16,1)
else
UPDATE Users Set

Name=@Name,
Login=@Login,
Password=@Password,
Icon=@Icon,
Email=@Email,
Role=@Role
Where IdUser=@IdUser

create proc [dbo].[GetUserID]
@Login varchar(max)
as
select IdUser  from Users where Login=@Login 

/* ValidateUser */
create proc [dbo].[validarUsuario]
@password varchar(max),
@login varchar(max)

as
select IdUser  from Users
where Password=@password and Login =@login 

/* restore user*/
create proc [dbo].[restore_user]
@iduser as int

as	 
UPDATE Users  SET State ='ACTIVO'
WHERE IdUser =@iduser

create proc [dbo].[search_users]
@search varchar(50)
as
select * from Users
where Login+Name+Email Like '%' + @search + '%'

CREATE proc [dbo].[showRoles]
@iduser int
as 
select 
Role 
from Users  
where idUser  =@iduser and State ='ACTIVO'

CREATE PROC [dbo].[remove permissions]
@IdUser As int

As
DELETE FROM Permissions
WHERE IdUser=@IdUser

create  procedure insert_client
@Name varchar(MAX),
@Address varchar(MAX),
@FiscalIndentificar varchar(MAX),                      
@Phone varchar(50),               
@State varchar(50),
@Residue varchar(50),
@Document as varchar(50)
		
as
	
if EXISTS (SELECT Name  FROM Clients  where Name  = @Name)
RAISERROR ('YA EXISTE UN REGISTRO CON ESE NOMBRE', 16,1)
else

insert into Clients  values 
            (@Name
           ,@Address
           ,@FiscalIndentificar
           ,@Phone    
           ,@State
           ,@Residue
		   ,@Document	
            )

create proc [dbo].[showLogin]
@idbox int
as
select * from Login 
where IdBox = @idbox

CREATE PROC delete_Modules
@IdModule As int

As
DELETE FROM Modules
WHERE IdModule=@IdModule

create proc [dbo].[editLogin]
@idsesion int,
@iduser int
as
update Login set IdUser = @iduser
where Idsesion = @idsesion

create proc showLogin
@idbox int
as
select * from Login

create proc [dbo].[insertLogin]
@idbox int,
@iduser int
as
insert into Login 
values(@idbox ,@iduser)
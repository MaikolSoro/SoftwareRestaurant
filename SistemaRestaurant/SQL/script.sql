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
CONSTRAINT PK_Users PRIMARY KEY(IdUser)
)

CREATE TABLE Permissions(
	IdPermissions int IDENTITY(1,1) NOT NULL,
	IdModule int NULL,
	IdUser int NULL,
	CONSTRAINT PK_Permissions PRIMARY KEY(IdPermissions)
)

CREATE TABLE Clients(
	Idclient int IDENTITY(1,1) NOT NULL,
	Name varchar(max) NULL,
	address varchar(max) NULL,
	FiscalIndentificar varchar(max) NULL,
	Phone varchar(max) NULL,
	State varchar(50) NULL,
	residue numeric(18, 2) NULL,
	document varchar(50) NULL,
	CONSTRAINT PK_Clients PRIMARY KEY(Idclient)
)

CREATE TABLE Login(
	Idsesion int IDENTITY(1,1) NOT NULL,
	IdBox int NULL,
	IdUser int NULL,
	CONSTRAINT PK_Login PRIMARY KEY(Idsesion),
	CONSTRAINT FK_Login_Box FOREIGN KEY(IdBox) REFERENCES Box(Id_Box),
	CONSTRAINT FK_Login_user FOREIGN KEY(IdUser) REFERENCES Users(IdUser)
	)

	CREATE TABLE Tables(
	Id_table int IDENTITY(1,1) NOT NULL,
	Board varchar(50) NULL,
	Id_salon int NULL,
	life_state varchar(50) NULL,
	state_of_availability varchar(50) NULL,
	CONSTRAINT PK_Tables PRIMARY KEY(Id_table),
	CONSTRAINT FK_Tables_salon FOREIGN KEY(Id_salon) REFERENCES Salon(Id_salon)
)
CREATE TABLE Modules(
	IdModule int IDENTITY(1,1) NOT NULL,
	Module varchar(max) NULL,
	CONSTRAINT PK_Modules PRIMARY KEY(IdModule)
)

 CREATE TABLE Salon(
	Id_salon int IDENTITY(1,1) NOT NULL,
	Salon varchar(50) NULL,
	State varchar(50) NULL,
	CONSTRAINT PK_Salon PRIMARY KEY(Id_salon)
)


 CREATE TABLE Box(
	Id_Box int IDENTITY(1,1) NOT NULL,
	Description varchar(50) NULL,
	Theme varchar(50) NULL,
	Serial_PC varchar(max) NULL,
	State varchar(50) NULL,
	Type varchar(50) NULL,
	Path_to_backup_copies varchar(max) NULL,
	Last_backup_date varchar(50) NULL,
	Last_copy_date_date datetime NULL,
	Frequency_of_copies int NULL,
	Backup_State varchar(50) NULL,
	CONSTRAINT PK_Box PRIMARY KEY(Id_Box)
)

 CREATE TABLE Sales(
	idsale int IDENTITY(1,1) NOT NULL,
	idclient int NULL,
	sale_date datetime NULL,
	Numer_of_doc varchar(50) NULL,
	Total_amount numeric(18, 2) NULL,
	Payment_type varchar(50) NULL,
	State varchar(50) NULL,
	IVA numeric(18, 2) NULL,
	Voucher varchar(50) NULL,
	Id_user int NULL,
	Payment_date varchar(50) NULL,
	Action varchar(50) NULL,
	residue numeric(18, 2) NULL,
	Pay_with numeric(18, 2) NULL,
	Porcentage_IVA numeric(18, 2) NULL,
	Id_box int NULL,
	Card_Reference varchar(50) NULL,
	Turned numeric(18, 2) NULL,
	Cash numeric(18, 2) NULL,
	Credit numeric(18, 2) NULL,
	Card numeric(18, 2) NULL,
	Id_table int NULL,
	Number_people int NULL,
	Where_will_be_consumed varchar(50) NULL,
	CONSTRAINT PK_Sales PRIMARY KEY(Idsale),
	CONSTRAINT FK_Sales_users FOREIGN KEY(Id_user) REFERENCES Users(IdUser),
	CONSTRAINT FK_Sales_clients FOREIGN KEY(Idclient) REFERENCES Clients(Idclient),
	CONSTRAINT FK_Sales_box FOREIGN KEY(Id_box) REFERENCES Box(Id_Box),
	CONSTRAINT FK_Sales_table FOREIGN KEY(Id_table) REFERENCES Tables(Id_table)
)

CREATE TABLE Group_of_Products(
	Idline int IDENTITY(1,1) NOT NULL,
	PGroup varchar(50) NULL,
	ByDefault varchar(50) NULL,
	Icon image NULL,
	State varchar(50) NULL,
	State_of_icon varchar(50) NULL,
	CONSTRAINT PK_group_of_Products PRIMARY KEY(Idline)
)
CREATE TABLE Product(
	Id_Product int IDENTITY(1,1) NOT NULL,
	Description varchar(50) NULL,
	Image image NULL,
	Id_group int NULL,
	Use_inventories varchar(50) NULL,
	Stock varchar(50) NULL,
	Sale_price numeric(18, 2) NULL,
	Stock_minimum numeric(18, 2) NULL,
	Purchase_price numeric(18, 2) NULL,
	State_image varchar(50) NULL,
	CONSTRAINT PK_Product PRIMARY KEY(Id_Product),
	CONSTRAINT FK_Product_group FOREIGN KEY(Id_group) REFERENCES Group_of_Products(Idline)
)

CREATE TABLE [dbo].[MovememtsBox](
	[IdMovementsBox] [int] IDENTITY(1,1) NOT NULL,
	[startDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[income] [numeric](18, 2) NULL,
	[egresos] [numeric](18, 2) NULL,
	[VCash] [numeric](18, 2) NULL,
	[VCredit] [numeric](18, 2) NULL,
	[VCard] [numeric](18, 2) NULL,
	[Iduser] [int] NULL,
	[CashCalculated] [numeric](18, 2) NULL,
	[ActualCash] [numeric](18, 2) NULL,
	[CashDifference] [numeric](18, 2) NULL,
	[IdBox] [int] NULL,
	[State] [varchar](50) NULL,
	[Initial Cash] [numeric](18, 2) NULL,
)

CREATE TABLE [dbo].[Table_Properties](
	[Id_properties] [int] IDENTITY(1,1) NOT NULL,
	[x] [int] NULL,
	[y] [int] NULL,
	[Letter_size] [int] NULL,

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

create proc [dbo].[Paginate_groups]
@From int,
@Until int
as
BEGIN
SET NOCOUNT ON;
select
Idline, 
Group,
Icon ,
Icon_state  
from 
(Select
Idline, 
Group,
Icon ,
Icon_state ,
ROW_NUMBER() Over (Order By Idline) 'Numero_de_fila' 
From Group_of_Products as Paginate
Where (Paginate.Row_Number>=@From ) and (Paginate.Row_Number <=@Until ) END

CREATE proc [dbo].[paginate_Products_by_group]
@From INT,
@Until INT,
@id_group int
AS
BEGIN
SET NOCOUNT ON;
SELECT
Id_Product,
Description,
Image,
Sale_price,
State_image,
Id_group
FROM
(SELECT
Id_Product,
Description,
Image,
Sale_price,
State_image,
Product.Id_group ,
ROW_NUMBER() OVER (ORDER BY Idline) 'Numero_de_fila'
FROM
Product INNER JOIN Group_of_Products on
Group_of_Products.Idline=Product.Id_group

) AS Paginate
WHERE
(Paginate.Row_Number >= @From)AND (Paginate.Row_Number<= @Until ) and Paginate.Id_group  =@id_group
END

create proc [dbo].[edit_table]

@table as varchar(50)
,@id_table as int
as
if EXISTS (SELECT Tables FROM Tables  where (Table  = @table and Id_table  <>@Id_table ))

RAISERROR ('Ya Existe una mesa con este Nombre, POR FAVOR INGRESE DE NUEVO', 16,1)
else
update Tables set Table=@table
where Id_table=@id_table 


create proc [dbo].[insert_table]
@table varchar(50),
@idsalon int
AS
declare @life_state varchar(50)
declare @state_of_availability varchar(50)
set @life_state ='ACTIVO'
set @state_of_availability = 'LIBRE'
if EXISTS(select Table  from Tables  where Table= @table and Table <>'NULO')
RAISERROR('YA EXISTE UNA MESA CON ESE NOMBRE, ingrese de nuevo', 16,1)
else
insert into Tables values (@table, @idsalon ,@life_state , @state_of_availability )

CREATE PROC [dbo].[insert_Modules]
@Module As varchar(MAX)
As
INSERT INTO Modules
Values (
@Module)


create proc [dbo].[insertPropertiesTables]
as
declare @x int
declare @y int
declare @lettersize int
set @x=136
set @y=110
set @lettersize=10
insert into Properties_of_tables 
values(@x,@y,@lettersize)

create proc [dbo].[show_recently_entered_salon_id]
@Salon as varchar(50)
AS
select Id_salon from Salon
where Salon= @Salon

CREATE proc [dbo].[show_tables_por_salon]
@id_salon int
AS
select Tables.*,Table_Properties.*  from Tables inner join Salon on Salon.Id_salon = Tables.Id_salon  
cross join Table_Properties
wHERE Tables.Id_salon = @id_salon 

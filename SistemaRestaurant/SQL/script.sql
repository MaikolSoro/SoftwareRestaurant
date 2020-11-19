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

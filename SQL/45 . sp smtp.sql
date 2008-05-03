create PROCEDURE dbo.SMTP_GuardarParametros 
(
	@AutenticacionSmtp bit,
	@Email nvarchar(50),
	@Host nvarchar(50),
	@Nombre nvarchar(50),
	@Password nvarchar(10),
	@Puerto int,
	@SSL bit,
	@UserName nvarchar(50)
)
AS


delete from smtp;
insert into smtp values (@AutenticacionSmtp,@Email,@Host,@Nombre,@Password,@Puerto,@SSL,@UserName);

select @@rowcount


;


create PROCEDURE dbo.SMTP_RecuperarConfiguracion

AS


SELECT       top 1 AutenticacionSmtp, Email, Host, Nombre, Password, Puerto, SSL, UserName
FROM            Smtp
USE MAD_PF;

GO

IF OBJECT_ID('spLogin') IS NOT NULL
BEGIN
	DROP PROCEDURE spLogin;
END;
GO

CREATE PROCEDURE spLogin
	(
	@Usuario		VARCHAR(30),
	@Contrasenia	VARCHAR(30)
	
	)
AS
BEGIN
	
	
	
	SELECT  Nombre,[Contrasenia], Usuario,Nivel_cuenta
	
	FROM Usuarios
	WHERE Usuario = @Usuario AND [Contrasenia] = @Contrasenia;
	
	SELECT  Usuario
	INTO ##GlobalVariables
	FROM Usuarios
	WHERE Usuario = @Usuario AND [Contrasenia] = @Contrasenia;
	
	
	
	
END;
GO
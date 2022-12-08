USE MAD_PF;

GO

IF OBJECT_ID('spLogin2') IS NOT NULL
BEGIN
	DROP PROCEDURE spLogin2;
END;
GO

CREATE PROCEDURE spLogin2
	(
	@Usuario		VARCHAR(30)
	
	
	)
AS
BEGIN
	
	
	
	IF OBJECT_ID('tempdb.dbo.##GlobalVariables') IS NOT NULL
	BEGIN
	DROP TABLE ##GlobalVariables
	END

	SELECT   ID,Usuario
	INTO ##GlobalVariables
	FROM Usuarios
	WHERE Usuario = @Usuario ;
	

	
	
	
	
	
	
	
END;
GO
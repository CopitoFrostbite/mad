USE MAD_PF;

GO

IF OBJECT_ID('spGestionUnidades') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionUnidades;
END;
GO

CREATE PROCEDURE spGestionUnidades
	(
	@Accion			CHAR(3),
	@ID			INT				=NULL,
	@Nombre		VARCHAR(30)		=NULL
	)
AS
BEGIN
	
	
	IF @Accion = 'IN'
	BEGIN
		
		INSERT INTO Unidades(Nombre)
			VALUES (@Nombre)
	END;

	

	IF @Accion = 'UP'
	BEGIN
		UPDATE Unidades
			SET
			Nombre			=	@Nombre
				
			WHERE ID		= @ID ;			
	END;


	IF @Accion = 'DE'
	BEGIN
		DELETE FROM Unidades			
		WHERE ID		= @ID ;
	END;

	IF @Accion = 'SE'
	BEGIN
		SELECT  ID,Nombre
		FROM Unidades
		
		WHERE  ID		= @ID ;
	END;

	IF @Accion = 'SE2'
	BEGIN
		SELECT  ID,Nombre
		FROM Unidades
		
		
	END;
	
	
END;
GO
USE MAD_PF;

GO

IF OBJECT_ID('spGestionHistorialCaja') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionHistorialCaja;
END;
GO

CREATE PROCEDURE spGestionHistorialCaja
	(
	@Accion			CHAR(3),
	@ID_Usuario		INT				=NULL,
	@Numero			INT				=NULL,
	@Fecha			DATE			=NULL
	
	
	)
AS
BEGIN
	
	SET @Fecha = GETDATE();

	IF @Accion = 'IN'
	BEGIN
		
		INSERT INTO Historial_Caja(ID_usuario,Numero,Fecha)
			VALUES(@ID_Usuario,@Numero,@Fecha)
	END;

	

	

	IF @Accion = 'SE'
	BEGIN
		SELECT  ID_usuario,Numero,Fecha
		FROM Historial_Caja
		WHERE ID_usuario		= @ID_Usuario
	END;

	
END;
GO
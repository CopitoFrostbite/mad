USE MAD_PF;

GO

IF OBJECT_ID('spGestionPago') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionPago;
END;
GO

CREATE PROCEDURE spGestionPago
	(
	@Accion			CHAR(3),
	
	@ID_Pago		INT				=NULL,
	@Metodo			VARCHAR(20)		=NULL
	)
AS
BEGIN
	
	

	IF @Accion = 'IN'
	BEGIN
		
		INSERT INTO Pago(Metodo)
			VALUES(@Metodo)
	END;

	IF @Accion = 'UP'
	BEGIN
		UPDATE Pago
			SET
				
				Metodo			= @Metodo	
				
			WHERE ID_Pago		= @ID_Pago;			
	END;

	IF @Accion = 'DE'
	BEGIN
		DELETE FROM Pago
		WHERE ID_Pago = @ID_Pago; 
	END;

	

	IF @Accion = 'SE'
	BEGIN
		SELECT  ID_Pago,Metodo
		FROM Pago
		
	END;

	
END;
GO
USE MAD_PF;

GO

IF OBJECT_ID('spGestionVentas') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionVentas;
END;
GO

CREATE PROCEDURE spGestionVentas
	(
	@Accion			CHAR(3),
	@Orden			INT				=NULL,
	@Caja			INT				=NULL,
	@Cajero			VARCHAR(30)		=NULL,
	@Fecha			DATE			=NULL,
	@Descuento		SMALLMONEY		=NULL,
	@Total			SMALLMONEY		=NULL,
	@Pago			SMALLMONEY		=NULL
	
	
	)
AS
BEGIN
	
	SET @Fecha = GETDATE() 
	DECLARE @max int
	
	SELECT @max = max(Orden)
	FROM ventas

	IF @Accion = 'IN'
	BEGIN
		
		INSERT INTO Ventas(Caja,Cajero,Fecha,Descuento,Total,Pago)
			VALUES(@Caja,@Cajero,@Fecha,'$0.00','$0.00','$0.00')
	END;

	IF @Accion = 'UP'
	BEGIN
		UPDATE Ventas
			SET
				Caja			= @Caja,
				Cajero			= @Cajero,
				Fecha			= @Fecha,
				Total			= @Total
				
			WHERE Orden		= @Orden;			
	END;

	IF @Accion = 'UP2'
	BEGIN
		UPDATE Ventas
			SET
				Descuento		= @Descuento,
				Total			= @Total,
				Pago			= @Pago
				
			WHERE Orden		= @max;			
	END;
	
	

	IF @Accion = 'DE'
	BEGIN
		DELETE FROM Ventas			
		WHERE Orden		= @max;
	END;

	IF @Accion = 'DE2'
	BEGIN
		DELETE FROM Ventas			
		WHERE Total		= 0;
	END;
	

	IF @Accion = 'SE'
	BEGIN
		SELECT  Orden,Caja,Cajero,Fecha,Total
		FROM Ventas
		WHERE Orden		= @Orden;
	END;

	
END;
GO
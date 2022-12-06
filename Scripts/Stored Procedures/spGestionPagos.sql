USE MAD_PF;

GO

IF OBJECT_ID('spGestionPagos') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionPagos;
END;
GO

CREATE PROCEDURE spGestionPagos
	(
	@Accion			CHAR(3),
	@Orden			INT				=NULL,
	@Num_Pago		INT				=NULL,
	@M_Pago			INT				=NULL,
	@Monto			SMALLMONEY		=NULL	
	
	
	
	)
AS
BEGIN
	
	DECLARE @max int
	
	SELECT @max = max(Orden)
	FROM Ventas

	IF @Accion = 'IN'
	BEGIN
		
		INSERT INTO Pagos(Orden,Num_Pago,M_Pago,Monto)
			VALUES (@max,@Num_Pago,@M_Pago,@Monto)
	END;

	IF @Accion = 'IN2'
	BEGIN
		
		INSERT INTO Pagos(Orden,Num_Pago,M_Pago,Monto)
			VALUES (@Orden,@Num_Pago,@M_Pago,@Monto)
	END;

	IF @Accion = 'UP'
	BEGIN
		UPDATE Pagos
			SET
			Orden			=	@Orden,
			Num_Pago		=	@Num_Pago,
			M_Pago			=	@M_Pago,
			
			Monto			=	@Monto
			
				
			WHERE Orden		= @Orden AND Num_Pago = @Num_Pago;			
	END;
	
	

	IF @Accion = 'DE'
	BEGIN
		DELETE FROM Pagos			
		WHERE Orden		= @max AND Num_Pago = @Num_Pago;	
	END;

	IF @Accion = 'DE2'
	BEGIN
		DELETE FROM Pagos			
		WHERE Orden		= @max ;	
	END;

	

	

	IF @Accion = 'SE'
	BEGIN
		SELECT  Orden,Pago, Metodo,Monto
		FROM viGestionPagos
		
		WHERE Orden		= @max;
	END;

	IF @Accion = 'SE2'
	BEGIN
		SELECT Orden,Num_Pago,M_Pago,Monto
		FROM Pagos
		WHERE Orden		= @Orden AND Num_Pago = @Num_Pago;
	END;

	
END;
GO
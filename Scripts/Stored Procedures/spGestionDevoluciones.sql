USE MAD_PF;

GO

IF OBJECT_ID('spGestionDevoluciones') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionDevoluciones;
END;
GO

CREATE PROCEDURE spGestionDevoluciones
	(
	@Accion			CHAR(3),
	@Recibo			int				=NULL,
	@ID_Dev			INT				=NULL,
	@Motivo			VARCHAR(30)		=NULL,	
	@Merma			BIT				=NULL,
	@Cantidad		DECIMAL(13,2)	=NULL, 
	@Subtotal		SMALLMONEY		=NULL,
	@Total			SMALLMONEY		=NULL,
	@Devuelto		bit				=null
	)
AS
BEGIN
	
	DECLARE @IDF VARCHAR(20)
			

	IF @Accion = 'IN'
	BEGIN
		
		 

		INSERT INTO Devoluciones(Recibo,ID_Dev,Motivo,Merma,Cantidad,Subtotal,Total,Devuelto)
			VALUES(@Recibo,@ID_Dev,@Motivo,@Merma,@Cantidad,@Subtotal,@Total,0)
	END;

	IF @Accion = 'UP'
	BEGIN
		UPDATE Devoluciones
			SET
				Devuelto		= 1
				
				
				
			WHERE Recibo = @Recibo and ID_Dev	= @ID_Dev ;			
	END;

	


	
	 
	IF @Accion = 'SE'

	BEGIN
		
		SELECT  Recibo,Articulo,Nombre,Motivo,Merma,Cantidad,Subtotal,Total,Devolucion,Devuelto
		FROM viGestionDevoluciones
			
		where recibo = @Recibo AND Devolucion = 1
	END;

	IF @Accion = 'SE2'

	BEGIN
		
		SELECT  Recibo,Articulo,Nombre,Motivo,Cantidad,Subtotal,Total TotalProd
		FROM viGestionDevoluciones
			
		where recibo = @Recibo 
	END;

	IF @Accion = 'SE3'

	BEGIN
		
		SELECT  Recibo,Articulo,Nombre,Motivo,Merma,Cantidad,Subtotal,Total,Devolucion,Devuelto
		FROM viGestionDevoluciones
			
		where recibo = @Recibo AND Devolucion = 1 and Devuelto = 0
	END;

	IF @Accion = 'DE'
	BEGIN
		DELETE FROM Devoluciones			
		WHERE Recibo = @Recibo and ID_Dev	= @ID_Dev ;
	END;


	
END;
GO
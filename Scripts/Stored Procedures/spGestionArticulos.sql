USE MAD_PF;

GO

IF OBJECT_ID('spGestionArticulos') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionArticulos;
END;
GO

CREATE PROCEDURE spGestionArticulos
	(
	@Accion			CHAR(3),
	@Orden			INT				=NULL,
	@Articulo		INT				=NULL,
	@Cantidad		DECIMAL(13,2)	=NULL,
	@Monto			SMALLMONEY		=NULL,
	@Subtotal		SMALLMONEY		=NULL,
	@Total			SMALLMONEY		=NULL
	
	
	)
AS
BEGIN
	
	DECLARE @max int
	
	SELECT @max = max(Orden)
	FROM ventas

	IF @Accion = 'IN'
	BEGIN
		
		INSERT INTO Articulos(Orden,Articulo,Cantidad,Subtotal,total)
			VALUES (@max,@Articulo,@Cantidad,$0.00,$0.00)
	END;

	IF @Accion = 'IN2'
	BEGIN
		
		INSERT INTO Articulos(Orden,Articulo,Cantidad,Subtotal,total)
			VALUES (@Orden,@Articulo,@Cantidad,$0.00,$0.00)
	END;

	IF @Accion = 'UP'
	BEGIN
		UPDATE Articulos
			SET
			Orden			=	@Orden,
			Articulo		=	@Articulo,
			Cantidad		=	@Cantidad,
			
			Subtotal		=	@Subtotal,
			Total			=	@Total
				
			WHERE Orden		= @Orden AND Articulo = @Articulo;			
	END;

	
	
	
	

	IF @Accion = 'DE'
	BEGIN
		DELETE FROM Articulos			
		WHERE Orden		= @max AND Articulo = @Articulo;
	END;

	IF @Accion = 'DE2'
	BEGIN
		DELETE FROM Articulos			
		WHERE Orden		= @max ;
	END;

	

	

	IF @Accion = 'SE'
	BEGIN
		SELECT  Orden,Articulo,Producto, Precio,Cantidad,Descuento,Subtotal,Total
		FROM viGestionArticulos
		
		WHERE Orden		= @max;
	END;

	IF @Accion = 'SE2'
	BEGIN
		SELECT  Orden,Articulo,Cantidad,Subtotal,Total
		FROM Articulos
		WHERE Orden		= @Orden AND Articulo = @Articulo;
	END;

	IF @Accion = 'SE3'
	BEGIN
		SELECT  Nombre,Sucursal,Direccion,Mensaje1,Mensaje2,Mensaje3,Mensaje4,Orden,Articulo,Producto, Precio,Cantidad, Descuento,Subtotal, TotalProd, DescuentoTotal ,Total,Pago  ,Cambio
		FROM viGestionRecibo
		
		WHERE Orden		= @max;
	END;

	IF @Accion = 'SE4'
	BEGIN
		SELECT Orden,Articulo,Cantidad
		FROM viGestionRecibo2
		
		WHERE Orden		= @max;
	END;


	
END;
GO
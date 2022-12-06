USE MAD_PF;

GO

IF OBJECT_ID('spGestionRecibo') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionRecibo;
END;
GO

CREATE PROCEDURE spGestionRecibo
	(
	@Accion			CHAR(3),
	@N_Ticket		INT				=NULL,
	@Ti_ID			INT				=NULL,	
	@Cambio			SMALLMONEY		=NULL,
	
	@fecha			DATE			=NULL,
	@caja			INT				=null			
	)
AS
BEGIN
	
	DECLARE @max int
	
	SELECT @max = max(Orden)
	FROM ventas

	IF @Accion = 'IN'
	BEGIN
		
		INSERT INTO Recibo(N_Ticket,Ti_ID,Cambio)
			VALUES (@max,1,@Cambio)
	END;
	
	
	

	IF @Accion = 'DE'
	BEGIN
		DELETE FROM Recibo			
		WHERE N_Ticket		= @N_Ticket ;
	END;

	

	

	IF @Accion = 'SE'
	BEGIN
		SELECT  N_Ticket,Ti_ID,Cambio
		FROM Recibo
		
		WHERE N_Ticket		= @max;
	END;

	IF @Accion = 'SE2'
	BEGIN
		SELECT  Orden,Articulo,Producto,Precio,Cantidad,Descuento,Subtotal,TotalProd, Devolucion
		FROM viGestionRecibo
		
		WHERE orden		= @N_Ticket;
	END;
	
	IF @Accion = 'SE3'
	BEGIN
		SELECT  Orden,Articulo,Producto, Precio,Cantidad, Descuento,Subtotal, TotalProd, DescuentoTotal ,Total,Pago 
		FROM viGestionRecibo
		
		
		WHERE orden		= @N_Ticket;
	END;

	IF @Accion = 'SE4'
	BEGIN
		SELECT  Orden,Articulo,Producto, Precio,Cantidad, Descuento,Subtotal, TotalProd, DescuentoTotal ,Total,Pago 
		FROM viGestionRecibo
		
		
		WHERE Fecha		= @fecha and Caja = @caja;
	END;

	IF @Accion = 'SE5'
	BEGIN
		SELECT  Nombre,Sucursal,Direccion,Mensaje1,Mensaje2,Mensaje3,Mensaje4,Orden,Articulo,Producto, Precio,Cantidad, Descuento,Subtotal, TotalProd, DescuentoTotal ,Total,Pago  ,Cambio
		FROM viGestionRecibo
		
		
		WHERE orden		= @N_Ticket;
	END;

	IF @Accion = 'SE6'
	BEGIN
		SELECT  Nombre,Sucursal,Direccion,Mensaje1,Mensaje2,Mensaje3,Mensaje4,Orden,Articulo,Producto, Precio,Cantidad, Descuento,Subtotal, TotalProd, DescuentoTotal ,Total,Pago  ,Cambio
		FROM viGestionRecibo
		
		
		WHERE Fecha		= @fecha and Caja = @caja;
	END;
	
END;
GO
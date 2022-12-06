USE MAD_PF;

GO

IF OBJECT_ID('spReporteVentas') IS NOT NULL
BEGIN
	DROP PROCEDURE spReporteVentas;
END;
GO

CREATE PROCEDURE spReporteVentas
	(
	@Accion			CHAR(3),
	@fechai			date			=null,
	@fechaf			date			=null,	
	@Caja			int				=NULL,	
	@Departamento	VARCHAR(20)		=NULL	
	)
AS
BEGIN
	

	IF @Accion = 'SE'

	BEGIN
		
		SELECT Fecha,Nombre,ID,Precio_U,Caja,Cantidad,Subtotal, Descuento, Venta, Utilidad 
		FROM viReporteVentas
		WHERE (Fecha is null OR( Fecha  between @fechai and @fechaf))
		AND (@Departamento IS NULL OR Nombre = @Departamento or Nombre is null)
		AND (@Caja IS NULL OR Caja = @Caja or Caja is null)
		order by Fecha desc
		
	END 

	
END;
GO
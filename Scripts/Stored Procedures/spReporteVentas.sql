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
		
		SELECT Nombre,Fecha,ID,Precio_U,Caja,Cantidad,Subtotal, Descuento, Venta, Utilidad 
		FROM viReporteVentas
		WHERE (Fecha is null OR( Fecha  between @fechai and @fechaf))
		AND (@Departamento IS NULL OR (Nombre = @Departamento or Nombre is null))
		AND (@Caja IS NULL OR (Caja = @Caja or Caja is null))
		union	
		SELECT  'Total',null,null,null,null,SUM(a.Cantidad),SUM((a.Cantidad * i.Precio_U)) Subtotal,SUM((I.Precio_U - dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Descuento,SUM( (dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Venta,SUM((i.Precio_U - i.Costo) * a.Cantidad) Utilidad 
		FROM Ventas V
		inner JOIN Articulos A
			ON v.Orden = a.Orden
		inner JOIN Inventario I
			ON a.Articulo = i.ID
		inner JOIN Descuentos De
			ON I.Descuento = De.ID_Des
		inner JOIN Departamento D
			ON i.Clave = d.Clave
		WHERE (Fecha is null OR( Fecha  between @fechai and @fechaf))
		AND (@Departamento IS NULL OR (Nombre = @Departamento or Nombre is null))
		AND (@Caja IS NULL OR (Caja = @Caja or Caja is null))
		order by Fecha desc
		
	END 

	
END;
GO
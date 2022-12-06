USE MAD_PF;

GO

IF OBJECT_ID('spReporteCaja') IS NOT NULL
BEGIN
	DROP PROCEDURE spReporteCaja;
END;
GO

CREATE PROCEDURE spReporteCaja
	(
	@Accion			CHAR(3),
	@fechai			date			=null,
	@fechaf			date			=null,	
	@Cajero			varchar(30)		=NULL,	
	@Departamento	VARCHAR(20)		=NULL	
	)
AS
BEGIN
	

	IF @Accion = 'SE'

	BEGIN
		
		SELECT Cajero,Fecha,Nombre,Cantidad,Venta, Utilidad 
		FROM viReporteCaja
		WHERE (Fecha is null OR( Fecha  between @fechai and @fechaf))
		AND (@Departamento IS NULL OR (Nombre = @Departamento or Nombre is null))
		AND (@Cajero IS NULL OR (Cajero = @Cajero or Cajero is null))
		union	
		SELECT  'Total',null,null,SUM(a.Cantidad),SUM( (dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Venta,SUM((i.Precio_U - i.Costo) * a.Cantidad) Utilidad 
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
		AND (@Cajero IS NULL OR (Cajero = @Cajero or Cajero is null))
		order by Fecha desc
		
	END 

	
END;
GO
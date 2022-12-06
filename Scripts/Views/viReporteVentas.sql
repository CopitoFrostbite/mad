USE MAD_PF;

GO

IF OBJECT_ID('viReporteVentas') IS NOT NULL
BEGIN
	DROP VIEW viReporteVentas;
END;
GO

CREATE View viReporteVentas 
AS
SELECT  v.Orden,v.Caja,Fecha,d.Nombre,i.ID,i.Descripcion,i.Precio_U,a.Cantidad,(a.Cantidad * i.Precio_U) Subtotal,(I.Precio_U - dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad Descuento, (dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad Venta,(i.Precio_U - i.Costo) * a.Cantidad Utilidad 
		FROM Ventas V
		LEFT JOIN Articulos A
			ON v.Orden = a.Orden
		LEFT JOIN Inventario I
			ON a.Articulo = i.ID
		LEFT JOIN Descuentos De
			ON I.Descuento = De.ID_Des
		LEFT JOIN Departamento D
			ON i.Clave = d.Clave
		

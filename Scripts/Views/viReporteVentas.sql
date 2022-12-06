USE MAD_PF;

GO

IF OBJECT_ID('viReporteVentas') IS NOT NULL
BEGIN
	DROP VIEW viReporteVentas;
END;
GO

CREATE View viReporteVentas 
AS
SELECT  Fecha,d.Nombre,i.ID,i.Precio_U,v.Caja,sum(a.Cantidad)as 'Cantidad',sum((a.Cantidad * i.Precio_U)) Subtotal,sum((I.Precio_U - dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Descuento,sum( (dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Venta,sum((i.Precio_U - i.Costo) * a.Cantidad) Utilidad 
		FROM Ventas V
		inner JOIN Articulos A
			ON v.Orden = a.Orden
		inner JOIN Inventario I
			ON a.Articulo = i.ID
		inner JOIN Descuentos De
			ON I.Descuento = De.ID_Des
		inner JOIN Departamento D
			ON i.Clave = d.Clave
		group by Fecha,d.Nombre,v.Caja,i.ID,i.Precio_U
		union	
		SELECT  null,null,null,null,null,SUM(a.Cantidad),SUM((a.Cantidad * i.Precio_U)) Subtotal,SUM((I.Precio_U - dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Descuento,SUM( (dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Venta,SUM((i.Precio_U - i.Costo) * a.Cantidad) Utilidad 
		FROM Ventas V
		inner JOIN Articulos A
			ON v.Orden = a.Orden
		inner JOIN Inventario I
			ON a.Articulo = i.ID
		inner JOIN Descuentos De
			ON I.Descuento = De.ID_Des
		inner JOIN Departamento D
			ON i.Clave = d.Clave
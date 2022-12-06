USE MAD_PF;

GO

IF OBJECT_ID('viReporteCaja') IS NOT NULL
BEGIN
	DROP VIEW viReporteCaja;
END;
GO

CREATE View viReporteCaja 
AS
SELECT  v.Cajero,Fecha,d.Nombre,sum(a.Cantidad)as 'Cantidad',sum((a.Cantidad * i.Precio_U)) Subtotal,sum((I.Precio_U - dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Descuento,sum( (dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Venta,sum((i.Precio_U - i.Costo) * a.Cantidad) Utilidad 
		FROM Ventas V
		inner JOIN Articulos A
			ON v.Orden = a.Orden
		inner JOIN Inventario I
			ON a.Articulo = i.ID
		inner JOIN Descuentos De
			ON I.Descuento = De.ID_Des
		inner JOIN Departamento D
			ON i.Clave = d.Clave
		group by v.Cajero,Fecha,d.Nombre
		

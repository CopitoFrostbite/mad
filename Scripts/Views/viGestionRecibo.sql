USE MAD_PF;

GO

IF OBJECT_ID('viGestionRecibo') IS NOT NULL
BEGIN
	DROP VIEW viGestionRecibo;
END;
GO

CREATE View viGestionRecibo 
AS
SELECT  T.Nombre,T.Sucursal,t.Direccion,t.Mensaje1,t.Mensaje2,t.Mensaje3,t.Mensaje4,A.Orden,Articulo,I.Descripcion Producto, a.Precio Precio,Cantidad,a.Precio - dbo.fnGetDes(a.Precio,D.Porcentaje,D.Activo) Descuento,dbo.fnGetDes(a.Precio,D.Porcentaje,D.Activo) Subtotal, (dbo.fnGetDes(a.Precio,D.Porcentaje,D.Activo))*A.Cantidad TotalProd,v.Descuento DescuentoTotal ,v.Total,v.Pago  ,R.Cambio, de.Devolucion Devolucion,v.Caja,v.Fecha  
		
		FROM Recibo R
		LEFT JOIN Articulos A
			ON R.N_Ticket = a.Orden
		LEFT JOIN Inventario I
			ON A.Articulo = I.ID
		LEFT JOIN Descuentos D
			ON I.Descuento = D.ID_Des
		LEFT JOIN Tienda T
			ON R.Ti_ID = t.ID
		LEFT JOIN Ventas V
			ON v.Orden = a.Orden
		LEFT JOIN Departamento De
			on i.Clave = de.Clave;
		

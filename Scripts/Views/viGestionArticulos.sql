USE MAD_PF;

GO

IF OBJECT_ID('viGestionArticulos') IS NOT NULL
BEGIN
	DROP VIEW viGestionArticulos;
END;
GO

CREATE View viGestionArticulos 
AS
SELECT  Orden,Articulo,I.Descripcion Producto, Precio_U Precio,Cantidad,I.Precio_U - dbo.fnGetDes(I.Precio_U,D.Porcentaje,D.Activo) Descuento,dbo.fnGetDes(I.Precio_U,D.Porcentaje,D.Activo) Subtotal, (dbo.fnGetDes(I.Precio_U,D.Porcentaje,D.Activo))*A.Cantidad Total  
		
		FROM Articulos A
		LEFT JOIN Inventario I
			ON A.Articulo = I.ID
		LEFT JOIN Descuentos D
			ON I.Descuento = D.ID_Des;
			
		
		

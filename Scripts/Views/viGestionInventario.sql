USE MAD_PF;

GO

IF OBJECT_ID('viGestionInventario') IS NOT NULL
BEGIN
	DROP VIEW viGestionInventario;
END;
GO

CREATE View viGestionInventario 
AS
SELECT  I.ID,I.Descripcion Producto,Precio_U Precio, Existencia,dbo.fnGetDesA(D.Activo,D.Porcentaje) Descuento,Eliminado
		FROM Inventario I
		LEFT JOIN Descuentos D
			ON I.Descuento = D.ID_Des
		
		
		

USE MAD_PF;

GO

IF OBJECT_ID('viReporteInventario') IS NOT NULL
BEGIN
	DROP VIEW viReporteInventario;
END;
GO

CREATE View viReporteInventario 
AS
SELECT  I.ID,I.Descripcion Producto,D.Nombre Departamento,U.Nombre Unidad,Precio_U Precio,Costo, Existencia,U_Vendidas Unidades_Vendidas, Merma, Pun_Reorden
		FROM Inventario I
		LEFT JOIN Departamento D
			ON I.Clave = D.Clave
		LEFT JOIN Unidades U
			ON I.U_Medida = u.ID
		
		
		
		

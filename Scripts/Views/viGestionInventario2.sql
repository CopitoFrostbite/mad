USE MAD_PF;

GO

IF OBJECT_ID('viGestionInventario2') IS NOT NULL
BEGIN
	DROP VIEW viGestionInventario2;
END;
GO

CREATE View viGestionInventario2 
AS
SELECT  I.ID,I.Descripcion Producto,I.Pun_Reorden PR, I.Existencia,I.Eliminado
		FROM Inventario I
		
		
		
		

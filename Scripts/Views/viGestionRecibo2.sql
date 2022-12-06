USE MAD_PF;

GO

IF OBJECT_ID('viGestionRecibo2') IS NOT NULL
BEGIN
	DROP VIEW viGestionRecibo2;
END;
GO

CREATE View viGestionRecibo2 
AS
SELECT  A.Orden,Articulo,Cantidad
		
		FROM Articulos A
		left join Inventario I
		on a.Articulo = i.ID

		
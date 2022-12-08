USE MAD_PF;

GO

IF OBJECT_ID('viGestionDevoluciones') IS NOT NULL
BEGIN
	DROP VIEW viGestionDevoluciones;
END;
GO

CREATE View viGestionDevoluciones 
AS
SELECT  D.Recibo, d.ID_Dev Articulo, i.Descripcion Nombre,d.Motivo Motivo, d.Merma Merma, d.Cantidad Cantidad, d.Subtotal Subtotal, d.Total Total, De.Devolucion Devolucion
		
		FROM Devoluciones D		
		LEFT JOIN Inventario I
			ON d.ID_Dev = I.ID		
		LEFT JOIN Departamento De
			on i.Clave = de.Clave;
		

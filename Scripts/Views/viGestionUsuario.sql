USE MAD_PF;

GO

IF OBJECT_ID('viGestionUsuarios') IS NOT NULL
BEGIN
	DROP VIEW viGestionUsuarios;
END;
GO

CREATE View viGestionUsuarios
AS
SELECT    ID,Usuario,(Nombre) +' '+ (Ap_Pat) +' '+ (Ap_Mat) Nombre, Estado Activo
		FROM Usuarios U
		
		
		
		

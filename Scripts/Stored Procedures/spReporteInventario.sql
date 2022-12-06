USE MAD_PF;

GO

IF OBJECT_ID('spReporteInventario') IS NOT NULL
BEGIN
	DROP PROCEDURE spReporteInventario;
END;
GO

CREATE PROCEDURE spReporteInventario
	(
	@Accion			CHAR(3),	
	@Existencia		BIT				=NULL,
	@Pun_Reorden	BIT				=NULL,	
	@Merma			BIT				=NULL,
	@Departamento	VARCHAR(20)		=NULL	
	)
AS
BEGIN
	

	IF @Accion = 'SE'

	BEGIN
		
		SELECT  ID,Producto,Departamento,Unidad,Precio,Costo,Existencia,Unidades_Vendidas as 'Ventas',Merma
		FROM viReporteInventario
		WHERE (@Pun_Reorden IS NULL OR  Existencia < Pun_Reorden)
		AND (@Departamento IS NULL OR Departamento = @Departamento)
		AND (@Existencia IS NULL OR Existencia = 0)
		AND (@Merma IS NULL OR Merma > 0)
		
	END; 

	
END;
GO
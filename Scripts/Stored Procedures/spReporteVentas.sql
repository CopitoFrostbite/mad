USE MAD_PF;

GO

IF OBJECT_ID('spReporteVentas') IS NOT NULL
BEGIN
	DROP PROCEDURE spReporteVentas;
END;
GO

CREATE PROCEDURE spReporteVentas
	(
	@Accion			CHAR(3),
	@fechai			date			=null,
	@fechaf			date			=null,	
	@Caja			int				=NULL,	
	@Departamento	VARCHAR(20)		=NULL	
	)
AS
BEGIN
	

	IF @Accion = 'SE'

	BEGIN
		
		SELECT  ID,Producto,Departamento,Unidad,Precio,Costo,Existencia,Unidades_Vendidas as 'Ventas',Merma
		FROM viReporteInventario
		WHERE (@fechai IS NULL OR  Existencia < Pun_Reorden)
		AND (@Departamento IS NULL OR Departamento = @Departamento)
		AND (@Existencia IS NULL OR Existencia = 0)
		AND (@Merma IS NULL OR Merma > 0)
		
	END; 

	
END;
GO
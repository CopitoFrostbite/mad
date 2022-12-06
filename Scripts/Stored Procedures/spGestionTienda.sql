USE MAD_PF;

GO

IF OBJECT_ID('spGestionTienda') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionTienda;
END;
GO

CREATE PROCEDURE spGestionTienda
	(
	@Accion			CHAR(3),
	@ID				INT				=NULL,
	@Nombre			VARCHAR(30)		=NULL,
	@Sucursal		VARCHAR(30)		=NULL,
	@Direccion		VARCHAR(50)		=NULL,
	@Mensaje1		VARCHAR(50)		=NULL,
	@Mensaje2		VARCHAR(50)		=NULL,
	@Mensaje3		VARCHAR(50)		=NULL,
	@Mensaje4		VARCHAR(70)		=NULL
	
	
	)
AS
BEGIN
	
	
	IF @Accion = 'IN'
	BEGIN
		
		INSERT INTO Tienda(Nombre,Sucursal,Direccion,Mensaje1,Mensaje2,Mensaje3,Mensaje4)
			VALUES ('','','','','','','')
	END;

	

	IF @Accion = 'UP'
	BEGIN
		UPDATE Tienda
			SET
			Nombre			=	@Nombre,
			Sucursal		=	@Sucursal,
			Direccion		=	@Direccion,
			Mensaje1		=	@Mensaje1,
			Mensaje2		=	@Mensaje2,
			Mensaje3		=	@Mensaje3,
			Mensaje4		=	@Mensaje4
				
			WHERE ID	= 1;			
	END;

	

	IF @Accion = 'SE'
	BEGIN
		SELECT  Nombre,Sucursal,Direccion,Mensaje1,Mensaje2,Mensaje3,Mensaje4
		FROM Tienda
		WHERE ID	= 1;
		
	END;

	

	
END;
GO
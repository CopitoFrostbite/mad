USE MAD_PF;

GO

IF OBJECT_ID('spGestionDepartamento') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionDepartamento;
END;
GO

CREATE PROCEDURE spGestionDepartamento
	(	
	@Accion			CHAR(3),
	@Clave			INT				=NULL,	
	@Nombre			VARCHAR(30)		=NULL,
	@Devolucion		BIT				=NULL
	)
AS
BEGIN
	
	

	IF @Accion = 'IN'
	BEGIN
		
		INSERT INTO Departamento(Nombre,Devolucion)
			VALUES(@Nombre,@Devolucion)
	END;

	IF @Accion = 'UP'
	BEGIN
		UPDATE Departamento
			SET
				
				Nombre			= @Nombre,	
				Devolucion		= @Devolucion
				
			WHERE Clave			= @Clave;			
	END;

	IF @Accion = 'DE'
	BEGIN
		DELETE FROM Departamento
		WHERE Clave = @Clave; 
	END;

	

	IF @Accion = 'SE'
	BEGIN
		SELECT  Clave,Nombre,Devolucion
		FROM Departamento
		WHERE Clave = @Clave;
	END;

	IF @Accion = 'SE2'
	BEGIN
		SELECT  Clave,Nombre Departamento
		FROM Departamento
		
	END;

	IF @Accion = 'SE3'
	BEGIN
		SELECT  Clave,Nombre,Devolucion
		FROM Departamento
		
	END;

	
	
END;
GO
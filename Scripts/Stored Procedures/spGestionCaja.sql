USE MAD_PF;

GO

IF OBJECT_ID('spGestionCaja') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionCaja;
END;
GO

CREATE PROCEDURE spGestionCaja
	(
	@Accion			CHAR(3),
	@Numero			INT			=NULL,
	@Disponibilidad BIT			=NULL
	)
AS
BEGIN
	
	

	IF @Accion = 'IN'
	BEGIN
		
		INSERT INTO Caja(Disponibilidad)
			VALUES(1)
	END;

	IF @Accion = 'UP'
	BEGIN
		UPDATE Caja
			SET				
				Disponibilidad	= @Disponibilidad	
				
			WHERE Numero			= @Numero;			
	END;

	IF @Accion = 'DE'
	BEGIN
		DELETE FROM Caja
		WHERE Numero = @Numero; 
	END;

	

	IF @Accion = 'SE'
	BEGIN
		SELECT  Numero,Disponibilidad
		FROM Caja
		WHERE Numero = @Numero;
	END;

	IF @Accion = 'SE2'
	BEGIN
		SELECT  Numero,Disponibilidad
		FROM Caja
		WHERE Disponibilidad = 1;
	END;

	IF @Accion = 'SE3'
	BEGIN
		SELECT  Numero,Disponibilidad
		FROM Caja
		
	END;
END;
GO
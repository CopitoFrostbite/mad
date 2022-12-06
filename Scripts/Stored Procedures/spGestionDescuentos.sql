USE MAD_PF;

GO

IF OBJECT_ID('spGestionDescuentos') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionDescuentos;
END;
GO

CREATE PROCEDURE spGestionDescuentos
	(
	@Accion			CHAR(3),
	@ID_Des			INT				=NULL,
	@Descripcion	VARCHAR(30)		=NULL,
	@Fecha_I		Date			=NULL,
	@Fecha_F		Date			=NULL,
	@Porcentaje		INT				=NULL,
	@Activo			BIT				=NULL
	
	)
AS
BEGIN
	
	DECLARE @Fec DATE
	DECLARE @FI	   DATE
	DECLARE @FF    DATE
	DECLARE @min	int
	DECLARE @max    int
	SET @Fec = GETDATE() 
	SELECT @min = min(ID_DES), @max = max(ID_Des)
	FROM Descuentos

	IF @Accion = 'IN'
	BEGIN
		
		INSERT INTO Descuentos(Descripcion,Fecha_I,Fecha_F,Porcentaje,Activo)
			VALUES(@Descripcion,@Fecha_I,@Fecha_F,@Porcentaje,0)
	END;

	IF @Accion = 'UP'
	BEGIN
		UPDATE Descuentos
			SET
				Descripcion		= @Descripcion,
				Fecha_I			= @Fecha_I,	
				Fecha_F			= @Fecha_F,
				Porcentaje		= @Porcentaje
				
				
			WHERE ID_Des		= @ID_Des;			
	END;

	IF @Accion = 'UP2'

	  
	  BEGIN
		WHILE(@min IS NOT NULL AND @min <= @max)
			BEGIN
				
				SELECT @FI = (Fecha_I), @FF = (Fecha_F)
				FROM Descuentos
				WHERE ID_Des = @min		
				UPDATE Descuentos		
				SET Activo = dbo.fnCheckdate(@FI,@FF)
				WHERE ID_Des = @min
				SET @MIN  = @min  + 1 
			END
		
	  END
	

	IF @Accion = 'DE'
	BEGIN
		DELETE FROM Descuentos
		WHERE ID_Des		= @ID_Des; 
	END;

	

	IF @Accion = 'SE'
	BEGIN
		SELECT  ID_Des ID,Descripcion,Fecha_I Fecha_Inicio,Fecha_F Fecha_Final,Porcentaje,Activo
		FROM Descuentos
		WHERE ID_Des		= @ID_Des;
	END;

	IF @Accion = 'SE2'
	BEGIN
		SELECT ID_Des ID_Descuento, Descripcion Descuento
		FROM Descuentos
		
	END;

	IF @Accion = 'SE3'
	BEGIN
		SELECT  ID_Des ID,Descripcion,Fecha_I Fecha_Inicio,Fecha_F Fecha_Final,Porcentaje,Activo
		FROM Descuentos
		
	END;

	IF @Accion = 'SE4'
	BEGIN
		SELECT  ID_Des ID,Descripcion,Fecha_I Fecha_Inicio,Fecha_F Fecha_Final,Porcentaje
		FROM Descuentos
		
	END;
	
END;
GO
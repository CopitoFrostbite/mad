USE MAD_PF;

GO

IF OBJECT_ID('spGestionInventario') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionInventario;
END;
GO

CREATE PROCEDURE spGestionInventario
	(
	@Accion			CHAR(3),
	@ID				INT				=NULL,
	@U_Medida		VARCHAR(20)		=NULL,
	@Descripcion	VARCHAR(30)		=NULL,
	@Costo			SMALLMONEY		=NULL,
	@Precio_U		SMALLMONEY		=NULL,
	@Fecha_Alta		DATE			=NULL,
	@Existencia		DECIMAL(13,2)	=NULL,
	@Pun_Reorden	DECIMAL(13,2)	=NULL,
	@Eliminado		BIT				=NULL,
	@U_Vendidas		DECIMAL(13,2)	=NULL, 
	@Merma			DECIMAL(13,2)	=NULL,
	@Clave			INT				=NULL, --(FK Departamento),
	@Descuento		INT				=NULL--(FK Descuento),
	)
AS
BEGIN
	
	DECLARE @IDF VARCHAR(20)
				

	IF @Accion = 'IN'
	BEGIN
		SET @Fecha_Alta = GETDATE();
		 

		INSERT INTO Inventario(U_Medida,Descripcion,Costo,Precio_U,Fecha_Alta,Existencia,Pun_Reorden,Eliminado,U_Vendidas,Merma,Clave,Descuento)
			VALUES(@U_Medida,@Descripcion,@Costo,@Precio_U,@Fecha_Alta,@Existencia,@Pun_Reorden,0,0,0,@Clave,@Descuento)
	END;

	IF @Accion = 'UP'
	BEGIN
		UPDATE Inventario
			SET
				U_Medida			=@U_Medida,
				Descripcion			=@Descripcion,
				Costo				=@Costo,
				Precio_U			=@Precio_U,
				Fecha_Alta			=@Fecha_Alta,
				Existencia			=@Existencia,
				Pun_Reorden			=@Pun_Reorden,
				Eliminado			=@Eliminado,
				U_Vendidas			=@U_Vendidas, 
				Merma				=@Merma,
				Clave				=@Clave, --(FK Departamento),
				Descuento			=@Descuento--(FK Descuento),
				

			WHERE ID			= @ID;			
	END;

	IF @Accion = 'UP2'
	BEGIN
		UPDATE Inventario
			SET
				
				Existencia			=Existencia - @Existencia,
				
				U_Vendidas			=U_Vendidas + @Existencia 
				
				

			WHERE ID			= @ID;			
	END;

	IF @Accion = 'UP3'
	BEGIN
		UPDATE Inventario
			SET
				
				Existencia			=Existencia + @Existencia,
				
				U_Vendidas			=U_Vendidas - @Existencia 
				
				

			WHERE ID			= @ID;			
	END;

	IF @Accion = 'UP4'
	BEGIN
		UPDATE Inventario
			SET
				
				Merma				=Merma + @Existencia,
				
				U_Vendidas			=U_Vendidas - @Existencia 
				
				

			WHERE ID			= @ID;			
	END;

	

	IF @Accion = 'DE'
	BEGIN
		DELETE FROM Inventario
		WHERE ID = @ID; 
	END;

	IF @Accion = 'BO'
	BEGIN
		UPDATE Inventario
			SET Eliminado = 1
		WHERE ID = @ID; 
	END;
	 
	IF @Accion = 'SE'

	BEGIN
		
		SELECT  ID,U_Medida,I.Descripcion,Costo,Precio_U,Fecha_Alta,Existencia,Pun_Reorden,Eliminado,U_Vendidas,Merma,Clave,D.Porcentaje,D.Activo
		FROM Inventario I
		LEFT JOIN Descuentos D
			ON I.Descuento = D.ID_Des
		WHERE ID = @ID AND Eliminado = 0 ;
	END;

	IF @Accion = 'SE2'
	BEGIN
		SELECT  ID,U_Medida,Descripcion,Costo,Precio_U,Fecha_Alta,Existencia,Pun_Reorden,Eliminado,U_Vendidas,Merma,Clave,Descuento
		FROM Inventario
		WHERE Eliminado = 0;
	END;

	IF @Accion = 'SE3'
	BEGIN
		SELECT  ID,U_Medida,Descripcion,Costo,Precio_U,Fecha_Alta,Existencia,Pun_Reorden,Eliminado,U_Vendidas,Merma,Clave,Descuento
		FROM Inventario
		WHERE Eliminado = 0 AND Existencia<Pun_Reorden;
	END;

	IF @Accion = 'SE4'

	BEGIN
		
		SELECT  ID,Producto,Precio,Existencia,Descuento
		FROM viGestionInventario
		
		WHERE  Producto	LIKE  '%' + @descripcion + '%' AND Eliminado = 0 AND Existencia > 0 ;
	END;

	IF @Accion = 'SE5'

	BEGIN
		

		SELECT  ID,Producto,Precio,Existencia,Descuento
		FROM viGestionInventario
		
		WHERE ID = @ID AND Eliminado = 0 AND Existencia > 0 ;
	END;

	IF @Accion = 'SE6'

	BEGIN
		
		SELECT  ID,U_Medida,I.Descripcion,Costo,Precio_U,Fecha_Alta,Existencia,Pun_Reorden,Eliminado,U_Vendidas,Merma,Clave,Descuento
		FROM Inventario I
		
		
	END;

	IF @Accion = 'SE7'

	BEGIN
		
		SELECT  ID,Producto 
		FROM viGestionInventario2
		
		
	END;
	IF @Accion = 'SE8'

	BEGIN
		
		SELECT  ID,Producto,PR,Existencia 
		FROM viGestionInventario2
		WHERE Eliminado = 0 AND Existencia<PR;
		
	END;
END;
GO
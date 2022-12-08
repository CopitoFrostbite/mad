USE MAD_PF;

IF EXISTS (SELECT name FROM sysobjects
      WHERE name = 'tpHistorial' AND type = 'TR')
   DROP TRIGGER tpHistorial

GO

CREATE TRIGGER tpHistorial
	ON Inventario
	AFTER UPDATE 
	
	
AS
	

	 BEGIN
        INSERT INTO Historial_Cambios (ID_usuario, ID_Inven, U_Medida, Descripcion,Costo,Precio_U,Fecha_Alta,Existencia,Pun_Reorden,Eliminado,U_Vendidas,Merma,Clave,Descuento,Fecha_cambio)
		SELECT a.ID  ,d.ID, U_Medida, Descripcion,Costo,Precio_U,Fecha_Alta,Existencia,Pun_Reorden,Eliminado,U_Vendidas,Merma,Clave,Descuento, GETDATE()
		FROM deleted d, ##GlobalVariables a	;
		
	 END;	
GO

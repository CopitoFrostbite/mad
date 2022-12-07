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
        INSERT INTO Historial_Cambios (ID_usuario, ID_Inven, quantity, updated_at)
		SELECT id, item, quantity, GETDATE()
		FROM deleted;
	 END;	
GO

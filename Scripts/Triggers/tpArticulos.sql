
USE MAD_PF;




IF EXISTS (SELECT name FROM sysobjects
      WHERE name = 'tpArt' AND type = 'TR')
   DROP TRIGGER tpArt

GO

CREATE TRIGGER tpArt
	ON Articulos
	FOR INSERT  
	
	
AS
	DECLARE @can DECIMAL(13,2),@exi DECIMAL(13,2) , @art INT
	
	SELECT @can = A.Cantidad, @art = A.Articulo 

	FROM inserted A

	SELECT  @exi = Existencia
	FROM Inventario  
		
	WHERE ID = @art
	
	IF (@can) > (@exi)

	 BEGIN
        RAISERROR('Seleccione una menor cantidad!', 16, 1);
        ROLLBACK TRANSACTION;
	 END;	
GO

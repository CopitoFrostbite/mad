USE MAD_PF;




IF EXISTS (SELECT name FROM sysobjects
      WHERE name = 'tpcomp' AND type = 'TR')
   DROP TRIGGER tpcomp

GO

CREATE TRIGGER tpcomp		
ON Articulos
INSTEAD OF INSERT
AS
BEGIN
    -- Verificar si el art�culo ya existe en la tabla
	
    IF EXISTS (SELECT 1 FROM Articulos a,inserted i WHERE a.Articulo = i.Articulo and a.Orden  = i.Orden)
    BEGIN
       IF (SELECT a.Cantidad FROM Articulos a,inserted i WHERE a.Articulo = i.Articulo and a.Orden  = i.Orden) + (select i.Cantidad from inserted i) > (SELECT Existencia FROM Inventario,inserted i WHERE ID = i.Articulo)
	   BEGIN
			-- Mostrar un mensaje de error y cancelar la operaci�n de inserci�n
			RAISERROR ('No hay suficiente cantidad de art�culos en inventario', 16, 1);
			ROLLBACK TRANSACTION;
		END
		ELSE
		BEGIN
		 -- Actualizar el n�mero de art�culos de ese art�culo en la tabla
			UPDATE Articulos
			SET Cantidad = Cantidad +(select i.Cantidad from inserted i)
			WHERE Articulo = (select i.Articulo from inserted i) and Orden  = (select i.Orden from inserted i);
			UPDATE Articulos
			SET Total = (Cantidad * (select i.Precio from inserted i))
			WHERE Articulo = (select i.Articulo from inserted i) and Orden  = (select i.Orden from inserted i);
		END
    END
    ELSE
    BEGIN
      
	   DECLARE @Orden			INT	   = (select i.Orden from inserted i)
	   DECLARE @Articulo		INT		= (select i.Articulo from inserted i)		
		DECLARE @Cantidad		DECIMAL(13,2)	= (select i.Cantidad from inserted i)
		DECLARE @Monto			SMALLMONEY		= (select i.Precio from inserted i)
		DECLARE @Subtotal		SMALLMONEY		= (select i.Total from inserted i)
		
        INSERT INTO Articulos(Orden,Articulo,Cantidad,Precio,total)
			VALUES (@Orden,@Articulo,@Cantidad,@Monto,@Subtotal)
    END
		
end
	
GO

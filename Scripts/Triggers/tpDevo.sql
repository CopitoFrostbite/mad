USE MAD_PF;




IF EXISTS (SELECT name FROM sysobjects
      WHERE name = 'tpdevo' AND type = 'TR')
   DROP TRIGGER tpdevo

GO

CREATE TRIGGER tpdevo		
ON Devoluciones
INSTEAD OF INSERT
AS
BEGIN
   
	
    IF EXISTS (SELECT 1 FROM Devoluciones a,inserted i WHERE a.Recibo = i.Recibo and a.ID_Dev  = i.ID_Dev)
    BEGIN
       IF (SELECT a.Cantidad FROM Devoluciones a,inserted i WHERE a.Recibo = i.Recibo and a.ID_Dev  = i.ID_Dev) + (select i.Cantidad from inserted i) > (SELECT r.Cantidad FROM Articulos r,inserted i WHERE r.Articulo = i.ID_Dev and r.Orden = i.Recibo)
	   BEGIN
			
			RAISERROR ('No hay suficiente cantidad de artículos en el recibo', 16, 1);
			ROLLBACK TRANSACTION;
		END
		ELSE
		BEGIN
		 
			UPDATE Devoluciones
			SET Cantidad = Cantidad +(select i.Cantidad from inserted i)
			WHERE ID_Dev = (select i.ID_Dev from inserted i) and Recibo  = (select i.Recibo from inserted i);
			UPDATE Devoluciones
			SET Total = (Cantidad * (select i.Subtotal from inserted i))
			WHERE ID_Dev = (select i.ID_Dev from inserted i) and Recibo  = (select i.Recibo from inserted i);
		END
    END
    ELSE
    BEGIN
      
	   DECLARE @Recibo			INT				= (select i.Recibo from inserted i)
	   DECLARE @ID_Dev			INT				= (select i.ID_Dev from inserted i)		
		DECLARE @Motivo			varchar(30)		= (select i.Motivo from inserted i)
		DECLARE @Merma			bit				= (select i.Merma from inserted i)
		DECLARE @Cantidad		DECIMAL(13,2)		= (select i.Cantidad from inserted i)
		DECLARE @Subtotal		SMALLMONEY		= (select i.Subtotal from inserted i)
		DECLARE @Total			SMALLMONEY		= (select i.Total from inserted i)
		
        INSERT INTO Devoluciones(Recibo,ID_Dev,Motivo,Merma,Cantidad,Subtotal,Total,Devuelto)
			VALUES(@Recibo,@ID_Dev,@Motivo,@Merma,@Cantidad,@Subtotal,@Total,0)
    END
		
end
	
GO

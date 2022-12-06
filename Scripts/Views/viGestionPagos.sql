USE MAD_PF;

GO

IF OBJECT_ID('viGestionPagos') IS NOT NULL
BEGIN
	DROP VIEW viGestionPagos;
END;
GO

CREATE View viGestionPagos 
AS
SELECT  Orden,Num_Pago Pago,pa.Metodo Metodo,Monto
		
		FROM Pagos P
		LEFT JOIN Pago Pa
			ON P.M_Pago = pa.ID_Pago
		
			
		
		

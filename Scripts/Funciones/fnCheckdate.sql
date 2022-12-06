USE MAD_PF;

GO

IF OBJECT_ID('fnCheckdate') IS NOT NULL
BEGIN
	DROP FUNCTION fnCheckdate;
END;
GO

CREATE FUNCTION fnCheckdate (@FI DATE,@FF DATE)


RETURNS bit

AS
BEGIN
	DECLARE @FECHA DATE
	
	SET @Fecha = GETDATE() 
	
 
	
	  BEGIN
		
		IF (@FI is null or @ff is null )
		return 0;
		IF @Fecha >= @FI AND @Fecha <= @FF 	
		
		RETURN 1;
		 

			
		
	  END
	
	return 0
END


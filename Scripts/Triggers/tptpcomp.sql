USE MAD_PF;




IF EXISTS (SELECT name FROM sysobjects
      WHERE name = 'tpcomp' AND type = 'TR')
   DROP TRIGGER tpcomp

GO

CREATE TRIGGER tpcomp
	ON Recibo
	FOR INSERT  
	
	
AS
	DECLARE @i int = 1;
	DECLARE @can INT,@exi INT, @art INT,@can2 int
	Declare @max int;
	SELECT @max = max(Orden)
	FROM ventas
	while @i <= (select count(Orden) from Articulos a where a.Orden = @max)
begin
	
	SELECT  @art = Articulo,@can = Cantidad, @can2 = Existencia
	FROM (
	SELECT   Articulo, Cantidad,  Existencia, ROW_NUMBER() OVER (PARTITION BY orden ORDER BY articulos DESC) [Fila]
	FROM Articulos A
		left join Inventario I
		on a.Articulo = i.ID)T1
	where [Fila]=@i
	
	SELECT  @art = Articulo,@can = Cantidad, @can2 = Existencia
	FROM Articulos A
		left join Inventario I
		on a.Articulo = i.ID)
		
		where orden = @max and Articulo = @i
		
		UPDATE inventario SET Existencia = @can2 - @can
		where ID = @art
		SET @i = @i+1
		
end
	
GO

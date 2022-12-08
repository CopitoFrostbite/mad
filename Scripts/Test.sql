USE MAD_PF;
EXEC spGestionUsuarios 'IN',NULL,'hitora','abolfo','gomez','nose','1234','curdp3','08/05/2002','nomdineroplz','awa@hot.com',null,0,null
EXEC spGestionUsuarios 'IN',NULL,'copito','rob','ruiz','si','dfg45','curdpd','08/05/2012','nom','ewr@hot.com',null,1,null
EXEC spGestionDepartamento 'IN',NULL,'depa1',0
EXEC spGestionDepartamento 'IN',NULL,'depa2',1
EXEC spGestionDepartamento 'IN',NULL,'depa3',0
EXEC spGestionDepartamento 'IN',NULL,'depa4',1
EXEC spGestionDescuentos 'IN',NULL,'desc','11/13/2022','11/30/2022',30
EXEC spGestionDescuentos 'IN',NULL,'desc2','5/2/2023','5/2/2023',50
EXEC spGestionDescuentos 'IN',NULL,'desc3','5/1/2022','5/1/2022',10
EXEC spGestionInventario 'IN',NULL,'cm','prod1','$50.00','$90.00',null,20,15,null,3,1,'s',null
EXEC spGestionInventario 'IN',NULL,'L','prod2','$70.00','$90.00',null,5,15,null,5,0,1,1
EXEC spGestionInventario 'IN',NULL,'unidades','prod3','$30.00','$50.00',null,2,25,null,2,1,2,0
EXEC spGestionInventario 'SE4',NULL,NULL,'1',NULL,NULL,null,NULL,NULL,null,NULL,NULL,NULL,NULL
EXEC spGestionDescuentos 'UP2'
EXEC spGestionVentas	'IN',NULL,'1','hitora','' ,$0.00

EXEC spGestionVentas	'IN',NULL,'2', $0.00

EXEC spGestionArticulos  'IN',null,'2','2',null,null

EXEC spGestionArticulos  'IN','2','3','2','0','0'
EXEC spGestionArticulos  'IN','1','2','2','0','0'
EXEC spGestionArticulos  'IN','1','1','2','0','0'
EXEC spGestionArticulos  'SE', '1'
EXEC spGestionArticulos  'SE3', '1'
EXEC spGestionArticulos  'SE4'
SELECT * FROM viGestionArticulos
SELECT * FROM viGestionInventario
SELECT * FROM Articulos
SELECT * FROM Inventario
SELECT * FROM Articulos A LEFT JOIN Inventario I	ON A.Articulo = I.ID LEFT JOIN Descuentos D	ON I.Descuento = D.ID_Des	WHERE Orden		= 1
SELECT * FROM Usuarios
SELECT * FROM Caja
SELECT * FROM Inventario
SELECT * FROM Unidades
select * from Ventas
SELECT * FROM Articulos
select * from Pagos
SELECT * FROM Departamento
SELECT * FROM viGestionInventario
SELECT * FROM Descuentos
SELECT * FROM Articulos
SELECT * FROM viGestionArticulos
SELECT * FROM Pago
SELECT * FROM Departamento
exec spGestionDepartamento 'SE2'
select * from Devoluciones
 SELECT * FROM Inventario
SElECT * FROM Tienda
select * from Recibo
select * from viGestionRecibo where orden = 1
select * from viGestionRecibo
SELECT 100 - 100*.20 SUMA
SELECT 100 - (100 * 20/100) SUMA
SELECT 100 * 100 / 20
EXEC spLogin 0,'1234'
EXEC spGestionInventario'SE6'
EXEC spGestionInventario'SE7'
EXEC spGestionArticulos  'DE','','1','0','0','0'
EXEC spLogin 'HiTorA','1234'

exec spGestionArticulos 'SE3'
EXEC spGestionRecibo'SE3', 1
exec spReporteInventario 'SE',null,1,null,'ewe'

SELECT  ID,Producto,Departamento,Unidad,Precio,Costo,Existencia,Unidades_Vendidas as 'Ventas',Merma
		FROM viReporteInventario
		WHERE (@Pun_Reorden IS NULL OR  Existencia < Pun_Reorden)
		AND (@Departamento IS NULL OR Departamento = @Departamento)
		AND (@Existencia IS NULL OR Existencia = 0)
		AND (@Merma IS NULL OR Merma > 0)
		group by ID

SELECT  Fecha,d.Nombre,i.ID,i.Precio_U,v.Caja,sum(a.Cantidad)as 'Cantidad',sum((a.Cantidad * i.Precio_U)) Subtotal,sum((I.Precio_U - dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Descuento,sum( (dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Venta,sum((i.Precio_U - i.Costo) * a.Cantidad) Utilidad 
		FROM Ventas V
		inner JOIN Articulos A
			ON v.Orden = a.Orden
		inner JOIN Inventario I
			ON a.Articulo = i.ID
		inner JOIN Descuentos De
			ON I.Descuento = De.ID_Des
		inner JOIN Departamento D
			ON i.Clave = d.Clave
		group by Fecha,d.Nombre,v.Caja,i.ID,i.Precio_U
		union	
		SELECT  null,null,null,null,null,SUM(a.Cantidad),SUM((a.Cantidad * i.Precio_U)) Subtotal,SUM((I.Precio_U - dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Descuento,SUM( (dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Venta,SUM((i.Precio_U - i.Costo) * a.Cantidad) Utilidad 
		FROM Ventas V
		inner JOIN Articulos A
			ON v.Orden = a.Orden
		inner JOIN Inventario I
			ON a.Articulo = i.ID
		inner JOIN Descuentos De
			ON I.Descuento = De.ID_Des
		inner JOIN Departamento D
			ON i.Clave = d.Clave
			where Caja = 3
			order by Fecha desc

		SELECT Fecha,Nombre,ID,Precio_U,Caja,Cantidad,Subtotal, Descuento, Venta, Utilidad 
		FROM viReporteVentas
		WHERE (Fecha is null OR( Fecha  between '2022-12-04' and '2022-12-06'))
		AND (null IS NULL OR (Nombre = NULL or Nombre is null))
		AND (3 IS NULL OR (Caja = null or Caja is null))
		union	
		SELECT  null,null,null,null,null,SUM(a.Cantidad),SUM((a.Cantidad * i.Precio_U)) Subtotal,SUM((I.Precio_U - dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Descuento,SUM( (dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad) Venta,SUM((i.Precio_U - i.Costo) * a.Cantidad) Utilidad 
		FROM Ventas V
		inner JOIN Articulos A
			ON v.Orden = a.Orden
		inner JOIN Inventario I
			ON a.Articulo = i.ID
		inner JOIN Descuentos De
			ON I.Descuento = De.ID_Des
		inner JOIN Departamento D
			ON i.Clave = d.Clave
		WHERE (Fecha is null OR( Fecha  between '2022-12-04' and '2022-12-06'))
		AND (null IS NULL OR (Nombre = NULL or Nombre is null))
		AND (3 IS NULL OR (Caja = 3 or Caja is null))
		order by Fecha desc

	SELECT  Nombre,[Contrasenia], Usuario,Nivel_cuenta	
	FROM Usuarios	
	WHERE Usuario = 'Admin' AND [Contrasenia] = 1234;
	
	IF OBJECT_ID('tempdb.dbo.#GlobalVariables') IS NOT NULL
	BEGIN
	DROP TABLE #GlobalVariables
	END

	SELECT   ID,Usuario
	INTO dbo.#GlobalVariables
	FROM Usuarios
	WHERE Usuario = 'hitora' AND [Contrasenia] = 'Koalaaa8!';
		select * from #GlobalVariables
		select * from ##GlobalVariables

	exec spLogin 'hitora','Koalaaa8!'
	exec spLogin 'Admin','1234'
	select * from Historial_Cambios
	select * from Inventario

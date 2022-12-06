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

EXEC spGestionArticulos  'IN','1','3','2','0','0'
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

SELECT  v.Orden,v.Caja,Fecha,d.Nombre,i.ID,i.Descripcion,i.Precio_U,a.Cantidad,(a.Cantidad * i.Precio_U) Subtotal,(I.Precio_U - dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad Descuento, (dbo.fnGetDes(I.Precio_U,De.Porcentaje,De.Activo))*a.Cantidad Venta,(i.Precio_U - i.Costo) * a.Cantidad Utilidad 
		FROM Ventas V
		LEFT JOIN Articulos A
			ON v.Orden = a.Orden
		LEFT JOIN Inventario I
			ON a.Articulo = i.ID
		LEFT JOIN Descuentos De
			ON I.Descuento = De.ID_Des
		LEFT JOIN Departamento D
			ON i.Clave = d.Clave
		group by v.Orden,Fecha,d.Nombre,v.Caja,i.ID,i.Precio_U
		order by v.Orden
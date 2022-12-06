USE MAD_PF;

EXEC spGestionCaja 'IN'
EXEC spGestionCaja 'IN'
EXEC spGestionCaja 'IN'
EXEC spGestionCaja 'IN'
EXEC spGestionCaja 'IN'

EXEC spGestionPago 'IN',NULL,'Efectivo'
EXEC spGestionPago 'IN',NULL,'Debito'
EXEC spGestionPago 'IN',NULL,'Credito'
EXEC spGestionPago 'IN',NULL,'Cheque'
EXEC spGestionPago 'IN',NULL,'Vale'
EXEC spGestionPago 'IN',NULL,'Otro'

EXEC spGestionUnidades 'IN',NULL,'Pieza'
EXEC spGestionUnidades 'IN',NULL,'Kilogramo'
EXEC spGestionUnidades 'IN',NULL,'Gramo'
EXEC spGestionUnidades 'IN',NULL,'Litro'
EXEC spGestionUnidades 'IN',NULL,'Mililitro'


EXEC spGestionUsuarios 'IN',NULL,'Admin','Roberto','ruiz','si','1234','curdpd','08/05/2012','nom','ewr@hot.com',null,1,null
EXEC spGestionTienda	'IN'
EXEC spGestionDescuentos 'IN',NULL,'Precio Base','01/01/1992','01/01/2992',0,0
EXEC spGestionDepartamento'IN',NULL,'Sin Departamento',1
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
EXEC spGestionUnidades 'IN',NULL,'Elemento'
EXEC spGestionUnidades 'IN',NULL,'Unidad de servicio'
EXEC spGestionUnidades 'IN',NULL,'Kilogramo'
EXEC spGestionUnidades 'IN',NULL,'Gramo'
EXEC spGestionUnidades 'IN',NULL,'Tarifa'
EXEC spGestionUnidades 'IN',NULL,'Metro'
EXEC spGestionUnidades 'IN',NULL,'Pulgada'
EXEC spGestionUnidades 'IN',NULL,'Pie'
EXEC spGestionUnidades 'IN',NULL,'Yarda'
EXEC spGestionUnidades 'IN',NULL,'Milla'
EXEC spGestionUnidades 'IN',NULL,'Metro Cuadrado'
EXEC spGestionUnidades 'IN',NULL,'Galon (UK)'
EXEC spGestionUnidades 'IN',NULL,'Galon (US)'
EXEC spGestionUnidades 'IN',NULL,'Hora'
EXEC spGestionUnidades 'IN',NULL,'Dia'
EXEC spGestionUnidades 'IN',NULL,'Year'
EXEC spGestionUnidades 'IN',NULL,'Batch'
EXEC spGestionUnidades 'IN',NULL,'A granel'
EXEC spGestionUnidades 'IN',NULL,'Lote'
EXEC spGestionUnidades 'IN',NULL,'Hora de trabajo'
EXEC spGestionUnidades 'IN',NULL,'Variedad'
EXEC spGestionUnidades 'IN',NULL,'Cabeza'
EXEC spGestionUnidades 'IN',NULL,'Personas'
EXEC spGestionUnidades 'IN',NULL,'Conjunto'
EXEC spGestionUnidades 'IN',NULL,'Caja'
EXEC spGestionUnidades 'IN',NULL,'Kit'
EXEC spGestionUnidades 'IN',NULL,'Bloque'


EXEC spGestionUsuarios 'IN',NULL,'Admin','Roberto','ruiz','si','1234','curdpd','08/05/2012','nom','ewr@hot.com',null,1,null
EXEC spGestionTienda	'IN'
EXEC spGestionDescuentos 'IN',NULL,'Precio Base','01/01/1992','01/01/2992',0,0
EXEC spGestionDepartamento'IN',NULL,'Sin Departamento',1
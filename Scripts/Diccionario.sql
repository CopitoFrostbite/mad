USE MAD_PF;

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del numero de pedido',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Articulos',
@level2type = N'Column' , @level2name = 'Orden'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador de los articulos a devolver',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Articulos',
@level2type = N'Column' , @level2name = 'Articulo'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Cantidad de los articulos a comprar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Articulos',
@level2type = N'Column' , @level2name = 'Cantidad'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Suma parcial de los articulos para obtener el total general',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Articulos',
@level2type = N'Column' , @level2name = 'Precio'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Resultado completo de todos los articulos',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Articulos',
@level2type = N'Column' , @level2name = 'Total'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del numero de caja',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Caja',
@level2type = N'Column' , @level2name = 'Numero'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del estado de caja',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Caja',
@level2type = N'Column' , @level2name = 'Disponibilidad'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del departamento',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Departamento',
@level2type = N'Column' , @level2name = 'Clave'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Nombre del departamento',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Departamento',
@level2type = N'Column' , @level2name = 'Nombre'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Devolucion en caso de que se permita en el departamento',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Departamento',
@level2type = N'Column' , @level2name = 'Devolucion'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del apartado descuentos',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Descuentos',
@level2type = N'Column' , @level2name = 'ID_Des'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Descripcion del descuento a aplicar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Descuentos',
@level2type = N'Column' , @level2name = 'Descripcion'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Fecha de inicio del descuento',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Descuentos',
@level2type = N'Column' , @level2name = 'Fecha_I'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Fecha de fin del descuento',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Descuentos',
@level2type = N'Column' , @level2name = 'Fecha_F'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Porcentaje del descuento a aplicar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Descuentos',
@level2type = N'Column' , @level2name = 'Porcentaje'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Estado de validación del descuento',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Descuentos',
@level2type = N'Column' , @level2name = 'Activo'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador de los recibos para devolucion',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Devoluciones',
@level2type = N'Column' , @level2name = 'Recibo'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del inventario para devoluciones',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Devoluciones',
@level2type = N'Column' , @level2name = 'ID_Dev'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Motivo de devolucion',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Devoluciones',
@level2type = N'Column' , @level2name = 'Motivo'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Perdida de mercancía',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Devoluciones',
@level2type = N'Column' , @level2name = 'Merma'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Cantidad de devoluciones',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Devoluciones',
@level2type = N'Column' , @level2name = 'Cantidad'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Subtotal de las devoluciones',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Devoluciones',
@level2type = N'Column' , @level2name = 'Subtotal'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Total de las devoluciones',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Devoluciones',
@level2type = N'Column' , @level2name = 'Total'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador para el historial de cambios',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'ID'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del usuario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'ID_usuario'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'ID_Inven'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Unidad de medida del producto a cambiar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'U_Medida'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Descripcion del producto a cambiar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'Descripcion'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Costo del producto a cambiar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'Costo'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Precio unitario del producto a cambiar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'Precio_U'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Fecha en que se realizo el alta',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'Fecha_Alta'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Existencia en inventario a cambiar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'Existencia'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Punto de reorden para cambiar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'Pun_Reorden'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Eliminado en el inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'Eliminado'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Unidades vendidas a cambiar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'U_Vendidas'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Perdida de mercancia a cambiar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'Merma'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del articulo a cambiar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'Clave'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del descuento a cambiar',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'Descuento'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Fecha de cambio',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_cambios',
@level2type = N'Column' , @level2name = 'Fecha_cambio'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'ID'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Valor de unidad de medida del articulo en el inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'U_Medida'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Descripcion del articulo en el inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'Descripcion'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Costo del articulo en el inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'Costo'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Precio del articulo en el inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'Precio_U'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Fecha de alta en el inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'Fecha_Alta'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Existencia en inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'Existencia'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Punto de reorden para abastecer el inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'Pun_Reorden'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Eliminado en el inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'Eliminado'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Unidades vendidas del inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'U_Vendidas'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Perdida de mercancia del inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'Merma'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del articulo en el inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'Clave'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del descuento en el inventario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Inventario',
@level2type = N'Column' , @level2name = 'Descuento'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador para el metodo de pago',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pago',
@level2type = N'Column' , @level2name = 'ID_Pago'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Metodo de pago',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pago',
@level2type = N'Column' , @level2name = 'Metodo'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del orden de pedido',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pagos',
@level2type = N'Column' , @level2name = 'Orden'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del numero de pago',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pagos',
@level2type = N'Column' , @level2name = 'Num_Pago'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del metodo de pago',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pagos',
@level2type = N'Column' , @level2name = 'M_Pago'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Cantidad futura del pago',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pagos',
@level2type = N'Column' , @level2name = 'Monto'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del numero de ticket',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Recibo',
@level2type = N'Column' , @level2name = 'N_Ticket'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del ticket',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Recibo',
@level2type = N'Column' , @level2name = 'Ti_ID'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Cambio de articulo',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Recibo',
@level2type = N'Column' , @level2name = 'Cambio'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador de la tienda',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Tienda',
@level2type = N'Column' , @level2name = 'ID'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Nombre de la tienda',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Tienda',
@level2type = N'Column' , @level2name = 'Nombre'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Sucursal de la tienda',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Tienda',
@level2type = N'Column' , @level2name = 'Sucursal'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Dirección de la sucursal de la tienda',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Tienda',
@level2type = N'Column' , @level2name = 'Direccion'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Mensaje 1 de la tienda',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Tienda',
@level2type = N'Column' , @level2name = 'Mensaje1'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Mensaje 2 de la tienda',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Tienda',
@level2type = N'Column' , @level2name = 'Mensaje2'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Mensaje 3 de la tienda',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Tienda',
@level2type = N'Column' , @level2name = 'Mensaje3'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Mensaje 4 de la tienda',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Tienda',
@level2type = N'Column' , @level2name = 'Mensaje4'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador de las Unidades',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Unidades',
@level2type = N'Column' , @level2name = 'ID'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Nombre de las Unidades',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Unidades',
@level2type = N'Column' , @level2name = 'Nombre'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del usuario ',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'ID'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Nombre visible del usuario ',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'Usuario'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Nombre del usuario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'Nombre'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Apellido paterno',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'Ap_Pat'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Apellido materno',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'Ap_Mat'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Contraseña para acceder',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'Contrasenia'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'CURP del usuario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'CURP'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Fecha de Nacimiento',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'F_Nac'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Nomina del usuario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'Nomina'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Correo del usuario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'Correo'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Fecha de ingreso del usuario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'Fec_Ing'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del nivel de cuenta',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'Nivel_cuenta'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Estado del usuario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'Estado'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador de la orden en ventas',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Ventas',
@level2type = N'Column' , @level2name = 'Orden'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Conector a la caja desde ventas',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Ventas',
@level2type = N'Column' , @level2name = 'Caja'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Conector al cajero desde ventas',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Ventas',
@level2type = N'Column' , @level2name = 'Cajero'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Fecha de las ventas',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Ventas',
@level2type = N'Column' , @level2name = 'Fecha'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Desuento de las ventas',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Ventas',
@level2type = N'Column' , @level2name = 'Descuento'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Total de ventas',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Ventas',
@level2type = N'Column' , @level2name = 'Total'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Pago de ventas',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Ventas',
@level2type = N'Column' , @level2name = 'Pago'


Select 
    --d.object_id,
    a.name [table], 
    --schema_name(a.schema_id) schema_name, 
    --a.create_date,
    b.name [column], 
    c.name [type], 
    CASE
        WHEN c.name = 'numeric' OR  c.name = 'decimal' OR c.name = 'float' THEN b.precision
        ELSE null
    END [Precision], 
    b.max_length, 
    CASE 
        WHEN b.is_nullable = 0 THEN 'NO'
        ELSE 'SI'
    END [Permite Nulls],
    CASE 
        WHEN b.is_identity = 0 THEN 'NO'
        ELSE 'SI'
    END [Es Autonumerico],
    ep.value [Descripcion],
    f.ForeignKey,
    f.ReferenceTableName,
    f.ReferenceColumnName
from sys.tables a 
    inner join sys.columns b on a.object_id= b.object_id 
    inner join sys.systypes c on b.system_type_id= c.xtype 
    inner join sys.objects d on a.object_id= d.object_id 
    LEFT JOIN sys.extended_properties ep ON d.object_id = ep.major_id AND b.column_Id = ep.minor_id
    LEFT JOIN (SELECT 
                f.name AS ForeignKey,
                OBJECT_NAME(f.parent_object_id) AS TableName,
                COL_NAME(fc.parent_object_id,fc.parent_column_id) AS ColumnName,
                OBJECT_NAME (f.referenced_object_id) AS ReferenceTableName,
                COL_NAME(fc.referenced_object_id,fc.referenced_column_id) AS ReferenceColumnName
                FROM sys.foreign_keys AS f
                INNER JOIN sys.foreign_key_columns AS fc ON f.OBJECT_ID = fc.constraint_object_id)     f ON f.TableName =a.name AND f.ColumnName =b.name
WHERE a.name <> 'sysdiagrams' 
ORDER BY a.name,b.column_Id
	--Esta es la base de datos
CREATE DATABASE MAD_PF;

USE MAD_PF;

CREATE TABLE Estado
(
Estado INT IDENTITY (0,1) PRIMARY KEY,
Valor VARCHAR(15) NOT NULL,
);

CREATE TABLE Nivel_cuenta
(
Niv_cuenta INT IDENTITY(0,1) PRIMARY KEY,
Rol VARCHAR(30)NOT NULL,
);

CREATE TABLE Usuarios
(
ID INT IDENTITY(0,1) PRIMARY KEY, 
Nombre VARCHAR(30) NOT NULL,
Ap_Pat VARCHAR(30) NOT NULL,
Ap_Mat VARCHAR(30),
Contrasenia VARCHAR(30) NOT NULL,
CURP VARCHAR(16) NOT NULL,
F_Nac DATE NOT NULL,
Nomina VARCHAR(30) NOT NULL,
Correo VARCHAR(30)NOT NULL,
Fec_Ing DATE DEFAULT CAST(GETDATE()AS DATE),
Nivel_cuenta INT FOREIGN KEY REFERENCES Nivel_cuenta(Niv_cuenta),
Estado INT FOREIGN KEY REFERENCES Estado(Estado)
);

CREATE TABLE Caja
(
Numero INT IDENTITY(0,1) PRIMARY KEY,
Disponibilidad INT FOREIGN KEY REFERENCES Estado(Estado),
);

CREATE TABLE Turnos
(
Turno INT IDENTITY(0,1) PRIMARY KEY,
Valor VARCHAR(12)NOT NULL,
);

CREATE TABLE Historial_Caja
(
ID_usuario INT FOREIGN KEY REFERENCES Usuarios(ID),
Numero INT FOREIGN KEY REFERENCES Caja(Numero),
Fecha DATE DEFAULT CAST(GETDATE()AS DATE),
Turno INT FOREIGN KEY REFERENCES Turnos(Turno),
Hora TIME NOT NULL,
CONSTRAINT PK_Historial_Caja PRIMARY KEY(ID_usuario, Numero, Turno)
);

CREATE TABLE Recibo
(
N_Ticket INT IDENTITY(1,1) PRIMARY KEY,
Cambio SMALLMONEY NOT NULL,
);

CREATE TABLE Ventas
(
Orden INT IDENTITY(1,1) PRIMARY KEY,
Caja INT FOREIGN KEY REFERENCES Caja(Numero),	
Total SMALLMONEY NOT NULL,
Ticket INT FOREIGN KEY REFERENCES Recibo(N_Ticket), 
);

CREATE TABLE Eliminado
(
ID INT IDENTITY(0,1) PRIMARY KEY,
Estado VARCHAR(15)
);

CREATE TABLE Departamento
(
Clave INT IDENTITY (0,1) PRIMARY KEY ,
Nombre VARCHAR(30) NOT NULL,
Devolucion INT NOT NULL,
);

CREATE TABLE Descuentos
(
ID_Des INT IDENTITY(0,1) PRIMARY KEY,
Descripción VARCHAR(30) NOT NULL,
Fecha_I DATE NOT NULL,
Fecha_F DATE NOT NULL,
Porcentaje INT NOT NULL,
);

CREATE TABLE Merma
(
Merma INT IDENTITY (0,1) PRIMARY KEY,
Valor VARCHAR(2)
);

CREATE TABLE Inventario
(
ID INT IDENTITY(1,1) PRIMARY KEY,
U_Medida VARCHAR(20) NOT NULL,
Descripcion TEXT NOT NULL,
Costo SMALLMONEY NOT NULL,
Precio_U SMALLMONEY NOT NULL,
Fecha_Alta DATE NOT NULL,
Existencia INT NOT NULL,
Pun_Reorden INT NOT NULL,
Eliminado INT FOREIGN KEY REFERENCES Eliminado(ID),
U_Vendidas INT NOT NULL, 
Merma INT NOT NULL,
Clave INT FOREIGN KEY REFERENCES Departamento(Clave),
Descuento INT FOREIGN KEY REFERENCES Descuentos(ID_Des)
);

CREATE TABLE Articulos
(
Orden INT FOREIGN KEY REFERENCES Ventas(Orden), --PK (FK ventas),
Articulo INT FOREIGN KEY REFERENCES Inventario(ID), --(PK FK ID inventario),
Cantidad INT NOT NULL,
Monto SMALLMONEY NOT NULL,
Subtotal SMALLMONEY NOT NULL,
Total SMALLMONEY NOT NULL,
CONSTRAINT PK_Articulos PRIMARY KEY (Orden, Articulo)
);

CREATE TABLE Pago
(
ID_Pago INT IDENTITY (0,1) PRIMARY KEY,
Tarjeta_credito SMALLMONEY NOT NULL,
Tarjeta_Debito  SMALLMONEY NOT NULL,
Efectivo SMALLMONEY NOT NULL,
Cheque SMALLMONEY NOT NULL,
Vale SMALLMONEY NOT NULL
);

CREATE TABLE Pagos
(
Orden INT FOREIGN KEY REFERENCES Ventas(Orden),
Num_Pago INT PRIMARY KEY,
M_Pago INT FOREIGN KEY REFERENCES Pago(ID_Pago),
Monto SMALLMONEY NOT NULL,
Total_Pago SMALLMONEY NOT NULL
);


CREATE TABLE Historial_cambios
(
ID_usuario INT FOREIGN KEY REFERENCES Usuarios(ID),
ID_Inven INT FOREIGN KEY REFERENCES Inventario(ID),
Fecha_cambio DATE,
CONSTRAINT PK_Historial_Cambios PRIMARY KEY (ID_usuario,ID_Inven)
);


CREATE TABLE Devoluciones
(
Recibo INT FOREIGN KEY REFERENCES Recibo(N_Ticket),-- PK (FK N. Ticket),
ID_Dev INT FOREIGN KEY REFERENCES Inventario(ID),-- PK (FK inventario),
Motivo VARCHAR(30),
Merma INT FOREIGN KEY REFERENCES Merma(Merma),--(FK merma),
Cantidad INT NOT NULL,
Subtotal SMALLMONEY NOT NULL,
Total SMALLMONEY NOT NULL,
);


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
@name = N'MS_Description' , @value = 'Es el valor acumulado del articulo',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Articulos',
@level2type = N'Column' , @level2name = 'Monto'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Suma parcial de los articulos para obtener el total general',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Articulos',
@level2type = N'Column' , @level2name = 'Subtotal'

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
@level2type = N'Column' , @level2name = 'Descripción'

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
@name = N'MS_Description' , @value = 'Identificador de las eliminaciones',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Eliminado',
@level2type = N'Column' , @level2name = 'ID'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Estado de las eliminaciones',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Eliminado',
@level2type = N'Column' , @level2name = 'Estado'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del estado',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Estado',
@level2type = N'Column' , @level2name = 'Estado'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Valor del estado',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Estado',
@level2type = N'Column' , @level2name = 'Valor'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del usuario',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_Caja',
@level2type = N'Column' , @level2name = 'ID_usuario'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del numero de caja',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_Caja',
@level2type = N'Column' , @level2name = 'Numero'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Fecha del historial de la caja',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_Caja',
@level2type = N'Column' , @level2name = 'Fecha'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Turno de la caja',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_Caja',
@level2type = N'Column' , @level2name = 'Turno'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Hora de la caja',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Historial_Caja',
@level2type = N'Column' , @level2name = 'Hora'

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
@name = N'MS_Description' , @value = 'Fecha en que se realizo el cambio',
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
@name = N'MS_Description' , @value = 'Identificador de mercancia perdida',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Merma',
@level2type = N'Column' , @level2name = 'Merma'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Valor del merma',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Merma',
@level2type = N'Column' , @level2name = 'Valor'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del nivel de cuenta',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Nivel_cuenta',
@level2type = N'Column' , @level2name = 'Niv_cuenta'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Tipo de rol de la cuenta',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Nivel_cuenta',
@level2type = N'Column' , @level2name = 'Rol'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador para el metodo de pago',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pago',
@level2type = N'Column' , @level2name = 'ID_Pago'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Metodo de pago con tarjeta de credito',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pago',
@level2type = N'Column' , @level2name = 'Tarjeta_credito'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Metodo de pago con tarjeta de debito',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pago',
@level2type = N'Column' , @level2name = 'Tarjeta_debito'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Metodo de pago con efectivo',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pago',
@level2type = N'Column' , @level2name = 'Efectivo'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Metodo de pago con cheque',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pago',
@level2type = N'Column' , @level2name = 'Cheque'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Metodo de pago con vale',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pago',
@level2type = N'Column' , @level2name = 'Vale'


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
@name = N'MS_Description' , @value = 'Total general del pago',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Pagos',
@level2type = N'Column' , @level2name = 'Total_Pago'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del numero de ticket',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Recibo',
@level2type = N'Column' , @level2name = 'N_Ticket'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Cambio de articulo',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Recibo',
@level2type = N'Column' , @level2name = 'Cambio'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del turno',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Turnos',
@level2type = N'Column' , @level2name = 'Turno'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Valor del turno',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Turnos',
@level2type = N'Column' , @level2name = 'Valor'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Identificador del usuario ',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Usuarios',
@level2type = N'Column' , @level2name = 'ID'

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
@name = N'MS_Description' , @value = 'Total de ventas',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Ventas',
@level2type = N'Column' , @level2name = 'Total'

EXEC sp_addextendedproperty
@name = N'MS_Description' , @value = 'Conector de ticket desde ventas',
@level0type = N'Schema' , @level0name = 'dbo',
@level1type = N'Table' , @level1name = 'Ventas',
@level2type = N'Column' , @level2name = 'Ticket'

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

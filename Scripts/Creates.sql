
USE MAD_PF;



IF OBJECT_ID('Historial_Cambios') IS NOT NULL
	DROP TABLE Historial_Cambios;
CREATE TABLE Historial_Cambios
(
ID INT IDENTITY(1,1) PRIMARY KEY,
ID_usuario INT NOT NULL, -- (FK Usuarios),
ID_Inven INT NOT NULL, -- (FK Inventario),
U_Medida INT NOT NULL,
Descripcion  VARCHAR(30) NOT NULL,
Costo SMALLMONEY NOT NULL,
Precio_U SMALLMONEY NOT NULL,
Fecha_Alta DATE NOT NULL,
Existencia DECIMAL(13,2) NOT NULL,
Pun_Reorden DECIMAL(13,2) NOT NULL,
Eliminado BIT NOT NULL,
U_Vendidas DECIMAL(13,2) NOT NULL, 
Merma DECIMAL(13,2) NOT NULL,
Clave INT NOT NULL,
Descuento INT,
Fecha_cambio DATE
);

IF OBJECT_ID('Devoluciones') IS NOT NULL
	DROP TABLE Devoluciones;
CREATE TABLE Devoluciones
(
Recibo INT NOT NULL,-- PK (FK N. Ticket),
ID_Dev INT NOT NULL,-- PK (FK inventario),
Motivo VARCHAR(30),
Merma BIT NOT NULL ,
Cantidad DECIMAL(13,2) NOT NULL,
Subtotal SMALLMONEY NOT NULL,
Total SMALLMONEY NOT NULL,
Devuelto bit not null
);

IF OBJECT_ID('Recibo') IS NOT NULL
	DROP TABLE Recibo;
CREATE TABLE Recibo
(
N_Ticket INT  PRIMARY KEY NOT NULL,--(FK ventas)
Ti_ID INT NOT NULL,
Cambio SMALLMONEY NOT NULL,
);

IF OBJECT_ID('Articulos') IS NOT NULL
	DROP TABLE Articulos;
CREATE TABLE Articulos
(
Orden INT NOT NULL, --PK (FK ventas),
Articulo INT NOT NULL, --(PK FK inventario),
Cantidad DECIMAL(13,2) NOT NULL,
Precio SMALLMONEY NOT NULL,
Total SMALLMONEY NOT NULL,
);

IF OBJECT_ID('Inventario') IS NOT NULL
	DROP TABLE Inventario;
CREATE TABLE Inventario
(
ID INT IDENTITY(1,1) PRIMARY KEY,
U_Medida INT NOT NULL,--(FK Unidades)
Descripcion  VARCHAR(30) NOT NULL,
Costo SMALLMONEY NOT NULL,
Precio_U SMALLMONEY NOT NULL,
Fecha_Alta DATE NOT NULL,
Existencia DECIMAL(13,2) NOT NULL,
Pun_Reorden DECIMAL(13,2) NOT NULL,
Eliminado BIT NOT NULL,
U_Vendidas DECIMAL(13,2) NOT NULL, 
Merma DECIMAL(13,2) NOT NULL,
Clave INT NOT NULL, --(FK Departamento),
Descuento INT, --(FK Descuento),
);

IF OBJECT_ID('Departamento') IS NOT NULL
	DROP TABLE Departamento;
CREATE TABLE Departamento
(
Clave INT IDENTITY (0,1) PRIMARY KEY ,
Nombre VARCHAR(30) NOT NULL,
Devolucion BIT NOT NULL,
);

IF OBJECT_ID('Descuentos') IS NOT NULL
	DROP TABLE Descuentos;
CREATE TABLE Descuentos
(
ID_Des INT IDENTITY(0,1) PRIMARY KEY,
Descripcion VARCHAR(30) NOT NULL,
Fecha_I DATE NOT NULL,
Fecha_F DATE NOT NULL,
Porcentaje INT NOT NULL,
Activo BIT NOT NULL,
);

IF OBJECT_ID('Pagos') IS NOT NULL
	DROP TABLE Pagos;
CREATE TABLE Pagos
(
Orden INT NOT NULL, --PK(FK Ventas),
Num_Pago INT NOT NULL, --PK
M_Pago INT NOT NULL, --(FK Pago),
Monto SMALLMONEY NOT NULL,

);

IF OBJECT_ID('Ventas') IS NOT NULL
	DROP TABLE Ventas;
CREATE TABLE Ventas
(
Orden INT IDENTITY(1,1) PRIMARY KEY,
Caja INT NOT NULL, --(FK Caja)
Cajero VARCHAR (30)  COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL, --(FK Usuario)
Fecha DATE NOT NULL,
Descuento SMALLMONEY NOT NULL,	
Total SMALLMONEY NOT NULL,
Pago SMALLMONEY NOT NULL
);

IF OBJECT_ID('Usuarios') IS NOT NULL
	DROP TABLE Usuarios;
CREATE TABLE Usuarios
(
ID INT IDENTITY(0,1) PRIMARY KEY,
Usuario VARCHAR(30)  COLLATE SQL_Latin1_General_CP1_CS_AS UNIQUE NOT NULL,
Nombre VARCHAR(30) NOT NULL,
Ap_Pat VARCHAR(30) NOT NULL,
Ap_Mat VARCHAR(30),
Contrasenia VARCHAR(30) NOT NULL,
CURP VARCHAR(18) NOT NULL,
F_Nac DATE NOT NULL,
Nomina VARCHAR(30) NOT NULL,
Correo VARCHAR(30)NOT NULL,
Fec_Ing DATE DEFAULT CAST(GETDATE()AS DATE),
Nivel_cuenta BIT NOT NULL,
Estado BIT NOT NULL,
 
);

IF OBJECT_ID('Caja') IS NOT NULL
	DROP TABLE Caja;
CREATE TABLE Caja
(
Numero INT IDENTITY(1,1) PRIMARY KEY,
Disponibilidad BIT NOT NULL,
);

IF OBJECT_ID('Pago') IS NOT NULL
	DROP TABLE Pago;
CREATE TABLE Pago
(
ID_Pago INT IDENTITY (0,1) PRIMARY KEY,
Metodo VARCHAR(20)
);

IF OBJECT_ID('Unidades') IS NOT NULL
	DROP TABLE Unidades;
CREATE TABLE Unidades
(
ID INT IDENTITY (1,1) PRIMARY KEY,
Nombre VARCHAR(30) 

);

IF OBJECT_ID('Tienda') IS NOT NULL
	DROP TABLE Tienda;
CREATE TABLE Tienda
(
ID INT IDENTITY (1,1) PRIMARY KEY,
Nombre VARCHAR(30) , 
Sucursal  VARCHAR(30),  
Direccion  VARCHAR(50),
Mensaje1   VARCHAR(200),
Mensaje2   VARCHAR(200),
Mensaje3   VARCHAR(200),
Mensaje4   VARCHAR(200),

);

ALTER TABLE Inventario
	ADD CONSTRAINT FK_Inventario FOREIGN KEY (Clave) REFERENCES Departamento(Clave),
		FOREIGN KEY (U_Medida) REFERENCES Unidades(ID),
		FOREIGN KEY (Descuento) REFERENCES Descuentos(ID_Des);

ALTER TABLE Recibo
	ADD CONSTRAINT FK_Recibo FOREIGN KEY (N_Ticket) REFERENCES Ventas(Orden),
		FOREIGN KEY (Ti_ID) REFERENCES Tienda(ID);

ALTER TABLE Articulos
	ADD  CONSTRAINT PK_Articulos PRIMARY KEY (Orden, Articulo),
		FOREIGN KEY (Articulo) REFERENCES Inventario(ID),
		FOREIGN KEY (Orden) REFERENCES Ventas(Orden);

ALTER TABLE Devoluciones
	ADD CONSTRAINT FK_Devoluciones PRIMARY KEY (Recibo, ID_Dev),
		FOREIGN KEY (Recibo) REFERENCES Recibo(N_Ticket),
		FOREIGN KEY (ID_Dev) REFERENCES Inventario(ID);



ALTER TABLE Ventas
	ADD  CONSTRAINT FK_Ventas FOREIGN KEY (Caja) REFERENCES Caja(Numero),
		FOREIGN KEY (Cajero) REFERENCES Usuarios(Usuario);

ALTER TABLE Pagos
	ADD  CONSTRAINT PK_Pagos PRIMARY KEY (Orden,Num_Pago),
		FOREIGN KEY (Orden) REFERENCES Ventas(Orden),
		FOREIGN KEY (M_Pago) REFERENCES Pago(ID_Pago);

ALTER TABLE Historial_Cambios
	ADD  CONSTRAINT PK_Historial_Cambios 
		FOREIGN KEY (ID_Inven) REFERENCES Inventario(ID),
		FOREIGN KEY (ID_Usuario) REFERENCES Usuarios(ID);
		

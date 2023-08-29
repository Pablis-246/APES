create database APES;
use APES;

create table Diseño(
  CodDiseño int PRIMARY KEY NOT NULL,
  Nombre varchar(50),
  Genero varchar(50),
  FechaCreacion date,
  Aprobacion bit
);

create table Proveedor_Materiales(
  CodMateriales int PRIMARY KEY NOT NULL,
  Nombre varchar(50),
  Cantidad int,
  Estado bit
);

create table Fabricacion(
  CodFabricacion int PRIMARY KEY NOT NULL,
  CodDiseño int,
  CodMateriales int,
  FechaFabricacion date,
  ProductoTerminado bit,
  CONSTRAINT fk_Fabricacion_CodDiseño FOREIGN KEY (CodDiseño) REFERENCES Diseño (CodDiseño),
  CONSTRAINT fk_Fabricacion_CodMateriales FOREIGN KEY (CodMateriales) REFERENCES Proveedor_Materiales (CodMateriales)
);

create table Productos(
  CodProducto int PRIMARY KEY NOT NULL,
  CodFabricacion int,
  Nombre varchar(50),
  Estado bit,
  CONSTRAINT fk_Productos_CodFabricacion FOREIGN KEY (CodFabricacion) REFERENCES Fabricacion (CodFabricacion)
);

create table Deposito(
  CodDeposito int PRIMARY KEY NOT NULL,
  CantidadMaxima int,
  Direccion varchar(50),
  Localidad varchar(50)
);

create table Producto_Deposito(
  CodProducto int,
  CodDeposito int,
  FechaExportacion date,
  CONSTRAINT fk_Producto_Deposito_CodProducto FOREIGN KEY (CodProducto) REFERENCES Productos (CodProducto),
  CONSTRAINT fk_Producto_Deposito_CodDeposito FOREIGN KEY (CodDeposito) REFERENCES Deposito (CodDeposito)
);

create table Local(
  CodLocal int PRIMARY KEY NOT NULL,
  Direccion varchar(50),
  Localidad varchar(50)
);

create table Deposito_Local(
  CodDeposito int,
  CodLocal int,
  CONSTRAINT fk_Deposito_Local_CodDeposito FOREIGN KEY (CodDeposito) REFERENCES Deposito (CodDeposito),
  CONSTRAINT fk_Deposito_Local_CodLocal FOREIGN KEY (CodLocal) REFERENCES Local (CodLocal)
);

create table Cliente(
  CodCliente int PRIMARY KEY NOT NULL,
  Nombre varchar(50),
  Apellido varchar(50),
  DNI varchar(10),
  Telefono int
);

create table Presupuesto(
  CodPresupuesto int PRIMARY KEY NOT NULL,
  CodCliente int,
  Nombre varchar(50),
  NombreProducto varchar(50),
  PrecioUnidad int,
  Cantidad int,
  PrecioFinal int,
  CONSTRAINT fk_Presupuesto_CodCliente FOREIGN KEY (CodCliente) REFERENCES Cliente (CodCliente)
);

create table Factura(
  CodFacturaVentas int PRIMARY KEY NOT NULL,
  CodPresupuesto int,
  CodCliente int,
  Nombre varchar(50),
  Apellido varchar(50),
  DNI varchar(10),
  Telefono int,
  PrecioTotal float,
  FechaVenta date,
  CONSTRAINT fk_Factura_CodPresupuesto FOREIGN KEY (CodPresupuesto) REFERENCES Presupuesto (CodPresupuesto),
  CONSTRAINT fk_Factura_CodCliente FOREIGN KEY (CodCliente) REFERENCES Cliente (CodCliente)
);

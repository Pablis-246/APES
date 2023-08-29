INSERT INTO Diseño (CodDiseño, Nombre, Genero, FechaCreacion, Aprobacion) VALUES
(137, 'Pantalón Friza', 'Feminino', '2022-11-19', 1),
(293, 'Chomba', 'Masculino', '2022-11-19', 0),
(338, 'Falda', 'Feminino', '2022-11-01', 1),
(416, 'Cargo Pantalon', 'Masculino', '2022-11-05', 1),
(509, 'Campera sin Capucha', 'Masculino', '2022-11-18', 0),
(673, 'Buzo', 'Masculino', '2022-11-15', 0),
(793, 'Short Jean', 'Feminino', '2022-11-12', 1),
(816, 'Chaleco Inflable', 'Masculino', '2022-11-07', 1),
(984, 'Remera Cuello V', 'Masculino', '2022-11-11', 0),
(1032, 'Saco Solapa Redonda', 'Feminino', '2022-11-02', 1),
(1134, 'Campera con Capucha', 'Masculino', '2022-11-18', 1),
(1290, 'Remera Algodon', 'Masculino', '2022-11-04', 0),
(1382, 'Camisa Cuadrille', 'Fememino', '2022-11-09', 1),
(1435, 'Buzo Friza', 'Masculino', '2022-11-12', 1),
(1516, 'Saco Blazer', 'Masculino', '2022-11-06', 1);

INSERT INTO Proveedor_Materiales (CodMateriales, Nombre, Cantidad, Estado) VALUES
(15, 'Tela Gabardina Negro', 1, 1),
(21, 'Tela Algodon Azul', 1, 0),
(33, 'Tela Seda Rosa', 2, 1),
(48, 'Tela Friza Rojo', 2, 1),
(54, 'Tela Polar Negro', 2, 1),
(69, 'Tela Poliester Bordo', 1, 1),
(71, 'Tela Cuadrille Amarillo', 4, 1),
(80, 'Tela Paño Azul Oscuro', 2, 1),
(96, 'Tela Jean Celeste', 1, 1);

INSERT INTO Fabricacion (CodFabricacion, CodDiseño, CodMateriales, FechaFabricacion, ProductoTerminado) VALUES
(14, 137, 48, '2022-12-01', 1),
(31, 338, 33, '2022-12-10', 1),
(47, 416, 15, '2022-12-03', 1),
(71, 793, 96, '2022-12-08', 1),
(84, 816, 54, '2022-12-10',  1),
(109, 1032, 80, '2022-12-05', 1),
(116, 1134, 69, '2022-12-06', 1),
(138, 1382, 71, '2022-12-04', 1),
(149, 1435, 48, '2022-12-02', 1),
(153, 1516, 80, '2022-12-07', 1);

INSERT INTO Productos (CodProducto, CodFabricacion, Nombre, Estado) VALUES
(12, 14, 'Pantalón Friza', 1),
(37, 31, 'Falda', 0),
(41, 47, 'Cargo Pantalon', 1),
(79, 71, 'Short Jean', 1),
(82, 84, 'Chaleco Inflable', 1),
(101, 109, 'Saco Solapa Redonda', 0),
(112, 116, 'Campera con Capucha', 1),
(131, 138, 'Camisa Cuadrille', 1),
(146, 149, 'Buzo Friza', 1),
(159, 153, 'Saco Blazer', 1);

INSERT INTO Deposito (CodDeposito, CantidadMaxima, Direccion, Localidad) VALUES
(1, 100, 'San Blas 4200', 'Floresta'),
(2, 50, 'Irigoyen 2000', 'Villa Real');

INSERT INTO Producto_Deposito (CodProducto, CodDeposito, FechaExportacion) VALUES
(12, 1, '2022-12-06'),
(41, 2, '2022-12-08'),
(79, 1, '2022-12-13'),
(82, 2, '2022-12-15'),
(112, 1, '2022-12-11'),
(131, 2, '2022-12-09'),
(146, 1, '2022-12-07'),
(159, 2, '2022-12-12');

INSERT INTO Local (CodLocal, Direccion, Localidad) VALUES
(1, 'Av Lope de Vega 1900', 'Monte Castro'),
(2, 'Av Avellaneda 3000', 'Flores'),
(3, 'Santo Tome 6200', 'Versalles'),
(4, 'Felipe Vallese 1000', 'Caballito');

INSERT INTO Deposito_Local (CodDeposito, CodLocal) VALUES
(2, 4),
(1, 3),
(2, 1),
(1, 2);

INSERT INTO Cliente (CodCliente, Nombre, Apellido, DNI, Telefono) VALUES
(1, 'Pablo', 'Laura', '43613893', 1129384612),
(2, 'Lucas', 'Romero', '17294624', 1127395066),
(3, 'Shande', 'Soncco', '74917482', 1193840921),
(4, 'Lucas', 'Mendoza', '58029121', 1131326890),

INSERT INTO Presupuesto (CodPresupuesto, CodCliente, Nombre, NombreProducto, PrecioUnidad, Cantidad, PrecioFinal) VALUES
(121, 1, 'Pablo', 'Pantalon Friza', 250, 2, 500),
(254, 2, 'Lucas', 'Cargo Pantalon', 300, 3, 900),
(398, 3, 'Shande', 'Saco Blazer', 400, 1, 400),
(414, 4, 'Lucas', 'Chaleco Inflable', 250, 1, 250);

INSERT INTO Factura (CodFacturaVentas, CodPresupuesto, CodCliente, Nombre, Apellido, Dni, Telefono, PrecioTotal, FechaVenta) VALUES
(183924, 121, 1, 'Pablo', 'Laura', '43613893', 1129384612, 500, '2022-12-23'),
(253012, 254, 2, 'Lucas', 'Romero', '17294624', 1127395066, 900, '2022-12-25'),
(391054, 398, 3, 'Shande', 'Soncco', '74917482', 1193840921, 400, '2022-12-22'),
(451856, 414, 4, 'Lucas', 'Mendoza', '58029121', 1131326890, 250, '2022-12-24');

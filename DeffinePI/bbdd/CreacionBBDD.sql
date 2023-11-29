-- Creación de la base de datos "PI"
CREATE DATABASE IF NOT EXISTS PI;

-- Uso de la base de datos "PI"
USE PI;
-- Creación de la tabla "Productos"
CREATE TABLE IF NOT EXISTS Productos (
IdProducto INT AUTO_INCREMENT PRIMARY KEY,
Descripcion VARCHAR(255),
Stock INT,
Precio DECIMAL(10, 2),
Talla VARCHAR(50),
Color VARCHAR(50),
Genero VARCHAR(50),
Imagen LONGBLOB
);

-- Creación de la tabla "Clientes"
CREATE TABLE IF NOT EXISTS Clientes (
IdCliente INT AUTO_INCREMENT PRIMARY KEY,
Nombre VARCHAR(100),
Apellido VARCHAR(100),
Contraseña VARCHAR(255),
Correo VARCHAR(255),
Administrador BOOLEAN
);

-- Creación de la tabla "Pedidos"
CREATE TABLE IF NOT EXISTS Pedidos (
IdPedido INT AUTO_INCREMENT PRIMARY KEY,
IdCliente INT,
Fecha DATE,
ImporteTotal DECIMAL(10, 2),
FOREIGN KEY (IdCliente) REFERENCES Clientes (IdCliente)
);

-- Creación de la tabla "Detalle_Pedido"
CREATE TABLE IF NOT EXISTS Detalle_Pedido (
IdDetalle INT AUTO_INCREMENT PRIMARY KEY,
IdPedido INT,
IdProducto INT,
Cantidad INT,
Subtotal DECIMAL(10, 2),
FOREIGN KEY (IdPedido) REFERENCES Pedidos (IdPedido),
FOREIGN KEY (IdProducto) REFERENCES Productos (IdProducto)
);

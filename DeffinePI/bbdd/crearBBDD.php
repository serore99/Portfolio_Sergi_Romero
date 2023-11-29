<?php
// Conexión a la base de datos
$mysqli = new mysqli("database-pi.cqinzqt39djq.us-east-1.rds.amazonaws.com", "admin", "12345678");

// Activar el modo de informe de errores
$mysqli->report_mode = MYSQLI_REPORT_ERROR;

if ($mysqli->connect_errno) {
  echo "Fallo conexión a MySQL: " . $mysqli->connect_errno . " " . $mysqli->connect_error;
  die("Salida del programa. Error acceso BBDD");
} else {
  echo "Se ha conectado al servidor";
  echo "<br>";
}

// Crear la base de datos "PI"
$consulta = "CREATE DATABASE IF NOT EXISTS PI;";
if (!$resultado = $mysqli->query($consulta)) {
  echo "Lo sentimos. App falla<br>";
  echo "Error en $consulta <br>";
  echo "Num.error: " . $mysqli->errno . "<br>";
  echo "Error: " . $mysqli->error . "<br>";
  exit;
} else {
    echo "La base de datos se ha creado correctamente";
    echo "<br><br>";
}

// Seleccionar la base de datos "PI"
if (!$mysqli->select_db("PI")) {
  echo "Lo sentimos. App falla<br>";
  echo "No se puede seleccionar la base de datos PI <br>";
  echo "Num.error: " . $mysqli->errno . "<br>";
  echo "Error: " . $mysqli->error . "<br>";
  exit;
}

// Crear la tabla "Productos"
$sql = "CREATE TABLE IF NOT EXISTS Productos (
    IdProducto INT AUTO_INCREMENT PRIMARY KEY,
    Descripcion VARCHAR(255),
    Stock INT,
    Precio DECIMAL(10, 2),
    Talla VARCHAR(50),
    Color VARCHAR(50),
    Genero VARCHAR(50),
    Imagen LONGBLOB
    )";
  
if ($mysqli->query($sql) === FALSE) {
  echo "Error al crear la tabla Productos: " . $mysqli->error . "<br>";
} else {
    echo "La tabla Productos se ha creado correctamente";
    echo "<br>";

}

// Crear la tabla "Clientes"
$sql = "CREATE TABLE IF NOT EXISTS Clientes (
    IdCliente INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Contraseña VARCHAR(255),
    Correo VARCHAR(255),
    Administrador BOOLEAN
    )";

if ($mysqli->query($sql) === FALSE) {
  echo "Error al crear la tabla Clientes: " . $mysqli->error . "<br>";
} else {
    echo "La tabla Clientes se ha creado correctamente";
    echo "<br>";

}

// Crear la tabla "Pedidos"
$sql = "CREATE TABLE IF NOT EXISTS Pedidos (
    IdPedido INT AUTO_INCREMENT PRIMARY KEY,
    IdCliente INT,
    Fecha DATE,
    ImporteTotal DECIMAL(10, 2),
    FOREIGN KEY (IdCliente) REFERENCES Clientes (IdCliente)
    )";
  
if ($mysqli->query($sql) === FALSE) {
  echo "Error al crear la tabla Pedidos: " . $mysqli->error . "<br>";
} else {
    echo "La tabla Pedidos se ha creado correctamente";
    echo "<br>";

}

// Crear la tabla "Detalle_Pedido"
$sql = "CREATE TABLE IF NOT EXISTS Detalle_Pedido (
    IdDetalle INT AUTO_INCREMENT PRIMARY KEY,
    IdPedido INT,
    IdProducto INT,
    Cantidad INT,
    Subtotal DECIMAL(10, 2),
    FOREIGN KEY (IdPedido) REFERENCES Pedidos (IdPedido),
    FOREIGN KEY (IdProducto) REFERENCES Productos (IdProducto)
    )";
  
if ($mysqli->query($sql) === FALSE) {
  echo "Error al crear la tabla Detalle_Pedido: " . $mysqli->error . "<br>";
} else {
    echo "La tabla Dealle_Pedido se ha creado correctamente";
    echo "<br>";

}

$mysqli->close();
?>

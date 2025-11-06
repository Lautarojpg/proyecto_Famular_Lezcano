CREATE DATABASE proyecto_Famular_Lezcano;
GO

USE proyecto_Famular_Lezcano;
GO

-- ========================================
-- TABLA: Rol
-- ========================================
CREATE TABLE Rol (
    id_rol INT IDENTITY(1,1) PRIMARY KEY,
    nombre_rol NVARCHAR(50) NOT NULL
);
GO

-- ========================================
-- TABLA: Usuario
-- ========================================
CREATE TABLE Usuario (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(50) NOT NULL,
    apellido NVARCHAR(50) NOT NULL,
    nombre_usuario NVARCHAR(50) NOT NULL UNIQUE,
    email NVARCHAR(100) NOT NULL,
    contrasena NVARCHAR(255) NOT NULL,
    id_rol INT NOT NULL,
    estado BIT DEFAULT 1,
    CONSTRAINT fk_usuario_rol FOREIGN KEY (id_rol) REFERENCES Rol(id_rol)
);
GO

-- ========================================
-- TABLA: Cliente
-- ========================================
CREATE TABLE Cliente (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nombre_cliente NVARCHAR(50) NOT NULL,
    apellido_cliente NVARCHAR(50) NOT NULL,
    email NVARCHAR(100),
    telefono NVARCHAR(20),
    direccion NVARCHAR(150),
    contrasena_cliente NVARCHAR(255) NOT NULL -- cambié a NVARCHAR, más seguro que INT
);
GO

-- ========================================
-- TABLA: Categoria
-- ========================================
CREATE TABLE Categoria (
    id_categoria INT IDENTITY(1,1) PRIMARY KEY,
    descripcion NVARCHAR(100) NOT NULL,
    activo BIT DEFAULT 1
);
GO

-- ========================================
-- TABLA: Ticket
-- ========================================
CREATE TABLE Ticket (
    id_ticket INT IDENTITY(1,1) PRIMARY KEY,
    cod_visualizacion NVARCHAR(20) NOT NULL UNIQUE,
    link NVARCHAR(255) NOT NULL
);
GO

-- ========================================
-- TABLA: Pelicula
-- ========================================
CREATE TABLE Pelicula (
    id_pelicula INT IDENTITY(1,1) PRIMARY KEY,
    nombre_pelicula NVARCHAR(100) NOT NULL,
    imagen NVARCHAR(255) NOT NULL,  -- corregido doble coma
    precio DECIMAL(10,2) NOT NULL,
    sinopsis NVARCHAR(500),
    stock INT NOT NULL,
    id_categoria INT NOT NULL,
    id_ticket INT NOT NULL,
    CONSTRAINT fk_pelicula_categoria FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria),
    CONSTRAINT fk_pelicula_ticket FOREIGN KEY (id_ticket) REFERENCES Ticket(id_ticket)
);
GO

-- ========================================
-- TABLA: Venta_Cabecera
-- ========================================
CREATE TABLE Venta_Cabecera (
    id_venta INT IDENTITY(1,1) PRIMARY KEY,
    fecha_compra DATETIME DEFAULT GETDATE(),
    total_venta DECIMAL(10,2),
    id_cliente INT NOT NULL,
    CONSTRAINT fk_venta_cliente FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente)
);
GO

-- ========================================
-- TABLA: Venta_Detalle
-- ========================================
CREATE TABLE Venta_Detalle (
    id_detalle INT IDENTITY(1,1) PRIMARY KEY,
    cantidad INT NOT NULL,
    id_pelicula INT NOT NULL,
    id_venta INT NOT NULL,
    id_usuario INT NULL,
    CONSTRAINT fk_detalle_pelicula FOREIGN KEY (id_pelicula) REFERENCES Pelicula(id_pelicula),
    CONSTRAINT fk_detalle_venta FOREIGN KEY (id_venta) REFERENCES Venta_Cabecera(id_venta),
    CONSTRAINT fk_usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario)
);
GO

-- ========================================
-- CATEGORÍAS INICIALES
-- ========================================
INSERT INTO Categoria(descripcion) VALUES ('Terror');
INSERT INTO Categoria(descripcion) VALUES ('Ciencia Ficcion');
INSERT INTO Categoria(descripcion) VALUES ('Romance');
INSERT INTO Categoria(descripcion) VALUES ('Drama');
INSERT INTO Categoria(descripcion) VALUES ('Comedia');
INSERT INTO Categoria(descripcion) VALUES ('Accion');
INSERT INTO Categoria(descripcion) VALUES ('Suspenso');
INSERT INTO Categoria(descripcion) VALUES ('Musical');
INSERT INTO Categoria(descripcion) VALUES ('Belico');
INSERT INTO Categoria(descripcion) VALUES ('Documental');

-- ========================================
-- ROLES INICIALES
-- ========================================
INSERT INTO Rol (nombre_rol) VALUES ('Administrador');
INSERT INTO Rol (nombre_rol) VALUES ('Gerente');
INSERT INTO Rol (nombre_rol) VALUES ('Vendedor');
GO

USE proyecto_Famular_Lezcano
SELECT * FROM Ticket 

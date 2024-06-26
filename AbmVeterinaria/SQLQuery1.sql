--Introduccion tablas veterinaria--

create table usuarios(
UsuarioID INT PRIMARY KEY IDENTITY,
NombreUsuario VARCHAR(50) not null,
Clave VARCHAR(25) not null
);

create table clientes(
ClienteID INT PRIMARY KEY IDENTITY,
DNI VARCHAR(20) NOT NULL UNIQUE,
Nombre VARCHAR(100)

);

create table especies(
EspecieID INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(100) NOT NULL,
EdadMadurez INT,
PesoPromedio Decimal(5,2)
);

create table animales(
AnimalID INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(100) NOT NULL,
Peso Decimal(5,2),
Edad INT NOT NULL,
ClienteID INT NOT NULL,
EspecieID INT NOT NULL,
--Relacion de campos usando Foreign KEY--
FOREIGN KEY(ClienteID) REFERENCES clientes(ClienteID),
FOREIGN KEY(EspecieID) REFERENCES especies(EspecieID),
);

select * from animales
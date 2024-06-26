CREATE DATABASE Pw3SegundoParcial;
GO
USE Pw3SegundoParcial;
GO

CREATE TABLE Sucursal (
	IdSucursal INT IDENTITY PRIMARY KEY,
	Direccion NVARCHAR(100) NOT NULL,
	Eliminada BIT NOT NULL
);

CREATE TABLE Empleado (
	IdEmpleado INT IDENTITY PRIMARY KEY,
	NombreCompleto NVARCHAR(100) NOT NULL,
	IdSucursal INT NOT NULL,
	FOREIGN KEY (IdSucursal) REFERENCES Sucursal (IdSucursal)
);

INSERT INTO Sucursal (Direccion, Eliminada)
	VALUES ('Av. del Sol 123',	0),
	       ('Paseo del Río 345', 0),
		   ('789 Maple Street', 1);
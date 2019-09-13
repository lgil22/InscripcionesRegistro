create database EstudiantesDb
go
use EstudiantesDb
go

select * from Inscripciones

create table Estudiantes(
EstudianteId int identity primary key,
	Matricula varchar(15) NULL,
	Nombre varchar(30) NULL,
	Apellidos varchar(30) NULL,
	Telefono varchar(13) NULL,
	Cedula varchar(13) NULL,
	Direccion varchar(max) NULL,
	Email varchar(25) NULL,
	Sexo varchar(9) NULL,
	FechaNacimiento date NULL,
	Balance decimal(12,2)
);

create table Inscripciones(
InscripcionId int identity primary key,
Fecha date NULL,
EstudianteId int,
Balance decimal(12,2),
Comentarios varchar(100) NULL,
Monto decimal(14, 2) NULL,
Deposito decimal(14, 2) NULL,
);






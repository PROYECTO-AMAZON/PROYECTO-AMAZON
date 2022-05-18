-- paginaweb.dbo.ALUMNO definition

-- Drop table

-- DROP TABLE paginaweb.dbo.ALUMNO;

CREATE TABLE paginaweb.dbo.ALUMNO (
	idAlumno int NOT NULL,
	dni varchar(8) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Nombres varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Apellido_Paterno varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Apellido_Materno varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Celular varchar(9) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Departamento varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Provincia varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Distrito varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	FechaNacimiento date NOT NULL,
	Genero char(1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Email varchar(65) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Contraseña varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT ALUMNO_PK PRIMARY KEY (idAlumno)
);


-- paginaweb.dbo.SEMANA definition

-- Drop table

-- DROP TABLE paginaweb.dbo.SEMANA;

CREATE TABLE paginaweb.dbo.SEMANA (
	idSemana int NOT NULL,
	descripcion varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT SEMANA_PK PRIMARY KEY (idSemana)
);


-- paginaweb.dbo.CARRERA definition

-- Drop table

-- DROP TABLE paginaweb.dbo.CARRERA;

CREATE TABLE paginaweb.dbo.CARRERA (
	idCarrera int NOT NULL,
	fechaCarrera date NOT NULL,
	distancia numeric(18,0) NOT NULL,
	tiempo time(0) NOT NULL,
	ritmoCard numeric(38,0) NOT NULL,
	idAlumno int NOT NULL,
	idSemana int NOT NULL,
	CONSTRAINT CARRERA_FK FOREIGN KEY (idAlumno) REFERENCES paginaweb.dbo.ALUMNO(idAlumno),
	CONSTRAINT CARRERA_FK_1 FOREIGN KEY (idSemana) REFERENCES paginaweb.dbo.SEMANA(idSemana)
);
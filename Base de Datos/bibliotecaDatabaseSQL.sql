create database biblioteca;
use [biblioteca];

create table Permisos(

	idPermisos INT NOT NULL IDENTITY(1,1),
	codigo INT not null,
    descripcion varchar(80) not null,
    primary key(idPermisos),
);

create table Perfiles(

	idPerfiles INT NOT NULL IDENTITY(1,1),
    nombrePerfiles varchar(40) not null,
    idPermisos int foreign key references Permisos,	
    primary key(idPerfiles)
);

create table Usuario(

	idUsuario INT NOT NULL IDENTITY(1,1),
    usuario varchar(40) not null,
    contraseña varchar(40) not null,
    idPerfiles int foreign key references Perfiles,	
    primary key(idUsuario)
);


create table Ciudad(
	idCiudad int not null IDENTITY(1,1),
    nombreCiudad varchar(40) not null,
    primary key(idCiudad)
);

create table TipoDocumento(
	idTipoDoc int not null IDENTITY(1,1),
    tipoDocumento varchar(40) not null,
    primary key(idTipoDoc)
);

create table EstadoEjemplar(
	idEstadoEjemplar int not null IDENTITY(1,1),
    nombreEstadoEjemplar varchar(40) not null,
    primary key(idEstadoEjemplar)
);

create table Editorial(
	idEditorial int not null IDENTITY(1,1),
    nombreEditorial varchar(40) not null,
    primary key(idEditorial)
);

create table Autor(
	idAutor int not null IDENTITY(1,1),
    nombreAutor varchar(40) not null,
    primary key(idAutor)
);

create table EstadoDetallePrestamo(
	idEstadoPrestamo int not null IDENTITY(1,1),
    nombreEstadoDetallePrestamo varchar(40) not null,
    primary key(idEstadoPrestamo)
);

create table Genero(
	idGenero int not null IDENTITY(1,1),
    nombreGenero varchar(40) not null,
    primary key(idGenero)
);




create table EstadoPrestamo(
	idEstadoPrestamo int not null IDENTITY(1,1),
    nombreEstadoPrestamo varchar(40) not null,
    primary key(idEstadoPrestamo)
);




create table EstadoPedido(
	idEstadoPedido int not null IDENTITY(1,1),
    nombreEstadoPedido varchar(40) not null,
    primary key(idEstadoPedido)
);




create table Pedido(
	idPedido int not null IDENTITY(1,1),
    idEstadoPedido int foreign key references EstadoPedido,	
    fechaPedido int not null,
    fechaRecepcion int not null
    primary key(idPedido)
);




create table Barrio(
	idBarrio int not null IDENTITY(1,1),
	idCiudad int foreign key references Ciudad,
    nombreBarrio varchar(32) not null,
    primary key(idBarrio)
);



create table Proveedor(
	idProveedor int not null IDENTITY(1,1),
	idBarrio int foreign key references Barrio,
    razonSocial varchar(32) not null,
    telefono int not null,
    mail varchar(32) not null,
    calle varchar(32) not null,
    nro int not null,
    primary key(idProveedor)
);





create table Socio(
	idSocio int not null IDENTITY(1,1),
    idTipoDoc int foreign key references TipoDocumento,
    idBarrio int foreign key references Barrio,
    idUsuario int foreign key references Usuario,
    numeroDocumento int not null,
    nombre varchar(32) not null,
    apellido varchar(32) not null,
    mail varchar(32) not null,
    telefono int not null,
    calle int not null,
    nro int not null,
    primary key(idSocio),
);


create table Libro(
	idLibro int not null IDENTITY(1,1),
    titulo varchar(32) not null,
    añoEdicion int not null,
    idGenero int foreign key references Genero,
    idAutor int foreign key references  Autor,
    idEditorial int foreign key references Editorial,
    sector varchar(32)not null,
    estante int not null,
    primary key(idLibro)
);

create table Ejemplar(
	idEjemplar integer not null IDENTITY(1,1),
    idLibro integer foreign key references EstadoEjemplar,
    idEstadoEjemplar int foreign key references Libro,
    primary key(idEjemplar, idLibro)
);


create table DetallePedido(
	idPedido int not null IDENTITY(1,1),
    idEjemplar int not null,
    idLibro int not null,
    cantidad int not null,
    precio int not null,
    primary key(idPedido, idEjemplar, idLibro),
    FOREIGN KEY (idEjemplar,idLibro) REFERENCES Ejemplar(idEjemplar,idLibro),
);


create table Prestamo(
	idPrestamo int not null IDENTITY(1,1),
    idSocio int foreign key references Socio,
    idEstadoPrestamo int foreign key references EstadoPrestamo,
    fechaPrestamo int not null,
    fechaLimite int not null,
   
    primary key(idPrestamo)
);


create table DetallePrestamo(
	idEstadoDetPres int not null IDENTITY(1,1),
	idPrestamo int foreign key references Prestamo,
    idEjemplar int not null,
    idLibro int not null,
    fechaDevolucion int not null,
    primary key (idEstadoDetPres),
	FOREIGN KEY (idEjemplar,idLibro) REFERENCES Ejemplar(idEjemplar,idLibro)
);



insert INTO Usuario(usuario,contraseña)values('Miguel123','123123');
insert INTO Usuario(usuario,contraseña)values('Juan321','123123');
insert INTO Usuario(usuario,contraseña)values('ADMIN','ADMIN');
insert INTO Usuario(usuario,contraseña)values('Gustavo','123123');
insert INTO Usuario(usuario,contraseña)values('perez121','123123');
insert INTO Usuario(usuario,contraseña)values('Jaime12311','123123');
insert INTO Usuario(usuario,contraseña)values('Perla131','123123');

insert INTO Genero(nombreGenero)values('Ciencia');
insert INTO Genero(nombreGenero)values('Aventura');
insert INTO Genero(nombreGenero)values('Romance');
insert INTO Genero(nombreGenero)values('Fantacia');
insert INTO Genero(nombreGenero)values('Misterio');


insert INTO Autor(nombreAutor)values('Patrick Rockffuss');
insert INTO Autor(nombreAutor)values('Stephen King');
insert INTO Autor(nombreAutor)values('Brandon sanderson');
insert INTO Autor(nombreAutor)values('Hermann Hesse');
insert INTO Autor(nombreAutor)values('Gaston Leroux');
insert INTO Autor(nombreAutor)values('John Katzenbach');
insert INTO Autor(nombreAutor)values('J. R. R. Tolkien');
insert INTO Autor(nombreAutor)values('Orson Scott Card');
insert INTO Autor(nombreAutor)values('James Dashner');
insert INTO Autor(nombreAutor)values('Pittacus Lore');
insert INTO Autor(nombreAutor)values('Ray Bradbury');
insert INTO Autor(nombreAutor)values('George R. R. Martin');




insert INTO Editorial(nombreEditorial)values('Booket');
insert INTO Editorial(nombreEditorial)values('Gradifco');
insert INTO Editorial(nombreEditorial)values('Penguin Random House');
insert INTO Editorial(nombreEditorial)values('Minotauro');
insert INTO Editorial(nombreEditorial)values('HarperCollins');
insert INTO Editorial(nombreEditorial)values('Tor Books');
insert INTO Editorial(nombreEditorial)values('ZETA');
insert INTO Editorial(nombreEditorial)values('Norma');
insert INTO Editorial(nombreEditorial)values('Ediciones B');


insert into Libro values('El nombre del viento',2019, 2,1,3,'Oro',3);



insert into Libro values('asdasd',2012, 2,1,3,'Oro',3);



insert into Libro values('12312asdasd',2011, 2,1,3,'Oro',3);



insert into Libro values('asdasdasdaaaaa',2012, 2,1,3,'Oro',3);




use biblioteca;
create proc listarLibros
@parametro
as
select idLibro as ID,
titulo as Titulo,
añoEdicion as Edicion, 
nombreGenero as Genero, 
nombreAutor as Autor, 
nombreEditorial as Editorial,
sector as Sector,
estante as Estante
from Libro


inner join Genero on Libro.idGenero = Genero.idGenero
inner join autor on Libro.idAutor = Autor.idAutor
inner join editorial on Libro.idEditorial = Editorial.idEditorial
go

listarLibros

select * from Libro;


CREATE proc procedimiento1

@Titulo varchar(50),
@AñoEdicion varchar(50)
as
SELECT titulo, añoEdicion, sector  
FROM Libro 
WHERE titulo = @titulo AND añoEdicion = @AñoEdicion;
go
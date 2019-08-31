create database biblioteca;
use [biblioteca]
create table Ciudad(
	idCiudad int not null,
    nombre varchar(40) not null,
    primary key(idCiudad)
);

create table TipoDocumento(
	idTipoDoc int not null,
    nombre varchar(40) not null,
    primary key(idTipoDoc)
);

create table EstadoEjemplar(
	idEstadoEjemplar int not null,
    nombre varchar(40) not null,
    primary key(idEstadoEjemplar)
);

create table Editorial(
	idEditorial int not null,
    nombreEditorial varchar(40) not null,
    primary key(idEditorial)
);

create table Autor(
	idAutor int not null,
    nombre varchar(40) not null,
    primary key(idAutor)
);

create table EstadoDetallePrestamo(
	idEstadoPrestamo int not null,
    nombre varchar(40) not null,
    primary key(idEstadoPrestamo)
);

create table Genero(
	idGenero int not null,
    nombre varchar(40) not null,
    primary key(idGenero)
);
create table EstadoPrestamo(
	idEstadoPrestamo int not null,
    nombre varchar(40) not null,
    primary key(idEstadoPrestamo)
);
create table EstadoPedido(
	idEstadoPedido int not null,
    nombre varchar(40) not null,
    primary key(idEstadoPedido)
);


create table Pedido(
	idPedido int not null,
    fechaPedido int not null,
    fechaRecepcion int not null,
    idEstadoPedido int not null,
    primary key(idPedido),
    FOREIGN KEY (idEstadoPedido) REFERENCES EstadoPedido(idEstadoPedido)
);


create table Barrio(
	idBarrio int not null,
    nombre varchar(32) not null,
    idCiudad int not null,
    primary key(idBarrio),
    FOREIGN KEY (idCiudad) REFERENCES Ciudad(idCiudad)
);
create table Proveedor(
	idProveedor int not null,
    razonSocial varchar(32) not null,
    telefono int not null,
    mail varchar(32) not null,
    calle varchar(32) not null,
    nro int not null,
    idBarrio int not null,
    primary key(idBarrio),
    FOREIGN KEY (idBarrio) REFERENCES Barrio(idBarrio)
);
create table Socio(
	idSocio int not null,
    idTipoDoc int not null,
    numeroDocumento int not null,
    nombre varchar(32) not null,
    apellido varchar(32) not null,
    mail varchar(32) not null,
    telefono int not null,
    calle int not null,
    nro int not null,
    idBarrio int not null,
    primary key(idSocio),
    FOREIGN KEY (idTipoDoc) REFERENCES TipoDocumento(idTipoDoc),
    FOREIGN KEY (idBarrio) REFERENCES Barrio(idBarrio)
);
create table Libro(
	idLibro int not null,
    titulo varchar not null,
    añoEdicion int not null,
    idGenero int not null,
    idAutor int not null,
    idEditorial int not null,
    sector int not null,
    estante int not null,
    primary key(idLibro),
    FOREIGN KEY (idGenero) REFERENCES Genero(idGenero),
    FOREIGN KEY (idAutor) REFERENCES Autor(idAutor),
    FOREIGN KEY (idEditorial) REFERENCES Editorial(idEditorial)
);

create table Ejemplar(
	idEjemplar integer not null,
    idLibro integer not null,
    idEstadoEjemplar int not null,
    primary key(idEjemplar, idLibro),
    FOREIGN KEY (idEstadoEjemplar) REFERENCES EstadoEjemplar(idEstadoEjemplar)
);


create table DetallePedido(
	idPedido int not null,
    idEjemplar int not null,
    idLibro int not null,
    cantidad int not null,
    precio int not null,
    primary key(idPedido, idEjemplar, idLibro),

    FOREIGN KEY (idEjemplar,idLibro) REFERENCES Ejemplar(idEjemplar,idLibro),
);


create table Prestamo(
	idPrestamo int not null,
    idSocio int not null,
    fechaPrestamo int not null,
    fechaLimite int not null,
    idEstadoPrestamo int not null,
    primary key(idPrestamo),
    FOREIGN KEY (idSocio) REFERENCES Socio(idSocio),
    FOREIGN KEY (idEstadoPrestamo) REFERENCES EstadoPrestamo(idEstadoPrestamo)
);


create table DetallePrestamo(
	idPrestamo int not null,
    idEjemplar int not null,
    idLibro int not null,
    fechaLimite int not null,
    idEstadoDetPres int not null,
    primary key(idPrestamo),
    FOREIGN KEY (idEstadoDetPres) REFERENCES EstadoPrestamo(idEstadoPrestamo)
);

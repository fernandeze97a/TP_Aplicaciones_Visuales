create database biblioteca;
use [biblioteca];


create table Usuario(

	idUsuario INT NOT NULL IDENTITY(1,1),
    usuario varchar(40) not null,
    contraseña varchar(40) not null,
    primary key(idUsuario),
);
create table Ciudad(
	idCiudad int not null IDENTITY(1,1),
    nombre varchar(40) not null,
    primary key(idCiudad)
);

create table TipoDocumento(
	idTipoDoc int not null IDENTITY(1,1),
    nombre varchar(40) not null,
    primary key(idTipoDoc)
);

create table EstadoEjemplar(
	idEstadoEjemplar int not null IDENTITY(1,1),
    nombre varchar(40) not null,
    primary key(idEstadoEjemplar)
);

create table Editorial(
	idEditorial int not null IDENTITY(1,1),
    nombreEditorial varchar(40) not null,
    primary key(idEditorial)
);

create table Autor(
	idAutor int not null IDENTITY(1,1),
    nombre varchar(40) not null,
    primary key(idAutor)
);

create table EstadoDetallePrestamo(
	idEstadoPrestamo int not null IDENTITY(1,1),
    nombre varchar(40) not null,
    primary key(idEstadoPrestamo)
);

create table Genero(
	idGenero int not null IDENTITY(1,1),
    nombre varchar(40) not null,
    primary key(idGenero)
);




create table EstadoPrestamo(
	idEstadoPrestamo int not null IDENTITY(1,1),
    nombre varchar(40) not null,
    primary key(idEstadoPrestamo)
);




create table EstadoPedido(
	idEstadoPedido int not null IDENTITY(1,1),
    nombre varchar(40) not null,
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
    nombre varchar(32) not null,
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
    sector int not null,
    estante varchar(32) not null,
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

insert INTO Genero(nombre)values('Ciencia');
insert INTO Genero(nombre)values('Aventura');
insert INTO Genero(nombre)values('Romance');
insert INTO Genero(nombre)values('Fantacia');
insert INTO Genero(nombre)values('Misterio');


insert INTO Autor(nombre)values('Patrick Rockffuss');
insert INTO Autor(nombre)values('Stephen King');
insert INTO Autor(nombre)values('Brandon sanderson');
insert INTO Autor(nombre)values('Hermann Hesse');
insert INTO Autor(nombre)values('Gaston Leroux');
insert INTO Autor(nombre)values('John Katzenbach');
insert INTO Autor(nombre)values('J. R. R. Tolkien');
insert INTO Autor(nombre)values('Orson Scott Card');
insert INTO Autor(nombre)values('James Dashner');
insert INTO Autor(nombre)values('Pittacus Lore');
insert INTO Autor(nombre)values('Ray Bradbury');
insert INTO Autor(nombre)values('George R. R. Martin');




insert INTO Editorial(nombreEditorial)values('Booket');
insert INTO Editorial(nombreEditorial)values('Gradifco');
insert INTO Editorial(nombreEditorial)values('Penguin Random House');
insert INTO Editorial(nombreEditorial)values('Minotauro');
insert INTO Editorial(nombreEditorial)values('HarperCollins');
insert INTO Editorial(nombreEditorial)values('Tor Books');
insert INTO Editorial(nombreEditorial)values('ZETA');
insert INTO Editorial(nombreEditorial)values('Norma');
insert INTO Editorial(nombreEditorial)values('Ediciones B');





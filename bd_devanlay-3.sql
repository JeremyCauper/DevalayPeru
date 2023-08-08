create database bd_devalay_peru
--drop database bd_devalay_peru
go
use bd_devalay_peru
go
set dateformat 'dmy'
go
create table tb_gerente (
	cod_gerente char(5) not null,
	num_documento varchar(20) not null,
	nombre VARCHAR(30) not null,
	ape_paterno VARCHAR(30) not null,
	ape_materno VARCHAR(30)not null ,
	telefono VARCHAR(9) not null ,
	email VARCHAR(100) not null,
	fecha_nacimiento DATE not null,
	direccion VARCHAR(100) not null
)
go
alter table tb_gerente add constraint pk_gerente primary key (cod_gerente)
go

CREATE TABLE tb_administrador (
	cod_administrador char(5) not null,
	num_documento varchar(20) not null,
	nombre VARCHAR(30) not null,
	ape_paterno VARCHAR(30) not null,
	ape_materno VARCHAR(30)not null ,
	telefono VARCHAR(9) not null ,
	email VARCHAR(100) not null,
	fecha_nacimiento DATE not null,
	direccion VARCHAR(100) not null
)
go
alter table tb_administrador add constraint pk_administrador primary key (cod_administrador)
go

create table tb_asistencia (
	cod_asistencia char(5) not null,
	fecha char(5) not null,
	presente bit not null,
	cod_empleado char(5) not null
)
alter table tb_asistencia add constraint pk_asistencia primary key (cod_asistencia)
go

create table tb_rrhh (
	cod_rrhh char(5) not null,
	num_documento varchar(20) not null,
	nombre VARCHAR(30) not null,
	ape_paterno VARCHAR(30) not null,
	ape_materno VARCHAR(30)not null ,
	telefono VARCHAR(9) not null ,
	email VARCHAR(100) not null,
	fecha_nacimiento DATE not null,
	direccion VARCHAR(100) not null
)
go
alter table tb_rrhh add constraint pk_rrhh primary key (cod_rrhh)
go

create table tb_empleado (
	cod_empleado char(5) not null,
	num_documento varchar(20) not null,
	nombre VARCHAR(30) not null,
	ape_paterno VARCHAR(30) not null,
	ape_materno VARCHAR(30)not null ,
	telefono VARCHAR(9) not null ,
	email VARCHAR(100) not null,
	fecha_nacimiento DATE not null,
	direccion VARCHAR(100) not null
)
go
alter table tb_empleado add constraint pk_empleado primary key (cod_empleado)
go

create table tb_cliente (
	cod_cliente char(5) not null,
	num_documento varchar(20) not null,
	nombre VARCHAR(30) not null,
	ape_paterno VARCHAR(30) not null,
	ape_materno VARCHAR(30)not null ,
	telefono VARCHAR(9) not null ,
	email VARCHAR(100) not null,
	fecha_nacimiento DATE not null,
	direccion VARCHAR(100) not null
)
go
alter table tb_cliente add constraint pk_cliente primary key (cod_cliente)
go

create table tb_proveedor (
	cod_proveedor char(5) not null,
	ruc varchar(11) not null,
	razon_social VARCHAR(255) not null,
	direccion VARCHAR(255) not null,
	email VARCHAR(100) not null,
	telefono char(9)
)
go
alter table tb_proveedor add constraint pk_proveedor primary key (cod_proveedor)
go

create table tb_producto (
	cod_producto char(5) not null,
	descripcion varchar(150) not null,
	fecha_registro date not null
)
go
alter table tb_producto add constraint pk_producto primary key (cod_producto)
go

create table tb_ventas (
	cod_venta char(5) not null,
	fecha_venta DATE,
	cantidad INT,
	precio_unitario DECIMAL(10,2),
	descuento DECIMAL(10,2),
	total DECIMAL(10,2),
	id_cliente char(5),
	id_almacen char(5)
  )
go
alter table tb_ventas add constraint pk_ventas primary key (cod_venta)
go

create table tb_almacen (
	cod_almacen char(5) not null,
	cantidad INT NOT NULL,
	unidad VARCHAR(50) NOT NULL,
	fecha_registro DATE NOT NULL,
	precio_venta_unitario DECIMAL(10,2) NOT NULL,
	id_producto char(5) not null,
	id_proveedor char(5) not null
)
go
alter table tb_almacen add constraint pk_almacen primary key (cod_almacen)
go

-------------------------------------------
-------- FORING KEY DE LAS TABLAS ---------
-------------------------------------------

-- Foring Key tb_asistencia
alter table tb_asistencia add constraint fk_asistencia_empleado foreign key (id_empleado) references tb_empleado(cod_empleado)
go

-- Foring Key tb_ventas
alter table tb_ventas add constraint fk_ventas_cliente foreign key (id_cliente) references tb_cliente(cod_cliente)
go
alter table tb_ventas add constraint fk_ventas_almacen foreign key (id_almacen) references tb_almacen(cod_almacen)
go

-- Foring Key tb_almacen
alter table tb_almacen add constraint fk_almacen_producto foreign key (id_producto) references tb_producto(cod_producto)
go
alter table tb_almacen add constraint fk_almacen_proveedor foreign key (id_proveedor) references tb_proveedor(cod_proveedor)
go

--------------------------------------------
--PROCEDURE TABLA EMPLEADO
--------------------------------------------

create procedure sp_listar_empleado
as
begin
	select * from tb_empleado order by cod_empleado asc
end
go
execute sp_listar_empleado
go
--drop porcedure sp_lista_empleado
--go

create procedure sp_registrar_empleado
	@cod_empleado char(5), @num_documento varchar(20), @nombre VARCHAR(30), @ape_paterno VARCHAR(30), @ape_materno VARCHAR(30), @telefono VARCHAR(9), @email VARCHAR(100), @fecha_nacimiento DATE, @direccion VARCHAR(100)
as
begin
	insert into tb_empleado values(@cod_empleado, @num_documento, @nombre, @ape_paterno, @ape_materno, @telefono, @email, @fecha_nacimiento, @direccion)
end
go
execute sp_registrar_empleado 'E0001', '12345678', 'Juan', 'Pérez', 'Gómez', '945871658', 'juanperez@gmail.com', '15-05-1990', 'Calle Principal, 123'
go
execute sp_registrar_empleado 'E0002', '98765432', 'María', 'González', 'López', '951236874', 'mariagonzalez@gmail.com', '22-08-1985', 'Avenida Central, 456'
go
execute sp_registrar_empleado 'E0003', '45678123', 'Pedro', 'Sánchez', 'Ramírez', '965874123', 'pedrosanchez@gmail.com', '10-12-1992', 'Calle Secundaria, 789'
go
execute sp_registrar_empleado 'E0004', '78913456', 'Luis', 'Hernández', 'Torres', '978541236', 'luishernandez@gmail.com', '03-07-1988', 'Avenida Principal, 789'
go
execute sp_registrar_empleado 'E0005', '65431987', 'Ana', 'López', 'García', '965487123', 'analgarcia@gmail.com', '28-03-1994', 'Calle Secundaria, 456'
go
--drop procedure sp_registrar_empleado
--go

create procedure sp_editar_empleado
	@cod_empleado char(5), @num_documento varchar(20), @nombre VARCHAR(30), @ape_paterno VARCHAR(30), @ape_materno VARCHAR(30), @telefono VARCHAR(9), @email VARCHAR(100), @fecha_nacimiento DATE, @direccion VARCHAR(100)
as
begin
	update tb_empleado set num_documento = @num_documento, nombre = @nombre, ape_paterno = @ape_paterno, ape_materno = @ape_materno, telefono = @telefono, email = @email, fecha_nacimiento = @fecha_nacimiento, direccion = @direccion where cod_empleado = @cod_empleado
end
go
execute sp_editar_empleado 'E001', '12345789', 'Juan', 'Pérez', 'Gómez', '945871658', 'juanperez@gmail.com', '15-05-1990', 'Calle Principal, 123'
go

--drop procedure sp_editar_empleado
--go

create procedure sp_borrar_empleado @cod char(5)
as
begin
	delete from tb_empleado where cod_empleado = @cod
end
go
--execute sp_borrar_empleado 'E0001'
--go
--drop procedure sp_borrar_empleado
--go


--------------------------------------------
--PROCEDURE TABLA PROVEEDOR
--------------------------------------------

create procedure sp_listar_proveedor
as
begin
	select * from tb_proveedor order by cod_proveedor asc
end
go
execute sp_listar_proveedor
go
--drop procedure sp_listar_proveedor
--go

create procedure sp_registrar_proveedor
	@cod_proveedor char(5), @ruc varchar(11), @razon_social VARCHAR(255), @direccion VARCHAR(255), @email VARCHAR(100), @telefono char(9)
as
begin
	insert into tb_proveedor values(@cod_proveedor, @ruc, @razon_social, @direccion, @email, @telefono)
end
go
execute sp_registrar_proveedor 'PR001', '10345678901', 'Proveedor A', 'Calle Principal, 123', 'proveedora@gmail.com', '945871658'
go
execute sp_registrar_proveedor 'PR002', '20765432109', 'Proveedor B', 'Avenida Central, 456', 'proveedorb@gmail.com', '951236874'
go
execute sp_registrar_proveedor 'PR003', '10678912304', 'Proveedor C', 'Calle Secundaria, 789', 'proveedorc@gmail.com', '965874123'
go
execute sp_registrar_proveedor 'PR004', '10912345603', 'Proveedor D', 'Avenida Principal, 789', 'proveedord@gmail.com', '978541236'
go
execute sp_registrar_proveedor 'PR005', '20432198702', 'Proveedor E', 'Calle Secundaria, 456', 'proveedore@gmail.com', '965487123'

go
--drop procedure sp_registrar_proveedor
--go

create procedure sp_editar_proveedor
	@cod_proveedor char(5), @ruc varchar(11), @razon_social VARCHAR(255), @direccion VARCHAR(255), @email VARCHAR(100), @telefono char(9)
as
begin
	update tb_proveedor set ruc = @ruc, razon_social = @razon_social, direccion = @direccion, email = @email, telefono = @telefono where cod_proveedor = @cod_proveedor
end
go
execute sp_editar_proveedor 'PR001', '10345678900', 'Proveedor A', 'Calle Principal, 123', 'proveedora@gmail.com', '945871658'
go
--drop procedure sp_editar_producto
--go

create procedure sp_borrar_proveedor @cod char(5)
as
begin
	delete from tb_proveedor where cod_proveedor = @cod
end
go
execute sp_borrar_proveedor 'PR001'
go
--drop procedure sp_borrar_proveedor
--go


--------------------------------------------
--PROCEDURE TABLA ADMINISTRADOR
--------------------------------------------

create procedure sp_listar_administrador
as
begin
	select * from tb_administrador order by cod_administrador asc
end
go
execute sp_listar_administrador
go
--drop procedure sp_listar_administrador
--go

CREATE PROCEDURE sp_registrar_administrador
	@cod_administrador char(5), @num_documento varchar(20), @nombre VARCHAR(30), @ape_paterno VARCHAR(30), @ape_materno VARCHAR(30), @telefono VARCHAR(9), @email VARCHAR(100), @fecha_nacimiento DATE, @direccion VARCHAR(100)
AS
BEGIN
	INSERT INTO tb_administrador VALUES (@cod_administrador, @num_documento, @nombre, @ape_paterno, @ape_materno, @telefono, @email, @fecha_nacimiento, @direccion);
END
GO
EXECUTE sp_registrar_administrador 'AD001', '103456789', 'Carlos', 'González', 'López', '945871658', 'carlosgonzalez@gmail.com', '15-05-1990', 'Calle Principal, 123'
go
EXECUTE sp_registrar_administrador 'AD002', '98754321', 'María', 'Hernández', 'Torres', '951236874', 'mariahernandez@gmail.com', '22-08-1985', 'Avenida Central, 456'
go
EXECUTE sp_registrar_administrador 'AD003', '45789123', 'Pedro', 'López', 'Ramírez', '965874123', 'pedrolopez@gmail.com', '10-12-1992', 'Calle Secundaria, 789'
go
EXECUTE sp_registrar_administrador 'AD004', '78913456', 'Luisa', 'Sánchez', 'Gómez', '978541236', 'luisasanchez@gmail.com', '03-07-1988', 'Avenida Principal, 789'
go
EXECUTE sp_registrar_administrador 'AD005', '65432187', 'Ana', 'Martínez', 'García', '965487123', 'anamartinez@gmail.com', '28-03-1994', 'Calle Secundaria, 456'
GO

--drop procedure sp_registrar_administrador
--go

create procedure sp_editar_administrador
	@cod_administrador char(5), @num_documento varchar(20), @nombre VARCHAR(30), @ape_paterno VARCHAR(30), @ape_materno VARCHAR(30), @telefono VARCHAR(9), @email VARCHAR(100), @fecha_nacimiento DATE, @direccion VARCHAR(100)
AS
BEGIN
	UPDATE tb_administrador SET num_documento = @num_documento, nombre = @nombre, ape_paterno = @ape_paterno, ape_materno = @ape_materno, telefono = @telefono, email = @email, fecha_nacimiento = @fecha_nacimiento, direccion = @direccion WHERE cod_administrador = @cod_administrador;
END
GO
EXECUTE sp_editar_administrador 'AD001', '103456789', 'Carlos', 'González', 'López', '945871658', 'carlosgonzalez@gmail.com', '15-05-1990', 'Calle Principal, 123'
GO
--drop procedure sp_editar_administrador
--go

create procedure cod @cod char(5)
as
begin
	delete from tb_administrador where cod_administrador = @cod
end
go
--execute sp_borrar_administrador 'A0001'
--go
--drop procedure sp_borrar_administrador
--go

--------------------------------------------
--PROCEDURE TABLA CLIENTE
--------------------------------------------

create procedure sp_listar_cliente
as
begin
	select * from tb_cliente order by cod_cliente asc
end
go
execute sp_listar_cliente
go
--drop procedure sp_listar_cliente
--go

create procedure sp_registrar_cliente
	@cod_cliente char(5), @num_documento varchar(20), @nombre VARCHAR(30), @ape_paterno VARCHAR(30), @ape_materno VARCHAR(30), @telefono VARCHAR(9), @email VARCHAR(100), @fecha_nacimiento DATE, @direccion VARCHAR(100)
as
begin
	insert into tb_cliente values(@cod_cliente, @num_documento, @nombre, @ape_paterno, @ape_materno, @telefono, @email, @fecha_nacimiento, @direccion);
end
go
execute sp_registrar_cliente 'C0001', '11516789', 'María', 'González', 'López', '945871658', 'mariagonzalez@gmail.com', '15-05-1990', 'Calle Principal, 123'
go
execute sp_registrar_cliente 'C0002', '98765321', 'Pedro', 'Sánchez', 'Ramírez', '951236874', 'pedrosanchez@gmail.com', '22-08-1985', 'Avenida Central, 456'
go
execute sp_registrar_cliente 'C0003', '45679123', 'Luis', 'Hernández', 'Torres', '965874123', 'luishernandez@gmail.com', '10-12-1992', 'Calle Secundaria, 789'
go
execute sp_registrar_cliente 'C0004', '78913456', 'Ana', 'López', 'García', '978541236', 'analgarcia@gmail.com', '03-07-1988', 'Avenida Principal, 789'
go
execute sp_registrar_cliente 'C0005', '65421987', 'Juan', 'Martínez', 'Pérez', '965487123', 'juanmartinez@gmail.com', '28-03-1994', 'Calle Secundaria, 456'
go
--drop procedure sp_registrar_cliente
--go

create procedure sp_editar_cliente
	@cod_cliente char(5), @num_documento varchar(20), @nombre VARCHAR(30), @ape_paterno VARCHAR(30), @ape_materno VARCHAR(30), @telefono VARCHAR(9), @email VARCHAR(100), @fecha_nacimiento DATE, @direccion VARCHAR(100)
as
begin
	update tb_cliente set num_documento = @num_documento, nombre = @nombre, ape_paterno = @ape_paterno, ape_materno = @ape_materno, telefono = @telefono, email = @email, fecha_nacimiento = @fecha_nacimiento, direccion = @direccion where cod_cliente = @cod_cliente;
end
go
execute sp_editar_cliente 'C0001', '11516788', 'María', 'González', 'López', '945871658', 'mariagonzalez@gmail.com', '15-05-1990', 'Calle Principal, 123'
go
--drop procedure sp_editar_cliente
--go

create procedure sp_borrar_cliente @cod char(5)
as
begin
	delete from tb_cliente where cod_cliente = @cod
end
go
--execute sp_borrar_cliente 'C0001'
--go
--drop procedure sp_borrar_cliente
--go

--------------------------------------------
--PROCEDURE TABLA PRODUCTO
--------------------------------------------

create procedure sp_listar_producto
as
begin
	select * from tb_producto order by cod_producto asc
end
go
execute sp_listar_producto
go
--drop procedure sp_listar_producto
--go

create procedure sp_registrar_producto
	@cod_producto char(5), @descripcion varchar(150), @fecha_registro DATE
as
begin
	insert into tb_producto values(@cod_producto, @descripcion, @fecha_registro);
end
go
execute sp_registrar_producto 'PD001', 'Camisa de algodón', '28-05-2023'
go
execute sp_registrar_producto 'PD002', 'Pantalón vaquero', '30-05-2023'
go
execute sp_registrar_producto 'PD003', 'Vestido de seda','02-06-2023'
go
execute sp_registrar_producto 'PD004', 'Chaqueta de lana', '05-06-2023'
go
execute sp_registrar_producto 'PD005', 'Bufanda de cashmere', '08-06-2023'
go

--drop procedure sp_registrar_producto
--go

create procedure sp_editar_producto
	@cod_producto char(5), @descripcion varchar(150), @fecha_registro DATE
as
begin
	update tb_producto set descripcion = @descripcion, fecha_registro = @fecha_registro where cod_producto = @cod_producto;
end
go
execute sp_editar_producto 'PD005', 'Bufanda de cashmere', '08-06-2023'
go
--drop procedure sp_editar_producto
--go

create procedure sp_borrar_producto @cod char(5)
as
begin
	delete from tb_producto where cod_producto = @cod
end
go
--execute sp_borrar_producto 'P0003'
--go
--drop procedure sp_borrar_producto
--go


--------------------------------------------
--PROCEDURE TABLA GERENTE
--------------------------------------------

create procedure sp_listar_gerente
as
begin
	select * from tb_gerente order by cod_gerente asc
end
go
execute sp_listar_gerente
go
--drop procedure sp_listar_gerente
--go

create procedure sp_registrar_gerente
	@cod_gerente char(5), @num_documento varchar(20), @nombre VARCHAR(30), @ape_paterno VARCHAR(30), @ape_materno VARCHAR(30), @telefono VARCHAR(9), @email VARCHAR(100), @fecha_nacimiento DATE, @direccion VARCHAR(100)
as
begin
	insert into tb_gerente values(@cod_gerente, @num_documento, @nombre, @ape_paterno, @ape_materno, @telefono, @email, @fecha_nacimiento, @direccion)
end
go
execute sp_registrar_gerente 'G0001', '12896789', 'Carlos', 'González', 'López', '945871658', 'carlosgonzalez@example.com', '10-05-1990', 'Calle Principal, 123'
go
execute sp_registrar_gerente 'G0002', '98764321', 'María', 'Hernández', 'Torres', '951236874', 'mariahernandez@example.com', '22-08-1985', 'Avenida Central, 456'
go
execute sp_registrar_gerente 'G0003', '45678923', 'Pedro', 'López', 'Ramírez', '965874123', 'pedrolopez@example.com', '10-12-1992', 'Calle Secundaria, 789'
go
execute sp_registrar_gerente 'G0004', '78913456', 'Luisa', 'Sánchez', 'Gómez', '978541236', 'luisasanchez@example.com', '03-07-1988', 'Avenida Principal, 789'
go
execute sp_registrar_gerente 'G0005', '65432197', 'Ana', 'Martínez', 'García', '965487123', 'anamartinez@example.com', '06-03-1994', 'Calle Secundaria, 456'
go
--drop procedure sp_registrar_gerente
--go

create procedure sp_editar_gerente
	@cod_gerente char(5), @num_documento varchar(20), @nombre VARCHAR(30), @ape_paterno VARCHAR(30), @ape_materno VARCHAR(30), @telefono VARCHAR(9), @email VARCHAR(100), @fecha_nacimiento DATE, @direccion VARCHAR(100)
as
begin
	update tb_gerente set num_documento = @num_documento, nombre = @nombre, ape_paterno = @ape_paterno, ape_materno = @ape_materno, telefono = @telefono, email = @email, fecha_nacimiento = @fecha_nacimiento, direccion = @direccion where cod_gerente = @cod_gerente
end
go
execute sp_editar_gerente 'G0001', '123456789', 'Carlos', 'González', 'López', '945871658', 'carlosgonzalez@example.com', '12-05-1990', 'Calle Principal, 123'
go
--drop procedure sp_editar_gerente
--go

create procedure sp_borrar_gerente @cod char(5)
as
begin
	delete from tb_gerente where cod_gerente = @cod
end
go
--execute sp_borrar_gerente 'G0001'
--go
--drop procedure sp_borrar_gerente
--go

--------------------------------------------
--PROCEDURE TABLA ALMACEN
--------------------------------------------

create procedure sp_listar_almacen
as
begin
	select * from tb_almacen order by cod_almacen asc
end
go
execute sp_listar_almacen
go
--drop procedure sp_listar_almacen
--go

create procedure sp_registrar_almacen
	@cod_almacen char(5), @cantidad INT, @unidad VARCHAR(50), @fecha_registro DATE, @precio_venta_unitario DECIMAL(10,2), @id_producto char(5), @id_proveedor char(5)
as
begin
	insert into tb_almacen values(@cod_almacen, @cantidad, @unidad, @fecha_registro, @precio_venta_unitario, @id_producto, @id_proveedor)
end
go
execute sp_registrar_almacen 'AL001', 100, 'NIU', '28-05-2023', 25.50, 'PD001', 'PR001'
go
execute sp_registrar_almacen 'AL002', 75, 'NIU', '29-05-2023', 12.75, 'PD002', 'PR002'
go
execute sp_registrar_almacen 'AL003', 50, 'NIU', '30-05-2023', 35.00, 'PD003', 'PR003'
go
execute sp_registrar_almacen 'AL004', 200, 'NIU', '30-06-2023', 10.99, 'PD004', 'PR004'
go
execute sp_registrar_almacen 'AL005', 150, 'NIU', '02-06-2023', 18.50, 'PD005', 'PR005'
go
--drop procedure sp_registrar_almacen
--go

create procedure sp_editar_almacen
	@cod_almacen char(5), @cantidad INT, @unidad VARCHAR(50), @fecha_registro DATE, @precio_venta_unitario DECIMAL(10,2), @id_producto char(5), @id_proveedor char(5)
as
begin
	update tb_almacen set cantidad = @cantidad, unidad = @unidad, fecha_registro = @fecha_registro, precio_venta_unitario = @precio_venta_unitario, id_producto = @id_producto, id_proveedor = @id_proveedor where cod_almacen = @cod_almacen
end
go
execute sp_editar_almacen 'AL002', 75, 'NIU', '29-05-2023', 12.75, 'PD002', 'PR002'
go

--drop procedure sp_editar_almacen
--go

create procedure sp_borrar_almacen @cod char(5)
as
begin
	delete from tb_almacen where cod_almacen = @cod
end
go
--execute sp_borrar_almacen 'AL001'
--go
--drop procedure sp_borrar_almacen
--go
Create Database Prestamos;

Use Prestamos;

Create Table Clientes
(
Cli_ID Int Identity(1,1) Primary Key,
Cli_Nombre Varchar(20) Not Null,
Cli_Primer_Apellido Varchar(20) Not Null,
Cli_Segundo_Apellido Varchar(20) Not Null,
Cli_Cedula Varchar(13) Not Null,
Cli_Genero Varchar(20) Null,
Cli_Estado_Civil Varchar(20) Null,
Cli_Correo_Electronico Varchar(30) Null,
Cli_Direccion Varchar(50) Null,
Cli_Estado Int Default 0
);

Create Table Servicios
(
Serv_ID Int Identity(1,1)  Primary Key,
Cli_Cedula Varchar(13) Not Null,
Serv_Monto_Prestamo Float Not Null,
Serv_Cuota Float Null,
Serv_Tasa Varchar(20) Null,
Serv_Fecha_Inicio Varchar(50) Null,
Serv_Fecha_Fin Varchar(50) Null,
Serv_Total_Pagar Float Null,
Serv_Estado Int Default 0,
Serv_CantidadMeses Int Null
);

Create Table Roles
(
Rol_ID Int Identity(1,1) Primary Key,
Rol_Descripcion Varchar(150),
Rol_Estado Int Default 0
);

Create Table Usuarios
(
Usu_ID Int Identity(1,1) Primary key,
Usu_Usuario Varchar(20) Not Null,
Usu_Contrasena Varchar(20) Not Null,
Usu_Nombre Varchar(150),
Rol_ID Int Foreign Key References Roles(Rol_ID) Default 1,
Usu_Estado Int Default 0,
Usu_LoginVencido Int Default 0
);

Create Table LoginTemporal
(
Lt_ID Int Identity(1,1) Primary Key,
Lt_Usuario Varchar(20) Not Null,
);

Create Table Pagos
(
Pago_ID Int Identity(1,1) Primary Key,
Serv_cuota Float Null,
Cli_Cedula Varchar(13) Not Null,
Serv_CantidadMeses Int Null
);

Insert Into Clientes(Cli_Nombre, Cli_Primer_Apellido, Cli_Segundo_Apellido, Cli_Cedula, Cli_Genero, Cli_Estado_Civil, Cli_Correo_Electronico, Cli_Direccion, Cli_Estado)
Values('Jose', 'Rodriguez', 'Santos', '402-0785000-2', 'Masculino', 'Soltero/a', 'jr19-0351@unphu.edu.do', '', 1);
Insert Into Clientes(Cli_Nombre, Cli_Primer_Apellido, Cli_Segundo_Apellido, Cli_Cedula, Cli_Genero, Cli_Estado_Civil, Cli_Correo_Electronico, Cli_Direccion, Cli_Estado)
Values('Victor', 'Rosa', 'Depratt', '402-1369763-0', 'Masculino', 'Soltero/a', 'vr19-1028@unphu.edu.do', '', 1);
Insert Into Clientes(Cli_Nombre, Cli_Primer_Apellido, Cli_Segundo_Apellido, Cli_Cedula, Cli_Genero, Cli_Estado_Civil, Cli_Correo_Electronico, Cli_Direccion, Cli_Estado)
Values('Prueba', 'Prueba', 'Prueba', '000-0000000-0', '', '', '', '', 0);

Insert Into Servicios(Cli_Cedula, Serv_Monto_Prestamo, Serv_Cuota, Serv_Tasa, Serv_Fecha_Inicio, Serv_Fecha_Fin, Serv_Total_Pagar, Serv_Estado, Serv_CantidadMeses)
Values('402-0785000-2', 21000, 700, '0.10', '14/12/2022', '14/03/2023', 23100, 1, 3);
Insert Into Servicios(Cli_Cedula, Serv_Monto_Prestamo, Serv_Cuota, Serv_Tasa, Serv_Fecha_Inicio, Serv_Fecha_Fin, Serv_Total_Pagar, Serv_Estado, Serv_CantidadMeses)
Values('402-1369763-0', 21000, 700, '0.10', '14/12/2022', '14/03/2023', 23100, 1, 3);
Insert Into Servicios(Cli_Cedula, Serv_Monto_Prestamo, Serv_Cuota, Serv_Tasa, Serv_Fecha_Inicio, Serv_Fecha_Fin, Serv_Total_Pagar, Serv_Estado, Serv_CantidadMeses)
Values('000-0000000-0', 21000, 700, '0.10', '14/12/2022', '14/03/2023', 23100, 0, 3);

Insert Into Roles(Rol_Descripcion, Rol_Estado) Values('Admin', 1);
Insert Into Roles(Rol_Descripcion, Rol_Estado) Values('Soporte', 1);
Insert Into Roles(Rol_Descripcion, Rol_Estado) Values('Servicio', 1);
Insert Into Roles(Rol_Descripcion, Rol_Estado) Values('Supervisor', 1);
Insert Into Roles(Rol_Descripcion, Rol_Estado) Values('Nose', 1);

Insert Into Usuarios(Usu_Usuario, Usu_Contrasena, Usu_Nombre, Rol_ID, Usu_Estado) Values ('Joss', '456', 'Jose Rodriguez', 1, 1);
Insert Into Usuarios(Usu_Usuario, Usu_Contrasena, Usu_Nombre, Rol_ID, Usu_Estado) Values ('Vrosa', '123', 'Victor Rosa', 2, 1);
Insert Into Usuarios(Usu_Usuario, Usu_Contrasena, Usu_Nombre, Rol_ID, Usu_Estado) Values ('Prueba', 'aaa', 'Prueba', 3, 0);

Insert Into Pagos(Serv_cuota, Serv_CantidadMeses, Cli_Cedula) Values (700, 3, '402-0785000-2');
Insert Into Pagos(Serv_cuota, Serv_CantidadMeses, Cli_Cedula) Values (700, 3, '402-1369763-0');
Insert Into Pagos(Serv_cuota, Serv_CantidadMeses, Cli_Cedula) Values (700, 3, '000-0000000-0');

Select * From Clientes;
Select * From Servicios;
Select * From Roles;
Select * From Usuarios;
Select * From LoginTemporal;
Select * From Pagos;

Drop Table Clientes;
Drop Table Servicios;
Drop Table Roles;
Drop Table Usuarios;
Drop Table LoginTemporal;
Drop Table Pagos;

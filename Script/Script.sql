create table localidad(cod_postal int primary key, nombre varchar(60));
create table centro_atencion(codigo serial primary key, nombre varchar(60), domicilio varchar(120),telefono varchar(20),cod_postal int);
create table enfermeros(nro_documento int primary key, nombres varchar(80), apellido varchar(90), domicilio varchar(120),telefono varchar(20), matricula varchar(15), cod_postal int);
create table pacientes(nro_documento int primary key, nombres varchar(80), apellido varchar(90), fecha_nac Date, domicilio varchar(120), telefono varchar(20),cod_postal int, de_riesgo bit, vacunado bit, observaciones varchar(250));
create table tipo_vacuna(codigo serial primary key, nombre varchar(90), cant_dosis int);
create table vacunas(codigo serial primary key, lote varchar(10),fecha_venc date, cod_tipo_vacuna int, cantidad float);
create table turno_vacuna(codigo serial primary key, fecha date, hora time,nro_doc_paciente int, nro_doc_enfermero int, asistio bit, cod_centro_a int, nro_dosis int,  cod_vacuna int);

alter table centro_atencion add constraint fk_centro_at_localidad foreign key(cod_postal) references localidad(cod_postal);

-- agregar columna relacion a un centro de atencion
alter table enfermeros add cod_centro_a int;

alter table enfermeros add constraint fk_enfermeros_centro_atencion foreign key(cod_centro_a) references centro_atencion(codigo);


alter table pacientes add constraint fk_paciente_localidad foreign key(cod_postal) references localidad(cod_postal);

alter table pacientes  ALTER COLUMN de_riesgo TYPE boolean using false;
alter table pacientes  ALTER COLUMN vacunado TYPE boolean using false;


alter table vacunas add constraint fk_vacuna_tipo_vac foreign key(cod_tipo_vacuna) references tipo_vacuna(codigo);

alter table turno_vacuna add constraint fk_turno_vacuna_paciente foreign key(nro_doc_paciente) references pacientes(nro_documento);
alter table turno_vacuna add constraint fk_turno_vacuna_enfermero foreign key(nro_doc_enfermero) references enfermeros(nro_documento);
alter table turno_vacuna add constraint fk_turno_vacuna_centro_at foreign key(cod_centro_a) references centro_atencion(codigo);
alter table turno_vacuna add constraint fk_turno_vacuna_vacuna foreign key(cod_vacuna) references vacunas(codigo);
alter table turno_vacuna ALTER COLUMN asistio TYPE boolean using false;

/* carga de informacion */


insert into localidad(cod_postal,nombre) values (9100,'Trelew'),(9103,'Rawson'),(9120, 'Puerto Madryn');
insert into tipo_vacuna(nombre, cant_dosis) values('pfizer-BiONTech',2),('Moderna',2),('Sputnik V',2);





-- tabla de usuarios del sistema - clave en texto claro, mejoras de este esquema tener la clave encriptada con algun algoritmo y para verificar, generar 
-- la clave con el texto que se ingresa desde la interfaz visual.
create table usuarios(id serial primary key, usuario varchar(90), clave varchar(120), fecha_login time, es_admin boolean default(false));
-- los roles de sistema permiten diferenciar accesos a funciones, por ejemplo
-- rol de consulta no podria acceder a operaciones de actualizacion de informacion
-- rol de operador -- algunas operaciones pueden ser restringidas segun rol.
-- rol de administrador.
create table roles(codigo int primary key, nombre varchar(40));

create table usuario_roles(codigo serial primary key, cod_usuario int, cod_rol int);

/* Mapeo de los permisos del usuario*/
/* Gestion de permiso administrador en el sistema, posee acceso a cada item del menu.*/
--- 

create table funciones(codigo serial primary key, nombre varchar(90));

create table funciones_rol(codigo serial primary key, cod_funcion int, cod_rol int, puede boolean default(false));

-- usuarios que se pueden conectar

insert into usuarios(usuario, clave,es_admin)
values
('msantander', 'lenguaje',true), --1
('operador','vacunacion',false), --2 
('admin', 'admin', false),		 --3
('consulta','consulta',false), 	 --4
('opEnfermeros','enfermero',false),--5
('opPacientes','paciente',false),  --6
('opTurnos','turno',false);  --7

-- roles que pueden tomar los usuarios
insert into roles(codigo,nombre) values(1,'consulta'),(2,'operador'),(3,'responsable'), (4,'administrador'),(5,'operadorEnfermero'),(6,'operadorPaciente'),(7,'operadorTurno')

-- funciones del sistema para dar permisos de acceso

insert into funciones(nombre) 
values
('AltaPaciente'),('ModificaPaciente'),('ConsultaPaciente'), -- 1,2,3
('AltaEnfermero'),('ModificaEnfermero'),('ConsultaEnfermero'), --4,5,6
('AltaTurno'),('ModificaTurno'),('ConsultaTurno'), --7,8,9
('AltaCentroAtencion'),('ModificaCentroAtencion'),('ConsultaCentroAtencion'),--10,11,12
('AltaTipoVacuna'),('ModificaTipoVacuna'),('ConsultaTipoVacuna'), --13,14,15
('AltaVacuna'),('ModificaVacuna'),('ConsultaVacuna'), -- 16,17,18
('AltaLocalidad'),('ModificaLocalidad'),('ConsultaLocalidad'), --19,20,21
('Listados'),('Estadisticas'),('Exportar'),--22,23,24
('ConsultaVacunado'),('RegistraAsistenciaTurno'),('ConsultaAuditoria');--25,26,27
-- rol asignado a usuario
-- asignacion de roles a usuarios
/*
msantander -> administrador
operador -> operador
admin -> administrador
consulta -> consulta
opEnfermeros -> operadorEnfermero
opPacientes -> operadorPaciente
opTurnos -> operadorTurno
*/
insert into usuario_roles(cod_usuario,cod_rol)values(1,4),(2,2),(3,4),(4,1),(5,5),(6,6),(7,7) ;

-- asignacion de funciones(todos) a rol administrador
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(1,4,true),(2,4,true),(3,4,true),(4,4,true),(5,4,true),(6,4,true),(7,4,true),(8,4,true),(9,4,true),(10,4,true),(11,4,true),(12,4,true),(13,4,true),(14,4,true),(15,4,true),(16,4,true),(17,4,true),(18,4,true),(19,4,true),(20,4,true),(21,4,true),(22,4,true),(23,4,true),(24,4,true),(25,4,true),(26,4,true),(27,4,true);

-- asignacion de permisos a consulta --  todas funciones de consulta y listado
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(3,1,true),(6,1,true),(9,1,true),(12,1,true),(15,1,true),(18,1,true),(21,1,true),(22,1,true);

-- asignacion de permisos a operadorEnfermero --  todas funciones de enfermero, listado y estadisticas
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(4,5,true),(5,5,true),(6,5,true),(22,5,true),(23,5,true);

-- asignacion de permisos a operadorPaciente --  todas funciones de paciente, listado y estadisticas
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(1,6,true),(2,6,true),(3,6,true),(22,6,true),(23,6,true);

-- permisos para operador
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(2,2,true),(3,2,true),(5,2,true),(6,2,true),(8,2,true),(9,2,true),(11,2,true),(12,2,true),(14,2,true),(17,2,true),(20,2,true),(21,2,true),(22,2,true),(23,2,true),(24,2,true),(25,2,true),(26,2,true);

-- permisos para operadorTurno
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(3,7,true),(6,7,true),(7,7,true),(8,7,true),(9,7,true),(12,7,true),(18,7,true),(21,7,true),(22,7,true),(23,7,true),(24,7,true),(25,7,true),(26,7,true);

--- tabla de auditoria.
create table logger(id serial primary key, usuario varchar(90), objeto varchar(90), fecha timestamp, operacion varchar(80), detalle varchar(8000));



use master
DROP DATABASE bdFutbol;
create  database bdFutbol;

go
use bdFutbol;
go

create table ligas(
	codLiga char(5),
	nomLiga varchar(50),
	constraint pkLigas  primary Key (codLiga)
);

insert into ligas VALUES('LFP00', 'LIGA DE FÚTBOL PROFESIONAL');
insert into ligas values('PREM0', 'PREMIER LEAGUE');
insert into ligas values('SERIA', 'SERIE A');

create table equipos(
	codEquipo int identity(1,1),
	nomEquipo varchar(40),
	codLiga char(5) default 'PDN',
	localidad varchar(60),
	internacional bit default 0 not null,
	constraint pkEquipos primary key (codEquipo),
	constraint fkEquipo_CodLiga foreign key (codLiga) references ligas (codLiga)
);

insert into equipos VALUES( 'FCB00', 'LFP00', 'BARCELONA', 1);
insert into equipos VALUES( 'RMCF0', 'LFP00', 'MADRID', 1);
select * from equipos

	
create table futbolistas(
	coddnionie char(9),
	nombre varchar(50),
	nacionalidad varchar(40),
	constraint pkFutbolistas primary key (coddnionie)
);

insert into futbolistas VALUES( '123456789', 'LIONEL MESSI', 'ARGENTINA');
insert into futbolistas VALUES( '123456389', 'TER STEGEN', 'ALEMANIA');
insert into futbolistas VALUES( '123412789', 'ANDRÉS INIESTA', 'ESPAÑA');



create table contratos(
	codcontrato int identity(1,1),
	coddnionie char (9),
	codEquipo int,
	fechaInicio date,
	fechaFin date,
	precioanual int,
	preciorecision int,
	constraint pkContratos primary key(codcontrato),
	constraint fkContratos_futbolistas foreign key (coddnionie) references futbolistas(coddnionie),
	constraint fkContratos_equipos foreign key (codEquipo) references equipos(codEquipo)
);

insert into contratos VALUES( '123456789', 1, '01/01/2018', '01/01/2021', 20000000, 5000000);
insert into contratos VALUES( '123456789', 1, '01/01/2014', '01/01/2018', 2000000, 500000);
insert into contratos VALUES( '123456389', 1, '01/01/2019', '01/08/2021', 320000, 50008);
insert into contratos VALUES( '123412789', 1, '01/01/2004', '01/01/2016', 5130000, 721415);


select * from contratos
--procesos y funciones

/*Crear un procedimiento almacenado que liste todos los contratos de cierto futbolista pasando por
parámetro de entrada el dni o nie del futbolista, ordenados por fecha de inicio.
Los datos a visualizar serán: Código de contrato, nombre de equipo, nombre de liga, fecha de inicio,
fecha de fin, precio anual y precio de recisión del contrato.
*/
go
create procedure contratos_futbolista
	@documento char(9)
		as
		begin
			select codcontrato, equipos.nomEquipo, ligas.nomLiga, fechaInicio, fechaFin, precioanual, preciorecision from contratos
			join equipos on equipos.codEquipo=contratos.codEquipo
			join ligas on ligas.codLiga=equipos.codLiga
			where coddnionie=@documento
			order by (fechaInicio)
		
		end

exec contratos_futbolista '123456789'


			   			   

/*
Crear un procedimiento almacenado que inserte un equipo, de modo que se le pase como parámetros
todos los datos.
Comprobar que el código de liga pasado exista en la tabla ligas. En caso de que no exista la liga que
no se inserte.
Devolver en un parámetro de salida: 0 si la liga no existe y 1 si la liga existe.
Devolver en otro parámetro de salida: 0 si el equipo no se insertó y 1 si la inserción fue
correcta.
*/
go
create procedure insertar_equipo
	@nomEquipo varchar(40),	@codLiga char(5), @localidad varchar(60),@internacional bit, @liga_existe bit output, @error_insercion bit output
		as	
		begin
			set @error_insercion=0
			set @liga_existe=0
			if exists (select nomLiga from ligas where codLiga=@codLiga)
				begin
					set @liga_existe=1
					insert into equipos values ( @nomEquipo, @codLiga, @localidad, @internacional)
					set @error_insercion=1
				end
		end
go
	declare  @liga_existe bit , @error_insercion bit 
	exec insertar_equipo 'BETIS', 'LFP00', 'SEVILLA', 0, @liga_existe output, @error_insercion output
	select @liga_existe, @error_insercion
	select * from equipos
	go

	declare  @liga_existe bit , @error_insercion bit 
	exec insertar_equipo 'BETIS', 'LFP40', 'SEVILLA', 0, @liga_existe output, @error_insercion output
	select @liga_existe, @error_insercion
	select * from equipos
/*
 Crear un procedimiento almacenado que indicándole un equipo, precio anual y un precio recisión,
devuelva dos parámetros. En un parámetro de salida la cantidad de futbolistas en activo (con contrato
vigente) que hay en dicho equipo. En otro parámetro de salida la cantidad de futbolistas en activo de
dicho equipo con precio anual y de recisión menor de los indicados.
*/
go
create procedure consulta_contratos
	@nomEquipo varchar(40), @precio_anual int, @precio_recision int, @numero_activos int output, @numero_consultado int output
	as
	begin
		set @numero_activos=( select COUNT(codcontrato) from contratos 
									join equipos on equipos.codEquipo=contratos.codEquipo
									where equipos.nomEquipo=@nomEquipo and getdate()<contratos.fechaFin
								
							);
		set @numero_consultado=( select COUNT(codcontrato) from contratos 
									join equipos on equipos.codEquipo=contratos.codEquipo
									where equipos.nomEquipo=@nomEquipo and getdate()<contratos.fechaFin and contratos.precioanual<=@precio_anual and contratos.preciorecision<=@precio_recision
								
							);



	end
go



declare  @numero_activos INT , @numero_consultado INT 
	exec consulta_contratos 'FCB00',5130000 ,500000, @numero_activos output, @numero_consultado output
	select @numero_activos, @numero_consultado

/*
 Crear una función que dándole un dni o nie de un futbolista nos devuelva en número de meses total
que ha estado en equipos. 
*/
go
create function meses_activo (@documento char(9))
	returns int
	begin
		declare @ans int
		set @ans=(select sum(DATEDIFF(month, fechaInicio, fechaFin ))from contratos
					where coddnionie=@documento) 
		return @ans
	end
go
select dbo.meses_activo('123456789')
select dbo.meses_activo('123412789')

--creamos la tabla personas--
create table personas(
 nombre varchar(25),
 apellido varchar(25),
 edad int ,
 -- 3 indica la cantidad de digitos, el 2 los numeros despues de la coma--
 estatura decimal(3,2)
 )


 --cargamos entre 10 y 20 personas--
 select * from personas

 insert into personas 
 values 
    ('Juan', 'P�rez', 25, 1.75),
    ('Mar�a', 'Gonz�lez', 30, 1.60),
    ('Luis', 'Mart�nez', 35, 1.80),
    ('Ana', 'L�pez', 28, 1.65),
    ('Carlos', 'Rodr�guez', 40, 1.70),
    ('Laura', 'S�nchez', 22, 1.55),
    ('Pedro', 'Hern�ndez', 33, 1.75),
    ('Sof�a', 'D�az', 24, 1.70),
    ('Miguel', 'Ruiz', 27, 1.80),
    ('Luc�a', 'Torres', 31, 1.60),
	('Myke', 'Towers', 30, 1.76),
	('Joaquinha', 'Riva', 29, 1.70),
	('Antonella', 'Pane', 27, 1.75),
	('Marcelo', 'Toscano', 57, 1.60),
	('Carlos', 'Maslaton', 31, 1.65),
	('Chicho', 'Franco', 11, 1.65),
	('Conan', 'Tassara', 13, 1.65);

	--mostrar todas las personas con +18 anos--

	select * from personas where edad >18;

	--mostrar listado completo por estatura--
	select * from personas order by estatura 

	--mostrar listado completo por apellido y nombre--
	select * from personas order by apellido , nombre

	--mostrar todas las personas con 18 o +  y mostrar su nombre, apellidp,edad y altura--
	select * from personas where edad >= 18 order by apellido, nombre

	--Eliminar todas las personas cuya edad sea exactamente 30 a�os--
	select * from personas where edad = 30
	delete from personas where edad = 30
	
	--Actualizar la estatura de todas las personas mayores de 1.75 metros, reduci�ndola en 0.05 metros--
	update personas
	set estatura = estatura - 0.05
	--condicionn de personas--
	where estatura > 1.75

	--Mostrar el nombre y apellido de la persona m�s joven--
	select nombre, apellido from personas order by edad
	--mostramos el mas menos de todos con metodo select top--
	select top 1 nombre, apellido from personas order by edad

	-- Eliminar todas las personas cuya estatura sea menor o igual a 1.60 metros--
		select * from personas where estatura <= 1.60
		delete from personas where estatura <= 1.60

	--Actualizar la edad de todas las personas mayores de 20 a�os, sum�ndoles 2 a�os--
	 update personas 
	 set edad = edad + 2
	 where edad > 20

	 -- Mostrar el nombre, apellido y edad de todas las personas cuya edad est� entre 25 y 35 a�os, ordenadas por edad de forma descendente.--
	 select nombre, apellido, edad from personas
	 where edad > 25 and edad < 35
	 order by edad desc

	-- Eliminar todas las personas cuyo nombre�sea�'Juan'--
	select * from personas where nombre = 'juan'
	delete from personas where nombre = 'juan'
	
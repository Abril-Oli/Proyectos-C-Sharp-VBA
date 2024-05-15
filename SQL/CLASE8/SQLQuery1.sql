--CREACION DE TABLA--

create table animales(
ID int primary key,
NOMBRE varchar(50) );

select * from animales;

--alteramos la tabla para agregar un campo--
--Agrega a la tabla animales especie, en registros previos donde el valor sea nulo, se default es perro-
alter table animales
add especie varchar(20) not null default 'Perro';

--agregamos animales de Sanrio--
INSERT INTO ANIMALES VALUES 
(1, 'Kitty', 'Gato'),
(2, 'Cinammoroll', 'Perro'),
(3, 'Pompompurin', 'Perro'),
(4, 'MyMelody', 'Conejo'),
(5, 'Kuromi', 'Conejo'),
(6, 'Pochacco', 'Perro'),
(7, 'Keroppi', 'Rana'),
(8, 'Chococat', 'Gato'),
(9, 'Badz Maru', 'Pajaro'),
(10, 'Tuxedosam', 'Pajaro')

select * from animales

--modificamos la tabla para agregar el campo edad/ no puede ser nulo--
alter table animales
 add edad int not null default 0 ;

 --agregamos mas animales/los mismos con id, nombre, especie y edad--
insert into Animales values
(11, 'Pirulina','Marmota', 200),
(12, 'Trotksy', 'Gato', 10),
(13, 'Shamoun', 'Ballena', 35);

--consultas--
--muestra por especie, el animal mas viejo y el que tenga el id mas bajo--

select especie , max (edad) as [Mas viejito], min (id) as [Minimo ID]
from Animales
group by especie

--muestra campo de especie, cuenta  la cantidad, los agrupa por especie y ordenada descendentemente.
SELECT especie, COUNT(*) AS cantidad FROM animales
GROUP BY especie
ORDER BY cantidad DESC;

--Clasifica por especie y cantidad, calcula el promedio de edad , muestra el mas grande y sordena descendentemente.--
SELECT especie, COUNT(*) AS cantidad, AVG(edad) AS promedio_edad, MAX(edad) AS maxima_edad
FROM animales
GROUP BY especie
ORDER BY cantidad DESC;

--Muestra los 3 gatos mas grandes--
select top 3 * from animales where especie = 'gato'
order by edad desc

--Muestra los primeros 3 nombres de perros o gatos y ordena por edad desc--
select top 3 nombre
from animales 
where especie in ('gato', 'perro')
order by edad desc

--Muestra los primeros 3 animales mas viejos que no sean gatos o perros y ordena desc--
select top 3 nombre, 
from animales 
where especie not in ('gato', 'perro')
order by edad desc



-- Crear la database
CREATE SCHEMA `clave5_grupo10db`;
use clave5_grupo10db

-- Crear la tabla pais
CREATE TABLE `clave5_grupo10db`.`tblpais` (
  `idPais` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idpais`));
  -- Crear la tabla contribuyente
CREATE TABLE `clave5_grupo10db`.`tblcontribuyente` (
  `idContribuyente` INT NOT NULL AUTO_INCREMENT,
  `dui` varchar(10) NOT NULL,
  `nombres` VARCHAR(45) NOT NULL,
  `apellidos` VARCHAR(45) NOT NULL,
  `fechaNacimiento` DATETIME NOT NULL,
  `idPais` INT NOT NULL,
  PRIMARY KEY (`idContribuyente`),
  INDEX `idPais` (`idPais` ASC) INVISIBLE,
  CONSTRAINT `idPais`
    FOREIGN KEY (`idPais`)
    REFERENCES `clave5_grupo10db`.`tblpais` (`idpais`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- Crear la tabla impuesto
CREATE TABLE `clave5_grupo10db`.`tblimpuesto` (
  `idImpuesto` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `tasa` DECIMAL(2,2) NOT NULL,
  `idPais` INT NOT NULL,
  PRIMARY KEY (`idImpuesto`),
  INDEX `idPais` (`idPais` ASC) INVISIBLE,
  CONSTRAINT `idPais2`
    FOREIGN KEY (`idPais`)
    REFERENCES `clave5_grupo10db`.`tblpais` (`idPais`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
    
-- Crear la tabla detalle de pago
CREATE TABLE `clave5_grupo10db`.`detallepago` (
  `iddetallepago` INT NOT NULL AUTO_INCREMENT,
  `idcontribuyente` INT NOT NULL,
  `idimpuesto` INT NOT NULL,
  `sobreConcepto` VARCHAR(45) NOT NULL,
  `cantidad` DECIMAL(7,2) NOT NULL,
  `total` DECIMAL(7,2) NOT NULL,
  `anio` INT NOT NULL,
  PRIMARY KEY (`iddetallepago`),
  INDEX `idcontribuyente` (`idcontribuyente` ASC) INVISIBLE,
  INDEX `idimpuesto` (`idimpuesto` ASC) VISIBLE,
  CONSTRAINT `idcontribuyente`
    FOREIGN KEY (`idcontribuyente`)
    REFERENCES `clave5_grupo10db`.`tblcontribuyente` (`idContribuyente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `idimpueesto`
    FOREIGN KEY (`idimpuesto`)
    REFERENCES `clave5_grupo10db`.`tblimpuesto` (`idImpuesto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
    -- introducir paises
insert into tblpais (idPais, nombre) values 
(1,'Costa Rica'),
(2,'Panamá'),
(3,'México'),
(4,'Brasil'),
(5,'Republica Dominicana'),
(6,'Colombia'),
(7,'Argentina'),
(8,'Brazil'),
(9,'Chile'),
(10,'El Salvador');
-- Introducir contribuyentes
insert into tblcontribuyente (idContribuyente, dui,nombres,apellidos, fechaNacimiento, idPais) values 
(1,'02188812-7','Chad', 'O''Hagerty',  '1997-10-17',1),
(2,'08758355-4','Chadwick', 'McGeagh', '2001-07-14',2),
(3,'07849141-8','Suzanna', 'Tonepohl', '2008-12-04',3),
(4,'01392748-7','Brien', 'Haysham', '2008-04-23',4),
(5,'09423654-3','Kirsteni', 'Balharrie', '2011-10-04',5),
(6,'06358238-6','Emmey', 'Tortis', '1996-06-09',6),
(7,'04789656-6','Melli', 'Sabbin', '2004-08-23',7),
(8,'05775169-1','Bebe', 'Bende', '2020-01-13',8),
(9,'05876841-6','Jaclyn', 'Keller', '2006-02-16',9),
(10,'06534373-1','Ceil', 'Elecum', '2003-06-07',10);

INSERT INTO tblimpuesto(idImpuesto, nombre,tasa,idPais) VALUES 
(1, 'ISR', 0.10, 10),
(2, 'IVA', 0.13, 10),
(3, 'Tabaco', 0.06, 10),
(4, 'Bebidas carbonatas', 0.07, 10),
(5, 'Bebidas alcohólicas', 0.20, 10),
(6, 'Inmuebles', 0.25, 10),
(7, 'Vehúculo automotriz', 0.25,10),
(8, 'Impuesto de ropa', 0.05,10),
(9, 'Impuesto de turismo', 0.10,10);

insert into detallepago(iddetallepago,idcontribuyente,idimpuesto,sobreConcepto,cantidad,total,anio) values
(1,10,1,'Salario',1300.00,130.00,2012),
(2,10,2,'Venta',100.00,13.00,2013),
(3,10,3,'Venta',50.00,3.00,2014),
(4,10,4,'Venta',250.00,17.50,2015),
(5,10,5,'Venta',250.00,50.00,2016),
(6,10,6,'Venta',35000.00,8750.00,2017),
(7,10,7,'Venta',8500.00,2125.00,2018),
(8,10,8,'Venta',125.00,6.25,2019),
(9,10,9,'Venta',500.00,50.00,2020);

-- Consulta de Contribuyente y pais
select tblcontribuyente.idContribuyente, tblcontribuyente.dui, tblcontribuyente.nombres, tblcontribuyente.apellidos, tblcontribuyente.fechaNacimiento, tblpais.nombre
 from tblcontribuyente inner join tblpais on tblcontribuyente.idPais = tblpais.idPais;

-- Consulta de todas las tablas
select tblcontribuyente.idContribuyente as NIT, tblcontribuyente.nombres as Nombre, tblcontribuyente.apellidos as Apellidos, detallepago.iddetallepago as "No. Pago", tblimpuesto.nombre as Impuesto, tblimpuesto.tasa as Tasa, detallepago.sobreConcepto as "Sobre Concepto", detallepago.cantidad as "Cantidad vendida", detallepago.total as "Total" , detallepago.anio as Año, tblpais.nombre as País from tblcontribuyente inner join detallepago on tblcontribuyente.idContribuyente = detallepago.idcontribuyente inner join tblimpuesto on detallepago.idimpuesto = tblimpuesto.idImpuesto inner join tblpais on tblimpuesto.idPais = tblpais.idPais;

-- Consulta sobre el impuesto y el pais
select tblimpuesto.idImpuesto, tblimpuesto.nombre, tblimpuesto.tasa, tblpais.nombre  from tblimpuesto inner join tblpais on tblimpuesto.idPais = tblpais.idPais;
-- Consulta sobre el impuesto relacionado al contribuyente
select tblimpuesto.idImpuesto from tblImpuesto inner join tblpais on tblImpuesto.idPais=tblpais.idPais inner join tblcontribuyente on tblpais.idPais = tblcontribuyente.idPais where tblcontribuyente.idContribuyente=10;

select * from detallepago
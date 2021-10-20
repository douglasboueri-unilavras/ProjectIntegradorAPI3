
CREATE TABLE `categoria` (
   `Id` int NOT NULL,
   `Nome` varchar(40) NOT NULL,
   PRIMARY KEY (`Id`)
 );
 CREATE TABLE `colaborador` (
   `Nome` varchar(40) NOT NULL,
   `Quantidade` int NOT NULL,
   `categoria` int NOT NULL,
   PRIMARY KEY (`Nome`)
 );
 CREATE TABLE `pizza` (
   `Nome` varchar(40) NOT NULL,
   `Numero_de_fatias` int NOT NULL,
   `Preço` double DEFAULT NULL,
   `Borda` int NOT NULL,
   PRIMARY KEY (`Nome`)
 );
 CREATE TABLE `produtocat` (
   `Id` int NOT NULL,
   `Nome` varchar(40) NOT NULL,
   `Quantidade` int NOT NULL,
   `Gluten` tinyint(1) NOT NULL,
   PRIMARY KEY (`Id`)
 );
 CREATE TABLE `produtotip` (
   `Nome` varchar(40) NOT NULL,
   `Codigo` int NOT NULL,
   `Tipo` varchar(40) NOT NULL,
   PRIMARY KEY (`Nome`)
 ); 
 CREATE TABLE `tipo` (
   `Id` int NOT NULL,
   `Nome` varchar(40) NOT NULL,
   PRIMARY KEY (`Id`)
 ); 
 

 insert into Categoria values (1,"salgado");
 insert into Categoria values (2,"lanche");
 insert into Categoria values (3,"pizza");
 
 insert into colaborador values ("messi",1,1);
 insert into colaborador values ("pele",2,2);
 
 insert into pizza values ("nelmara",8,35,1);
 insert into pizza  values ("nara",8,40,1);
 
 insert into produtocat values (1,"tony",2,1);
 
insert into produtotip values ("juka",13,"lenda");
insert into produtotip values ("coutinho",14,"fera");

insert into tipo  values (1,"marca");
insert into tipo values (2,"estoque");

 
 
 
 
 
 
 
 
 
 
 
 
 
--create database MinhaDB;

use MinhaDB;


create table Cliente(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Nome varchar(50) not null,
);


create table Telefones(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Numero varchar(50) unique not null,
	TipoTelefone varchar(10),
	ClienteId int FOREIGN KEY REFERENCES Cliente(Id)	
);

--DROP TABLE Telefones;

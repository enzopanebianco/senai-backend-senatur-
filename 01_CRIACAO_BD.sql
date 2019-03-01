create database Senatour_Tarde

create table Pacotes(
	ID int identity primary key
	,NomePacote varchar(255) not null
	,Descricao varchar(255) 
	,DataIda datetime not null
	,DataVolta datetime not null
	,Valor decimal(10,2) not null
	,Ativo int not null
	,Cidade varchar(255) not null
);

create table Usuarios(
	ID int identity primary key 
	,Email varchar(255) not null unique
	,Senha varchar(255) not null
	,Tipo_Usuario varchar(255) not null
);

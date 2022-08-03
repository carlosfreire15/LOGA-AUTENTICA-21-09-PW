create database dbAutorizacao;
use dbAutorizacao;


create table tbUsuario(
	UsuarioID int auto_increment primary key,
    UsuNome varchar(100) not null unique,
    Login varchar(50) not null unique,
    senha varchar(100) not null
);


create database dbExemplo;
use dbExemplo;

create table tbUsuario
(
	idUsuario int primary key auto_increment,
    NomeUsu varchar(50) not null,
    Cargo varchar(50) not null,
    DataNasc date 
);

insert into tbUsuario(NomeUsu, Cargo, DataNasc) 
		values ("Bob", "Motorista", "2019/04/16"),
			   ("Maria", "171", "2019/04/16");
               
select * from tbUsuario;
		
DELIMITER $$

create procedure InsereUsu(pNomeUsu varchar(50), 
					pCargo varchar(50), pDataNasc date)
begin
	insert into tbUsuario(NomeUsu, Cargo, DataNasc)
		values (pNomeUsu, pCargo, pDataNasc);
end; $$

call InsereUsu ("DST", "Aluno", "2020/02/07");








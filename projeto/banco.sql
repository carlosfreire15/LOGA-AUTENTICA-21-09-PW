
use dbAutorizacao;


create table tbUsuario(
	UsuarioID int auto_increment primary key,
    UsuNome varchar(100) not null unique,
    Login varchar(50) not null unique,
    senha varchar(100) not null
);
select * from tbUsuario;

-- procedure Insert Usuario
DELIMITER $$
CREATE PROCEDURE spInsertUsuario(vUsuNome varchar(100), vLogin varchar(50), vSenha varchar(100))
begin
insert into tbUsuario(UsuNome,Login,Senha)
				values(vUsuNome,vLogin,vSenha);
End $$



-- método SelectUsuario

DELIMITER $$
CREATE PROCEDURE spSelectUsuario(vLogin varchar(50))
begin
select * from tbUsuario where Login = vLogin;
End $$


-- método SelectLogin

DELIMITER $$
CREATE PROCEDURE spSelectLogin(vLogin varchar(50))
begin
select Login from tbUsuario where Login = vLogin;
End $$




-- método UpdateSenha

DELIMITER $$
CREATE PROCEDURE spUpdateSenha(vLogin varchar(50), vSenha varchar(100))
begin
update tbUsuario set Senha = vSenha where Login = vLogin;
End $$






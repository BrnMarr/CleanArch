
--SELECT * FROM Empresas


--INSERT INTO Empresas (Nome) values ('Toda Linda Vest ME')

SELECT * FROM Perfil

INSERT INTO Perfil (idEmpresa, Nome, SemanaTodos,Alteracao,Ativo) values (1, 'Admin',1,1,1)

INSERT INTO PerfilPermissao (idPerfil,Nome,RotaPrincipal) values (1,'Produtos','Index')



ALTER TABLE PerfilPermissao ALTER COLUMN RotaPrincipal varchar(35) null
ALTER TABLE PerfilPermissao ALTER COLUMN RotaSecundaria varchar(35) null


SELECT * FROM PerfilPermissao



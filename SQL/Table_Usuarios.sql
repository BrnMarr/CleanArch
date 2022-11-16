
--DROP TABLE Empresa

CREATE TABLE Empresas
(
   idEmpresa int identity(1,1) not null,
   Nome varchar(50) null,

CONSTRAINT [PK_Empresas] PRIMARY KEY CLUSTERED 
(
	[idEmpresa] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE Perfil
(
   idPerfil int identity(1,1) not null,
   idEmpresa int not null,
   Nome varchar(50) null,
   DataExpiracao datetime2(7) null,
   HorarioInicio datetime2(7) null, 
   HorarioFim datetime2(7) null,
   SemanaTodos bit null,
   Segunda bit null,
   Terca bit null,
   Quarta bit null,
   Quinta bit null,
   Sexta bit null,
   Sabado bit null,
   Domingo bit null,
   Feriado bit null,
   Alteracao bit null,
   Inserir bit null,
   Deletar bit null,
   Consultar bit null,
   Ativo bit null,

CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[idPerfil] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Perfil] WITH CHECK ADD CONSTRAINT [FK_Perfil_idEmpresa] FOREIGN KEY([idEmpresa])
REFERENCES [Empresas] ([idEmpresa])
GO

CREATE TABLE PerfilPermissao
(
   idPerfilPermissao int identity(1,1) not null,
   idPerfil int not null,
   Nome varchar(30) not null,
   RotaPrincipal bit null,
   RotaSecundaria bit null,

CONSTRAINT [PK_PerfilPermissao] PRIMARY KEY CLUSTERED 
(
	[idPerfilPermissao] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


ALTER TABLE [PerfilPermissao] WITH CHECK ADD CONSTRAINT [FK_PerfilPermissao_idPerfil] FOREIGN KEY([idPerfil])
REFERENCES [Perfil] ([idPerfil])
GO



CREATE TABLE Usuarios
(
   idUsuario int identity(1,1) not null,
   idPerfil int not null,
   Nome varchar(50) null,
   Senha varchar(30) null,
   Ativo bit null,
CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


ALTER TABLE [Usuarios] WITH CHECK ADD CONSTRAINT [FK_Usuarios_idPerfil] FOREIGN KEY([idPerfil])
REFERENCES [Perfil] ([idPerfil])
GO


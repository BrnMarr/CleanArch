
--DROP TABLE Empresa

CREATE TABLE Empresa
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
   idTipoPerfil int null,
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

ALTER TABLE [Perfil] WITH CHECK ADD CONSTRAINT [FK_Perfil_idUsuario] FOREIGN KEY([idUsuario])
REFERENCES [Usuario] ([idUsuario])
GO

CREATE TABLE PerfilAcesso
(
   idPerfilAcesso int identity(1,1) not null,
   idPerfil int not null,
   Nome varchar(30) not null,
   RotaPrincipal varchar(15),
   RotaSecundaria varchar(15) null,

CONSTRAINT [PK_idPerfilAcesso] PRIMARY KEY CLUSTERED 
(
	[idPerfilAcesso] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [PerfilAcesso] WITH CHECK ADD CONSTRAINT [FK_PerfilAcesso_idPerfil] FOREIGN KEY([idPerfil])
REFERENCES [Perfil] ([idPerfil])
GO



CREATE TABLE Usuario
(
   [idUsuario] int identity(1,1) not null,
   [idEmpresa] int not null,  
   [Nome] varchar (50) null,
   [Email] varchar (30) NULL,
   [Senha] varchar(30) null,
   [Ativo] bit null,
CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Usuario] WITH CHECK ADD CONSTRAINT [FK_Usuario_idEmpresa] FOREIGN KEY([idEmpresa])
REFERENCES [Empresa] ([idEmpresa])
GO

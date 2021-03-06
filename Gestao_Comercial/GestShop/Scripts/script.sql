USE [GestShop]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 17/12/2019 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](20) NOT NULL,
	[Ativo] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil_Usuario]    Script Date: 17/12/2019 19:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil_Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Perfil] [int] NOT NULL,
	[Id_Usuario] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 17/12/2019 19:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Preco_Custo] [decimal](7, 2) NOT NULL,
	[Preco_Venda] [decimal](7, 2) NOT NULL,
	[Quant_Estoque] [int] NOT NULL,
	[Id_Fornecedor] [int] NOT NULL,
	[Id_Local_Armazenamento] [int] NOT NULL,
	[Ativo] [bit] NOT NULL,
	[Imagem] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 17/12/2019 19:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Senha] [nvarchar](32) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](150) NULL,
	[Id_Perfil] [int] NOT NULL
) ON [PRIMARY]
GO

/****** Procedimento de Banco de Dados ******/
create procedure add_produto

@Codigo varchar(10) NOT NULL,
@Nome varchar(50) NOT NULL,
@Preco_Custo decimal(7, 2) NOT NULL,
@Preco_Venda decimal(7, 2) NOT NULL,
@Quant_Estoque int NOT NULL,
@Id_Fornecedor int NOT NULL,
@Id_Local_Armazenamento int NOT NULL,
@Ativo bit NOT NULL,
@Imagem varchar(100) NULL
as
begin

insert into Produto (Codigo,Nome,Preco_Custo,Preco_Venda,Quant_Estoque,Id_Fornecedor,Id_Local_Armazenamento,Ativo,Imagem) values 
(@Codigo,@Nome,@Preco_Custo,@Preco_Venda,@Quant_Estoque,@Id_Fornecedor,@Id_Local_Armazenamento,@Ativo,@Imagem)


end



SET IDENTITY_INSERT [dbo].[Perfil] ON 

INSERT [dbo].[Perfil] ([Id], [Nome], [Ativo]) VALUES (1, N'Admin', 1)
INSERT [dbo].[Perfil] ([Id], [Nome], [Ativo]) VALUES (2, N'Gerente', 1)
INSERT [dbo].[Perfil] ([Id], [Nome], [Ativo]) VALUES (3, N'Funcionario', 1)
SET IDENTITY_INSERT [dbo].[Perfil] OFF
SET IDENTITY_INSERT [dbo].[Perfil_Usuario] ON 

INSERT [dbo].[Perfil_Usuario] ([Id], [Id_Perfil], [Id_Usuario]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[Perfil_Usuario] OFF
SET IDENTITY_INSERT [dbo].[Produto] ON 

INSERT [dbo].[Produto] ([Id], [Codigo], [Nome], [Preco_Custo], [Preco_Venda], [Quant_Estoque], [Id_Fornecedor], [Id_Local_Armazenamento], [Ativo], [Imagem]) VALUES (1, N'000000001', N'Produto1', CAST(50.00 AS Decimal(7, 2)), CAST(80.00 AS Decimal(7, 2)), 5, 1, 1, 1, NULL)
INSERT [dbo].[Produto] ([Id], [Codigo], [Nome], [Preco_Custo], [Preco_Venda], [Quant_Estoque], [Id_Fornecedor], [Id_Local_Armazenamento], [Ativo], [Imagem]) VALUES (2, N'000000002', N'Produto2', CAST(25.00 AS Decimal(7, 2)), CAST(45.00 AS Decimal(7, 2)), 3, 1, 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[Produto] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [Login], [Senha], [Nome], [Email], [Id_Perfil]) VALUES (1, N'admin', N'admin', N'Pereira', N'pereira@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
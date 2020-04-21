USE [GerenciamentoFinancas]
GO
/****** Object:  Table [dbo].[tCategoria_Despesa]    Script Date: 20/04/2020 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCategoria_Despesa](
	[cCategoria] [decimal](10, 0) IDENTITY(1,1) NOT NULL,
	[rCategoria] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[cCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tCobranca_Pagamento]    Script Date: 20/04/2020 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCobranca_Pagamento](
	[cCobrPag] [decimal](10, 0) IDENTITY(1,1) NOT NULL,
	[cTipo] [decimal](2, 0) NULL,
	[dtRegistro] [date] NULL,
	[cValor] [decimal](18, 2) NULL,
	[rTitular] [varchar](100) NULL,
	[cStatus] [decimal](2, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[cCobrPag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tConsulta]    Script Date: 20/04/2020 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tConsulta](
	[cConsulta] [decimal](10, 0) IDENTITY(1,1) NOT NULL,
	[dtCriacao] [datetime] NULL,
	[rReceita] [varchar](50) NULL,
	[cValorReceita] [decimal](18, 0) NULL,
	[rDespesa] [varchar](50) NULL,
	[cValorDespesa] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[cConsulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tConta_Bancaria]    Script Date: 20/04/2020 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tConta_Bancaria](
	[cConta] [decimal](10, 0) IDENTITY(1,1) NOT NULL,
	[rBanco] [varchar](60) NULL,
	[cAgencia] [decimal](6, 0) NULL,
	[cCta] [decimal](11, 0) NULL,
	[cSaldo] [decimal](18, 2) NULL,
	[rLog] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[cConta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tDespesa]    Script Date: 20/04/2020 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tDespesa](
	[cDespesa] [decimal](10, 0) IDENTITY(1,1) NOT NULL,
	[rDescricao] [varchar](100) NULL,
	[cValor] [decimal](18, 2) NULL,
	[cConta] [decimal](10, 0) NULL,
	[cCategoria] [decimal](10, 0) NULL,
	[cPagamento] [decimal](10, 0) NULL,
	[dtRegistro] [date] NULL,
	[dtUltAtua] [date] NULL,
	[cStatus] [decimal](2, 0) NULL,
	[rLog] [varchar](max) NULL,
	[rQtdeParcela] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[cDespesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tForma_Pagamento]    Script Date: 20/04/2020 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tForma_Pagamento](
	[cFormaPagamento] [decimal](10, 0) IDENTITY(1,1) NOT NULL,
	[rPagamento] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[cFormaPagamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tReceita]    Script Date: 20/04/2020 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tReceita](
	[cReceita] [decimal](10, 0) IDENTITY(1,1) NOT NULL,
	[dtRec] [datetime] NULL,
	[rDescricao] [varchar](100) NULL,
	[cValor] [decimal](18, 2) NULL,
	[cConta] [decimal](10, 0) NULL,
	[cTipo] [decimal](10, 0) NULL,
	[rLog] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[cReceita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tTipo_Receita]    Script Date: 20/04/2020 23:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tTipo_Receita](
	[cTipoReceita] [decimal](10, 0) IDENTITY(1,1) NOT NULL,
	[rLog] [varchar](max) NULL,
	[cTipo] [decimal](2, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[cTipoReceita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tConsulta] ON 

INSERT [dbo].[tConsulta] ([cConsulta], [dtCriacao], [rReceita], [cValorReceita], [rDespesa], [cValorDespesa]) VALUES (CAST(1 AS Decimal(10, 0)), CAST(N'2020-03-03T00:00:00.000' AS DateTime), N'SALARIO', CAST(2000 AS Decimal(18, 0)), N'FATURA ALAN', CAST(379 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[tConsulta] OFF
ALTER TABLE [dbo].[tDespesa]  WITH CHECK ADD FOREIGN KEY([cCategoria])
REFERENCES [dbo].[tCategoria_Despesa] ([cCategoria])
GO
ALTER TABLE [dbo].[tDespesa]  WITH CHECK ADD FOREIGN KEY([cConta])
REFERENCES [dbo].[tConta_Bancaria] ([cConta])
GO
ALTER TABLE [dbo].[tDespesa]  WITH CHECK ADD FOREIGN KEY([cPagamento])
REFERENCES [dbo].[tForma_Pagamento] ([cFormaPagamento])
GO
ALTER TABLE [dbo].[tDespesa]  WITH CHECK ADD FOREIGN KEY([cCategoria])
REFERENCES [dbo].[tCategoria_Despesa] ([cCategoria])
GO
ALTER TABLE [dbo].[tDespesa]  WITH CHECK ADD FOREIGN KEY([cCategoria])
REFERENCES [dbo].[tCategoria_Despesa] ([cCategoria])
GO
ALTER TABLE [dbo].[tDespesa]  WITH CHECK ADD FOREIGN KEY([cConta])
REFERENCES [dbo].[tConta_Bancaria] ([cConta])
GO
ALTER TABLE [dbo].[tDespesa]  WITH CHECK ADD FOREIGN KEY([cConta])
REFERENCES [dbo].[tConta_Bancaria] ([cConta])
GO
ALTER TABLE [dbo].[tDespesa]  WITH CHECK ADD FOREIGN KEY([cPagamento])
REFERENCES [dbo].[tForma_Pagamento] ([cFormaPagamento])
GO
ALTER TABLE [dbo].[tDespesa]  WITH CHECK ADD FOREIGN KEY([cPagamento])
REFERENCES [dbo].[tForma_Pagamento] ([cFormaPagamento])
GO
ALTER TABLE [dbo].[tReceita]  WITH CHECK ADD FOREIGN KEY([cConta])
REFERENCES [dbo].[tConta_Bancaria] ([cConta])
GO
ALTER TABLE [dbo].[tReceita]  WITH CHECK ADD FOREIGN KEY([cTipo])
REFERENCES [dbo].[tTipo_Receita] ([cTipoReceita])
GO

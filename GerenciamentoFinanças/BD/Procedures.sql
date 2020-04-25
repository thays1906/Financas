USE [GerenciamentoFinancas]
GO
/****** Object:  StoredProcedure [dbo].[pCategoria_Despesa]    Script Date: 24/04/2020 23:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pCategoria_Despesa]
@Operacao varchar(4),
@cCategoria decimal(10,0)=null,
@rCategoria varchar(100)=null
AS 
BEGIN

	IF @Operacao = 'INSE'
	BEGIN
		INSERT INTO 
					tCategoria_Despesa
		VALUES
			(@rCategoria)

		Return @@IDentity
	END

	IF @Operacao = 'ALTE'
	BEGIN

		UPDATE
			tCategoria_Despesa
		SET
			rCategoria = @rCategoria
		WHERE 
			cCategoria = @cCategoria
	END

	IF @Operacao = 'DELE'
	BEGIN

		DELETE FROM
					tCategoria_Despesa
		WHERE
			cCategoria = @cCategoria

	END

	IF @Operacao = 'OBTE'
	BEGIN
		SELECT
		*
		FROM
			tCategoria_Despesa
	END

	IF @Operacao = 'GRID'
	BEGIN
		SELECT 
			rCategoria AS 'as_Categoria#250'
		FROM 
			tCategoria_Despesa
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pCobranca_Pagamento]    Script Date: 24/04/2020 23:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pCobranca_Pagamento]
@Operacao Varchar(4) = NULL,
@cCobrPag Decimal(10,0) = NULL,
@cTipo Decimal(2,0)= NULL,
@dtRegistro Date= NULL,
@cValor Decimal(18,2)= NULL,
@rTitular Varchar(100)= NULL,
@cStatus Decimal(2,0)= NULL
AS 
BEGIN

	IF @Operacao = 'INSE'
	BEGIN
		INSERT INTO	
					tCobranca_Pagamento
		VALUES(
		@cTipo,
		@dtRegistro,
		@cValor ,
		@rTitular ,
		@cStatus )

		return @@identity
	END

	IF @Operacao  = 'ALTE'
	BEGIN
		UPDATE 
			tCobranca_Pagamento
		SET
			cTipo   = @cTipo,
			dtRegistro  = @dtRegistro,
			cValor 	  = @cValor,
			rTitular  = @rTitular,
			cStatus   = @cStatus
			
		WHERE 
			cCobrPag = @cCobrPag
			
	END

	IF @Operacao = 'DELE'
	BEGIN
		DELETE FROM	
					tCobranca_Pagamento
		WHERE 
				cCobrPag = @cCobrPag
	END

	IF @Operacao = 'OBTE'
	BEGIN
		SELECT
			*
		  FROM
			tCobranca_Pagamento
		WHERE 
			cCobrPag = @cCobrPag
	END

	IF @Operacao ='GRID'
	BEGIN
		SELECT
			cTipo   AS 'as_Tipo#100',
		    dtRegistro AS 'as_Data',
			cValor 	AS 'as_Valor#150',
			rTitular  AS 'as_Nome',
			cStatus   AS 'as_Status#150'
		FROM
			tCobranca_Pagamento  
	END
			 
END
GO
/****** Object:  StoredProcedure [dbo].[pConsulta]    Script Date: 24/04/2020 23:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pConsulta]
@Operacao varchar(4),
@cConsulta Decimal(10,0) = null,
@dtCriacao datetime= null,
@rReceita varchar(50)= null,
@cValorReceita Decimal(18,0)= null,
@rDespesa varchar(50)= null,
@cValorDespesa Decimal(18,0)= null
AS
Begin
	IF @Operacao='GRID'
	BEGIN
		SELECT 
				dtCriacao as 'as_Data',
				rReceita as 'as_Receita#200',
				cValorReceita as 'as_Valor_Receita#200',
				rDespesa as 'as_Despesa#200',
				cValorDespesa as 'as_Valor_Despesa#150'
		FROM tConsulta
	END

	IF @Operacao='OBTE'
		BEGIN
			SELECT *
				

				
			FROM tConsulta
		
		END
END
GO
/****** Object:  StoredProcedure [dbo].[pConta_Bancaria]    Script Date: 24/04/2020 23:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pConta_Bancaria]
@Operacao Varchar (4),
@cConta Decimal(10,0) = NULL,
@rBanco Varchar(60) = NULL,
@cAgencia Decimal(6,0)= NULL,
@cCta Decimal(11,0)= NULL,
@cSaldo Decimal(18,2)= NULL,
@rLog Varchar(max) = NULL
AS
BEGIN

	IF @Operacao= 'INSE'
	BEGIN
		INSERT INTO 
				tConta_Bancaria 
		VALUES
				(@rBanco  ,
				 @cAgencia ,
				 @cCta ,
				 @cSaldo)

	
	END
	
	IF @Operacao = 'ALTE'
	BEGIN
		UPDATE 
			tConta_Bancaria
		SET
			rBanco =	 @rBanco  ,
			cAgencia =	 @cAgencia ,
			cCta = 		 @cCta ,
			cSaldo =	 @cSaldo

		WHERE 
			cConta =  @cConta
	END

	IF @Operacao = 'GRID'
	BEGIN
		SELECT 
			rBanco   As 'as_Banco#200' ,
			cAgencia As  'as_Agência#150',
			cCta	 As 'as_Conta#250',
			cSaldo	 As 'as_Saldo#150'
		FROM 
			tConta_Bancaria
	END

	IF @Operacao = 'OBTE'
	BEGIN

		SELECT 
		*
		FROM 
			tConta_Bancaria
		WHERE 
			cConta = @cConta
	END

	IF @Operacao = 'DELE'
	BEGIN
		DELETE FROM
				tConta_Bancaria
		WHERE
			cConta = @cConta
	END
	IF @Operacao = 'COMB'
	BEGIN

		SELECT 
				rBanco + ' - ' + 
				Convert(varchar,cAgencia) + ' - ' + 
				Convert(varchar,cCta)
				AS 'rBanco',

				cConta
		FROM 
			tConta_Bancaria
		
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pDespesa]    Script Date: 24/04/2020 23:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pDespesa]
@Operacao Varchar (4),
@cDespesa Decimal(10,0) = NULL,
@rDescricao Varchar(100) = NULL,
@cValor Decimal(18,2) = NULL,
@cConta Decimal(10,0) = NULL,
@cCategoria Decimal(10,0) = NULL,
@cPagamento Decimal(10,0) = NULL,
@dtRegistro Date = NULL,
@dtUltAtua Date = NULL,
@cStatus Decimal(2,0) = NULL,
@rLog Varchar(max) = NULL
AS
BEGIN

	IF @Operacao= 'INSE'
	BEGIN
		INSERT INTO 
				tDespesa
		VALUES
				(@rDescricao  ,
				 @cValor ,
				 @cConta ,
				 @cCategoria,
				 @cPagamento,
				 @dtRegistro,
				 null,
				 @cStatus,
				 @rLog)

		Return @@Identity
	END
	
	IF @Operacao = 'ALTE'
	BEGIN
		UPDATE 
			tDespesa
		SET
			rDescricao =     @rDescricao  ,
			cValor = 	     @cValor ,
			cConta = 	     @cConta ,
			cCategoria =	 @cCategoria,
			cPagamento = 	 @cPagamento,
			dtRegistro = 	 @dtRegistro,
			cStatus = 	     @cStatus,
			rLog =		 Concat(rLog, @rLog)

		WHERE 
			cDespesa =  @cDespesa
	END

	IF @Operacao = 'GRID'
	BEGIN
		SELECT 
			dtRegistro As 'as_Data',
			rDescricao   As 'as_Banco#200' ,
			cValor As  'as_Agência#150',
			cConta	 As 'as_Conta#250',
			cCategoria	 As 'as_Saldo#150', -- case
			cPagamento As 'as_Forma_de_Pagamento#300', --case
			cStatus As 'as_Status#200' -- case
		FROM 
			tDespesa
	END

	IF @Operacao = 'OBTE'
	BEGIN

		SELECT 
		*
		FROM 
			tDespesa
		WHERE 
			cDespesa = @cDespesa
	END

	IF @Operacao = 'DELE'
	BEGIN
		DELETE FROM
				tDespesa
		WHERE
			cDespesa = @cDespesa
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pForma_Pagamento]    Script Date: 24/04/2020 23:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pForma_Pagamento]
@Operacao varchar(4),
@cPagamento decimal(10,0)=null,
@rPagamento varchar(100)=null
AS 
BEGIN

	IF @Operacao = 'INSE'
	BEGIN
		INSERT INTO 
					tForma_Pagamento
		VALUES
			(@rPagamento)

		Return @@IDentity
	END

	IF @Operacao = 'ALTE'
	BEGIN

		UPDATE
			tForma_Pagamento
		SET
			rPagamento = @rPagamento
		WHERE 
			cFormaPagamento = @cPagamento
	END

	IF @Operacao = 'DELE'
	BEGIN

		DELETE FROM
					tForma_Pagamento
		WHERE
			cFormaPagamento = @cPagamento

	END

	IF @Operacao = 'OBTE'
	BEGIN
		SELECT
		*
		FROM
			tForma_Pagamento
	END

	IF @Operacao = 'GRID'
	BEGIN
		SELECT 
			rPagamento AS 'as_Categoria#250'
		FROM 
			tForma_Pagamento
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pReceita]    Script Date: 24/04/2020 23:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pReceita]
@Operacao Varchar (4),
@cReceita Decimal(10,0) = NULL,
@dtRec Date  = NULL,
@rDescricao Varchar(100) = NULL,
@cValor Decimal(18,2) = NULL,
@cConta Decimal(10,0) = NULL,
@cTipo Decimal(10,0) =  NULL,
@rLog Varchar(max) = NULL
AS
BEGIN

	IF @Operacao= 'INSE'
	BEGIN
		INSERT INTO 
				tReceita 
		VALUES
				(@dtRec  ,
				 @rDescricao ,
				 @cValor ,
				 @cConta ,
				 @cTipo,
				 @rLog)

		UPDATE
			tConta_Bancaria 
		SET
			cSaldo = Csaldo + @cValor

		WHERE 
			tConta_Bancaria.cConta= @cConta

	END
	
	IF @Operacao = 'ALTE'
	BEGIN
		UPDATE 
			tReceita
		SET
			rDescricao = @rDescricao ,
			cValor = 	 @cValor ,
			cConta = 	 @cConta ,
			cTipo  =	 @cTipo,
			rLog =		 Concat(rLog + ' - ', @rLog)

		WHERE cReceita =  @cReceita
	END

	IF @Operacao = 'GRID'
	BEGIN
		SELECT 
			rDescricao As 'as_Descrição#200' ,
			format(cValor,'C','pt-br') As  'as_Valor_#150',
			CT.rBanco +  ' - ' +
			CONVERT(VARCHAR, CT.cAgencia) + ' - ' +
			CONVERT(VARCHAR, CT.cCta) As 'as_Conta#250',
			TR.rTipo  As 'as_Tipo_de_Receita#200',
			r.cReceita As 'id_cReceita'

			
		FROM 
			tReceita R
			INNER JOIN tConta_Bancaria CT 
			ON R.cConta = CT.cConta 
			INNER JOIN tTipo_Receita TR
			ON R.cTipo = TR.cTipoReceita
	END

	IF @Operacao = 'OBTE'
	BEGIN

		SELECT 
			 r.cReceita,
			 r.dtRec,
			 r.cValor,
			 r.rDescricao,
			 r.cConta,
			 r.cTipo,
			 c.rBanco + 
			 Convert(varchar,c.cAgencia ) + 
			 Convert(varchar,c.cCta) as 'rBanco',
			 tr.rTipo,
			 tr.cTipoReceita
			  
		FROM 
			tReceita R,
			tTipo_Receita TR,
			tConta_Bancaria C
			
		WHERE 
			cReceita = @cReceita AND
			c.cConta = r.cConta AND
			r.cTipo = tr.cTipoReceita


	END

	IF @Operacao = 'DELE'
	BEGIN
		DELETE FROM
				tReceita
		WHERE
			cReceita = @cReceita
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pTipo_Receita]    Script Date: 24/04/2020 23:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pTipo_Receita]
@Operacao Varchar (4),
@cTipoReceita Decimal(10,0) =  NULL,
@rTipo Varchar(100) = NULL
AS
BEGIN

	IF @Operacao= 'INSE'
	BEGIN
		INSERT INTO 
			tTipo_Receita 
		VALUES
			(@rTipo)
	END

	IF @Operacao = 'OBTE'
	BEGIN
		SELECT 
			*
		From 
			tTipo_Receita
	END

	IF @Operacao = 'ALTE'
	BEGIN
		UPDATE 
			tTipo_Receita
		SET
			rTipo  = @rTipo

		WHERE cTipoReceita =  @cTipoReceita
	END

	IF @Operacao = 'DELE'
	BEGIN
		DELETE FROM
				tTipo_Receita
		where
			cTipoReceita = @cTipoReceita
	END

END
GO

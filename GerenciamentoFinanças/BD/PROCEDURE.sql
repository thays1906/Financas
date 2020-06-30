USE [GerenciamentoFinancas]
GO
/****** Object:  StoredProcedure [dbo].[pCategoria_Despesa]    Script Date: 30/06/2020 00:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pCategoria_Despesa]
@Operacao varchar(4),
@cCategoria decimal(10,0)=null,
@rCategoria varchar(100)=null,
@Status decimal (2,0)=null
AS 
BEGIN

	IF @Operacao = 'INSE'
	BEGIN
		INSERT INTO 
					tCategoria_Despesa
		VALUES
			(@rCategoria,1)

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

		UPDATE
				tCategoria_Despesa
		SET
				[STATUS] = 2
		WHERE
			cCategoria = @cCategoria

	END

	IF @Operacao = 'OBTE'
	BEGIN
		SELECT
		*
		FROM
			tCategoria_Despesa

		WHERE  cCategoria = @cCategoria
	END

	IF @Operacao = 'GRID'
	BEGIN
		SELECT 
				
			rCategoria AS 'as_Categoria#250',
			cCategoria as 'id_Categoria'
		FROM 
			tCategoria_Despesa

		WHERE 
			[STATUS] = 1
	END
	
	IF @Operacao = 'COMB'
	BEGIN
		SELECT
			rCategoria,
			cCategoria
		FROM
			tCategoria_Despesa

			where [status] = 1 
			
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pCobranca_Pagamento]    Script Date: 30/06/2020 00:23:31 ******/
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
/****** Object:  StoredProcedure [dbo].[pConsulta]    Script Date: 30/06/2020 00:23:31 ******/
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
@cValorDespesa Decimal(18,0)= null,
@cConta Decimal(10,0)=NULL,
@dtInicio Date =NULL,
@dtFim Date=NULL
AS
Begin
	IF @Operacao='GRID'
	BEGIN
		CREATE TABLE #tExtrato(
				   cValor Decimal(18,2),
				   DtReg  Date,
				   rBanco Varchar(100),
				   rDescricao Varchar(100))

			   INSERT #tExtrato 
--DESPESA
					SELECT 
						cValor * -1,dtRegistro,rBanco,
						CASE 
							WHEN CP.cControleParcelamento IS NULL THEN rDescricao
							ELSE rDescricao + ' (' + 
							CONVERT(VARCHAR,cNumeroParcela) + '/' +
							CONVERT(VARCHAR,CP.cQtdeParcela) + ')'
						END 

					 FROM 
						tDespesa

					INNER JOIN tConta_Bancaria Conta
					ON tDespesa.cConta = conta.cConta
					LEFT JOIN tControle_Parcelamento CP
					ON tDespesa.cControleParcelamento = CP.cControleParcelamento

					WHERE 
						(@cConta = 0 OR Conta.cConta=@cConta) AND
						(@dtInicio IS NULL OR 
						 dtRegistro BETWEEN @dtInicio AND @dtFim ) 

				INSERT #tExtrato 
--RECEITA
					SELECT
						cValor,dtRec,rBanco,rDescricao
					FROM
						tReceita

					INNER JOIN tConta_Bancaria Conta
					ON tReceita.cConta = Conta.cConta

					WHERE 
						(@cConta = 0  OR Conta.cConta=@cConta) AND
						(@dtInicio IS NULL OR 
						 dtRec BETWEEN @dtInicio AND @dtFim ) 

				SELECT 
					Convert(varchar,DtReg,103)  AS 'as_Data',
					FORMAT(cValor,'C','PT-BR') AS 'as_Valor',
					rDescricao AS 'as_Descrição',
					rBanco AS 'as_Banco'
				FROM
					#tExtrato
				ORDER BY
					DtReg

				DROP TABLE #tExtrato
	END

	IF @Operacao='OBTE'
		BEGIN
			SELECT *
				

				
			FROM tConsulta
		
		END
END
GO
/****** Object:  StoredProcedure [dbo].[pConta_Bancaria]    Script Date: 30/06/2020 00:23:31 ******/
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
@cTipo Decimal(1,0)=null,
@cPrincipal Decimal(1,0)=NULL,
@cStatus Decimal(1,0)=NULL
AS
BEGIN

	IF @Operacao= 'INSE'
	BEGIN
		
		IF ISNULL(@cPrincipal,2) = 2
		BEGIN
			SET @cPrincipal=2
		END
		ELSE
		BEGIN
			UPDATE tConta_Bancaria 
			SET cPrincipal = 2
			WHERE cPrincipal = 1
		END

		INSERT INTO 
				tConta_Bancaria 
		VALUES
				(@rBanco  ,
				 @cAgencia ,
				 @cCta ,
				 @cSaldo,
				 @cTipo,
				 @cPrincipal,
				 @cStatus)
		
	
	END
	
	IF @Operacao = 'ALTE'
	BEGIN

		UPDATE 
			tConta_Bancaria
		SET
			rBanco =	 @rBanco  ,
			cAgencia =	 @cAgencia ,
			cCta = 		 @cCta ,
			cSaldo =	 @cSaldo,
			cTipo  =	 @cTipo,
			cPrincipal = @cPrincipal
		
		WHERE 
			cConta =  @cConta

		IF @cPrincipal = 1
		BEGIN
			UPDATE
				tConta_Bancaria
			SET
				cPrincipal = 2
			WHERE 
				cConta != @cConta
		END
	END

	IF @Operacao = 'GRID'
	BEGIN

		SELECT 

			CASE
				WHEN cPrincipal = 1  THEN 'SIM'
				WHEN cPrincipal = 2  THEN 'NÃO'
				ELSE ''
			END AS 'AS_PRINCIPAL',

			rBanco   As 'as_BANCO#200' ,

			CASE

				WHEN cAgencia = 0 THEN ''
				ELSE CONVERT(VARCHAR,cAgencia )

			END AS 'as_AGÊNCIA#150',

			CASE	

				WHEN cCta = 0 THEN ''
				ELSE CONVERT(VARCHAR,cCta)

			END AS 'as_CONTA#250',

			FORMAT(cSaldo,'c','pt-br')	 As 'as_SALDO#150',

			CASE
				WHEN cTipo = 1 THEN 'Corrente'
				WHEN cTipo = 2 THEN 'Poupança'
				WHEN cTipo = 3 THEN 'Carteira Digital'
				ELSE ''
			END AS 'as_TIPO_DE_CONTA',

			cConta as 'id_cConta'

		FROM 
			tConta_Bancaria
		
		WHERE
			cStatus = 1
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
		UPDATE 
				tConta_Bancaria
		SET
				cStatus = 2
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

				cPrincipal,

				cConta
		FROM 
			tConta_Bancaria
		 
		 WHERE
			cStatus = 1
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pControle_Parcelamento]    Script Date: 30/06/2020 00:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pControle_Parcelamento]
@Operacao varchar(4),
@cControleParcelamento Decimal(10,0)=null,
@cQtdeParcela Decimal(2,0)=null
AS
BEGIN
	IF @Operacao = 'INSE'
	BEGIN
		INSERT 
			tControle_Parcelamento
		Values (@cQtdeParcela)

		SELECT @@identity as cControleParcelamento
		RETURN  
	END

	IF @Operacao = 'ALTE'
	BEGIN
		UPDATE
			tControle_Parcelamento
		SET
			cQtdeParcela = @cQtdeParcela

		WHERE
			cControleParcelamento = @cControleParcelamento
	END

	IF @Operacao = 'DELE'
	BEGIN

		DELETE FROM
			tControle_Parcelamento

		WHERE
			cControleParcelamento = @cControleParcelamento
	END

	IF @Operacao ='OBTE'
	BEGIN
		SELECT
			*
		FROM
			tControle_Parcelamento
		WHERE cControleParcelamento = @cControleParcelamento
	END

	IF @Operacao ='OBTT'
	BEGIN

		SELECT 
			*
		FROM
			tControle_Parcelamento CP
			INNER JOIN tDespesa D
			ON CP.cControleParcelamento = D.cControleParcelamento

		WHERE
			CP.cControleParcelamento = @cControleParcelamento

			SELECT 
				SUM(cValor) AS 'TOTAL' ,

				(SELECT  
					SUM(cValor) AS 'PAGO' 
				FROM 
					tControle_Parcelamento CP
					INNER JOIN tDespesa D
					ON CP.cControleParcelamento = D.cControleParcelamento 
			
				WHERE
					cStatus=1 AND 
					CP.cControleParcelamento = @cControleParcelamento) PAGO ,-- CSTATUS = 1 )

				(SELECT 
					SUM(cValor) AS 'NPAGO'
				FROM 
					tControle_Parcelamento CP
					INNER JOIN tDespesa D
					ON CP.cControleParcelamento = D.cControleParcelamento 

				WHERE 
					cStatus=2 AND 
					CP.cControleParcelamento = @cControleParcelamento) NPAGO 
			
			FROM
				tControle_Parcelamento CP
				INNER JOIN tDespesa D
				ON CP.cControleParcelamento = D.cControleParcelamento

			WHERE
				CP.cControleParcelamento = @cControleParcelamento
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pDespesa]    Script Date: 30/06/2020 00:23:31 ******/
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
@cControleParcelamento decimal(10,0)=NULL,
@cNumeroParcela Decimal(2,0)=NULL,
@rLog Varchar(max) = NULL,
@dtMes decimal(2,0)=NULL,
@dtYear decimal(4,0)=NULL,
@cDespesaFixa Decimal(10,0)=NULL
AS
BEGIN

	IF @Operacao= 'INSE'
	BEGIN
		INSERT INTO 
				tDespesa 
		VALUES
				(@cControleParcelamento,
				 @cDespesaFixa,
				 @dtRegistro,
				 @rDescricao  ,
				 @cValor ,
				 @cConta ,
				 @cCategoria,
				 @cPagamento,
				 @cStatus,
				 @cNumeroParcela,
				 null,
				 @rLog)
		
		IF @cStatus=1
		BEGIN
			UPDATE 
				tConta_Bancaria 
			SET
				cSaldo = cSaldo - @cValor
			WHERE  
				tConta_Bancaria.cConta = @cConta  
		END

		--Return @@Identity

		
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
			dtUltAtua =      GETDATE(),
			cStatus = 	     @cStatus,
			rLog =		     Concat(rLog, @rLog)

		WHERE 
			cDespesa =  @cDespesa

		IF @cStatus=1
		BEGIN
			UPDATE 
				tConta_Bancaria 
			SET
				cSaldo = cSaldo - @cValor
			WHERE  
				tConta_Bancaria.cConta = @cConta  
		END
	END

	IF @Operacao = 'GRID'
	BEGIN
	
		SELECT 

			CONVERT(VARCHAR,dtRegistro,103) As 'as_Data#150',

			CASE  
				WHEN DESP.cStatus=1 THEN 'PAGO' 
				WHEN DESP.cStatus=2 THEN 'PENDENTE'
				ELSE 'ATRASADO'
			END  As 'as_Status#100' ,-- case

			rDescricao   As 'as_Descrição#350' ,
			format(cValor,'C','pt-br') As  'as_Valor#150',

			CASE
				WHEN Desp.cDespesaFixa = 0 THEN 'NÃO'
				ELSE 'SIM'
			END AS 'AS_Despesa_Fixa',

			CASE	
				WHEN DESP.cControleParcelamento  = 0   THEN 'NÃO'
				ELSE 'SIM'
			END AS 'as_Parcelado#100',

			CONVERT(VARCHAR,cNumeroParcela) +
			'/'  + CONVERT(VARCHAR,CP.cQtdeParcela) As 'as_Parcela',

			CD.rCategoria	 As 'as_Categoria#150', -- case
			fp.rPagamento As 'as_Forma_de_Pagamento#200', --case
			cDespesa as 'id_cDespesa',
			Conta.rBanco	 As 'as_Conta#150'
			
		FROM 
			tDespesa Desp 
			INNER JOIN tConta_Bancaria Conta
			ON Desp.cConta = CONTA.cConta
			INNER JOIN tCategoria_Despesa CD
			ON Desp.cCategoria = CD.cCategoria
			INNER JOIN tForma_Pagamento FP
			ON Desp.cPagamento = FP.cFormaPagamento
			LEFT JOIN tControle_Parcelamento CP
			ON DESP.cControleParcelamento = CP.cControleParcelamento
			
		--FILTRO
		
		WHERE
			(@cStatus IS NULL OR desp.cStatus=@cStatus) AND 
			(@dtMes IS NULL OR MONTH(dtRegistro) = @dtMes ) AND
			(@dtYear IS NULL OR YEAR(dtRegistro) = @dtYear)



		--Soma total das despesas pesquisadas.
		SELECT SUM(CVALOR) AS 'TOTAL'

		FROM tDespesa D
		WHERE
				(@cStatus IS NULL OR D.cStatus=@cStatus) AND 
				(@dtMes IS NULL OR MONTH(dtRegistro) = @dtMes) AND
				(@dtYear IS NULL OR YEAR(dtRegistro) = @dtYear)
	END
	
	IF @Operacao = 'OBTE'
	BEGIN

		SELECT 
				rDescricao,
				cValor,
				desp.cConta,
				desp.cCategoria,
				desp.cPagamento,
				Desp.cStatus,
				dtRegistro,
				Desp.cControleParcelamento,
				Desp.cNumeroParcela,
				CP.cQtdeParcela,
				desp.cDespesaFixa

		FROM 
			tDespesa Desp
			LEFT JOIN tControle_Parcelamento CP
			ON Desp.cControleParcelamento = CP.cControleParcelamento
			INNER JOIN tConta_Bancaria Conta
			ON Desp.cConta = Conta.cConta
			INNER JOIN tCategoria_Despesa CatDes
			ON Desp.cCategoria = CatDes.cCategoria
			INNER JOIN tForma_Pagamento FormPag
			ON Desp.cPagamento = FormPag.cFormaPagamento
			
		WHERE 
			Desp.cDespesa = @cDespesa 
	END

	IF @Operacao = 'DELE'
	BEGIN
		DELETE FROM
				tDespesa
		WHERE
			cDespesa = @cDespesa

		RETURN
	END

	IF @Operacao = 'PAGO'
	BEGIN
		UPDATE 
			tDespesa
		SET
			cStatus = 1

		WHERE cDespesa = @cDespesa

		UPDATE 
			tConta_Bancaria 
		SET
			cSaldo = cSaldo - @cValor
		WHERE  
			tConta_Bancaria.cConta = @cConta 
		
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pDespesa_Fixa]    Script Date: 30/06/2020 00:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pDespesa_Fixa]
@Operacao Varchar(4),
@cDespesaFixa Decimal(10,0)=NULL,
@cPeriodo Decimal(4,0)=NULL,
@rDescricao Varchar(100) = NULL,
@cValor Decimal(18,2) = NULL,
@cConta Decimal(10,0) = NULL,
@cCategoria Decimal(10,0) = NULL,
@cPagamento Decimal(10,0) = NULL,
@dtRegistro Date = NULL
AS
BEGIN
	IF @Operacao='INSE'
	BEGIN
		INSERT 
			tDespesa_Fixa
		VALUES
			(@dtRegistro,
			 @cPeriodo,
			 @rDescricao ,
			 @cValor,
			 @cConta ,
			 @cCategoria ,
			 @cPagamento)

		SELECT @@IDENTITY AS cDespesaFixa
		RETURN
	END
	------------------------------
	--3 CASOS : [ALTERAR 1 REGISTRO] [ALTERAR DTREGISTRO ATUAL EM DIA] [ALTERAR TODOS]
	--------------------------------
	IF @Operacao='ALTE'
	BEGIN
		UPDATE
			tDespesa_Fixa
		SET
			dtRegistro	 = @dtRegistro,
			cPeriodo	 = @cPeriodo,
			rDescricao   = @rDescricao ,
			cValor		 = @cValor,
			cCategoria   = @cConta ,
			cPagamento	 = @cCategoria ,
			cConta	     = @cPagamento 

		WHERE
			cDespesaFixa = @cDespesaFixa 
	END

	------------------------------
	--3 CASOS : [DELETAR 1 REGISTRO] [DELETAR DTREGISTRO ATUAL EM DIA] [DELETAR TODOS]
	--------------------------------
	IF @Operacao = 'DELE'
	BEGIN
		DELETE FROM 
			tDespesa
		WHERE 
			cDespesaFixa = @cDespesaFixa
	
		DELETE FROM
				tDespesa_Fixa
		WHERE 
			cDespesaFixa = @cDespesaFixa
	END

	IF @Operacao = 'OBTE'
	BEGIN
		SELECT
			*
		FROM
			tDespesa_Fixa
		WHERE 
			cDespesaFixa=@cDespesaFixa
	END

	IF @Operacao = 'GRID'
	BEGIN
		SELECT
			
			CASE 
				WHEN cPeriodo = 1   THEN 'Diariamente'
				WHEN cPeriodo = 7   THEN 'Semanalmente'
				WHEN cPeriodo = 15  THEN 'Quinzenal'
				WHEN cPeriodo = 30  THEN 'Mensalmente'
				WHEN cPeriodo = 60  THEN 'A cada 2 meses'
				WHEN cPeriodo = 90  THEN 'A cada 3 meses'
				WHEN cPeriodo = 182 THEN 'A cada 6 meses'
				WHEN cPeriodo = 365 THEN '1 vez por ano'
				ELSE 'Não repete'
			END  AS 'AS_Repete_',

			rDescricao AS 'AS_Descrição',

			FORMAT(cValor,'C','pt-br') AS 'AS_Valor_da_Despesa',

			CD.rCategoria AS 'AS_Categoria_da_Despesa',
			F.rPagamento AS 'AS_Forma_de_Pagamento',

			C.rBanco + ' - ' +
			CONVERT(varchar,C.cAgencia) +' - ' +
			CONVERT(varchar,C.cCta) 
			AS 'AS_Conta_Báncaria',

			cDespesaFixa as 'id_cDespesaFixa'

		FROM
			tDespesa_Fixa DF
			INNER JOIN tConta_Bancaria C
			ON DF.cConta = C.cConta
			INNER JOIN tCategoria_Despesa CD
			ON DF.cCategoria = CD.cCategoria
			INNER JOIN tForma_Pagamento F
			ON DF.cPagamento = F.cFormaPagamento

		GROUP BY
			cDespesaFixa,
			cPeriodo,
			rDescricao,
			cValor,
			CD.rCategoria,
			F.rPagamento,
			C.cCta,
			C.cAgencia,
			C.rBanco
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pFixa]    Script Date: 30/06/2020 00:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--select * from tDespesa

--select * from tDespesa_Fixa
/*
update tDespesa_Fixa 
set rDescricao = 'Compras',
    cConta = 1 , 
	cCategoria = 4, 
	cPagamento = 2
WHERE cDespesaFixa = 1
*/
--exec pFixa 5,2020
CREATE PROCEDURE [dbo].[pFixa]
(
@MES INT ,
@ANO INT 
)

AS
BEGIN




SET @MES = 5 
SET @ANO = 2020 

CREATE TABLE #TEMP 
(
cDespesaFixa DECIMAL (10,0),
cPeriodo DECIMAL(4,0),
rDescricao VARCHAR(300),
cValor DECIMAL(18,2),
cConta DECIMAL(10,0),
cPagamento DECIMAL(10,0),
cCategoria DECIMAL(10,0)
)

INSERT 
	#TEMP
		SELECT
			cDespesaFixa, cPeriodo,rDescricao,cValor,cConta,cPagamento,cCategoria 
		FROM 
			tDespesa_Fixa 
		ORDER BY 
			cPeriodo ASC

WHILE EXISTS(SELECT * FROM #TEMP)
BEGIN
	DECLARE @cDespesaFixaLocal DECIMAL(10,0) 
	DECLARE @cPeriodo DECIMAL(4,0) 
	DECLARE @rDescricaoFixa VARCHAR(300)
	DECLARE @cValorFixa VARCHAR(300)
	DECLARE @cContaFixa DECIMAL(10,0)
	DECLARE @cPagamentoFixa DECIMAL(10,0)
	DECLARE @cCategoriaFixa DECIMAL(10,0)

	SELECT  TOP 1 @cDespesaFixaLocal = cDespesaFixa,
	              @cPeriodo = cPeriodo ,
				  @rDescricaoFixa = rDescricao,
				  @cValorFixa = cValor,
				  @cContaFixa  = cConta,
				  @cPagamentoFixa  = cPagamento,
				  @cCategoriaFixa  = cCategoria
			FROM 
				#TEMP 
			ORDER BY 
				cDespesaFixa 


	DECLARE @DATAINICIO DATE 
	DECLARE @DATAFIM DATE 
	DECLARE @DATAPASSADA DATE 

	SET @DATAPASSADA = CONVERT(DATETIME,'01/' + CONVERT(VARCHAR,@MES) + '/'+ CONVERT(VARCHAR,@ANO))

	SET @DATAINICIO =  DATEADD(dd,-(DAY(@DATAPASSADA)-1),@DATAPASSADA)

	DECLARE @DIASEMANA INT =  Datepart(weekday, @DATAINICIO)

	IF @DIASEMANA = 1 OR @DIASEMANA = 7 
	BEGIN
	 WHILE @DIASEMANA = 1 OR @DIASEMANA = 7
	-- FIM DE SEMANA PEGAR PROXIMO DIA 
		SET @DATAINICIO = DATEADD(DAY,1,@DATAINICIO)
		SET @DIASEMANA  =  Datepart(weekday, @DATAINICIO)
	END

	----------------------------
	--DESPESA FIXA: DAIRIAMENTE
	----------------------------
	IF @cPeriodo = 1 
	BEGIN
		
		--VERIFICANDO SE JA EXISTE O REGISTRO CRIADO

			IF NOT EXISTS(SELECT * FROM tDespesa 
						  WHERE CONVERT(VARCHAR,dtregistro,103) = CONVERT(VARCHAR,GETDATE(),103) AND 
						  cDespesaFixa = @cDespesaFixaLocal)

		-- SE NÃO EXISTE FAZ INSERT DO REGISTRO
			BEGIN
				PRINT 'INSERINDO 1 REGISTRO DIARIO'
				PRINT @DATAINICIO

				DECLARE @NOVADATA DATETIME = GETDATE()

				EXEC 
					pDESPESA @OPERACAO = 'INSE',
					   @rDescricao = @rDescricaoFixa, 
					   @cValor = @cValorFixa,
					   @cConta = @cContaFixa , 
					   @cCategoria = @cCategoriaFixa,
					   @Dtregistro =  @NOVADATA,
					   @cStatus = 2,@rlog = ' DESPESA FIXA: DIARIA ' ,
					   @cPagamento =@cPagamentoFixa,
					   @cControleParcelamento = 0, 
					   @cDespesaFixa = @cDespesaFixaLocal, 
					   @cNumeroParcela = 0
			END
	END
	------------------------------------
	--DESPESA FIXA: SEMANAL OU QUINZENAL
	------------------------------------
	IF @cPeriodo = 7 or @cPeriodo = 15
	BEGIN
			DECLARE @MULTIPLICADOR INT 

			--VERIFICAR NOS PRIMEIROS 7 DIAS 
			IF @cPeriodo = 7
				SET @MULTIPLICADOR = 4 
			ELSE 
				SET @MULTIPLICADOR = 2

				DECLARE @I INT = 0

				WHILE @i  < @MULTIPLICADOR

				BEGIN
					PRINT @DATAINICIO
					
					IF @DATAINICIO < GETDATE() AND NOT EXISTS
							 (SELECT 
									* 
						  	  FROM 
									tDespesa 
							  WHERE 
									dtregistro BETWEEN @DATAINICIO AND
									DATEADD(DAY,@cPeriodo,@DATAINICIO) AND 
									cDespesaFixa = @cDespesaFixaLocal)
					BEGIN
							
							EXEC pDESPESA @OPERACAO = 'INSE',
										  @rDescricao = @rDescricaoFixa, 
										  @cValor = @cValorFixa,
										  @cConta = @cContaFixa , 
										  @cCategoria = @cCategoriaFixa,
										  @Dtregistro =  @DATAINICIO,
										  @cStatus = 2,
										  @rlog =  ' DESPESA FIXA: SEM/QUINZ ' , 
										  @cPagamento =@cPagamentoFixa,
										  @cControleParcelamento = 0, 
										  @cDespesaFixa = @cDespesaFixaLocal, 
										  @cNumeroParcela = 0
					END

					SET @i = @i + 1

					SET @DATAINICIO = DATEADD(DAY,7,@DATAINICIO)
				END
	END
	---------------------------
	--DESPESA FIXA: MENSAL
	---------------------------
	IF @cPeriodo = 30
	BEGIN
			IF @DATAINICIO < GETDATE() AND NOT EXISTS
							(SELECT 
									* 
							FROM 
								tDespesa 
							WHERE
								MONTH(dtregistro) = @MES AND
								YEAR(dtRegistro) = @ANO AND 
								cDespesaFixa = @cDespesaFixaLocal)
					BEGIN
							EXEC pDESPESA @OPERACAO = 'INSE',
										  @rDescricao = @rDescricaoFixa, 
										  @cValor = @cValorFixa,
										  @cConta = @cContaFixa , 
										  @cCategoria = @cCategoriaFixa,
										  @Dtregistro =  @DATAINICIO,
										  @cStatus = 2,
										  @rlog =  ' DESPESA FIXA: MENSAL ' , 
										  @cPagamento =@cPagamentoFixa,
										  @cControleParcelamento = 0, 
										  @cDespesaFixa = @cDespesaFixaLocal, 
										  @cNumeroParcela = 0
					END
	END

	DELETE
		#TEMP 
	WHERE 
		cDespesaFixa = @cDespesaFixaLocal
END

	DROP TABLE
			#TEMP
END
GO
/****** Object:  StoredProcedure [dbo].[pForma_Pagamento]    Script Date: 30/06/2020 00:23:31 ******/
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
			(@rPagamento,1)

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

		UPDATE
				tForma_Pagamento
		SET
				[STATUS]=2
		WHERE
			cFormaPagamento = @cPagamento

	END

	IF @Operacao = 'OBTE'
	BEGIN
		SELECT
		*
		FROM
			tForma_Pagamento

		where cFormaPagamento = @cPagamento
	END

	IF @Operacao = 'GRID'
	BEGIN
		SELECT 
			rPagamento AS 'as_Formas_de_Pagamento#250',
			cFormaPagamento AS 'id_Pagamento'

		FROM 
			tForma_Pagamento

			WHERE [STATUS]=1
	END

	IF @Operacao = 'COMB'

	BEGIN

		SELECT
			rPagamento,
			cFormaPagamento
		FROM	
			tForma_Pagamento

		WHERE
			[Status] = 1 
	END


END
GO
/****** Object:  StoredProcedure [dbo].[pLancamento_Futuro]    Script Date: 30/06/2020 00:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pLancamento_Futuro]
(
	@DATA DATETIME ,
	@DATAFIM DATETIME,
	@cDespesaFixa DECIMAL 
)
AS
BEGIN
	DECLARE @cDespesaFixaLocal DECIMAL(10,0) 
	DECLARE @cPeriodo DECIMAL(4,0) 
	DECLARE @rDescricaoFixa VARCHAR(300)
	DECLARE @cValorFixa VARCHAR(300)
	DECLARE @cContaFixa DECIMAL(10,0)
	DECLARE @cPagamentoFixa DECIMAL(10,0)
	DECLARE @cCategoriaFixa DECIMAL(10,0)
	DECLARE @dtRegistroFixa DATETIME

	SELECT
		@cDespesaFixaLocal = cDespesaFixa, 
		@DATA = dtRegistro,
		@cPeriodo = cPeriodo,
		@rDescricaoFixa = rDescricao,
		@cValorFixa = cValor,
		@cContaFixa = cConta,
		@cPagamentoFixa = cPagamento,
		@cCategoriaFixa = cCategoria 
	FROM 
		tDespesa_Fixa 
	WHERE 
		cDespesaFixa = @cDespesaFixa


	WHILE @DATA < @DATAFIM
	BEGIN

	DECLARE @Log VARCHAR(100) 

	SET @Log = ' DESPESA FIXA: ' + CONVERT(VARCHAR,@cPeriodo) 

	EXEC pDESPESA @OPERACAO = 'INSE',
				  @rDescricao = @rDescricaoFixa, 
				  @cValor = @cValorFixa,
				  @cConta = @cContaFixa , 
				  @cCategoria = @cCategoriaFixa,
				  @Dtregistro =  @DATA,
				  @cStatus = 2,
				  @rlog = @Log,
				  @cPagamento =@cPagamentoFixa,
				  @cControleParcelamento = 0, 
				  @cDespesaFixa = @cDespesaFixaLocal, 
				  @cNumeroParcela = 0
		
		IF @cPeriodo IN (6,12) 
			SET @DATA = DATEADD(MONTH,@cPeriodo,@DATA)
		ELSE
			SET @DATA = DATEADD(DAY,@cPeriodo,@DATA)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pParcelamento]    Script Date: 30/06/2020 00:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pParcelamento]
@Operacao varchar(4),
@cParcelamento decimal(10,0)=null,
@cQtdeParcela decimal(2,0)=null,
@cStatus decimal(1,0)=null
AS
BEGIN
	IF @Operacao = 'INSE'
	BEGIN 
		INSERT
			tParcelamento 
		VALUES
			(@cQtdeParcela,2)

		RETURN @@iDENTITY
	END
	
	IF @Operacao = 'ALTE'
	BEGIN
		UPDATE 
			tParcelamento
		SET
			cStatus = @cStatus
		WHERE
			cParcelamento = @cParcelamento

			IF @cStatus = 1
				UPDATE 
					tParcelamento
				SET 
					cStatus =  2
				WHERE
					cParcelamento != @cParcelamento

			ELSE IF @cStatus = 2
					
				UPDATE 
					tParcelamento
				SET
					cStatus = 1
				WHERE
					cParcelamento != @cParcelamento

	END

	IF @Operacao = 'GRID'
		BEGIN
			SELECT 
			    
				CASE 
					WHEN cstatus = 1 THEN 'marca' ELSE '' END as chk,
				Convert(Varchar,cQtdeParcela) + 'x' as 'as_Nº_de_Parcelas#300',
				cStatus,
				cParcelamento as 'id_cParcelamento'
			FROM
				tParcelamento

		END
	IF @Operacao = 'COMB'
	BEGIN
		SELECT 
			*
		FROM
			tParcelamento
		WHERE cStatus = 1
	END
	
	IF @Operacao = 'DELE'
		BEGIN
			DELETE FROM	
					tParcelamento
			WHERE cParcelamento = @cParcelamento
		END

END
GO
/****** Object:  StoredProcedure [dbo].[pReceita]    Script Date: 30/06/2020 00:23:31 ******/
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
@rLog Varchar(max) = NULL,
@dtMes as Decimal(2,0)=NULL
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
			CONVERT(VARCHAR,dtRec,103) as 'as_Data',
			rDescricao As 'as_Descrição#300' ,
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
		
		WHERE
			(@dtMes IS NULL OR MONTH(dtRec)=@dtMes)

			SELECT SUM(cValor) AS 'total' FROM tReceita
		
		WHERE
			(@dtMes IS NULL OR MONTH(dtRec)=@dtMes)

			
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
/****** Object:  StoredProcedure [dbo].[pTipo_Receita]    Script Date: 30/06/2020 00:23:31 ******/
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

		WHERE cTipoReceita = @cTipoReceita
	END

	IF @Operacao = 'COMB'
		BEGIN
			SELECT
				*
			FROM
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

	IF @Operacao =  'GRID'
		BEGIN
			SELECT 
				 rTipo AS 'as_Tipo_de_Receita#250',
				 cTipoReceita as 'id_'
			FROM
				tTipo_Receita

		END
END
GO

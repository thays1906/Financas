USE [GerenciamentoFinancas]
GO

/****** Object:  StoredProcedure [dbo].[pDespesa]    Script Date: 01/07/2020 00:29:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[pDespesa]
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

		ORDER BY 
				dtRegistro

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


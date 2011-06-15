USE [TIPDATA]
GO
/****** Object:  StoredProcedure [dbo].[sp_FillTblOzet]    Script Date: 01/31/2011 12:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_FillTblOzetAYPAnaIslem] 
	@TarihCode1 varchar(10),
	@TarihCode2 varchar(10),
	@TarihCode3 varchar(10)
as

begin

truncate table rtblOzetAYPAnaIslem

insert rtblOzetAYPAnaIslem

SELECT 
	tlkpAYP.strUzun AS AYP, 
	tlkpAnaIslemTipi.strName AS AnaIslem, 
	
	ISNULL([qselOzetAYPAnaIslemC].[SumOfAdet],0) AS AdetC, 
	ISNULL([qselOzetAYPAnaIslemP].[SumOfADET],0) AS AdetP, 
	ISNULL([qselOzetAYPAnaIslemP1].[SumOfADET],0) AS AdetP1, 
	dbo.udf_ComputeDiff([qselOzetAYPAnaIslemC].[SumOfAdet],[qselOzetAYPAnaIslemP].[SumOfADET]) AS AdetY, 
	
	ISNULL([qselOzetAYPAnaIslemC].[CountOfHasta],0) AS HastaC, 
	ISNULL([qselOzetAYPAnaIslemP].[CountOfHasta],0) AS HastaP, 
	ISNULL([qselOzetAYPAnaIslemP1].[CountOfHasta],0) AS HastaP1, 
	dbo.udf_ComputeDiff([qselOzetAYPAnaIslemC].[CountOfHasta],[qselOzetAYPAnaIslemP].[CountOfHasta]) AS HastaY, 
	
	ISNULL([qselOzetAYPAnaIslemC].[SumOfToplam],0) AS ToplamC, 
	ISNULL([qselOzetAYPAnaIslemP].[SumOfToplam],0) AS ToplamP, 
	ISNULL([qselOzetAYPAnaIslemP1].[SumOfToplam],0) AS ToplamP1, 
	dbo.udf_ComputeDiff([qselOzetAYPAnaIslemC].[SumOfToplam],[qselOzetAYPAnaIslemP].[SumOfToplam]) AS ToplamY, 
	
	ISNULL([qselOzetAYPAnaIslemC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qselOzetAYPAnaIslemC].[CountOfHasta]) AS KisiBasiC, 
	ISNULL([qselOzetAYPAnaIslemP].[SumOfToplam],0) / dbo.udf_ZeroConvert([qselOzetAYPAnaIslemP].[CountOfHasta]) AS KisiBasiP, 
	ISNULL([qselOzetAYPAnaIslemP1].[SumOfToplam],0) / dbo.udf_ZeroConvert([qselOzetAYPAnaIslemP1].[CountOfHasta]) AS KisiBasiP1, 
	dbo.udf_ComputeDiff( ISNULL([qselOzetAYPAnaIslemC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qselOzetAYPAnaIslemC].[CountOfHasta]),
		ISNULL([qselOzetAYPAnaIslemP].[SumOfToplam],0) / dbo.udf_ZeroConvert([qselOzetAYPAnaIslemP].[CountOfHasta])) AS KisiBasiY, 
	
	[qselOzetAYPAnaIslemC].[SumOfToplam] / dbo.udf_ZeroConvert([qselOzetAYPAnaIslemC].[SumOfAdet]) AS IslemBasiC, 
	[qselOzetAYPAnaIslemP].[SumOfToplam] / dbo.udf_ZeroConvert([qselOzetAYPAnaIslemP].[SumOfAdet]) AS IslemBasiP, 
	[qselOzetAYPAnaIslemP1].[SumOfToplam] / dbo.udf_ZeroConvert([qselOzetAYPAnaIslemP1].[SumOfAdet]) AS IslemBasiP1, 
	dbo.udf_ComputeDiff(ISNULL([qselOzetAYPAnaIslemC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qselOzetAYPAnaIslemC].[SumOfAdet]),
		ISNULL([qselOzetAYPAnaIslemP].[SumOfToplam],0) / dbo.udf_ZeroConvert([qselOzetAYPAnaIslemP].[SumOfAdet])) AS IslemBasiY
	
FROM tlkpAYP INNER JOIN 
	((((
		(SELECT tlkpAYP.strKisa, tlkpAnaIslemTipi.ID
		FROM tlkpAnaIslemTipi, tlkpAYP) as qselAYPAnaIslemTipi
	LEFT JOIN 
		udf_GetAYPAnaIslem(@TarihCode1) as qselOzetAYPAnaIslemC ON qSelAYPAnaIslemTipi.strKisa = qselOzetAYPAnaIslemC.AYP AND qSelAYPAnaIslemTipi.ID = qselOzetAYPAnaIslemC.Islem)
	LEFT JOIN 
		udf_GetAYPAnaIslem(@TarihCode2) as qselOzetAYPAnaIslemP ON qSelAYPAnaIslemTipi.strKisa = qselOzetAYPAnaIslemP.AYP AND qSelAYPAnaIslemTipi.ID = qselOzetAYPAnaIslemP.Islem) 
	LEFT JOIN 
		udf_GetAYPAnaIslem(@TarihCode3) as qselOzetAYPAnaIslemP1 ON qSelAYPAnaIslemTipi.strKisa = qselOzetAYPAnaIslemP1.AYP AND qSelAYPAnaIslemTipi.ID = qselOzetAYPAnaIslemP1.Islem) 
		
	INNER JOIN 
		tlkpAnaIslemTipi ON qSelAYPAnaIslemTipi.ID = tlkpAnaIslemTipi.ID) 
		
	ON tlkpAYP.strKisa = qSelAYPAnaIslemTipi.strKisa

	
end


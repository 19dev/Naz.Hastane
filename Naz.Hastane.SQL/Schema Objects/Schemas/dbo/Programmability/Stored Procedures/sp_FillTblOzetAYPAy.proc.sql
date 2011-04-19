
CREATE proc [dbo].[sp_FillTblOzetAYPAy] 
	@TarihCode1 varchar(10)
	
as

begin

drop table rtblOzetAYPAy

SELECT 
	ROW_NUMBER() OVER(ORDER BY tlkpAYP.strUzun ASC) AS 'RowNumber',
	tlkpAYP.strUzun AS Key1, 
	AY AS Key2,
	
	ISNULL([qC].[SumOfAdet],0) AS AdetC, 
	
	ISNULL([qC].[CountOfHasta],0) AS HastaC, 
	
	ISNULL([qC].[SumOfToplam],0) AS ToplamC, 
	
	ISNULL([qC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qC].[CountOfHasta]) AS KisiBasiC, 
	
	ISNULL([qC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qC].[SumOfAdet]) AS IslemBasiC
	
	into rtblOzetAYPAy
	
FROM tlkpAYP LEFT JOIN 
		udf_GetAYPAy(@TarihCode1) as qC ON tlkpAYP.strKisa = qC.AYP
	
end



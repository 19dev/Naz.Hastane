

CREATE proc [dbo].[sp_FillTblOzetYatakServisAy] 
	@TarihCode1 varchar(10)
	
as

begin

drop table rtblOzetYatakServisAy

SELECT 
	ROW_NUMBER() OVER(ORDER BY qc.Key1 ASC) AS 'RowNumber',
	qC.Key1, 
	qc.Key2,
	
	ISNULL([qC].[SumOfAdet],0) AS AdetC, 
	
	ISNULL([qC].[CountOfHasta],0) AS HastaC, 
	
	ISNULL([qC].[SumOfToplam],0) AS ToplamC, 
	
	ISNULL([qC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qC].[CountOfHasta]) AS KisiBasiC, 
	
	ISNULL([qC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qC].[SumOfAdet]) AS IslemBasiC
	
	into rtblOzetYatakServisAy
	
FROM udf_GetYatakServisAy(@TarihCode1) as qC
	
end




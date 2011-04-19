

CREATE proc [dbo].[sp_FillTblOzetAnaIslemAy] 
	@TarihCode1 varchar(10)
as

begin

drop table rtblOzetAnaIslemAy

SELECT 
	ROW_NUMBER() OVER(ORDER BY tlkpAnaIslemTipi.strName ASC) AS 'RowNumber',
	tlkpAnaIslemTipi.strName AS Key1,
	AY as Key2,
	
	ISNULL([qC].[SumOfAdet],0) AS AdetC, 
	
	ISNULL([qC].[CountOfHasta],0) AS HastaC, 
	
	ISNULL([qC].[SumOfToplam],0) AS ToplamC, 
	
	ISNULL([qC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qC].[CountOfHasta]) AS KisiBasiC, 
	
	ISNULL([qC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qC].[SumOfAdet]) AS IslemBasiC
	
	into rtblOzetAnaIslemAy
	
FROM tlkpAnaIslemTipi
	LEFT JOIN 
		udf_GetAnaIslemAy(@TarihCode1) as qC ON tlkpAnaIslemTipi.ID = qC.lngAnaIslemID
WHERE
	[qC].[SumOfToplam] <> 0
end




CREATE proc [dbo].[sp_FillTblOzetServis] 
	@TarihCode1 varchar(10),
	@TarihCode2 varchar(10),
	@TarihCode3 varchar(10)
as

begin

drop table rtblOzetServis

SELECT 
	ROW_NUMBER() OVER(ORDER BY tlkpServisTipi.strName ASC) AS 'RowNumber',
	tlkpServisTipi.strName AS Key1, 
	
	ISNULL([qC].[SumOfAdet],0) AS AdetC, 
	ISNULL([qP].[SumOfADET],0) AS AdetP, 
	ISNULL([qP1].[SumOfADET],0) AS AdetP1, 
	dbo.udf_ComputeDiff([qC].[SumOfAdet],[qP].[SumOfADET]) AS AdetY, 
	dbo.udf_ComputeDiff([qC].[SumOfAdet],[qP1].[SumOfADET]) AS AdetY1, 
	
	ISNULL([qC].[CountOfHasta],0) AS HastaC, 
	ISNULL([qP].[CountOfHasta],0) AS HastaP, 
	ISNULL([qP1].[CountOfHasta],0) AS HastaP1, 
	dbo.udf_ComputeDiff([qC].[CountOfHasta],[qP].[CountOfHasta]) AS HastaY, 
	dbo.udf_ComputeDiff([qC].[CountOfHasta],[qP1].[CountOfHasta]) AS HastaY1, 
	
	ISNULL([qC].[SumOfToplam],0) AS ToplamC, 
	ISNULL([qP].[SumOfToplam],0) AS ToplamP, 
	ISNULL([qP1].[SumOfToplam],0) AS ToplamP1, 
	dbo.udf_ComputeDiff([qC].[SumOfToplam],[qP].[SumOfToplam]) AS ToplamY, 
	dbo.udf_ComputeDiff([qC].[SumOfToplam],[qP1].[SumOfToplam]) AS ToplamY1, 
	
	ISNULL([qC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qC].[CountOfHasta]) AS KisiBasiC, 
	ISNULL([qP].[SumOfToplam],0) / dbo.udf_ZeroConvert([qP].[CountOfHasta]) AS KisiBasiP, 
	ISNULL([qP1].[SumOfToplam],0) / dbo.udf_ZeroConvert([qP1].[CountOfHasta]) AS KisiBasiP1, 
	dbo.udf_ComputeDiff( ISNULL([qC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qC].[CountOfHasta]),
		ISNULL([qP].[SumOfToplam],0) / dbo.udf_ZeroConvert([qP].[CountOfHasta])) AS KisiBasiY, 
	dbo.udf_ComputeDiff( ISNULL([qC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qC].[CountOfHasta]),
		ISNULL([qP1].[SumOfToplam],0) / dbo.udf_ZeroConvert([qP1].[CountOfHasta])) AS KisiBasiY1, 
	
	ISNULL([qC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qC].[SumOfAdet]) AS IslemBasiC, 
	ISNULL([qP].[SumOfToplam],0) / dbo.udf_ZeroConvert([qP].[SumOfAdet]) AS IslemBasiP, 
	ISNULL([qP1].[SumOfToplam],0) / dbo.udf_ZeroConvert([qP1].[SumOfAdet]) AS IslemBasiP1, 
	dbo.udf_ComputeDiff(ISNULL([qC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qC].[SumOfAdet]),
		ISNULL([qP].[SumOfToplam],0) / dbo.udf_ZeroConvert([qP].[SumOfAdet])) AS IslemBasiY,
	dbo.udf_ComputeDiff(ISNULL([qC].[SumOfToplam],0) / dbo.udf_ZeroConvert([qC].[SumOfAdet]),
		ISNULL([qP1].[SumOfToplam],0) / dbo.udf_ZeroConvert([qP1].[SumOfAdet])) AS IslemBasiY1
	
	into rtblOzetServis
	
FROM tlkpServisTipi 
	LEFT JOIN 
		udf_GetServis(@TarihCode1) as qC ON tlkpServisTipi.ID = qC.lngDoktorServisTipiID
	LEFT JOIN 
		udf_GetServis(@TarihCode2) as qP ON tlkpServisTipi.ID = qP.lngDoktorServisTipiID
	LEFT JOIN 
		udf_GetServis(@TarihCode3) as qP1 ON tlkpServisTipi.ID = qP1.lngDoktorServisTipiID
		
WHERE
	ISNULL([qC].[SumOfToplam],0) <>0 and ISNULL([qP].[SumOfToplam],0)<>0 and ISNULL([qP1].[SumOfToplam],0)<>0
	
end


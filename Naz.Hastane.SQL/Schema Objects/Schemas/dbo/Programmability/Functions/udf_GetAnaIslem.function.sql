

CREATE function [dbo].[udf_GetAnaIslem](
	@TarihCode varchar(10))
	returns table 
	as return (

	SELECT    
		lngAnaIslemID, 
		COUNT(distinct Hasta) AS CountOfHasta, 
		SUM(Adet) AS SumOfAdet, 
		SUM(Toplam) AS SumOfToplam

	FROM dbo.rTblOzet
    WHERE (TarihCode = @TarihCode)
	GROUP BY lngAnaIslemID
	
	)

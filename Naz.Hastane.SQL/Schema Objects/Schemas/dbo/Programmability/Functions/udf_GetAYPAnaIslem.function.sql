
CREATE function [dbo].[udf_GetAYPAnaIslem](
	@TarihCode varchar(10))
	returns table 
	as return (

	SELECT    
		AYP, 
		lngAnaIslemID, 
		COUNT(distinct Hasta) AS CountOfHasta, 
		SUM(Adet) AS SumOfAdet, 
		SUM(Toplam) AS SumOfToplam

	FROM dbo.rTblOzet
    WHERE TarihCode = @TarihCode
	GROUP BY AYP, lngAnaIslemID
	
	)
	
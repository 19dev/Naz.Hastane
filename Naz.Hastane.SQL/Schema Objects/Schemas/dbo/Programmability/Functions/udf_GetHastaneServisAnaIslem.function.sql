

CREATE function [dbo].[udf_GetHastaneServisAnaIslem](
	@TarihCode varchar(10))
	returns table 
	as return (

	SELECT    
		HastaneServis, 
		rTblOzet.lngAnaIslemID, 
		COUNT(distinct Hasta) AS CountOfHasta, 
		SUM(Adet) AS SumOfAdet, 
		SUM(Toplam) AS SumOfToplam

	FROM rTblOzet
    WHERE TarihCode = @TarihCode
	GROUP BY 
	HastaneServis, 
	rTblOzet.lngAnaIslemID
	
	)

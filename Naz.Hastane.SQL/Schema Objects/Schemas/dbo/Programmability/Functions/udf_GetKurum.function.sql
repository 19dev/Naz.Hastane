

CREATE function [dbo].[udf_GetKurum](
	@TarihCode varchar(10))
	returns table 
	as return (

	SELECT    
		lngKurumTipiID, 
		COUNT(distinct Hasta) AS CountOfHasta, 
		SUM(Adet) AS SumOfAdet, 
		SUM(Toplam) AS SumOfToplam

	FROM rTblOzet
    WHERE TarihCode = @TarihCode
	GROUP BY lngKurumTipiID
	
	)
	


CREATE function [dbo].[udf_GetKurumAnaIslem](
	@TarihCode varchar(10))
	returns table 
	as return (

	SELECT    
		lngKurumTipiID, 
		lngAnaIslemID, 
		COUNT(distinct Hasta) AS CountOfHasta, 
		SUM(Adet) AS SumOfAdet, 
		SUM(Toplam) AS SumOfToplam

	FROM rTblOzet
    WHERE (TarihCode = @TarihCode)
	GROUP BY lngKurumTipiID, lngAnaIslemID
	
	)
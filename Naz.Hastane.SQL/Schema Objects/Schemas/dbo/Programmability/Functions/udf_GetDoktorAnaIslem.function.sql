
CREATE function [dbo].[udf_GetDoktorAnaIslem](
	@TarihCode varchar(10))
	returns table 
	as return (

	SELECT    
		Doktor, 
		lngAnaIslemID, 
		COUNT(distinct Hasta) AS CountOfHasta, 
		SUM(Adet) AS SumOfAdet, 
		SUM(Toplam) AS SumOfToplam

	FROM dbo.rTblOzet
    WHERE (TarihCode = @TarihCode)
	GROUP BY Doktor, lngAnaIslemID
	
	)
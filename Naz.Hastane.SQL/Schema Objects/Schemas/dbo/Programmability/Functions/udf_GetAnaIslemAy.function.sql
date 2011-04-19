


CREATE function [dbo].[udf_GetAnaIslemAy](
	@TarihCode varchar(10))
	returns table 
	as return (

	SELECT    
		lngAnaIslemID, 
		AY,
		COUNT(distinct Hasta) AS CountOfHasta, 
		SUM(Adet) AS SumOfAdet, 
		SUM(Toplam) AS SumOfToplam

	FROM dbo.rTblOzet
    WHERE (TarihCode = @TarihCode) and rTblOzet.AYP = 'Y'
	GROUP BY lngAnaIslemID, AY
	
	)





CREATE function [dbo].[udf_GetAYPAy](
	@TarihCode varchar(10))
	returns table 
	as return (

	SELECT    
		AYP, 
		AY,
		COUNT(distinct Hasta) AS CountOfHasta, 
		SUM(Adet) AS SumOfAdet, 
		SUM(Toplam) AS SumOfToplam

	FROM rTblOzet
    WHERE TarihCode = @TarihCode
	GROUP BY AYP, AY
	
	)
	


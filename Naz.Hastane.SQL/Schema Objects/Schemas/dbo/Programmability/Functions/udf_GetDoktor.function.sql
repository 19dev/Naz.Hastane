

CREATE function [dbo].[udf_GetDoktor](
	@TarihCode varchar(10))
	returns table 
	as return (

	SELECT    
		Doktor, 
		COUNT(distinct Hasta) AS CountOfHasta, 
		SUM(Adet) AS SumOfAdet, 
		SUM(Toplam) AS SumOfToplam

	FROM dbo.rTblOzet
    WHERE (TarihCode = @TarihCode)
	GROUP BY Doktor
	
	)

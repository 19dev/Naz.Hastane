

CREATE function [dbo].[udf_GetYatakServisAy](
	@TarihCode varchar(10))
	returns table 
	as return (

	SELECT    
		tlkpvService.SLT as Key1, 
		rTblOzet.AY as Key2, 
		
		COUNT(distinct Hasta) AS CountOfHasta, 
		SUM(Adet) AS SumOfAdet, 
		SUM(Toplam) AS SumOfToplam

	FROM rTblOzet
		INNER JOIN tlkpvService ON rtblOzet.HastaneServis = tlkpvService.SLB
    WHERE 
		rTblOzet.TarihCode = @TarihCode AND
		rTblOzet.lngAnaIslemID = '10' AND
		tlkpvServis.SLXX = '1'
	GROUP BY 
		tlkpvService.SLT, 
		rTblOzet.AY
	
	)

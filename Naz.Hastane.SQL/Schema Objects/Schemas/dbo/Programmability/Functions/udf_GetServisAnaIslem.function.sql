
CREATE function [dbo].[udf_GetServisAnaIslem](
	@TarihCode varchar(10))
	returns table 
	as return (

	SELECT    
		tlkpvDoctor.lngDoktorServisTipiID, 
		rTblOzet.lngAnaIslemID, 
		COUNT(distinct Hasta) AS CountOfHasta, 
		SUM(Adet) AS SumOfAdet, 
		SUM(Toplam) AS SumOfToplam

	FROM rTblOzet
        INNER JOIN tlkpvDoctor ON Doktor = tlkpvDoctor.SLB
    WHERE TarihCode = @TarihCode
	GROUP BY tlkpvDoctor.lngDoktorServisTipiID, rTblOzet.lngAnaIslemID
	
	)
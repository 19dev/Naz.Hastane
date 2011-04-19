

CREATE proc [dbo].[sp_GetGunlukMuhasebeFisiToTable] 
	@Tarih datetime
as

begin
	drop table rtblGunlukMuhasebeFisi

	select ROW_NUMBER() OVER(ORDER BY Aciklama DESC) AS 'RowNumber', * into rtblGunlukMuhasebeFisi
	from 
	(
	select * from udf_GetGunlukKasa(@Tarih)
	union all
	select * from udf_GetGunlukKasaBanka(@Tarih)
	union all
	select * from udf_GetGunlukFaturaP(@Tarih)
	union all
	select * from udf_GetGunlukFaturaY(@Tarih)
	) as a
	order by RecordType, HesapKodu, Aciklama
end



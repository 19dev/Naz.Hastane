sp_FillTblOzet '20100101', '20110101', '2010',
	'20090101', '20100101', '2009',
	'20080101', '20090101', '2008'
go

sp_FillTblOzetAYPAnaIslem '2010','2009','2008'
go

sp_FillTblOzetAYPKurum '2010','2009','2008'
go

sp_FillTblOzetDoktorAnaIslem '2010','2009','2008'
go

sp_FillTblOzetKurumAnaIslem '2010','2009','2008'
go

sp_FillTblOzetServisAnaIslem '2010','2009','2008'
go

drop table rTblOzetAy
select *  into rTblOzetAy from udf_GetDataOzetAy('20100101', '20110101', '2010')

select AY, Kurum, Doktor, Adet, Toplam, TarihCode, HastaAdet from udf_GetDataOzetAy('20100101', '20110101', '2010')

select * from rTblOzetDoktorAnaIslem

select COUNT(*) from rTblOzet
sp_FillTblOzet '20110101', '20110201', '2011',
	'20100101', '20100201', '2010',
	'20090101', '20090201', '2009'
go
sp_FillTblOzetAYPAnaIslem '2011','2010','2009'
go
sp_FillTblOzetAYPKurum '2011','2010','2009'
go
sp_FillTblOzetDoktorAnaIslem '2011','2010','2009'
go
sp_FillTblOzetKurumAnaIslem '2011','2010','2009'
go
sp_FillTblOzetServisAnaIslem '2011','2010','2009'
go

select * from rTblOzet


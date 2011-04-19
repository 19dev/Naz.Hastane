CREATE proc [dbo].[sp_FillTblOzet] 
	@Tarih1Start datetime,
	@Tarih1End datetime,
	@TarihCode1 varchar(10),
	@Tarih2Start datetime,
	@Tarih2End datetime,
	@TarihCode2 varchar(10),
	@Tarih3Start datetime,
	@Tarih3End datetime,
	@TarihCode3 varchar(10)
as

begin

drop table rtblOzet

select * into rtblOzet from udf_GetDataOzet(@Tarih1Start, @Tarih1End, @TarihCode1)
union all
select * from udf_GetDataOzet(@Tarih2Start, @Tarih2End, @TarihCode2)
union all
select * from udf_GetDataOzet(@Tarih3Start, @Tarih3End, @TarihCode3)

end

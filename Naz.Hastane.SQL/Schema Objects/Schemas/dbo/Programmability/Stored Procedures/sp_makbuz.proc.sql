


--***********************

CREATE PROCEDURE [dbo].[sp_makbuz] @makno varchar(10)
AS
--set @makno = '0000747'
select k.*,a.HASTAADI ,a.HASTASOYADI from kasa k
inner join adres a on a.knr = k.knr
where makno = @makno






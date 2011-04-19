



CREATE PROCEDURE [dbo].[sp_HastaBul]  @knr varchar(6),@ad varchar(20),@soyad varchar(30)
AS

select knr,HASTAADI,HASTASOYADI,TCKIMLIKNO,BAGNO,BAGKARNENO
FROM ADRES
WHERE (KNR LIKE @knr+'%') AND (HASTAADI LIKE @ad+'%' AND HASTASOYADI LIKE @soyad+'%')





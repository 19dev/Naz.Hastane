



















CREATE PROCEDURE [dbo].[sp_MedulaV3FaturaDataset] @hstbasno varchar(8) , @DataSet varchar(20)
AS


declare  @knr varchar(6), @snr varchar(3),
        @doktor varchar(10),@serviskodu varchar(10),@servis varchar(50),
        @ambu varchar(1),@CikisTarih varchar(10),@TaburcuKodu varchar(2),
        @Sonucu varchar(1000),@IstisnaiDurum varchar(2) , @Sonucaciklama varchar(1000),@Eksorgu varchar(2),
        @TesisKodu varchar(10) ,@kod varchar(20),@sorguturu varchar(7),@protokolno varchar(100)
      --,@TakipNo varchar(8), @DataSet varchar(15)

--set @TakipNo = '12345678'

select @TesisKodu = slt from keydat
where slk = '00' and  slb = 'INT_GSSKOD'

select @knr = knr,@snr = snr from behand
where HASTABASNO = @hstbasno
 
if @Dataset = 'Anamnez' 
begin 

select  DISTINCT(BH.TAKIPNO)
,BH.TABKODU as TABKODU

from BEHAND  BH 
left join BEHAND_DETAY  BD ON BD.KNR = BH.KNR AND    BH.SNR = BD.SNR
WHERE  BH.HASTABASNO=@hstbasno and BH.TAKIPNO<>'' AND BH.TAKIPSEND='1' AND BD.EKSORGU='H'
end
---*Radyoloj








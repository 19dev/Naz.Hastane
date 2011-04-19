
CREATE  PROCEDURE [dbo].[faturakes]
@knr varchar(6) ,
@snr varchar(3),
@tarih varchar(20),
@fn varchar(10),
@tutar float,
@user varchar(20),
@cdate varchar(10),
@FTUTAR FLOAT
AS
DECLARE
@os varchar(1),
@pn varchar(10),
@mn int,@vezne varchar(10),
@KULLANILAN FLOAT

declare @aid int , @KULL FLOAT , @AVTUT  FLOAT , @EKLE  FLOAT , @TUTKALAN FLOAT

DECLARE AVANSLAR_cursor CURSOR FOR 

       	SELECT AV_ID,(TUTAR-KULLANILAN),KULLANILAN,MAKNO,SNR
       	FROM AVANSLAR 
       	WHERE KNR = @KNR /*AND SNR=@SNR */ AND (TUTAR > KULLANILAN)
             ORDER BY AV_ID ,knr 
	
             OPEN AVANSLAR_cursor
 
	FETCH NEXT FROM AVANSLAR_cursor 
	INTO @aid,@AVTUT,@KULL,@mn,@SNR
    
        SELECT @aid , @AVTUT, @KULL,@SNR

--IF @@FETCH_STATUS <> 0 
--BEGIN       
  WHILE @@FETCH_STATUS = 0 
  BEGIN   
       IF @TUTAR > @AVTUT
       BEGIN
         
          --  IF @AVTUT > @KULL  
          --  BEGIN
           --  SET @EKLE = (@AVTUT-@KULL)
             SET @TUTAR = @TUTAR -(@AVTUT)
           -- SET @TUTKALAN = @TUTKALAN + @EKLE

            INSERT into AVANSLAR_KULLANILAN (AV_ID,TARIH,FATURANO,TUTAR,USER_ID,DATE_CREATE)
            values(@aid,@tarih,@fn,@AVTUT,@user,@cdate)
            PRINT 'AVANSLAR KULLANILAN INSERT EDILDI'

            SET @KULLANILAN = (SELECT SUM(TUTAR) FROM AVANSLAR_KULLANILAN WHERE AV_ID = @aid)

             UPDATE AVANSLAR 
             SET KULLANILAN = @KULLANILAN
             WHERE AV_ID = @aid

             PRINT  'AVANSLAR UPDATE EDILDI'
 
         
           EXEC DBO.DOKTORHAKEDIS @KNR,@SNR,@tarih,@AVTUT,@mn,@user,@cdate,@FTUTAR,@fn         

           
        END ELSE
        BEGIN

           

           INSERT into AVANSLAR_KULLANILAN (AV_ID,TARIH,FATURANO,TUTAR,USER_ID,DATE_CREATE)
           values(@aid,@tarih,@fn,@tutar,@user,@cdate)
           PRINT  'AVANSLAR KULLANILAN INSERT EDILDI'

           SET @KULLANILAN = (SELECT SUM(TUTAR) FROM AVANSLAR_KULLANILAN WHERE AV_ID = @aid)

--          SET @EKLE = @TUTAR

          UPDATE AVANSLAR 
          SET KULLANILAN = @KULLANILAN
          WHERE AV_ID = @aid
          PRINT  'AVANSLAR UPDATE EDILDI'


         EXEC DBO.DOKTORHAKEDIS @KNR,@SNR,@tarih,@tutar,@mn,@user,@cdate,@FTUTAR,@fn          
      
          GOTO SON  
        END

                  
        FETCH NEXT FROM AVANSLAR_cursor
        INTO @aid,@AVTUT,@KULL,@mn,@SNR
   END
SON:
        CLOSE AVANSLAR_CURSOR
      	DEALLOCATE AVANSLAR_cursor 

--END ELSE
--BEGIN
--PRINT ''
--    EXEC DBO.ODEMEAL @KNR,@SNR,@TARİH,@TUTAR,@OS,@PN,@MN,@USER,@FN,@VEZNE 

--END

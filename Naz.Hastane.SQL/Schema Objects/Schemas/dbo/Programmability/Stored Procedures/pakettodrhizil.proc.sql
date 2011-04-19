


CREATE PROCEDURE [dbo].[pakettodrhızıl] 
@tarih varchar(20),
@tarih2 varchar(20),
@doktor varchar(10)
AS
DECLARE
@knr varchar(6) ,
@snr varchar(3),
@tar datetime,
@code varchar(8),
@name1 varchar(250),
@adet int,
@htutarı float,
@tutarı float,
@kdv float,
@faturano varchar(10),
@fat_ıd int,
@arzt varchar(300),
@tanım varchar(10),
@grup varchar(20),
@say int,
@psg varchar(10)


--set @tarih = '20060901'
--set @tarih2 = '20060930'

DECLARE Fp_cursor CURSOR FOR 

    select arzt ,knr,snr,tarıh,code,name1,adet,htutarı,tutarı,faturano,fat_ıd ,kdv,tanım,grup,psg from FPAKETLER 
    where TARIH >= @tarih and TARIH <=@tarih2
    OPEN fp_cursor
 
	FETCH NEXT FROM fp_cursor 
	INTO @arzt ,@knr,@snr,@tar,@code,@name1,@adet,@htutarı,@tutarı,@faturano,@fat_ıd ,@kdv ,@tanım ,@grup ,@psg
    

  WHILE @@FETCH_STATUS = 0 
  BEGIN   
      
   IF @ARZT <> '' 
   BEGIN
     
     select @say = count(datavalue) from strtotable(@arzt,',')   
     
     insert into drhızıl (arzt , knr, snr ,tarıh ,code ,name1 ,adet ,satısf ,ksatısf ,kfatno ,kdv ,tanım ,grup ,p_adet ,psg ,date_create) 

     select datavalue, @knr,@snr,@tar,@code,@name1,@adet,@htutarı/@say,@tutarı/@say,@fat_ıd , @kdv ,@tanım ,@grup , @say -1 ,@psg ,getdate() 
     from strtotable(@arzt,',')   
    where datavalue in  (select datavalue from strtotable(@doktor,','))
    
   END    

    FETCH NEXT FROM fp_cursor 
    INTO @arzt,@knr,@snr,@tar,@code,@name1,@adet,@htutarı,@tutarı,@faturano,@fat_ıd ,@kdv ,@tanım ,@grup,@psg


  END 
        CLOSE fp_CURSOR
      	DEALLOCATE fp_cursor


insert into Doktor_HavuzAl 
select datavalue,@tarih,@tarih2,'P'
from (
select datavalue from strtotable(@doktor,',')
) as t



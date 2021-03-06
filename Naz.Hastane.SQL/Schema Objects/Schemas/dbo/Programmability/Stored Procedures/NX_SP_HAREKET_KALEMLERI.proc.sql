﻿


CREATE  PROCEDURE NX_SP_HAREKET_KALEMLERI
	(
		@HAREKET_ID int
	)
AS
  DECLARE @DEPO_ID varchar(4)  
  SELECT @DEPO_ID=(CASE WHEN HAREKET_TIPI IN('IG','SG','DG','SY') THEN GIRIS_DEPOSU ELSE CIKIS_DEPOSU END) 
  FROM NX_HAREKETLER WHERE HAREKET_ID=@HAREKET_ID
  
	DECLARE @TANIM varchar(2)
	DECLARE @AKOD varchar(2)
	SELECT  @TANIM=(CASE LEFT(@DEPO_ID,2) WHEN '03' THEN '09' WHEN '04' THEN '16' END), 
	        @AKOD=RIGHT(@DEPO_ID,2)
	
  SELECT  K.HAREKET_ID, 
          K.MALZEME, 
          K.MIKTAR, K.ETIKET_FIYATI, K.ECZACI_KARI, K.MAL_FAZLASI,K.MIADI, 
          K.OZEL_INDIRIM, K.KDV,
          I.NAME1 AS MALZEME_ADI, 
          (I.TOPGIR-I.TOPCIK) AS MEVCUT_MIKTAR, 
          I.CODE AS KOD, 
          I.CODE AS BARKOD
  FROM  NX_HAREKET_KALEMLERI K LEFT OUTER JOIN ILACSARF I ON K.MALZEME=I.CODE 
  WHERE K.HAREKET_ID=@HAREKET_ID AND 
        I.TANIM=@TANIM AND 
        I.AKOD=@AKOD



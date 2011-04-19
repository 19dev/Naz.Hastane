


CREATE PROCEDURE NX_SP_HAREKET_EKLE
	(
        @FAT_NO varchar(16),
        @IRS_NO varchar(16),
        @BELGE_NO varchar(16),
        @ILAC_SARF char(1),
        @GIRIS_DEPOSU varchar(4),
        @CIKIS_DEPOSU varchar(4),
        @TEDARIKCI varchar(5),
        @HAREKET_TIPI char(2),
        @FAT_TARIHI datetime,
        @IRS_TARIHI datetime,
        @KARANTINA_NO varchar(7),
        @KULLANICI_KODU varchar(20),
        @HAREKET_ID int Output
	)
AS
	INSERT INTO NX_HAREKETLER 
        (FAT_NO,IRS_NO,BELGE_NO,ISLEM_TARIHI,GIRIS_DEPOSU,CIKIS_DEPOSU,
         TEDARIKCI,HAREKET_TIPI,FAT_TARIHI,IRS_TARIHI,
         KARANTINA_NO,KULLANICI_KODU,ILAC_SARF)
	VALUES 
        (@FAT_NO,@IRS_NO,@BELGE_NO,dbo.nx_f_cdate(getdate()),@GIRIS_DEPOSU,@CIKIS_DEPOSU,
         @TEDARIKCI,@HAREKET_TIPI,dbo.nx_f_cdate(@FAT_TARIHI),dbo.nx_f_cdate(@IRS_TARIHI),
         @KARANTINA_NO,@KULLANICI_KODU,@ILAC_SARF)
	
    SELECT @HAREKET_ID=@@IDENTITY
	
	RETURN @@ROWCOUNT



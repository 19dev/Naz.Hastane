SELECT SLT FROM KEYDAT WHERE SLK='00' AND SLB='FATKONT' 
select SLT from KEYDAT where SLK='25' and SLB='FATNO'
exec sp_cursoropen @p1 output,N'select SLK, SLB, SLT, SLX, SLY, SLZ, SLVV, SLXX, SLYY, SLZZ from KEYDAT where SLK=''25'' and SLB=''FATNO''',@p3 output,@p4 output,@p5 output
exec sp_cursor 180150043,33,1,N'KEYDAT',@SLT='AYDIN SAKAR'
select SLT from KEYDAT where SLK='25' and SLB='FATNO'
select SLT from KEYDAT where SLK='00' and SLB='FATNO'
exec sp_cursoropen @p1 output,N'select SLK, SLB, SLT, SLX, SLY, SLZ, SLVV, SLXX, SLYY, SLZZ from KEYDAT where SLK=''00'' and SLB=''FATNO''',@p3 output,@p4 output,@p5 output
exec sp_cursor 180150045,33,1,N'KEYDAT',@SLT='1794821'
select SLT from KEYDAT where SLK='25' and SLB='FATNO'
exec sp_cursoropen @p1 output,N'select SLK, SLB, SLT, SLX, SLY, SLZ, SLVV, SLXX, SLYY, SLZZ from KEYDAT where SLK=''25'' and SLB=''FATNO''',@p3 output,@p4 output,@p5 output

select SLT from KEYDAT where SLK='25' and SLB='MAKNO'
exec sp_cursoropen @p1 output,N'select SLK, SLB, SLT, SLX, SLY, SLZ, SLVV, SLXX, SLYY, SLZZ from KEYDAT where SLK=''25'' and SLB=''MAKNO''',@p3 output,@p4 output,@p5 output
exec sp_cursor 180150049,33,1,N'KEYDAT',@SLT='AYDIN SAKAR'
select SLT from KEYDAT where SLK='25' and SLB='MAKNO'
select SLT from KEYDAT where SLK='00' and SLB='MAKNO'
exec sp_cursoropen @p1 output,N'select SLK, SLB, SLT, SLX, SLY, SLZ, SLVV, SLXX, SLYY, SLZZ from KEYDAT where SLK=''00'' and SLB=''MAKNO''',@p3 output,@p4 output,@p5 output
exec sp_cursor 180150051,33,1,N'KEYDAT',@SLT='3750475'
select SLT from KEYDAT where SLK='25' and SLB='MAKNO'
exec sp_cursoropen @p1 output,N'select SLK, SLB, SLT, SLX, SLY, SLZ, SLVV, SLXX, SLYY, SLZZ from KEYDAT where SLK=''25'' and SLB=''MAKNO''',@p3 output,@p4 output,@p5 output
exec sp_cursor 180150053,33,1,N'KEYDAT',@SLT=' '

select SLT from KEYDAT where SLK='00' and SLB='AVANS_ID'
exec sp_cursoropen @p1 output,N'select SLK, SLB, SLT, SLX, SLY, SLZ, SLVV, SLXX, SLYY, SLZZ from KEYDAT where SLK=''00'' and SLB=''AVANS_ID''',@p3 output,@p4 output,@p5 output
exec sp_cursor 180150055,33,1,N'KEYDAT',@SLT='1701189'
INSERT into AVANSLAR (AV_ID, KNR, SNR, TARIH, TUTAR, KULLANILAN, ODEMESEKLI, POSNO, MAKNO,HESAPKODU,ALTHESAPKODU, USER_ID, DATE_CREATE) values (1701189, '870366', '999', '15.06.2011 11:11:14', 9, 9, 'N', Null, '3750475', '', '', 'AYDIN SAKAR', '15.06.2011 11:12:05')
INSERT into AVANSLAR_KULLANILAN (AV_ID, TARIH, FATURANO, TUTAR, USER_ID, DATE_CREATE) values(1701189, '15.06.2011 11:11:14', '1794821', 9, 'AYDIN SAKAR', '15.06.2011 11:12:05')

INSERT into KASA(MAKNO, KNR, SNR, TARIH, MAKBUZNO, MAKBUZTIPI, ODEMESEKLI, POSNO, TUTAR, BORCALACAK, FATURANO, VEZNE,HESAPKODU,ALTHESAPKODU, USER_ID, DATE_CREATE)values ( '3750475', '870366', '999', '15.06.2011 11:11:14', 'F-C996535', 'A', 'N', Null, 9, 'B', '1794821', '01', '', '', 'AYDIN SAKAR', '15.06.2011 11:12:05')
select SLT from KEYDAT where SLK='25' and SLB='MAKNO'
exec sp_cursoropen @p1 output,N'select SLK, SLB, SLT, SLX, SLY, SLZ, SLVV, SLXX, SLYY, SLZZ from KEYDAT where SLK=''25'' and SLB=''MAKNO''',@p3 output,@p4 output,@p5 output
exec sp_cursor 180150057,33,1,N'KEYDAT',@SLT='AYDIN SAKAR'
select SLT from KEYDAT where SLK='25' and SLB='MAKNO'
select SLT from KEYDAT where SLK='00' and SLB='MAKNO'
exec sp_cursoropen @p1 output,N'select SLK, SLB, SLT, SLX, SLY, SLZ, SLVV, SLXX, SLYY, SLZZ from KEYDAT where SLK=''00'' and SLB=''MAKNO''',@p3 output,@p4 output,@p5 output
exec sp_cursor 180150059,33,1,N'KEYDAT',@SLT='3750476'
select SLT from KEYDAT where SLK='25' and SLB='MAKNO'
exec sp_cursoropen @p1 output,N'select SLK, SLB, SLT, SLX, SLY, SLZ, SLVV, SLXX, SLYY, SLZZ from KEYDAT where SLK=''25'' and SLB=''MAKNO''',@p3 output,@p4 output,@p5 output
exec sp_cursor 180150061,33,1,N'KEYDAT',@SLT=' '
INSERT into FATURA (KNR, FATURA_ID, SLNR, FATURANO, FATURATARIHI, HIZMETTUTARI, INDIRIM, KDVTUTARI, YUVARLAMA, FATURATUTARI, KDVORANI, NAME, FATURATIPI, FAK, ZHLKZ, PSG, ISODENDI, MAKNO, VEZNE, USER_ID, DATE_CREATE) VALUES ('870366','1794821','C996535','C996535','15.06.2011 11:11:14',8.33,0,0.67,0,9,'0','AYDIN SAKAR','H','K','N','','1','3750476','01','AYDIN SAKAR','15.06.2011 11:12:05')

UPDATE HIZIL set MAKNO='3750476' where KNR='870366' and SNR='999' and SIRANO=1
select B.AMBU, H.DRYUZDE, H.PHYUZDE, H.HAVUZ, HZ.*, HDY.YUZDE from HIZMET H inner join HIZIL HZ on H.TANIM=HZ.TANIM and H.GRUP=HZ.GRUP and H.CODE=HZ.CODE inner join BEHAND B on B.KNR=HZ.KNR and B.SNR=HZ.SNR left join HIZMETDOKTORYUZDE HDY on H.TANIM=HDY.TANIM and H.GRUP=HDY.GRUP and H.CODE=HDY.CODE and HDY.ARZT=HZ.ARZT2 where HZ.KNR='870366' and HZ.SNR='999' and HZ.SIRANO=1
select KNR from DOKTORLAR where ARZT='0008'
select isnull(max(SIRA),0) as SIRA from DOKTORLAR_FATURA_DETAY where KNR='00021'
Insert into DOKTORLAR_FATURA_DETAY (KNR, SIRA, HKNR, HSNR, HSIRANO, HAREKETTIPI, FATNO, FATURANO, FATURATARIHI, MAKNO, AMBU, TANIM, GRUP, CODE, TOPLAM, PAY, USER_ID, DATE_CREATE) values ('00021', 9191967, '870366', '999', '1', 'F', '1794821', 'C996535', '15.06.2011', '3750476', 'P', '00', '002', '1000', 8.33, 2.39, 'AYDIN SAKAR', '15.06.2011 11:12:05')

select KNR from DOKTORLAR where ARZT='LARH'
select isnull(max(SIRA),0) as SIRA from DOKTORLAR_FATURA_DETAY where KNR='00249'
Insert into DOKTORLAR_FATURA_DETAY (KNR, SIRA, HKNR, HSNR, HSIRANO, HAREKETTIPI, FATNO, FATURANO, FATURATARIHI, MAKNO, AMBU, TANIM, GRUP, CODE, TOPLAM, PAY, USER_ID, DATE_CREATE) values ('00249', 761089, '870366', '999', '1', 'F', '1794821', 'C996535', '15.06.2011', '3750476', 'P', '00', '002', '1000', 8.33, 3.54, 'AYDIN SAKAR', '15.06.2011 11:12:06')

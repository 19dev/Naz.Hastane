

CREATE PROCEDURE [dbo].[sp_kur] 
AS

declare @var int
set @var= 0

set @var = (select count(*) from  sysobjects
       where name = 'DRHIZIL')

if @var = 0
begin
CREATE TABLE [DRHIZIL] (
	[KAYITID] [numeric](18, 0) IDENTITY (1, 1) NOT NULL ,
	[KNR] [varchar] (6) COLLATE Turkish_CI_AS NOT NULL ,
	[SNR] [varchar] (3) COLLATE Turkish_CI_AS NOT NULL ,
	[SIRANO] [float] NULL ,
	[AKOD] [varchar] (2) COLLATE Turkish_CI_AS NULL ,
	[TANIM] [varchar] (2) COLLATE Turkish_CI_AS NULL ,
	[GRUP] [varchar] (3) COLLATE Turkish_CI_AS NULL ,
	[CODE] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[ARZT] [varchar] (4) COLLATE Turkish_CI_AS NULL ,
	[ARZT2] [varchar] (4) COLLATE Turkish_CI_AS NULL ,
	[ADET] [float] NULL ,
	[UNITE] [varchar] (2) COLLATE Turkish_CI_AS NULL ,
	[NAME1] [varchar] (100) COLLATE Turkish_CI_AS NULL ,
	[SATISF] [float] NULL ,
	[KSATISF] [float] NULL ,
	[KDV] [float] NULL ,
	[TARIH] [datetime] NULL ,
	[PSG] [varchar] (6) COLLATE Turkish_CI_AS NULL ,
	[HZLNO] [smallint] NULL ,
	[USER_ID] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[DATE_CREATE] [datetime] NULL ,
	[USER_ID_UPDATE] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[DATE_UPDATE] [datetime] NULL ,
	[MAKNO] [varchar] (8) COLLATE Turkish_CI_AS NULL ,
	[KFATNO] [varchar] (7) COLLATE Turkish_CI_AS NULL ,
	[FATURAEDILSIN] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[ISLENDIMI] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[IPTAL] [varchar] (1) COLLATE Turkish_CI_AS NULL CONSTRAINT [DF_DRHIZIL_IPTAL] DEFAULT (0),
	[S_ADET] [int] NULL ,
	[K_PAY] [float] NULL CONSTRAINT [DF_DRHIZIL_K_PAY] DEFAULT (0),
	[H_PAY] [float] NULL CONSTRAINT [DF_DRHIZIL_H_PAY] DEFAULT (0),
	[p_adet] [int] NULL CONSTRAINT [DF_DRHIZIL_p_adet] DEFAULT (0),
	[kfiyatyuzde] [float] NULL ,
	[sfiyatyuzde] [float] NULL ,
	[kfiyat] [float] NULL ,
	[sfiyat] [float] NULL ,
	CONSTRAINT [PK_DRHIZIL] PRIMARY KEY  CLUSTERED 
	(
		[KAYITID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
end

set @var = (select count(*) from  sysobjects
       where name = 'HIZMETDOKTORYUZDE_MUH')
if @var = 0
begin
CREATE TABLE [HIZMETDOKTORYUZDE_MUH] (
	[TANIM] [varchar] (2) COLLATE Turkish_CI_AS NOT NULL ,
	[GRUP] [varchar] (3) COLLATE Turkish_CI_AS NOT NULL ,
	[CODE] [varchar] (15) COLLATE Turkish_CI_AS NOT NULL ,
	[ARZT] [varchar] (4) COLLATE Turkish_CI_AS NOT NULL ,
	[YUZDE] [float] NOT NULL CONSTRAINT [DF_HIZMETDOKTORYUZDE_YUZDE_MUH] DEFAULT (0),
	[kfiyatYuzde] [float] NULL ,
	[sfiyatYuzde] [float] NULL ,
	[kfiyat] [float] NULL ,
	[sfiyat] [float] NULL ,
	[kurum] [varchar] (10) COLLATE Turkish_CI_AS NOT NULL ,
	[fiylist] [varchar] (2) COLLATE Turkish_CI_AS NULL ,
	[KAYITID] [int] IDENTITY (1, 1) NOT NULL ,
	CONSTRAINT [PK_HIZMETDOKTORYUZDE_MUH] PRIMARY KEY  CLUSTERED 
	(
		[TANIM],
		[GRUP],
		[CODE],
		[ARZT],
		[kurum]
	)  ON [PRIMARY] 
) ON [PRIMARY]
end


set @var = (select count(*) from  sysobjects
       where name = 'DOKTOR_HAKEDIS_BEKLEYEN')
if @var = 0
begin

CREATE TABLE [DOKTOR_HAKEDIS_BEKLEYEN] (
	[arzt] [varchar] (6) COLLATE Turkish_CI_AS NULL ,
	[ilktarih] [varchar] (10) COLLATE Turkish_CI_AS NULL ,
	[sontarih] [varchar] (10) COLLATE Turkish_CI_AS NULL ,
	[kpay] [float] NULL ,
	[hpay] [float] NULL ,
	[tarih] [varchar] (10) COLLATE Turkish_CI_AS NULL ,
	[durum] [varchar] (1) COLLATE Turkish_CI_AS NULL CONSTRAINT [DF_DOKTOR_HAKEDIS_BEKLEYEN_durum] DEFAULT ('B'),
	[KAYITID] [numeric](18, 0) IDENTITY (1, 1) NOT NULL 
) ON [PRIMARY]
end

set @var = (select count(*) from  sysobjects
       where name = 'Doktor_HavuzAl')
if @var = 0
begin

CREATE TABLE [Doktor_HavuzAl] (
	[dknr] [varchar] (4) COLLATE Turkish_CI_AS NULL ,
	[ilktarih] [varchar] (10) COLLATE Turkish_CI_AS NULL ,
	[sontarih] [varchar] (10) COLLATE Turkish_CI_AS NULL ,
	[opr] [varchar] (1) COLLATE Turkish_CI_AS NULL 
) ON [PRIMARY]
end



         if not exists (select * from syscolumns 
         where id=object_id('FATURA') and name='mk') 
         alter table FATURA add mk varchar(1) NULL

--         alter table KURADR add hesap_kodu nvarchar(50)

         if not exists (select * from syscolumns 
         where id=object_id('KURADR') and name='hesap_kodu') 
         alter table KURADR add hesap_kodu varchar(50) NULL

--         alter table KURADR add c_hesap_kodu varchar(20)
         if not exists (select * from syscolumns 
         where id=object_id('KURADR') and name='c_hesap_kodu') 
         alter table KURADR add c_hesap_kodu varchar(20) NULL
         

--         alter table KURADR add c_borc float
         if not exists (select * from syscolumns 
         where id=object_id('KURADR') and name='c_borc') 
         alter table KURADR add c_borc float NULL
         
--         alter table KURADR add c_alacak float
         if not exists (select * from syscolumns 
         where id=object_id('KURADR') and name='c_alacak') 
         alter table KURADR add c_alacak float NULL
         

--         alter table KURADR add FIYLIST varchar(2)
         if not exists (select * from syscolumns 
         where id=object_id('KURADR') and name='FIYLIST') 
         alter table KURADR add FIYLIST varchar(2) NULL
         

--         alter table KASA add ce char(1)
         if not exists (select * from syscolumns 
         where id=object_id('KASA') and name='ce') 
         alter table KASA add ce varchar(1) NULL
         
         if not exists (select * from syscolumns 
         where id=object_id('BEHAND') and name='ce') 
         alter table BEHAND add ce varchar(1) NULL
         
--         alter table KASA add tutardoviz float
         if not exists (select * from syscolumns 
         where id=object_id('KASA') and name='tutardoviz') 
         alter table KASA add tutardoviz float
         
--         alter table KASA add dovizcinsi varchar(50)
         if not exists (select * from syscolumns 
         where id=object_id('KASA') and name='dovizcinsi') 
         alter table KASA add dovizcinsi varchar(50)
         
--         alter table FATURALAR add ftutar float
         if not exists (select * from syscolumns 
         where id=object_id('FATURALAR') and name='ftutar') 
         alter table FATURALAR add ftutar float
         

--         alter table FATURALAR add kdvtutar float
         if not exists (select * from syscolumns 
         where id=object_id('FATURALAR') and name='kdvtutar') 
         alter table FATURALAR add kdvtutar float
         

--         alter table FATURALAR add gtop float
         if not exists (select * from syscolumns 
         where id=object_id('FATURALAR') and name='gtop')
         alter table FATURALAR add gtop float
         

--         alter table FATURALAR add yaziile varchar(255)
         if not exists (select * from syscolumns 
         where id=object_id('FATURALAR') and name='yaziile') 
         alter table FATURALAR add yaziile varchar(255)
         
  --       alter table FATURALAR add indtoplam float
         if not exists (select * from syscolumns 
         where id=object_id('FATURALAR') and name='indtoplam')
         alter table FATURALAR add indtoplam float
         

--         alter table FATURALAR add indsiztoplam float
         if not exists (select * from syscolumns 
         where id=object_id('FATURALAR') and name='indsiztoplam') 
         alter table FATURALAR add indsiztoplam float
         

--         alter table FATURALAR add doviz varchar(50)
         if not exists (select * from syscolumns 
         where id=object_id('FATURALAR') and name='doviz') 
         alter table FATURALAR add doviz varchar(50)
         
         
   
--         alter table FATURALAR_DETAY add tutar float
         if not exists (select * from syscolumns 
         where id=object_id('FATURALAR_DETAY') and name='tutar') 
         alter table FATURALAR_DETAY add tutar float
         

--         alter table FATURALAR_DETAY add adet float
         if not exists (select * from syscolumns 
         where id=object_id('FATURALAR_DETAY') and name='adet') 
         alter table FATURALAR_DETAY add adet float
         

--         alter table FATURALAR_DETAY add bfiyat float
         if not exists (select * from syscolumns 
         where id=object_id('FATURALAR_DETAY') and name='bfiyat') 
         alter table FATURALAR_DETAY add bfiyat float
         

--         alter table FATURALAR_DETAY add e_tutar float
         if not exists (select * from syscolumns 
         where id=object_id('FATURALAR_DETAY') and name='e_tutar') 
         alter table FATURALAR_DETAY add e_tutar float
         

--         alter table FATURALAR_DETAY add tanim varchar(2)
         if not exists (select * from syscolumns 
         where id=object_id('FATURALAR_DETAY') and name='tanim') 
         alter table FATURALAR_DETAY add tanim varchar(2)








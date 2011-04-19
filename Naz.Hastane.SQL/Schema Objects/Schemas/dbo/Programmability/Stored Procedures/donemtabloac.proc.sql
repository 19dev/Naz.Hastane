


CREATE PROCEDURE [dbo].[donemtabloac] 
AS

CREATE TABLE [muh_CARIKART] (
	[ATTRIBUTE] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[HESAPKODU] [varchar] (20) COLLATE Turkish_CI_AS NOT NULL ,
	[UNVANI] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[YETKILI] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[ISADRES1] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[ISADRES2] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[ISADRES3] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[ISPOSTA] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[ISTELEFON1] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[VERGIDAIRE] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[VERGIHESNO] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[ISKYUZDESI] [float] NULL ,
	[MUAFIYET] [float] NULL ,
	[KREDILIMIT] [float] NULL ,
	[RISKLIMIT] [float] NULL ,
	[SONHARTARB] [smalldatetime] NULL ,
	[SONHARTARA] [smalldatetime] NULL ,
	[HARDEVBO] [float] NULL ,
	[HARDEVAL] [float] NULL ,
	[YILDEVBO] [float] NULL ,
	[YILDEVAL] [float] NULL ,
	[YBBFTUTBO] [float] NULL ,
	[YBBFTUTAL] [float] NULL ,
	[YBBFADETBO] [float] NULL ,
	[YBBFADETAL] [float] NULL ,
	[YBBNTUTBO] [float] NULL ,
	[YBBNTUTAL] [float] NULL ,
	[YBBNADETBO] [float] NULL ,
	[YBBNADETAL] [float] NULL ,
	[YBBSTUTBO] [float] NULL ,
	[YBBSTUTAL] [float] NULL ,
	[YBBSADETBO] [float] NULL ,
	[YBBSADETAL] [float] NULL ,
	[YBBCTUTBO] [float] NULL ,
	[YBBCTUTAL] [float] NULL ,
	[YBBCADETBO] [float] NULL ,
	[YBBCADETAL] [float] NULL ,
	[YBBDTUTBO] [float] NULL ,
	[YBBDTUTAL] [float] NULL ,
	[YBBDADETBO] [float] NULL ,
	[YBBDADETAL] [float] NULL ,
	[DBBFTUTBO] [float] NULL ,
	[DBBFTUTAL] [float] NULL ,
	[DBBFADETBO] [float] NULL ,
	[DBBFADETAL] [float] NULL ,
	[DBBNTUTBO] [float] NULL ,
	[DBBNTUTAL] [float] NULL ,
	[DBBNADETBO] [float] NULL ,
	[DBBNADETAL] [float] NULL ,
	[DBBSTUTBO] [float] NULL ,
	[DBBSTUTAL] [float] NULL ,
	[DBBSADETBO] [float] NULL ,
	[DBBSADETAL] [float] NULL ,
	[DBBCTUTBO] [float] NULL ,
	[DBBCTUTAL] [float] NULL ,
	[DBBCADETBO] [float] NULL ,
	[DBBCADETAL] [float] NULL ,
	[DBBDTUTBO] [float] NULL ,
	[DBBDTUTAL] [float] NULL ,
	[DBBDADETBO] [float] NULL ,
	[DBBDADETAL] [float] NULL ,
	[DOVIZ] [varchar] (5) COLLATE Turkish_CI_AS NULL ,
	[DOVHDBO] [float] NULL ,
	[DOVHDAL] [float] NULL ,
	[DOVYDBA] [float] NULL ,
	[DOVYBBBO] [float] NULL ,
	[DOVYBBAL] [float] NULL ,
	[KRUNTU] [varchar] (12) COLLATE Turkish_CI_AS NULL ,
	[BRUNTU] [varchar] (12) COLLATE Turkish_CI_AS NULL ,
	[ISTELEFON2] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[MUHKOD1] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[MUHKOD2] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[EVADRES1] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[EVADRES2] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[EVADRES3] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[EVPOSTA] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[EVTELEFON1] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[EVTELEFON2] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[OZELKOD1] [varchar] (10) COLLATE Turkish_CI_AS NULL ,
	[OZELKOD2] [varchar] (10) COLLATE Turkish_CI_AS NULL ,
	[OZELKOD3] [varchar] (10) COLLATE Turkish_CI_AS NULL ,
	[OZELKOD4] [varchar] (10) COLLATE Turkish_CI_AS NULL ,
	[OZELKOD5] [varchar] (10) COLLATE Turkish_CI_AS NULL ,
	[ACIKLAMA1] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[ACIKLAMA2] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[ACIKLAMA3] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[ACIKLAMA4] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[ACIKLAMA5] [varchar] (30) COLLATE Turkish_CI_AS NULL 
) ON [PRIMARY]



CREATE TABLE [muh_FATURA] (
	[ATTRIBUTE] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[KAYNAKPROG] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[FATTARIHI] [smalldatetime] NULL ,
	[FATURANO] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[FATTIPI] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[KAPALIFAT] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[VADESI] [smalldatetime] NULL ,
	[IRSTARIHI] [smalldatetime] NULL ,
	[REFNO] [float] NULL ,
	[OZELKOD] [varchar] (5) COLLATE Turkish_CI_AS NULL ,
	[BASILDIMI] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[IPTALFAT] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[SATMUSKODU] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[UNVANI] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[ADRES1] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[ADRES2] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[ADRES3] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[POSTAKODU] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[VERGIDAIRE] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[VERGIHESNO] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[ACIKLAMA] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[STOKOZKOD] [varchar] (5) COLLATE Turkish_CI_AS NULL ,
	[CARIOZKOD] [varchar] (5) COLLATE Turkish_CI_AS NULL ,
	[TOPLAM] [float] NULL ,
	[MUHTELIF1] [float] NULL ,
	[MUH1YUZDE] [float] NULL ,
	[MUHTELIF2] [float] NULL ,
	[MUH2YUZDE] [float] NULL ,
	[MUHTELIF3] [float] NULL ,
	[MUH3YUZDE] [float] NULL ,
	[KALEMISK] [float] NULL ,
	[ISKONTO1] [float] NULL ,
	[ISK1YUZDE] [float] NULL ,
	[ISKONTO2] [float] NULL ,
	[ISK2YUZDE] [float] NULL ,
	[ARATOPLAM] [float] NULL ,
	[KDVORANI] [float] NULL ,
	[KDVDAHILMI] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[KDVTUTARI] [float] NULL ,
	[KDVALTIISK] [float] NULL ,
	[GENELTOP] [float] NULL ,
	[KDVTEVKIF] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[POSREKNO] [float] NULL ,
	[IRSNO] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[IRSATARIHI] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[ACIKLAMA1] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[ACIKLAMA2] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[CARIFFLAG] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[CARIFRECNO] [float] NULL ,
	[CARINFLAG] [smallint] NULL ,
	[CARINRECNO] [float] NULL ,
	[MUHREFNO] [float] NULL ,
	[NEXTFLAG] [smallint] NULL ,
	[NEXTRECNO] [float] NULL ,
	[KDVVADESI] [smalldatetime] NULL ,
	[KALEMISK2] [float] NULL ,
	[KALEMISK3] [float] NULL ,
	[TEVKIFAT] [float] NULL ,
	[ADISREKNO] [float] NULL ,
	[EKACIK1] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[EKACIK2] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[EKACIK3] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[EKACIK4] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[EKACIK5] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[EKACIK6] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[EKACIK7] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[EKACIK8] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[DEPOKOD] [varchar] (10) COLLATE Turkish_CI_AS NULL ,
	[STKAYNAK] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[HARTARIHI] [smalldatetime] NULL ,
	[STOKKODU] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[STREFNO] [float] NULL ,
	[STOZELKOD] [varchar] (5) COLLATE Turkish_CI_AS NULL ,
	[STSATMUS] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[STACIKLAMA] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[STEVRAKNO] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[GCFLAG] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[MIKTAR] [float] NULL ,
	[FIYAT] [float] NULL ,
	[TUTAR] [float] NULL ,
	[KDVYUZDESI] [float] NULL ,
	[ISKYUZDESI] [float] NULL ,
	[STNTFLAG] [smallint] NULL ,
	[STNTRECNO] [float] NULL ,
	[ISKTUTARI] [float] NULL ,
	[IKIBIRTUT] [float] NULL ,
	[ISKYUZDES2] [float] NULL ,
	[ISKYUZDES3] [float] NULL ,
	[STVADESI] [smalldatetime] NULL ,
	[STOKCINSI] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[STACIK1] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[STACIK2] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[STACIK3] [varchar] (15) COLLATE Turkish_CI_AS NULL 
) ON [PRIMARY]



CREATE TABLE [muh_fisler] (
	[fisno] [numeric](18, 0) NOT NULL ,
	[fistip] [int] NULL ,
	[tarih] [datetime] NULL ,
	[fis_acikla] [text] COLLATE Turkish_CI_AS NULL ,
	[borc] [float] NULL ,
	[alacak] [float] NULL ,
	[ozelkod1] [nchar] (1) COLLATE Turkish_CI_AS NULL ,
	[ozelkod2] [nchar] (1) COLLATE Turkish_CI_AS NULL ,
	[fisacan_kul] [nchar] (25) COLLATE Turkish_CI_AS NULL ,
	[update_tarih] [datetime] NULL ,
	[user] [nchar] (20) COLLATE Turkish_CI_AS NULL ,
	CONSTRAINT [PK_muh_fisler] PRIMARY KEY  CLUSTERED 
	(
		[fisno]
	)  ON [PRIMARY] 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [muh_hesap_plani] (
	[kat_id] [int] IDENTITY (1, 1) NOT NULL ,
	[ust_id] [int] NOT NULL ,
	[hesap_kodu] [nchar] (30) COLLATE Turkish_CI_AS NOT NULL ,
	[hesap_adi] [nchar] (100) COLLATE Turkish_CI_AS NULL ,
	[ust_hesap] [nchar] (20) COLLATE Turkish_CI_AS NULL ,
	[fisyer] [nchar] (10) COLLATE Turkish_CI_AS NULL ,
	[fisyerkontrol] [nchar] (10) COLLATE Turkish_CI_AS NULL ,
	[hesaptip] [nchar] (10) COLLATE Turkish_CI_AS NULL ,
	[ay1topb] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay1topb] DEFAULT (0),
	[ay2topb] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay2topb] DEFAULT (0),
	[ay3topb] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay3topb] DEFAULT (0),
	[ay4topb] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay4topb] DEFAULT (0),
	[ay5topb] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay5topb] DEFAULT (0),
	[ay6topb] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay6topb] DEFAULT (0),
	[ay7topb] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay7topb] DEFAULT (0),
	[ay8topb] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay8topb] DEFAULT (0),
	[ay9topb] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay9topb] DEFAULT (0),
	[ay10topb] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay10topb] DEFAULT (0),
	[ay11topb] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay11topb] DEFAULT (0),
	[ay12topb] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay12topb] DEFAULT (0),
	[ay1topa] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay1topa] DEFAULT (0),
	[ay2topa] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay2topa] DEFAULT (0),
	[ay3topa] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay3topa] DEFAULT (0),
	[ay4topa] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay4topa] DEFAULT (0),
	[ay5topa] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay5topa] DEFAULT (0),
	[ay6topa] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay6topa] DEFAULT (0),
	[ay7topa] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay7topa] DEFAULT (0),
	[ay8topa] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay8topa] DEFAULT (0),
	[ay9topa] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay9topa] DEFAULT (0),
	[ay10topa] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay10topa] DEFAULT (0),
	[ay11topa] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay11topa] DEFAULT (0),
	[ay12topa] [float] NULL CONSTRAINT [DF_muh_hesap_plani_ay12topa] DEFAULT (0),
	CONSTRAINT [PK_muh_hesap_plani] PRIMARY KEY  CLUSTERED 
	(
		[hesap_kodu]
	)  ON [PRIMARY] 
) ON [PRIMARY]



CREATE TABLE [muh_hesap_tanim] (
	[TANIM] [char] (10) COLLATE Turkish_CI_AS NOT NULL ,
	[TANIMADI] [varchar] (50) COLLATE Turkish_CI_AS NOT NULL ,
	[HESAPKODU] [char] (50) COLLATE Turkish_CI_AS NOT NULL 
) ON [PRIMARY]



CREATE TABLE [muh_KEYDAT] (
	[SLK] [varchar] (2) COLLATE Turkish_CI_AS NOT NULL ,
	[SLB] [varchar] (10) COLLATE Turkish_CI_AS NOT NULL ,
	[SLT] [varchar] (80) COLLATE Turkish_CI_AS NOT NULL ,
	[SLX] [float] NULL ,
	[SLY] [float] NULL ,
	[SLZ] [float] NULL ,
	[SLVV] [varchar] (100) COLLATE Turkish_CI_AS NULL ,
	[SLXX] [varchar] (100) COLLATE Turkish_CI_AS NULL ,
	[SLYY] [varchar] (100) COLLATE Turkish_CI_AS NULL ,
	[SLZZ] [varchar] (100) COLLATE Turkish_CI_AS NULL 
) ON [PRIMARY]



CREATE TABLE [muh_personel] (
	[personel_cari_kod] [nchar] (20) COLLATE Turkish_CI_AS NOT NULL ,
	[muh_kodu] [nchar] (20) COLLATE Turkish_CI_AS NOT NULL ,
	[adi] [char] (40) COLLATE Turkish_CI_AS NOT NULL ,
	[bolum] [char] (10) COLLATE Turkish_CI_AS NOT NULL ,
	[tckimlik] [nchar] (15) COLLATE Turkish_CI_AS NULL ,
	[maas] [float] NOT NULL ,
	[adres] [nchar] (250) COLLATE Turkish_CI_AS NULL ,
	[adres1] [nchar] (250) COLLATE Turkish_CI_AS NULL ,
	[tel] [nchar] (20) COLLATE Turkish_CI_AS NULL ,
	[ceptel] [nchar] (20) COLLATE Turkish_CI_AS NULL ,
	[rev] [nchar] (20) COLLATE Turkish_CI_AS NULL ,
	[knr] [nchar] (10) COLLATE Turkish_CI_AS NULL ,
	[aktif] [char] (1) COLLATE Turkish_CI_AS NOT NULL CONSTRAINT [DF_muh_personel_aktif] DEFAULT ('E'),
	[dtarih] [datetime] NULL ,
	[cinsiyet] [char] (10) COLLATE Turkish_CI_AS NULL ,
	[calgunsay] [int] NULL ,
	[isegiristarihi] [datetime] NULL ,
	[cikistarihi] [datetime] NULL ,
	[izinaygun] [char] (4) COLLATE Turkish_CI_AS NULL ,
	[calismasaat1] [nchar] (10) COLLATE Turkish_CI_AS NULL ,
	[calismasaat2] [nchar] (10) COLLATE Turkish_CI_AS NULL ,
	[odenekt] [float] NOT NULL ,
	[kesintit] [float] NOT NULL ,
	[izinucretli] [char] (1) COLLATE Turkish_CI_AS NOT NULL ,
	CONSTRAINT [PK_muh_personel] PRIMARY KEY  CLUSTERED 
	(
		[personel_cari_kod]
	)  ON [PRIMARY] 
) ON [PRIMARY]



CREATE TABLE [muh_table] (
	[katid] [uniqueidentifier] NULL ,
	[ust_id] [int] NULL ,
	[d] [int] IDENTITY (1, 1) NOT NULL 
) ON [PRIMARY]



CREATE TABLE [muh_temp_karzarar] (
	[hesapkodu1] [nchar] (20) COLLATE Turkish_CI_AS NULL CONSTRAINT [DF_muh_temp_karzarar_hesapkodu1] DEFAULT (9999),
	[hesapadi1] [nchar] (50) COLLATE Turkish_CI_AS NULL ,
	[tutar1] [float] NULL ,
	[hesapkodu2] [nchar] (20) COLLATE Turkish_CI_AS NULL CONSTRAINT [DF_muh_temp_karzarar_hesapkodu2] DEFAULT (9999),
	[hesapadi2] [nchar] (50) COLLATE Turkish_CI_AS NULL ,
	[tutar2] [float] NULL 
) ON [PRIMARY]



CREATE TABLE [muh_cari_hareket] (
	[carikod] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[tarih] [datetime] NULL ,
	[btutar] [float] NULL ,
	[atutar] [float] NULL ,
	[evrakno] [char] (10) COLLATE Turkish_CI_AS NULL ,
	[evraktarih] [datetime] NULL ,
	[evrakesas] [char] (10) COLLATE Turkish_CI_AS NULL ,
	[evrakesastarih] [datetime] NULL ,
	[aciklama] [nvarchar] (50) COLLATE Turkish_CI_AS NULL ,
	[evraktipi] [char] (1) COLLATE Turkish_CI_AS NULL ,
	[vade] [datetime] NULL ,
	[odemegec] [char] (1) COLLATE Turkish_CI_AS NULL ,
	[odemetip] [nvarchar] (50) COLLATE Turkish_CI_AS NULL 
) ON [PRIMARY]



CREATE TABLE [muh_CHAR] (
	[HARTARIHI] [smalldatetime] NULL ,
	[HESAPKODU] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[REFNO] [float] NULL ,
	[OZELKOD] [varchar] (5) COLLATE Turkish_CI_AS NULL ,
	[ISLEMCINSI] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[ACIKLAMA] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[EVRAKNO] [varchar] (15) COLLATE Turkish_CI_AS NULL ,
	[BAFLAG] [varchar] (1) COLLATE Turkish_CI_AS NULL ,
	[TUTAR] [float] NULL ,
	[VADESI] [smalldatetime] NULL ,
	[ACIKLAMA1] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[ACIKLAMA2] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[ACIKLAMA3] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[UNVANI] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[KARTACIK1] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[KARTACIK2] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[KARTACIK3] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[KARTACIK4] [varchar] (30) COLLATE Turkish_CI_AS NULL ,
	[KARTACIK5] [varchar] (30) COLLATE Turkish_CI_AS NULL 
) ON [PRIMARY]



CREATE TABLE [muh_donemler] (
	[donem] [nchar] (10) COLLATE Turkish_CI_AS NOT NULL ,
	[donemadi] [nchar] (40) COLLATE Turkish_CI_AS NOT NULL ,
	[tarih1] [datetime] NULL ,
	[tarih2] [datetime] NULL ,
	[secili] [bit] NULL ,
	CONSTRAINT [PK_muh_donemler] PRIMARY KEY  CLUSTERED 
	(
		[donem]
	)  ON [PRIMARY] 
) ON [PRIMARY]



CREATE TABLE [muh_doviz_kurlari] (
	[doviz] [nchar] (20) COLLATE Turkish_CI_AS NOT NULL ,
	[alis] [float] NULL ,
	[satis] [float] NULL ,
	[tarih] [datetime] NULL ,
	CONSTRAINT [IX_muh_doviz_kurlari] UNIQUE  NONCLUSTERED 
	(
		[doviz],
		[tarih]
	)  ON [PRIMARY] 
) ON [PRIMARY]



CREATE TABLE [muh_fis_hareket] (
	[id] [uniqueidentifier] NULL ,
	[fisno] [numeric](18, 0) NULL ,
	[fistip] [int] NULL ,
	[hesapkodu] [nchar] (30) COLLATE Turkish_CI_AS NULL ,
	[borc] [float] NULL ,
	[alacak] [float] NULL ,
	[aciklama] [nchar] (200) COLLATE Turkish_CI_AS NULL ,
	[tarih] [datetime] NULL ,
	CONSTRAINT [FK_muh_fis_hareket_muh_fisler] FOREIGN KEY 
	(
		[fisno]
	) REFERENCES [muh_fisler] (
		[fisno]
	),
	CONSTRAINT [FK_muh_fis_hareket_muh_hesap_plani] FOREIGN KEY 
	(
		[hesapkodu]
	) REFERENCES [muh_hesap_plani] (
		[hesap_kodu]
	)
) ON [PRIMARY]



CREATE TABLE [muh_pcari_hareket] (
	[satirid] [numeric](10, 0) IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[carikod] [varchar] (20) COLLATE Turkish_CI_AS NULL ,
	[tarih] [datetime] NULL ,
	[btutar] [float] NULL ,
	[atutar] [float] NULL ,
	[evrakno] [char] (10) COLLATE Turkish_CI_AS NULL ,
	[evraktarih] [datetime] NULL ,
	[evrakesas] [char] (10) COLLATE Turkish_CI_AS NULL ,
	[evrakesastarih] [datetime] NULL ,
	[aciklama] [nvarchar] (50) COLLATE Turkish_CI_AS NULL ,
	[evraktipi] [char] (1) COLLATE Turkish_CI_AS NULL ,
	[vade] [datetime] NULL ,
	[odemegec] [char] (1) COLLATE Turkish_CI_AS NULL ,
	[odemetip] [nvarchar] (50) COLLATE Turkish_CI_AS NULL ,
	[knr_snr] [nchar] (20) COLLATE Turkish_CI_AS NULL ,
	[pcfisno] [numeric](18, 0) NULL ,
	CONSTRAINT [PK_muh_pcari_hareket] PRIMARY KEY  CLUSTERED 
	(
		[satirid]
	)  ON [PRIMARY] 
) ON [PRIMARY]



CREATE TABLE [muh_personel_odenekleri] (
	[cari_hesap_kodu] [nchar] (20) COLLATE Turkish_CI_AS NULL ,
	[aciklama] [nchar] (50) COLLATE Turkish_CI_AS NULL ,
	[kesinti] [float] NULL ,
	[odenek] [float] NULL ,
	CONSTRAINT [FK_muh_personel_odenekleri_muh_personel] FOREIGN KEY 
	(
		[cari_hesap_kodu]
	) REFERENCES [muh_personel] (
		[personel_cari_kod]
	)
) ON [PRIMARY]



CREATE TABLE [muh_karzarartab_hesaplari] (
	[hesapkodu] [nchar] (20) COLLATE Turkish_CI_AS NOT NULL ,
	[hesapadi] [nchar] (100) COLLATE Turkish_CI_AS NULL ,
	[hesaptipi] [char] (1) COLLATE Turkish_CI_AS NULL ,
	CONSTRAINT [PK_muh_karzarartab_hesaplari] PRIMARY KEY  CLUSTERED 
	(
		[hesapkodu]
	)  ON [PRIMARY] 
) ON [PRIMARY]

CREATE TABLE [muh_hesaplar] (
	[serviskodu] [char] (10) COLLATE Turkish_CI_AS NULL ,
	[hizmetgrup] [char] (10) COLLATE Turkish_CI_AS NULL ,
	[hesapkodu] [char] (50) COLLATE Turkish_CI_AS NULL ,
	[hesapadi] [char] (100) COLLATE Turkish_CI_AS NULL ,
	[karsilikhesap] [char] (50) COLLATE Turkish_CI_AS NULL ,
	[karsilikhesapadi] [char] (100) COLLATE Turkish_CI_AS NULL 
) ON [PRIMARY]



CREATE TABLE [muh_login] (
	[user] [nchar] (20) COLLATE Turkish_CI_AS NOT NULL ,
	[password] [nchar] (20) COLLATE Turkish_CI_AS NULL ,
	[default] [bit] NULL ,
	[donem] [nchar] (20) COLLATE Turkish_CI_AS NULL ,
	[parametreler] [bit] NULL ,
	CONSTRAINT [PK_muh_login] PRIMARY KEY  CLUSTERED 
	(
		[user]
	)  ON [PRIMARY] 
) ON [PRIMARY]





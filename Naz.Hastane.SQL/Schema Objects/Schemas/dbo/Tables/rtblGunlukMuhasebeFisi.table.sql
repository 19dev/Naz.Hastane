CREATE TABLE [dbo].[rtblGunlukMuhasebeFisi] (
    [RowNumber]    NVARCHAR (255) NULL,
    [OdemeSekli]   NVARCHAR (1)   NULL,
    [Tarih]        NVARCHAR (10)  NULL,
    [TCKIMLIKNO]   NVARCHAR (15)  NULL,
    [HesapKodu]    NVARCHAR (20)  NULL,
    [Aciklama]     NVARCHAR (150) NULL,
    [MakbuzNo]     NVARCHAR (20)  NULL,
    [Tutar]        FLOAT          NULL,
    [HizmetTutari] FLOAT          NULL,
    [KDVOrani]     INT            NULL,
    [RecordType]   NVARCHAR (17)  NULL,
    [USER_ID]      NVARCHAR (20)  NULL
);


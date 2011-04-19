CREATE TABLE [dbo].[FIYDATA] (
    [FIYLIST]          VARCHAR (2)   NOT NULL,
    [TANIM]            VARCHAR (2)   NOT NULL,
    [GRUP]             VARCHAR (3)   NOT NULL,
    [HP_REF_FIYLIST]   VARCHAR (2)   NULL,
    [HP_AYAR]          SMALLINT      NULL,
    [HP_DEGER]         VARCHAR (500) NULL,
    [HP_KIYAS]         BIT           NULL,
    [HP_KIYAS_TIP]     SMALLINT      NULL,
    [HP_KIYAS_FIYLIST] VARCHAR (2)   NULL,
    [KP_REF_FIYLIST]   VARCHAR (2)   NULL,
    [KP_AYAR]          SMALLINT      NULL,
    [KP_DEGER]         VARCHAR (500) NULL,
    [KP_KIYAS]         BIT           NULL,
    [KP_KIYAS_TIP]     SMALLINT      NULL,
    [KP_KIYAS_FIYLIST] VARCHAR (2)   NULL
);


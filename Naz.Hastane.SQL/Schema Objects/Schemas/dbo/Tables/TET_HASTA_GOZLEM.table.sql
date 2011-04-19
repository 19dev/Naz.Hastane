CREATE TABLE [dbo].[TET_HASTA_GÖZLEM] (
    [KNR]            VARCHAR (6)   NOT NULL,
    [SNR]            VARCHAR (3)   NOT NULL,
    [GELISTARIHI]    DATETIME      NOT NULL,
    [TARIH]          DATETIME      NOT NULL,
    [ATEŞ]           INT           NULL,
    [NABIZ]          INT           NULL,
    [BÜYÜK_TANSİYON] INT           NULL,
    [KÜÇÜK_TANSİYON] INT           NULL,
    [LAVMAN]         BIT           NULL,
    [ALDIĞI_İDRAR]   INT           NULL,
    [VERDİĞİ_İDRAR]  INT           NULL,
    [ICEN_KOD]       VARCHAR (50)  NULL,
    [ICEN_AÇIKLAMA]  VARCHAR (100) NULL,
    [GÖZLERAÇIK]     INT           NULL,
    [MOTORCEVAP]     INT           NULL,
    [SÖZELCEVAP]     INT           NULL,
    [NOTLAR]         TEXT          NULL
);


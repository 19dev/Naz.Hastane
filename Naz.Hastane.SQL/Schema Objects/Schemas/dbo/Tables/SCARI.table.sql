CREATE TABLE [dbo].[SCARI] (
    [KNR]             VARCHAR (5)  NOT NULL,
    [SNR]             VARCHAR (3)  NOT NULL,
    [TARIH]           DATETIME     NOT NULL,
    [EVRAKNO]         VARCHAR (10) NOT NULL,
    [ACIKLAMA]        VARCHAR (35) NULL,
    [B_A]             VARCHAR (1)  NOT NULL,
    [TUTAR]           FLOAT        NOT NULL,
    [KOD]             VARCHAR (1)  NOT NULL,
    [BK]              VARCHAR (1)  NOT NULL,
    [EEVRAKNO]        VARCHAR (10) NULL,
    [ETARIH]          DATETIME     NULL,
    [SIRAID]          FLOAT        NULL,
    [SERVIS]          VARCHAR (2)  NULL,
    [PROVIZYONNO]     VARCHAR (50) NULL,
    [USER_ID]         VARCHAR (20) NOT NULL,
    [DATE_CREATE]     DATETIME     NOT NULL,
    [USER_ID_UPDATE]  VARCHAR (20) NULL,
    [DATE_UPDATE]     DATETIME     NULL,
    [ICMALNO]         VARCHAR (20) NULL,
    [ICMALTARIHI]     DATETIME     NULL,
    [MEDFATURATARIHI] DATETIME     NULL
);


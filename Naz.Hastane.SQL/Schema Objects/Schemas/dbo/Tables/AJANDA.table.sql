CREATE TABLE [dbo].[AJANDA] (
    [MSG_ID]           NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [USER_ID]          VARCHAR (20)  NOT NULL,
    [TARIH]            DATETIME      NOT NULL,
    [HATIRLATMAMESAJI] VARCHAR (200) NOT NULL,
    [TARIHGEL]         CHAR (1)      NOT NULL,
    [CHK_AY]           CHAR (1)      NOT NULL,
    [CHK_HAFTA]        CHAR (1)      NOT NULL,
    [CHK_GUN]          CHAR (1)      NOT NULL,
    [GUN_SAYI]         SMALLINT      NOT NULL,
    [CHK_BUGUN]        CHAR (1)      NOT NULL,
    [BUGUN]            DATETIME      NULL,
    [CHK_PRGSTART]     CHAR (1)      NOT NULL,
    [CHK_BUSAAT]       CHAR (1)      NOT NULL,
    [SAAT]             VARCHAR (5)   NULL
);


﻿CREATE TABLE [dbo].[BEHAND_DETAY] (
    [KNR]             VARCHAR (6)   NOT NULL,
    [SNR]             VARCHAR (3)   NOT NULL,
    [GELISTARIHI]     DATETIME      NOT NULL,
    [ARZT]            VARCHAR (4)   NOT NULL,
    [SERVIS]          VARCHAR (2)   NOT NULL,
    [AMBU]            VARCHAR (1)   NOT NULL,
    [SERNO]           VARCHAR (5)   NULL,
    [MUAYENEOLDU]     VARCHAR (1)   NOT NULL,
    [KONTROL_ID]      NUMERIC (18)  NULL,
    [USER_ID]         VARCHAR (20)  NOT NULL,
    [DATE_CREATE]     DATETIME      NOT NULL,
    [USER_ID_UPDATE]  VARCHAR (20)  NULL,
    [DATE_UPDATE]     DATETIME      NULL,
    [KONS]            CHAR (1)      NULL,
    [ACIL_KONS]       CHAR (1)      NULL,
    [ISTEM_ARZT]      VARCHAR (4)   NULL,
    [NOTLAR]          VARCHAR (100) NULL,
    [GOZ_NOTLAR]      VARCHAR (100) NULL,
    [ONERILER]        VARCHAR (100) NULL,
    [GELMEDİ]         CHAR (1)      NULL,
    [KONS_SNR]        VARCHAR (3)   NULL,
    [KONS_TARIH]      DATETIME      NULL,
    [PSG]             VARCHAR (10)  NULL,
    [MCIKISTARIHI]    DATETIME      NULL,
    [TABKODU]         VARCHAR (2)   NULL,
    [KONT]            VARCHAR (1)   NULL,
    [ISTISNAIDURUM]   VARCHAR (2)   NULL,
    [EKSORGU]         VARCHAR (1)   NULL,
    [HASTABASNO]      VARCHAR (10)  NULL,
    [TEDAVITURU]      VARCHAR (10)  NULL,
    [TAKIPTIPI]       VARCHAR (10)  NULL,
    [TEDAVITIPI]      VARCHAR (10)  NULL,
    [BRANSKODU]       VARCHAR (10)  NULL,
    [SEVKTAKIPNO]     VARCHAR (10)  NULL,
    [TAKIPTURU]       VARCHAR (10)  NULL,
    [ILISKILITAKIPNO] VARCHAR (20)  NULL,
    [TETHASTASIRA]    BIT           NOT NULL,
    [SIGORTALIKARTNO] NCHAR (10)    NULL
);


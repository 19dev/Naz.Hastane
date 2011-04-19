﻿CREATE TABLE [dbo].[HIZIL_SEREF] (
    [KNR]             VARCHAR (6)   NOT NULL,
    [SNR]             VARCHAR (3)   NOT NULL,
    [SIRANO]          FLOAT         NOT NULL,
    [AKOD]            VARCHAR (2)   NULL,
    [TANIM]           VARCHAR (2)   NOT NULL,
    [GRUP]            VARCHAR (3)   NOT NULL,
    [CODE]            VARCHAR (15)  NOT NULL,
    [ARZT]            VARCHAR (4)   NOT NULL,
    [ARZT2]           VARCHAR (4)   NOT NULL,
    [ADET]            FLOAT         NOT NULL,
    [UNITE]           VARCHAR (2)   NULL,
    [NAME1]           VARCHAR (100) NOT NULL,
    [SATISF]          FLOAT         NOT NULL,
    [KSATISF]         FLOAT         NOT NULL,
    [DSATISF]         FLOAT         NULL,
    [KDV]             FLOAT         NOT NULL,
    [TARIH]           DATETIME      NOT NULL,
    [PSG]             VARCHAR (6)   NOT NULL,
    [HZLNO]           SMALLINT      NULL,
    [USER_ID]         VARCHAR (20)  NOT NULL,
    [DATE_CREATE]     DATETIME      NOT NULL,
    [USER_ID_UPDATE]  VARCHAR (20)  NULL,
    [DATE_UPDATE]     DATETIME      NULL,
    [MAKNO]           VARCHAR (8)   NULL,
    [KFATNO]          VARCHAR (7)   NULL,
    [FATURAEDILSIN]   VARCHAR (1)   NULL,
    [ISLENDIMI]       VARCHAR (1)   NULL,
    [PAKET]           VARCHAR (1)   NULL,
    [LRGOR]           VARCHAR (1)   NULL,
    [BUTCODE]         VARCHAR (20)  NULL,
    [BUTNAME]         VARCHAR (100) NULL,
    [ESKI_SATISF]     FLOAT         NULL,
    [KABUL]           VARCHAR (1)   NULL,
    [ISODENDI]        VARCHAR (1)   NULL,
    [CARIFIYAT]       FLOAT         NULL,
    [ODEMETARIHI]     DATETIME      NULL,
    [ISDURUM]         VARCHAR (1)   NULL,
    [PSEANS]          VARCHAR (2)   NULL,
    [SAGSOL]          VARCHAR (1)   NULL,
    [EUSCORE]         VARCHAR (3)   NULL,
    [HMAKNO]          VARCHAR (12)  NULL,
    [HODENDI]         VARCHAR (1)   NULL,
    [AMAKNO]          VARCHAR (12)  NULL,
    [HYATISTARIHI]    DATETIME      NULL,
    [HCIKISTARIHI]    DATETIME      NULL,
    [REFGUNSAY]       VARCHAR (4)   NULL,
    [ISLEMSIRANO]     VARCHAR (20)  NULL,
    [MEDSIRANO]       VARCHAR (20)  NULL,
    [MEDONAY]         VARCHAR (2)   NULL,
    [MEDTUTAR]        FLOAT         NULL,
    [TBASLANGICSAATI] NVARCHAR (5)  NULL,
    [TBITISSAATI]     NVARCHAR (5)  NULL,
    [MEDOZDURUM]      VARCHAR (1)   NULL,
    [MEDANOMALI]      VARCHAR (1)   NOT NULL
);


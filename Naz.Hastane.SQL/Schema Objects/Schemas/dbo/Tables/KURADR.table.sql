﻿CREATE TABLE [dbo].[KURADR] (
    [PSG]            VARCHAR (6)    NOT NULL,
    [KNR]            VARCHAR (5)    NOT NULL,
    [DESTEKPSG]      VARCHAR (6)    NULL,
    [FIXKURUM]       SMALLINT       NOT NULL,
    [KURUMTIPI]      VARCHAR (4)    NOT NULL,
    [ADI1]           VARCHAR (200)  NOT NULL,
    [ADRZUS]         VARCHAR (200)  NULL,
    [STR]            VARCHAR (30)   NULL,
    [PLZ]            VARCHAR (5)    NULL,
    [ORT]            VARCHAR (20)   NOT NULL,
    [TEL1]           VARCHAR (20)   NULL,
    [TEL2]           VARCHAR (20)   NULL,
    [FAX]            VARCHAR (20)   NULL,
    [VERDAR]         VARCHAR (20)   NULL,
    [VERNO]          VARCHAR (20)   NULL,
    [YETKILI]        VARCHAR (28)   NULL,
    [BORC]           FLOAT          NOT NULL,
    [ALACAK]         FLOAT          NOT NULL,
    [EKSIKODENEN]    FLOAT          NOT NULL,
    [ANLASMADURUMU]  CHAR (1)       NOT NULL,
    [ORAN1]          VARCHAR (150)  NOT NULL,
    [ORAN2]          VARCHAR (150)  NOT NULL,
    [PFIYLIST]       VARCHAR (2)    NOT NULL,
    [YFIYLIST]       VARCHAR (2)    NULL,
    [ILACODE]        VARCHAR (1)    NOT NULL,
    [SARFODE]        VARCHAR (1)    NOT NULL,
    [HASTAKATILIM]   CHAR (1)       NOT NULL,
    [HASTALIMIT]     FLOAT          NOT NULL,
    [VER]            VARCHAR (20)   NULL,
    [SEVKGECSURE]    SMALLINT       NOT NULL,
    [DRPAYNEZAMAN]   VARCHAR (1)    NOT NULL,
    [SIRAID]         FLOAT          NOT NULL,
    [ECZMUAUCRETI]   FLOAT          NOT NULL,
    [ECZKATPAYI]     FLOAT          NOT NULL,
    [ECZBILGKATPAYI] FLOAT          NOT NULL,
    [USER_ID]        VARCHAR (20)   NOT NULL,
    [DATE_CREATE]    DATETIME       NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20)   NULL,
    [DATE_UPDATE]    DATETIME       NULL,
    [OZELNOT]        TEXT           NULL,
    [ILACINDIRIM]    VARCHAR (1)    NULL,
    [hesap_kodu]     NVARCHAR (50)  NULL,
    [c_hesap_kodu]   VARCHAR (20)   NULL,
    [c_borc]         FLOAT          NULL,
    [c_alacak]       FLOAT          NULL,
    [FIYLIST]        VARCHAR (2)    NULL,
    [SIFIRGOSTER]    VARCHAR (50)   NOT NULL,
    [VADESURESI]     VARCHAR (50)   NULL,
    [SEVKBASAMAK]    VARCHAR (1)    NULL,
    [DSTKDUS]        VARCHAR (1)    NULL,
    [MKURUM]         VARCHAR (50)   NULL,
    [MLIMIT]         VARCHAR (50)   NULL,
    [ORKA1]          CHAR (10)      NULL,
    [ORKA2]          CHAR (10)      NULL,
    [ORKA3]          CHAR (10)      NULL,
    [POLSURE]        VARCHAR (50)   NULL,
    [sec]            BIT            NULL,
    [EPOSTA]         VARBINARY (50) NULL,
    [ACILKATILIM]    VARCHAR (1)    NOT NULL,
    [lngKurumTipiID] INT            NULL
);


﻿CREATE TABLE [dbo].[ILACSARF] (
    [AKOD]            VARCHAR (2)   NOT NULL,
    [TANIM]           VARCHAR (2)   NOT NULL,
    [GRUP]            VARCHAR (3)   NOT NULL,
    [CODE]            VARCHAR (15)  NOT NULL,
    [NAME1]           VARCHAR (65)  NOT NULL,
    [NAME2]           VARCHAR (35)  NULL,
    [UNITE]           VARCHAR (4)   NULL,
    [FIRMA]           VARCHAR (4)   NULL,
    [KDV]             FLOAT         NOT NULL,
    [SATISF]          FLOAT         NOT NULL,
    [ALISF]           FLOAT         NOT NULL,
    [KSATISF]         FLOAT         NULL,
    [ASATISF]         FLOAT         NULL,
    [YSATISF]         FLOAT         NULL,
    [ORTALAMAF]       FLOAT         NOT NULL,
    [TOPGIR]          FLOAT         NOT NULL,
    [TOPCIK]          FLOAT         NOT NULL,
    [MINIMUM]         FLOAT         NOT NULL,
    [VERADET]         FLOAT         NOT NULL,
    [TOPSAT]          FLOAT         NOT NULL,
    [TOPALS]          FLOAT         NOT NULL,
    [SEVKDAT]         DATETIME      NULL,
    [ENVDAT]          DATETIME      NULL,
    [DEVIR]           FLOAT         NOT NULL,
    [SKDAT]           DATETIME      NULL,
    [FAR_KOD]         VARCHAR (4)   NULL,
    [JEN_KOD]         VARCHAR (4)   NULL,
    [DOZAJ]           FLOAT         NOT NULL,
    [KAR]             FLOAT         NOT NULL,
    [DOVIZ]           FLOAT         NULL,
    [DOVIZCINSI]      VARCHAR (3)   NULL,
    [REUSE]           VARCHAR (1)   NOT NULL,
    [INFIYAT]         FLOAT         NOT NULL,
    [KOLI]            FLOAT         NOT NULL,
    [DAHHAR]          VARCHAR (1)   NOT NULL,
    [OZELF]           VARCHAR (1)   NOT NULL,
    [GUNLUK]          FLOAT         NOT NULL,
    [ILACKONTROL]     CHAR (1)      NOT NULL,
    [ILACKONTROLSURE] SMALLINT      NOT NULL,
    [KURUMINDIRIM]    FLOAT         NULL,
    [ESKIALISF]       FLOAT         NULL,
    [APILACSARF]      VARCHAR (1)   NULL,
    [PDAHIL]          VARCHAR (1)   NULL,
    [MALTURU]         VARCHAR (4)   NULL,
    [DETAYKOD]        VARCHAR (50)  NULL,
    [mk]              BIT           NULL,
    [SEC]             BIT           NULL,
    [ILACADET]        VARCHAR (10)  NULL,
    [MEDGONDER]       VARCHAR (1)   NULL,
    [MALDURUM]        VARCHAR (10)  NULL,
    [ILACTURU]        VARCHAR (1)   NULL,
    [KBIRIMI]         FLOAT         NOT NULL,
    [JENKOD]          VARCHAR (50)  NULL,
    [ETKENMADDE]      VARCHAR (250) NULL,
    [BIRIMCINS]       VARCHAR (50)  NULL,
    [RECTIPI]         VARCHAR (50)  NULL,
    [ILFIRMA]         VARCHAR (50)  NULL,
    [UBBCODE]         VARCHAR (50)  NULL,
    [KATKIPAYI]       VARCHAR (1)   NULL,
    [MEDONAY]         VARCHAR (1)   NULL,
    [MAKSIMUM]        VARCHAR (10)  NULL,
    [KHIZMET]         VARCHAR (1)   NULL
);


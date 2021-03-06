﻿CREATE TABLE [dbo].[BILGISISTEMLERIYATAKSEND_112] (
    [SIRANO]           INT           IDENTITY (1, 1) NOT NULL,
    [BOLUMKODU]        NVARCHAR (50) NULL,
    [BOLUMADI]         NVARCHAR (50) NULL,
    [HIZMETDURUMU]     NVARCHAR (50) NULL,
    [TOPLAMYATAK]      NVARCHAR (50) NULL,
    [TOPLAMBOSYATAK]   NVARCHAR (50) NULL,
    [ERKEKTOPLAMYATAK] NVARCHAR (50) NULL,
    [ERKEKBOSYATAK]    NVARCHAR (50) NULL,
    [KADINTOPLAMYATAK] NVARCHAR (50) NULL,
    [KADINBOSYATAK]    NVARCHAR (50) NULL,
    [COCUKTOPLAMYATAK] NVARCHAR (50) NULL,
    [COCUKBOSYATAK]    NVARCHAR (50) NULL,
    [TOPLAMVENTI]      NVARCHAR (50) NULL,
    [BOSVENTI]         NVARCHAR (50) NULL,
    [TOPLAMKUVEZ]      NVARCHAR (50) NULL,
    [BOSKUVEZ]         NVARCHAR (50) NULL,
    [ACIKLAMA]         NVARCHAR (50) NULL,
    [TARIH]            DATETIME      NULL,
    [GONDERMETARIHI]   DATETIME      NULL,
    [USER112]          NVARCHAR (50) NULL,
    [GONDERILDI]       NVARCHAR (50) NULL
);


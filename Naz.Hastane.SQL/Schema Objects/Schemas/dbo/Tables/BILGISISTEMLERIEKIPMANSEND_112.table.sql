﻿CREATE TABLE [dbo].[BILGISISTEMLERIEKIPMANSEND_112] (
    [SIRANO]          INT           IDENTITY (1, 1) NOT NULL,
    [EKIPKODU]        NVARCHAR (50) NULL,
    [EKIPADI]         NVARCHAR (50) NULL,
    [EKIPKULDURUM]    NVARCHAR (50) NULL,
    [EKIPTOPADET]     NVARCHAR (50) NULL,
    [EKIPACILBOSADET] NVARCHAR (50) NULL,
    [EKIPANABOSADET]  NVARCHAR (50) NULL,
    [EKIPACIKLAMA]    NVARCHAR (50) NULL,
    [TARIH]           DATETIME      NULL,
    [GONDERMETARIHI]  DATETIME      NULL,
    [USER112]         NVARCHAR (50) NULL,
    [GONDERILDI]      NVARCHAR (50) NULL
);


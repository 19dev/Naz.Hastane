﻿CREATE TABLE [dbo].[KULLANICILAR] (
    [VEZNE]        VARCHAR (2)   NULL,
    [USER_ID]      VARCHAR (20)  NOT NULL,
    [USER_PASS]    VARCHAR (10)  NOT NULL,
    [USER_GRUP]    VARCHAR (2)   NULL,
    [PR2WIN]       VARCHAR (1)   NOT NULL,
    [ARZT]         VARCHAR (4)   NULL,
    [ISBUSY]       VARCHAR (1)   NOT NULL,
    [LASTACCESS]   VARCHAR (10)  NOT NULL,
    [TARIH]        DATETIME      NOT NULL,
    [TESTER]       VARCHAR (1)   NOT NULL,
    [STARTOBJ]     VARCHAR (100) NOT NULL,
    [DATE_CREATED] DATETIME      NULL,
    [DATE_UPDATED] DATETIME      NULL,
    [TERM_PASS]    VARCHAR (10)  NULL,
    [INDIRIMYUZDE] VARCHAR (5)   NULL,
    [SEC]          BIT           NULL,
    [REV]          VARCHAR (4)   NULL
);

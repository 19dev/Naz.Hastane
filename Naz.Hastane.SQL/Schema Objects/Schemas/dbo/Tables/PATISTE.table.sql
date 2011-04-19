CREATE TABLE [dbo].[PATISTE] (
    [TANIM]          VARCHAR (2)  NOT NULL,
    [GRUP]           VARCHAR (3)  NOT NULL,
    [CODE]           VARCHAR (15) NOT NULL,
    [KNR]            VARCHAR (6)  NOT NULL,
    [SNR]            VARCHAR (3)  NOT NULL,
    [TARIH]          DATETIME     NOT NULL,
    [ARZT]           VARCHAR (4)  NULL,
    [TOOLTIPTEXT]    VARCHAR (75) NULL,
    [KABUL]          VARCHAR (1)  NOT NULL,
    [KABUL_ID]       VARCHAR (20) NULL,
    [KABUL_TARIH]    DATETIME     NULL,
    [KABUL_NO]       VARCHAR (10) NULL,
    [DISMERKEZ]      VARCHAR (5)  NULL,
    [ONAY]           VARCHAR (1)  NOT NULL,
    [ONAY_ID]        VARCHAR (20) NULL,
    [ONAY_TARIH]     DATETIME     NULL,
    [PAT_ID]         FLOAT        NULL,
    [USER_ID]        VARCHAR (20) NOT NULL,
    [DATE_CREATE]    DATETIME     NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20) NULL,
    [DATE_UPDATE]    DATETIME     NULL
);


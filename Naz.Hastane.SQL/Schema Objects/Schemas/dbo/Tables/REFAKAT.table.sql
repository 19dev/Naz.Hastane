CREATE TABLE [dbo].[REFAKAT] (
    [KNR]            VARCHAR (6)  NOT NULL,
    [SNR]            VARCHAR (3)  NOT NULL,
    [R_NAME]         VARCHAR (20) NULL,
    [R_BNAME]        VARCHAR (15) NULL,
    [R_YASI]         VARCHAR (4)  NULL,
    [R_DOGYER]       VARCHAR (15) NULL,
    [R_HASYAK]       VARCHAR (10) NULL,
    [R_GIRTAR]       DATETIME     NULL,
    [R_CIKTAR]       DATETIME     NULL,
    [R_ARSIVNO]      VARCHAR (6)  NULL,
    [R_UCRET]        FLOAT        NULL,
    [R_GUN]          VARCHAR (3)  NULL,
    [USER_ID]        VARCHAR (20) NOT NULL,
    [DATE_CREATE]    DATETIME     NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20) NULL,
    [DATE_UPDATE]    DATETIME     NULL
);


CREATE TABLE [dbo].[HIZMETDOKTORYUZDE_MUH] (
    [TANIM]       VARCHAR (2)  NOT NULL,
    [GRUP]        VARCHAR (3)  NOT NULL,
    [CODE]        VARCHAR (15) NOT NULL,
    [ARZT]        VARCHAR (4)  NOT NULL,
    [YUZDE]       FLOAT        NOT NULL,
    [kfiyatYuzde] FLOAT        NULL,
    [sfiyatYuzde] FLOAT        NULL,
    [kfiyat]      FLOAT        NULL,
    [sfiyat]      FLOAT        NULL,
    [kurum]       VARCHAR (10) NOT NULL,
    [fiylist]     VARCHAR (2)  NULL,
    [KAYITID]     INT          IDENTITY (1, 1) NOT NULL,
    [mindeger]    FLOAT        NULL,
    [minyuzde]    FLOAT        NULL
);


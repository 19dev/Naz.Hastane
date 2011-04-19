CREATE TABLE [dbo].[DOKTOR_HAKEDIS_BEKLEYEN] (
    [arzt]     VARCHAR (6)  NULL,
    [ilktarih] VARCHAR (10) NULL,
    [sontarih] VARCHAR (10) NULL,
    [kpay]     FLOAT        NULL,
    [hpay]     FLOAT        NULL,
    [tarih]    VARCHAR (10) NULL,
    [durum]    VARCHAR (1)  NULL,
    [KAYITID]  NUMERIC (18) IDENTITY (1, 1) NOT NULL
);


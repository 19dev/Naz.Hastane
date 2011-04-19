CREATE TABLE [dbo].[RANDEVULAR] (
    [HASTA_ID]     FLOAT         NOT NULL,
    [TARIH]        DATETIME      NOT NULL,
    [SAAT]         CHAR (5)      NOT NULL,
    [SIRA]         SMALLINT      NULL,
    [SURE]         SMALLINT      NULL,
    [ARZT]         CHAR (4)      NOT NULL,
    [SERVIS]       CHAR (3)      NULL,
    [TIPI]         CHAR (1)      NULL,
    [ACIKLAMA]     VARCHAR (100) NULL,
    [IPTAL_TARIHI] DATETIME      NULL,
    [IPTAL_ID]     VARCHAR (20)  NULL,
    [IPTAL_NEDEN]  VARCHAR (50)  NULL,
    [STATU]        CHAR (1)      NULL,
    [USER_ID]      VARCHAR (50)  NULL,
    [DATE_CREATE]  DATETIME      NULL
);

